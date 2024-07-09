#nullable enable
using RRCG;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace RRCGBuild
{
    public class DataTableColumn<T> where T : AnyPort, new()
    {
        private string DataTableName;
        private string ColumnName;

        internal DataTableColumn(string dataTableName, string columnName)
        {
            DataTableName = dataTableName;
            ColumnName = columnName;
        }

        private string SingletonKey(string chipName, string portKey) => $"_RRCG_DataTableColumn_{DataTableName}_{ColumnName}_{chipName}_{portKey}";

        public StringPort Name => ColumnName;

        public ListPort<IntPort> GetAllRowsContaining(T Value) =>
            CircuitBuilder.Singleton(SingletonKey("GetAllRowsContaining", Value.PortKey()),
                () => ChipBuilder.DataTableGetAllRowsContaining(Value, new(DataTableName, ColumnName)));

        public IntPort GetFirstRowContaining(T Value) =>
            CircuitBuilder.Singleton(SingletonKey("GetFirstRowContaining", Value.PortKey()),
                () => ChipBuilder.DataTableGetFirstRowContaining(Value, new(DataTableName, ColumnName)));

        public T ReadCell(IntPort Row) =>
            CircuitBuilder.Singleton(SingletonKey("ReadCell", Row.PortKey()),
                () => ChipBuilder.DataTableReadCell<T>(Row, new(DataTableName, ColumnName)));

        public T this[IntPort Row] => ReadCell(Row); // Have it both ways -- whichever you prefer!
    }

    public abstract class BaseDataTable
    {
        protected string DataTableName = "";
        protected string[] DataTableColumnNames = new string[] { };
        protected Node? DataTableNode;

        // TODO: Not all of these support pure-data values yet.
        private static readonly Type[] ValidColumnTypes = new[] { typeof(BoolPort), typeof(IntPort), typeof(FloatPort), typeof(StringPort),
                                                                  typeof(RewardPort), typeof(ColorPort), typeof(InventoryItemPort) };

        public IntPort RowCount => GetRowCount();
        public IntPort ColumnCount => GetColumnCount();

        protected BaseDataTable() { }

        /// <summary>Constructor for an already-existing Data Table in the room.</summary>
        protected void InitExistingDataTable(StringPort name, params StringPort[] columnNames)
        {
            DataTableName = name.AsData<string>();
            DataTableColumnNames = columnNames.Select(s => s.AsData<string>()).ToArray();
        }

        /// <summary>Constructor for a new Data Table, created with RRCG.</summary>
        protected void InitNewDataTable(Action<DataTableDefinitionData> dataTableCreator, StringPort name, params (Type Type, StringPort Name, IEnumerable<AnyPort> Cells)[] columns)
        {
            DataTableName = name.AsData<string>();

            // Compile data table columns
            var columnsList = new List<(Type Type, string Name, object[] Cells)>();

            for (int i=0; i < columns.Length; i++)
            {
                var column = columns[i];

                // Ensure column type is valid for Data Tables
                if (!ValidColumnTypes.Contains(column.Type))
                    throw new Exception($"Data tables do not support columns of type {column.Type.Name}!");

                // Build cells
                var cellsList = new List<object>();
                foreach (var cell in column.Cells)
                {
                    // Each cell must match the provided type.
                    if (cell.GetType() != column.Type)
                        throw new Exception("Cell & column types do not match!");

                    // Each cell must be a data port
                    if (!cell.IsDataPort)
                        throw new Exception("Can't create a Data Table with dynamic data! Be sure to pass pure-data values!");

                    // Store the underlying data
                    cellsList.Add(cell.Data);
                }

                // Store the new column
                columnsList.Add((column.Type, column.Name.AsData<string>(), cellsList.ToArray()));
            }

            // Validate all columns have the same number of cells
            var expectedLength = columnsList.FirstOrDefault().Cells?.Length ?? 0;
            if (!columnsList.All(c => c.Cells.Length == expectedLength))
                throw new Exception("All columns must have the same number of cells!");

            // Create Data Table definition, store the node & column names
            dataTableCreator(new(DataTableName, columnsList.ToArray()));
            DataTableNode = Context.lastSpawnedNode;
            DataTableColumnNames = columnsList.Select(c => c.Name).ToArray();
        }

        protected DataTableColumn<T> GetColumn<T>(int columnIndex) where T : AnyPort, new()
        {
            if (columnIndex >= DataTableColumnNames.Length)
                throw new IndexOutOfRangeException("Column index exceeds the number of column names we have!");

            return new DataTableColumn<T>(DataTableName, DataTableColumnNames[columnIndex]);
        }

        private IntPort GetRowCount()
        {
            // If we know this value ahead of time, return a data port.
            // ASSUMPTION: All columns will have the same number of cells.
            if (DataTableNode != null)
                return DataTableNode.DataTableDefinitionData.Columns.FirstOrDefault().Cells?.Length ?? 0;

            // Otherwise we need the real chip.
            return CircuitBuilder.Singleton($"_RRCG_DataTable_{DataTableName}_RowCount",
                () => ChipBuilder.DataTableGetRowCount(new(DataTableName)));
        }

        private IntPort GetColumnCount()
        {
            // If we know this value ahead of time, return a data port.
            if (DataTableNode != null)
                return DataTableNode.DataTableDefinitionData.Columns.Length;

            // Otherwise we need the real chip.
            return CircuitBuilder.Singleton($"_RRCG_DataTable_{DataTableName}_ColumnCount",
                () => ChipBuilder.DataTableGetColumnCount(new(DataTableName)));
        }

        /// <summary>
        /// Transposes an enumerable of whole data table rows (like IEnumerable<(T0, T1, T2)>)
        /// into an array of columns for the InitNewDataTable constructor.
        /// 
        /// This is so that we can reconcile the constructor for the source-realm DataTables
        /// with the build-realm BaseDataTable constructor.
        /// </summary>
        protected static (Type Type, StringPort Name, IEnumerable<AnyPort> Cells)[] TransposeRowsToColumns(IEnumerable rows, params (string Name, Type Type)[] columns)
        {
            // Setup list of column definitions
            var columnsList = new List<(Type Type, StringPort Name, List<AnyPort> Cells)>();

            foreach (var column in columns)
                columnsList.Add((column.Type, column.Name, new()));
            
            // Enumerate rows and copy cell values
            foreach (var row in rows)
            {
                dynamic[] rowCells = row is ITuple tuple ? TupleUtils.WrapTuple(tuple) : new[] { row };
                if (rowCells.Length != columnsList.Count)
                    throw new Exception("Number of elements in a row should match the number of columns!");

                for (int i=0; i < columnsList.Count; i++)
                {
                    var currCell = rowCells[i];
                    var currColumn = columnsList[i];

                    // Ensure the cell is a data port of the correct type.
                    var port = PortConversionUtils.ToSpecificPort(currCell, currColumn.Type);
                    if (!port.IsDataPort)
                        throw new Exception("Can't create a Data Table with dynamic data! Be sure to pass pure-data values!");

                    // Then we can add it to the column cells.
                    currColumn.Cells.Add(port);
                }
            }

            // Finalize & return the columns.
            return columnsList.Select(c => (c.Type, c.Name, (IEnumerable<AnyPort>)c.Cells)).ToArray();
        }
    }

    #region Data Table Variants
    public class DataTable<T0> : BaseDataTable
        where T0 : AnyPort, new()
    {
        internal DataTable(bool disambiguate, StringPort name, StringPort column0Name) => InitExistingDataTable(name, column0Name);
        public DataTable(StringPort name, IEnumerable<T0> rows) => InitNewDataTable(
            (config) => ChipBuilder.DataTable(null, config),
            name,
            TransposeRowsToColumns(rows, ("column0", typeof(T0)))
        );

        public DataTableColumn<T0> Column0 => GetColumn<T0>(0);
    }

    public class DataTable<T0, T1> : BaseDataTable
        where T0 : AnyPort, new()
        where T1 : AnyPort, new()
    {
        internal DataTable(bool disambiguate, StringPort name, StringPort column0Name, StringPort column1Name) => InitExistingDataTable(name, column0Name, column1Name);
        public DataTable(StringPort name, IEnumerable<(T0, T1)> rows) => InitNewDataTable(
            (config) => ChipBuilder.DataTable(null, config),
            name,
            TransposeRowsToColumns(rows, ("column0", typeof(T0)), ("column1", typeof(T1)))
        );

        public DataTableColumn<T0> Column0 => GetColumn<T0>(0);
        public DataTableColumn<T1> Column1 => GetColumn<T1>(1);
    }

    public class DataTable<T0, T1, T2> : BaseDataTable
        where T0 : AnyPort, new()
        where T1 : AnyPort, new()
        where T2 : AnyPort, new()
    {
        internal DataTable(bool disambiguate, StringPort name, StringPort column0Name, StringPort column1Name, StringPort column2Name) => InitExistingDataTable(name, column0Name, column1Name, column2Name);
        public DataTable(StringPort name, IEnumerable<(T0, T1, T2)> rows) => InitNewDataTable(
            (config) => ChipBuilder.DataTable(null, config),
            name,
            TransposeRowsToColumns(rows, ("column0", typeof(T0)), ("column1", typeof(T1)), ("column2", typeof(T2)))
        );

        public DataTableColumn<T0> Column0 => GetColumn<T0>(0);
        public DataTableColumn<T1> Column1 => GetColumn<T1>(1);
        public DataTableColumn<T2> Column2 => GetColumn<T2>(2);
    }

    public class DataTable<T0, T1, T2, T3> : BaseDataTable
        where T0 : AnyPort, new()
        where T1 : AnyPort, new()
        where T2 : AnyPort, new()
        where T3 : AnyPort, new()
    {
        internal DataTable(bool disambiguate, StringPort name, StringPort column0Name, StringPort column1Name, StringPort column2Name, StringPort column3Name) => InitExistingDataTable(name, column0Name, column1Name, column2Name, column3Name);
        public DataTable(StringPort name, IEnumerable<(T0, T1, T2, T3)> rows) => InitNewDataTable(
            (config) => ChipBuilder.DataTable(null, config),
            name,
            TransposeRowsToColumns(rows, ("column0", typeof(T0)), ("column1", typeof(T1)), ("column2", typeof(T2)), ("column3", typeof(T3)))
        );

        public DataTableColumn<T0> Column0 => GetColumn<T0>(0);
        public DataTableColumn<T1> Column1 => GetColumn<T1>(1);
        public DataTableColumn<T2> Column2 => GetColumn<T2>(2);
        public DataTableColumn<T3> Column3 => GetColumn<T3>(3);
    }

    public class DataTable<T0, T1, T2, T3, T4> : BaseDataTable
        where T0 : AnyPort, new()
        where T1 : AnyPort, new()
        where T2 : AnyPort, new()
        where T3 : AnyPort, new()
        where T4 : AnyPort, new()
    {
        internal DataTable(bool disambiguate, StringPort name, StringPort column0Name, StringPort column1Name, StringPort column2Name, StringPort column3Name, StringPort column4Name) => InitExistingDataTable(name, column0Name, column1Name, column2Name, column3Name, column4Name);
        public DataTable(StringPort name, IEnumerable<(T0, T1, T2, T3, T4)> rows) => InitNewDataTable(
            (config) => ChipBuilder.DataTable(null, config),
            name,
            TransposeRowsToColumns(rows, ("column0", typeof(T0)), ("column1", typeof(T1)), ("column2", typeof(T2)), ("column3", typeof(T3)), ("column4", typeof(T4)))
        );

        public DataTableColumn<T0> Column0 => GetColumn<T0>(0);
        public DataTableColumn<T1> Column1 => GetColumn<T1>(1);
        public DataTableColumn<T2> Column2 => GetColumn<T2>(2);
        public DataTableColumn<T3> Column3 => GetColumn<T3>(3);
        public DataTableColumn<T4> Column4 => GetColumn<T4>(4);
    }

    public class DataTable<T0, T1, T2, T3, T4, T5> : BaseDataTable
        where T0 : AnyPort, new()
        where T1 : AnyPort, new()
        where T2 : AnyPort, new()
        where T3 : AnyPort, new()
        where T4 : AnyPort, new()
        where T5 : AnyPort, new()
    {
        internal DataTable(bool disambiguate, StringPort name, StringPort column0Name, StringPort column1Name, StringPort column2Name, StringPort column3Name, StringPort column4Name, StringPort column5Name) => InitExistingDataTable(name, column0Name, column1Name, column2Name, column3Name, column4Name, column5Name);
        public DataTable(StringPort name, IEnumerable<(T0, T1, T2, T3, T4, T5)> rows) => InitNewDataTable(
            (config) => ChipBuilder.DataTable(null, config),
            name,
            TransposeRowsToColumns(rows, ("column0", typeof(T0)), ("column1", typeof(T1)), ("column2", typeof(T2)), ("column3", typeof(T3)), ("column4", typeof(T4)), ("column5", typeof(T5)))
        );

        public DataTableColumn<T0> Column0 => GetColumn<T0>(0);
        public DataTableColumn<T1> Column1 => GetColumn<T1>(1);
        public DataTableColumn<T2> Column2 => GetColumn<T2>(2);
        public DataTableColumn<T3> Column3 => GetColumn<T3>(3);
        public DataTableColumn<T4> Column4 => GetColumn<T4>(4);
        public DataTableColumn<T5> Column5 => GetColumn<T5>(5);
    }

    public class DataTable<T0, T1, T2, T3, T4, T5, T6> : BaseDataTable
        where T0 : AnyPort, new()
        where T1 : AnyPort, new()
        where T2 : AnyPort, new()
        where T3 : AnyPort, new()
        where T4 : AnyPort, new()
        where T5 : AnyPort, new()
        where T6 : AnyPort, new()
    {
        internal DataTable(bool disambiguate, StringPort name, StringPort column0Name, StringPort column1Name, StringPort column2Name, StringPort column3Name, StringPort column4Name, StringPort column5Name, StringPort column6Name) => InitExistingDataTable(name, column0Name, column1Name, column2Name, column3Name, column4Name, column5Name, column6Name);
        public DataTable(StringPort name, IEnumerable<(T0, T1, T2, T3, T4, T5, T6)> rows) => InitNewDataTable(
            (config) => ChipBuilder.DataTable(null, config),
            name,
            TransposeRowsToColumns(rows, ("column0", typeof(T0)), ("column1", typeof(T1)), ("column2", typeof(T2)), ("column3", typeof(T3)), ("column4", typeof(T4)), ("column5", typeof(T5)), ("column6", typeof(T6)))
        );

        public DataTableColumn<T0> Column0 => GetColumn<T0>(0);
        public DataTableColumn<T1> Column1 => GetColumn<T1>(1);
        public DataTableColumn<T2> Column2 => GetColumn<T2>(2);
        public DataTableColumn<T3> Column3 => GetColumn<T3>(3);
        public DataTableColumn<T4> Column4 => GetColumn<T4>(4);
        public DataTableColumn<T5> Column5 => GetColumn<T5>(5);
        public DataTableColumn<T6> Column6 => GetColumn<T6>(6);
    }

    public class DataTable<T0, T1, T2, T3, T4, T5, T6, T7> : BaseDataTable
        where T0 : AnyPort, new()
        where T1 : AnyPort, new()
        where T2 : AnyPort, new()
        where T3 : AnyPort, new()
        where T4 : AnyPort, new()
        where T5 : AnyPort, new()
        where T6 : AnyPort, new()
        where T7 : AnyPort, new()
    {
        internal DataTable(bool disambiguate, StringPort name, StringPort column0Name, StringPort column1Name, StringPort column2Name, StringPort column3Name, StringPort column4Name, StringPort column5Name, StringPort column6Name, StringPort column7Name) => InitExistingDataTable(name, column0Name, column1Name, column2Name, column3Name, column4Name, column5Name, column6Name, column7Name);
        public DataTable(StringPort name, IEnumerable<(T0, T1, T2, T3, T4, T5, T6, T7)> rows) => InitNewDataTable(
            (config) => ChipBuilder.DataTable(null, config),
            name,
            TransposeRowsToColumns(rows, ("column0", typeof(T0)), ("column1", typeof(T1)), ("column2", typeof(T2)), ("column3", typeof(T3)), ("column4", typeof(T4)), ("column5", typeof(T5)), ("column6", typeof(T6)), ("column7", typeof(T7)))
        );

        public DataTableColumn<T0> Column0 => GetColumn<T0>(0);
        public DataTableColumn<T1> Column1 => GetColumn<T1>(1);
        public DataTableColumn<T2> Column2 => GetColumn<T2>(2);
        public DataTableColumn<T3> Column3 => GetColumn<T3>(3);
        public DataTableColumn<T4> Column4 => GetColumn<T4>(4);
        public DataTableColumn<T5> Column5 => GetColumn<T5>(5);
        public DataTableColumn<T6> Column6 => GetColumn<T6>(6);
        public DataTableColumn<T7> Column7 => GetColumn<T7>(7);
    }

    public class DataTable<T0, T1, T2, T3, T4, T5, T6, T7, T8> : BaseDataTable
        where T0 : AnyPort, new()
        where T1 : AnyPort, new()
        where T2 : AnyPort, new()
        where T3 : AnyPort, new()
        where T4 : AnyPort, new()
        where T5 : AnyPort, new()
        where T6 : AnyPort, new()
        where T7 : AnyPort, new()
        where T8 : AnyPort, new()
    {
        internal DataTable(bool disambiguate, StringPort name, StringPort column0Name, StringPort column1Name, StringPort column2Name, StringPort column3Name, StringPort column4Name, StringPort column5Name, StringPort column6Name, StringPort column7Name, StringPort column8Name) => InitExistingDataTable(name, column0Name, column1Name, column2Name, column3Name, column4Name, column5Name, column6Name, column7Name, column8Name);
        public DataTable(StringPort name, IEnumerable<(T0, T1, T2, T3, T4, T5, T6, T7, T8)> rows) => InitNewDataTable(
            (config) => ChipBuilder.DataTable(null, config),
            name,
            TransposeRowsToColumns(rows, ("column0", typeof(T0)), ("column1", typeof(T1)), ("column2", typeof(T2)), ("column3", typeof(T3)), ("column4", typeof(T4)), ("column5", typeof(T5)), ("column6", typeof(T6)), ("column7", typeof(T7)), ("column8", typeof(T8)))
        );

        public DataTableColumn<T0> Column0 => GetColumn<T0>(0);
        public DataTableColumn<T1> Column1 => GetColumn<T1>(1);
        public DataTableColumn<T2> Column2 => GetColumn<T2>(2);
        public DataTableColumn<T3> Column3 => GetColumn<T3>(3);
        public DataTableColumn<T4> Column4 => GetColumn<T4>(4);
        public DataTableColumn<T5> Column5 => GetColumn<T5>(5);
        public DataTableColumn<T6> Column6 => GetColumn<T6>(6);
        public DataTableColumn<T7> Column7 => GetColumn<T7>(7);
        public DataTableColumn<T8> Column8 => GetColumn<T8>(8);
    }

    public class DataTable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : BaseDataTable
        where T0 : AnyPort, new()
        where T1 : AnyPort, new()
        where T2 : AnyPort, new()
        where T3 : AnyPort, new()
        where T4 : AnyPort, new()
        where T5 : AnyPort, new()
        where T6 : AnyPort, new()
        where T7 : AnyPort, new()
        where T8 : AnyPort, new()
        where T9 : AnyPort, new()
    {
        internal DataTable(bool disambiguate, StringPort name, StringPort column0Name, StringPort column1Name, StringPort column2Name, StringPort column3Name, StringPort column4Name, StringPort column5Name, StringPort column6Name, StringPort column7Name, StringPort column8Name, StringPort column9Name) => InitExistingDataTable(name, column0Name, column1Name, column2Name, column3Name, column4Name, column5Name, column6Name, column7Name, column8Name, column9Name);
        public DataTable(StringPort name, IEnumerable<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9)> rows) => InitNewDataTable(
            (config) => ChipBuilder.DataTable(null, config),
            name,
            TransposeRowsToColumns(rows, ("column0", typeof(T0)), ("column1", typeof(T1)), ("column2", typeof(T2)), ("column3", typeof(T3)), ("column4", typeof(T4)), ("column5", typeof(T5)), ("column6", typeof(T6)), ("column7", typeof(T7)), ("column8", typeof(T8)), ("column9", typeof(T9)))
        );

        public DataTableColumn<T0> Column0 => GetColumn<T0>(0);
        public DataTableColumn<T1> Column1 => GetColumn<T1>(1);
        public DataTableColumn<T2> Column2 => GetColumn<T2>(2);
        public DataTableColumn<T3> Column3 => GetColumn<T3>(3);
        public DataTableColumn<T4> Column4 => GetColumn<T4>(4);
        public DataTableColumn<T5> Column5 => GetColumn<T5>(5);
        public DataTableColumn<T6> Column6 => GetColumn<T6>(6);
        public DataTableColumn<T7> Column7 => GetColumn<T7>(7);
        public DataTableColumn<T8> Column8 => GetColumn<T8>(8);
        public DataTableColumn<T9> Column9 => GetColumn<T9>(9);
    }

    public class DataTable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : BaseDataTable
        where T0 : AnyPort, new()
        where T1 : AnyPort, new()
        where T2 : AnyPort, new()
        where T3 : AnyPort, new()
        where T4 : AnyPort, new()
        where T5 : AnyPort, new()
        where T6 : AnyPort, new()
        where T7 : AnyPort, new()
        where T8 : AnyPort, new()
        where T9 : AnyPort, new()
        where T10 : AnyPort, new()
    {
        internal DataTable(bool disambiguate, StringPort name, StringPort column0Name, StringPort column1Name, StringPort column2Name, StringPort column3Name, StringPort column4Name, StringPort column5Name, StringPort column6Name, StringPort column7Name, StringPort column8Name, StringPort column9Name, StringPort column10Name) => InitExistingDataTable(name, column0Name, column1Name, column2Name, column3Name, column4Name, column5Name, column6Name, column7Name, column8Name, column9Name, column10Name);
        public DataTable(StringPort name, IEnumerable<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> rows) => InitNewDataTable(
            (config) => ChipBuilder.DataTable(null, config),
            name,
            TransposeRowsToColumns(rows, ("column0", typeof(T0)), ("column1", typeof(T1)), ("column2", typeof(T2)), ("column3", typeof(T3)), ("column4", typeof(T4)), ("column5", typeof(T5)), ("column6", typeof(T6)), ("column7", typeof(T7)), ("column8", typeof(T8)), ("column9", typeof(T9)), ("column10", typeof(T10)))
        );

        public DataTableColumn<T0> Column0 => GetColumn<T0>(0);
        public DataTableColumn<T1> Column1 => GetColumn<T1>(1);
        public DataTableColumn<T2> Column2 => GetColumn<T2>(2);
        public DataTableColumn<T3> Column3 => GetColumn<T3>(3);
        public DataTableColumn<T4> Column4 => GetColumn<T4>(4);
        public DataTableColumn<T5> Column5 => GetColumn<T5>(5);
        public DataTableColumn<T6> Column6 => GetColumn<T6>(6);
        public DataTableColumn<T7> Column7 => GetColumn<T7>(7);
        public DataTableColumn<T8> Column8 => GetColumn<T8>(8);
        public DataTableColumn<T9> Column9 => GetColumn<T9>(9);
        public DataTableColumn<T10> Column10 => GetColumn<T10>(10);
    }

    public class DataTable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : BaseDataTable
        where T0 : AnyPort, new()
        where T1 : AnyPort, new()
        where T2 : AnyPort, new()
        where T3 : AnyPort, new()
        where T4 : AnyPort, new()
        where T5 : AnyPort, new()
        where T6 : AnyPort, new()
        where T7 : AnyPort, new()
        where T8 : AnyPort, new()
        where T9 : AnyPort, new()
        where T10 : AnyPort, new()
        where T11 : AnyPort, new()
    {
        internal DataTable(bool disambiguate, StringPort name, StringPort column0Name, StringPort column1Name, StringPort column2Name, StringPort column3Name, StringPort column4Name, StringPort column5Name, StringPort column6Name, StringPort column7Name, StringPort column8Name, StringPort column9Name, StringPort column10Name, StringPort column11Name) => InitExistingDataTable(name, column0Name, column1Name, column2Name, column3Name, column4Name, column5Name, column6Name, column7Name, column8Name, column9Name, column10Name, column11Name);
        public DataTable(StringPort name, IEnumerable<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> rows) => InitNewDataTable(
            (config) => ChipBuilder.DataTable(null, config),
            name,
            TransposeRowsToColumns(rows, ("column0", typeof(T0)), ("column1", typeof(T1)), ("column2", typeof(T2)), ("column3", typeof(T3)), ("column4", typeof(T4)), ("column5", typeof(T5)), ("column6", typeof(T6)), ("column7", typeof(T7)), ("column8", typeof(T8)), ("column9", typeof(T9)), ("column10", typeof(T10)), ("column11", typeof(T11)))
        );

        public DataTableColumn<T0> Column0 => GetColumn<T0>(0);
        public DataTableColumn<T1> Column1 => GetColumn<T1>(1);
        public DataTableColumn<T2> Column2 => GetColumn<T2>(2);
        public DataTableColumn<T3> Column3 => GetColumn<T3>(3);
        public DataTableColumn<T4> Column4 => GetColumn<T4>(4);
        public DataTableColumn<T5> Column5 => GetColumn<T5>(5);
        public DataTableColumn<T6> Column6 => GetColumn<T6>(6);
        public DataTableColumn<T7> Column7 => GetColumn<T7>(7);
        public DataTableColumn<T8> Column8 => GetColumn<T8>(8);
        public DataTableColumn<T9> Column9 => GetColumn<T9>(9);
        public DataTableColumn<T10> Column10 => GetColumn<T10>(10);
        public DataTableColumn<T11> Column11 => GetColumn<T11>(11);
    }

    public class DataTable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : BaseDataTable
        where T0 : AnyPort, new()
        where T1 : AnyPort, new()
        where T2 : AnyPort, new()
        where T3 : AnyPort, new()
        where T4 : AnyPort, new()
        where T5 : AnyPort, new()
        where T6 : AnyPort, new()
        where T7 : AnyPort, new()
        where T8 : AnyPort, new()
        where T9 : AnyPort, new()
        where T10 : AnyPort, new()
        where T11 : AnyPort, new()
        where T12 : AnyPort, new()
    {
        internal DataTable(bool disambiguate, StringPort name, StringPort column0Name, StringPort column1Name, StringPort column2Name, StringPort column3Name, StringPort column4Name, StringPort column5Name, StringPort column6Name, StringPort column7Name, StringPort column8Name, StringPort column9Name, StringPort column10Name, StringPort column11Name, StringPort column12Name) => InitExistingDataTable(name, column0Name, column1Name, column2Name, column3Name, column4Name, column5Name, column6Name, column7Name, column8Name, column9Name, column10Name, column11Name, column12Name);
        public DataTable(StringPort name, IEnumerable<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> rows) => InitNewDataTable(
            (config) => ChipBuilder.DataTable(null, config),
            name,
            TransposeRowsToColumns(rows, ("column0", typeof(T0)), ("column1", typeof(T1)), ("column2", typeof(T2)), ("column3", typeof(T3)), ("column4", typeof(T4)), ("column5", typeof(T5)), ("column6", typeof(T6)), ("column7", typeof(T7)), ("column8", typeof(T8)), ("column9", typeof(T9)), ("column10", typeof(T10)), ("column11", typeof(T11)), ("column12", typeof(T12)))
        );

        public DataTableColumn<T0> Column0 => GetColumn<T0>(0);
        public DataTableColumn<T1> Column1 => GetColumn<T1>(1);
        public DataTableColumn<T2> Column2 => GetColumn<T2>(2);
        public DataTableColumn<T3> Column3 => GetColumn<T3>(3);
        public DataTableColumn<T4> Column4 => GetColumn<T4>(4);
        public DataTableColumn<T5> Column5 => GetColumn<T5>(5);
        public DataTableColumn<T6> Column6 => GetColumn<T6>(6);
        public DataTableColumn<T7> Column7 => GetColumn<T7>(7);
        public DataTableColumn<T8> Column8 => GetColumn<T8>(8);
        public DataTableColumn<T9> Column9 => GetColumn<T9>(9);
        public DataTableColumn<T10> Column10 => GetColumn<T10>(10);
        public DataTableColumn<T11> Column11 => GetColumn<T11>(11);
        public DataTableColumn<T12> Column12 => GetColumn<T12>(12);
    }

    public class DataTable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : BaseDataTable
        where T0 : AnyPort, new()
        where T1 : AnyPort, new()
        where T2 : AnyPort, new()
        where T3 : AnyPort, new()
        where T4 : AnyPort, new()
        where T5 : AnyPort, new()
        where T6 : AnyPort, new()
        where T7 : AnyPort, new()
        where T8 : AnyPort, new()
        where T9 : AnyPort, new()
        where T10 : AnyPort, new()
        where T11 : AnyPort, new()
        where T12 : AnyPort, new()
        where T13 : AnyPort, new()
    {
        internal DataTable(bool disambiguate, StringPort name, StringPort column0Name, StringPort column1Name, StringPort column2Name, StringPort column3Name, StringPort column4Name, StringPort column5Name, StringPort column6Name, StringPort column7Name, StringPort column8Name, StringPort column9Name, StringPort column10Name, StringPort column11Name, StringPort column12Name, StringPort column13Name) => InitExistingDataTable(name, column0Name, column1Name, column2Name, column3Name, column4Name, column5Name, column6Name, column7Name, column8Name, column9Name, column10Name, column11Name, column12Name, column13Name);
        public DataTable(StringPort name, IEnumerable<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)> rows) => InitNewDataTable(
            (config) => ChipBuilder.DataTable(null, config),
            name,
            TransposeRowsToColumns(rows, ("column0", typeof(T0)), ("column1", typeof(T1)), ("column2", typeof(T2)), ("column3", typeof(T3)), ("column4", typeof(T4)), ("column5", typeof(T5)), ("column6", typeof(T6)), ("column7", typeof(T7)), ("column8", typeof(T8)), ("column9", typeof(T9)), ("column10", typeof(T10)), ("column11", typeof(T11)), ("column12", typeof(T12)), ("column13", typeof(T13)))
        );

        public DataTableColumn<T0> Column0 => GetColumn<T0>(0);
        public DataTableColumn<T1> Column1 => GetColumn<T1>(1);
        public DataTableColumn<T2> Column2 => GetColumn<T2>(2);
        public DataTableColumn<T3> Column3 => GetColumn<T3>(3);
        public DataTableColumn<T4> Column4 => GetColumn<T4>(4);
        public DataTableColumn<T5> Column5 => GetColumn<T5>(5);
        public DataTableColumn<T6> Column6 => GetColumn<T6>(6);
        public DataTableColumn<T7> Column7 => GetColumn<T7>(7);
        public DataTableColumn<T8> Column8 => GetColumn<T8>(8);
        public DataTableColumn<T9> Column9 => GetColumn<T9>(9);
        public DataTableColumn<T10> Column10 => GetColumn<T10>(10);
        public DataTableColumn<T11> Column11 => GetColumn<T11>(11);
        public DataTableColumn<T12> Column12 => GetColumn<T12>(12);
        public DataTableColumn<T13> Column13 => GetColumn<T13>(13);
    }

    public class DataTable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : BaseDataTable
        where T0 : AnyPort, new()
        where T1 : AnyPort, new()
        where T2 : AnyPort, new()
        where T3 : AnyPort, new()
        where T4 : AnyPort, new()
        where T5 : AnyPort, new()
        where T6 : AnyPort, new()
        where T7 : AnyPort, new()
        where T8 : AnyPort, new()
        where T9 : AnyPort, new()
        where T10 : AnyPort, new()
        where T11 : AnyPort, new()
        where T12 : AnyPort, new()
        where T13 : AnyPort, new()
        where T14 : AnyPort, new()
    {
        internal DataTable(bool disambiguate, StringPort name, StringPort column0Name, StringPort column1Name, StringPort column2Name, StringPort column3Name, StringPort column4Name, StringPort column5Name, StringPort column6Name, StringPort column7Name, StringPort column8Name, StringPort column9Name, StringPort column10Name, StringPort column11Name, StringPort column12Name, StringPort column13Name, StringPort column14Name) => InitExistingDataTable(name, column0Name, column1Name, column2Name, column3Name, column4Name, column5Name, column6Name, column7Name, column8Name, column9Name, column10Name, column11Name, column12Name, column13Name, column14Name);
        public DataTable(StringPort name, IEnumerable<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)> rows) => InitNewDataTable(
            (config) => ChipBuilder.DataTable(null, config),
            name,
            TransposeRowsToColumns(rows, ("column0", typeof(T0)), ("column1", typeof(T1)), ("column2", typeof(T2)), ("column3", typeof(T3)), ("column4", typeof(T4)), ("column5", typeof(T5)), ("column6", typeof(T6)), ("column7", typeof(T7)), ("column8", typeof(T8)), ("column9", typeof(T9)), ("column10", typeof(T10)), ("column11", typeof(T11)), ("column12", typeof(T12)), ("column13", typeof(T13)), ("column14", typeof(T14)))
        );

        public DataTableColumn<T0> Column0 => GetColumn<T0>(0);
        public DataTableColumn<T1> Column1 => GetColumn<T1>(1);
        public DataTableColumn<T2> Column2 => GetColumn<T2>(2);
        public DataTableColumn<T3> Column3 => GetColumn<T3>(3);
        public DataTableColumn<T4> Column4 => GetColumn<T4>(4);
        public DataTableColumn<T5> Column5 => GetColumn<T5>(5);
        public DataTableColumn<T6> Column6 => GetColumn<T6>(6);
        public DataTableColumn<T7> Column7 => GetColumn<T7>(7);
        public DataTableColumn<T8> Column8 => GetColumn<T8>(8);
        public DataTableColumn<T9> Column9 => GetColumn<T9>(9);
        public DataTableColumn<T10> Column10 => GetColumn<T10>(10);
        public DataTableColumn<T11> Column11 => GetColumn<T11>(11);
        public DataTableColumn<T12> Column12 => GetColumn<T12>(12);
        public DataTableColumn<T13> Column13 => GetColumn<T13>(13);
        public DataTableColumn<T14> Column14 => GetColumn<T14>(14);
    }

    public class DataTable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : BaseDataTable
        where T0 : AnyPort, new()
        where T1 : AnyPort, new()
        where T2 : AnyPort, new()
        where T3 : AnyPort, new()
        where T4 : AnyPort, new()
        where T5 : AnyPort, new()
        where T6 : AnyPort, new()
        where T7 : AnyPort, new()
        where T8 : AnyPort, new()
        where T9 : AnyPort, new()
        where T10 : AnyPort, new()
        where T11 : AnyPort, new()
        where T12 : AnyPort, new()
        where T13 : AnyPort, new()
        where T14 : AnyPort, new()
        where T15 : AnyPort, new()
    {
        internal DataTable(bool disambiguate, StringPort name, StringPort column0Name, StringPort column1Name, StringPort column2Name, StringPort column3Name, StringPort column4Name, StringPort column5Name, StringPort column6Name, StringPort column7Name, StringPort column8Name, StringPort column9Name, StringPort column10Name, StringPort column11Name, StringPort column12Name, StringPort column13Name, StringPort column14Name, StringPort column15Name) => InitExistingDataTable(name, column0Name, column1Name, column2Name, column3Name, column4Name, column5Name, column6Name, column7Name, column8Name, column9Name, column10Name, column11Name, column12Name, column13Name, column14Name, column15Name);
        public DataTable(StringPort name, IEnumerable<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)> rows) => InitNewDataTable(
            (config) => ChipBuilder.DataTable(null, config),
            name,
            TransposeRowsToColumns(rows, ("column0", typeof(T0)), ("column1", typeof(T1)), ("column2", typeof(T2)), ("column3", typeof(T3)), ("column4", typeof(T4)), ("column5", typeof(T5)), ("column6", typeof(T6)), ("column7", typeof(T7)), ("column8", typeof(T8)), ("column9", typeof(T9)), ("column10", typeof(T10)), ("column11", typeof(T11)), ("column12", typeof(T12)), ("column13", typeof(T13)), ("column14", typeof(T14)), ("column15", typeof(T15)))
        );

        public DataTableColumn<T0> Column0 => GetColumn<T0>(0);
        public DataTableColumn<T1> Column1 => GetColumn<T1>(1);
        public DataTableColumn<T2> Column2 => GetColumn<T2>(2);
        public DataTableColumn<T3> Column3 => GetColumn<T3>(3);
        public DataTableColumn<T4> Column4 => GetColumn<T4>(4);
        public DataTableColumn<T5> Column5 => GetColumn<T5>(5);
        public DataTableColumn<T6> Column6 => GetColumn<T6>(6);
        public DataTableColumn<T7> Column7 => GetColumn<T7>(7);
        public DataTableColumn<T8> Column8 => GetColumn<T8>(8);
        public DataTableColumn<T9> Column9 => GetColumn<T9>(9);
        public DataTableColumn<T10> Column10 => GetColumn<T10>(10);
        public DataTableColumn<T11> Column11 => GetColumn<T11>(11);
        public DataTableColumn<T12> Column12 => GetColumn<T12>(12);
        public DataTableColumn<T13> Column13 => GetColumn<T13>(13);
        public DataTableColumn<T14> Column14 => GetColumn<T14>(14);
        public DataTableColumn<T15> Column15 => GetColumn<T15>(15);
    }
    #endregion
}
#nullable disable