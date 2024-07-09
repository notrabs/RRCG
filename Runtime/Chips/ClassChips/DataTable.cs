using System.Collections.Generic;

namespace RRCGSource
{
    public class DataTableColumn<T>
    {
        /// <summary>The name of the column in the data table</summary>
        public string Name => default;

        /// <summary>Returns a list containing the indices of all cells matching the value</summary>
        public List<int> GetAllRowsContaining(T Value) => default;

        /// <summary>Returns the index of the first cell that matches the value</summary>
        public int GetFirstRowContaining(T Value) => default;

        /// <summary>Reads the cell at the given index.</summary>
        public T ReadCell(int Row) => default;

        /// <inheritdoc cref="ReadCell(int)"/>
        public T this[int Row] => ReadCell(Row); // Have it both ways -- whichever you prefer!
    }

    #region Data Table Variants
    public class DataTable<T0>
    {
        /// <summary>
        /// Constructs a new data table programatically.
        /// </summary>
        /// <param name="name">The name of the data table</param>
        /// <param name="rows">An enumerable that describes the cell values for each row</param>
        public DataTable(string name, IEnumerable<T0> rows) { }

        /// <summary>The number of rows in the data table</summary>
        public int RowCount => default;

        /// <summary>The number of columns in the data table</summary>
        public int ColumnCount => default;

        public DataTableColumn<T0> Column0 => default;
    }

    public class DataTable<T0, T1>
    {
        /// <summary>
        /// Constructs a new data table programatically.
        /// </summary>
        /// <param name="name">The name of the data table</param>
        /// <param name="rows">An enumerable that describes the cell values for each row</param>
        public DataTable(string name, IEnumerable<(T0, T1)> rows) { }

        /// <summary>The number of rows in the data table</summary>
        public int RowCount => default;

        /// <summary>The number of columns in the data table</summary>
        public int ColumnCount => default;

        public DataTableColumn<T0> Column0 => default;
        public DataTableColumn<T1> Column1 => default;
    }

    public class DataTable<T0, T1, T2>
    {
        /// <summary>
        /// Constructs a new data table programatically.
        /// </summary>
        /// <param name="name">The name of the data table</param>
        /// <param name="rows">An enumerable that describes the cell values for each row</param>
        public DataTable(string name, IEnumerable<(T0, T1, T2)> rows) { }

        /// <summary>The number of rows in the data table</summary>
        public int RowCount => default;

        /// <summary>The number of columns in the data table</summary>
        public int ColumnCount => default;

        public DataTableColumn<T0> Column0 => default;
        public DataTableColumn<T1> Column1 => default;
        public DataTableColumn<T2> Column2 => default;
    }

    public class DataTable<T0, T1, T2, T3>
    {
        /// <summary>
        /// Constructs a new data table programatically.
        /// </summary>
        /// <param name="name">The name of the data table</param>
        /// <param name="rows">An enumerable that describes the cell values for each row</param>
        public DataTable(string name, IEnumerable<(T0, T1, T2, T3)> rows) { }

        /// <summary>The number of rows in the data table</summary>
        public int RowCount => default;

        /// <summary>The number of columns in the data table</summary>
        public int ColumnCount => default;

        public DataTableColumn<T0> Column0 => default;
        public DataTableColumn<T1> Column1 => default;
        public DataTableColumn<T2> Column2 => default;
        public DataTableColumn<T3> Column3 => default;
    }

    public class DataTable<T0, T1, T2, T3, T4>
    {
        /// <summary>
        /// Constructs a new data table programatically.
        /// </summary>
        /// <param name="name">The name of the data table</param>
        /// <param name="rows">An enumerable that describes the cell values for each row</param>
        public DataTable(string name, IEnumerable<(T0, T1, T2, T3, T4)> rows) { }

        /// <summary>The number of rows in the data table</summary>
        public int RowCount => default;

        /// <summary>The number of columns in the data table</summary>
        public int ColumnCount => default;

        public DataTableColumn<T0> Column0 => default;
        public DataTableColumn<T1> Column1 => default;
        public DataTableColumn<T2> Column2 => default;
        public DataTableColumn<T3> Column3 => default;
        public DataTableColumn<T4> Column4 => default;
    }

    public class DataTable<T0, T1, T2, T3, T4, T5>
    {
        /// <summary>
        /// Constructs a new data table programatically.
        /// </summary>
        /// <param name="name">The name of the data table</param>
        /// <param name="rows">An enumerable that describes the cell values for each row</param>
        public DataTable(string name, IEnumerable<(T0, T1, T2, T3, T4, T5)> rows) { }

        /// <summary>The number of rows in the data table</summary>
        public int RowCount => default;

        /// <summary>The number of columns in the data table</summary>
        public int ColumnCount => default;

        public DataTableColumn<T0> Column0 => default;
        public DataTableColumn<T1> Column1 => default;
        public DataTableColumn<T2> Column2 => default;
        public DataTableColumn<T3> Column3 => default;
        public DataTableColumn<T4> Column4 => default;
        public DataTableColumn<T5> Column5 => default;
    }

    public class DataTable<T0, T1, T2, T3, T4, T5, T6>
    {
        /// <summary>
        /// Constructs a new data table programatically.
        /// </summary>
        /// <param name="name">The name of the data table</param>
        /// <param name="rows">An enumerable that describes the cell values for each row</param>
        public DataTable(string name, IEnumerable<(T0, T1, T2, T3, T4, T5, T6)> rows) { }

        /// <summary>The number of rows in the data table</summary>
        public int RowCount => default;

        /// <summary>The number of columns in the data table</summary>
        public int ColumnCount => default;

        public DataTableColumn<T0> Column0 => default;
        public DataTableColumn<T1> Column1 => default;
        public DataTableColumn<T2> Column2 => default;
        public DataTableColumn<T3> Column3 => default;
        public DataTableColumn<T4> Column4 => default;
        public DataTableColumn<T5> Column5 => default;
        public DataTableColumn<T6> Column6 => default;
    }

    public class DataTable<T0, T1, T2, T3, T4, T5, T6, T7>
    {
        /// <summary>
        /// Constructs a new data table programatically.
        /// </summary>
        /// <param name="name">The name of the data table</param>
        /// <param name="rows">An enumerable that describes the cell values for each row</param>
        public DataTable(string name, IEnumerable<(T0, T1, T2, T3, T4, T5, T6, T7)> rows) { }

        /// <summary>The number of rows in the data table</summary>
        public int RowCount => default;

        /// <summary>The number of columns in the data table</summary>
        public int ColumnCount => default;

        public DataTableColumn<T0> Column0 => default;
        public DataTableColumn<T1> Column1 => default;
        public DataTableColumn<T2> Column2 => default;
        public DataTableColumn<T3> Column3 => default;
        public DataTableColumn<T4> Column4 => default;
        public DataTableColumn<T5> Column5 => default;
        public DataTableColumn<T6> Column6 => default;
        public DataTableColumn<T7> Column7 => default;
    }

    public class DataTable<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    {
        /// <summary>
        /// Constructs a new data table programatically.
        /// </summary>
        /// <param name="name">The name of the data table</param>
        /// <param name="rows">An enumerable that describes the cell values for each row</param>
        public DataTable(string name, IEnumerable<(T0, T1, T2, T3, T4, T5, T6, T7, T8)> rows) { }

        /// <summary>The number of rows in the data table</summary>
        public int RowCount => default;

        /// <summary>The number of columns in the data table</summary>
        public int ColumnCount => default;

        public DataTableColumn<T0> Column0 => default;
        public DataTableColumn<T1> Column1 => default;
        public DataTableColumn<T2> Column2 => default;
        public DataTableColumn<T3> Column3 => default;
        public DataTableColumn<T4> Column4 => default;
        public DataTableColumn<T5> Column5 => default;
        public DataTableColumn<T6> Column6 => default;
        public DataTableColumn<T7> Column7 => default;
        public DataTableColumn<T8> Column8 => default;
    }

    public class DataTable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        /// <summary>
        /// Constructs a new data table programatically.
        /// </summary>
        /// <param name="name">The name of the data table</param>
        /// <param name="rows">An enumerable that describes the cell values for each row</param>
        public DataTable(string name, IEnumerable<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9)> rows) { }

        /// <summary>The number of rows in the data table</summary>
        public int RowCount => default;

        /// <summary>The number of columns in the data table</summary>
        public int ColumnCount => default;

        public DataTableColumn<T0> Column0 => default;
        public DataTableColumn<T1> Column1 => default;
        public DataTableColumn<T2> Column2 => default;
        public DataTableColumn<T3> Column3 => default;
        public DataTableColumn<T4> Column4 => default;
        public DataTableColumn<T5> Column5 => default;
        public DataTableColumn<T6> Column6 => default;
        public DataTableColumn<T7> Column7 => default;
        public DataTableColumn<T8> Column8 => default;
        public DataTableColumn<T9> Column9 => default;
    }

    public class DataTable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        /// <summary>
        /// Constructs a new data table programatically.
        /// </summary>
        /// <param name="name">The name of the data table</param>
        /// <param name="rows">An enumerable that describes the cell values for each row</param>
        public DataTable(string name, IEnumerable<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> rows) { }

        /// <summary>The number of rows in the data table</summary>
        public int RowCount => default;

        /// <summary>The number of columns in the data table</summary>
        public int ColumnCount => default;

        public DataTableColumn<T0> Column0 => default;
        public DataTableColumn<T1> Column1 => default;
        public DataTableColumn<T2> Column2 => default;
        public DataTableColumn<T3> Column3 => default;
        public DataTableColumn<T4> Column4 => default;
        public DataTableColumn<T5> Column5 => default;
        public DataTableColumn<T6> Column6 => default;
        public DataTableColumn<T7> Column7 => default;
        public DataTableColumn<T8> Column8 => default;
        public DataTableColumn<T9> Column9 => default;
        public DataTableColumn<T10> Column10 => default;
    }

    public class DataTable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    {
        /// <summary>
        /// Constructs a new data table programatically.
        /// </summary>
        /// <param name="name">The name of the data table</param>
        /// <param name="rows">An enumerable that describes the cell values for each row</param>
        public DataTable(string name, IEnumerable<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> rows) { }

        /// <summary>The number of rows in the data table</summary>
        public int RowCount => default;

        /// <summary>The number of columns in the data table</summary>
        public int ColumnCount => default;

        public DataTableColumn<T0> Column0 => default;
        public DataTableColumn<T1> Column1 => default;
        public DataTableColumn<T2> Column2 => default;
        public DataTableColumn<T3> Column3 => default;
        public DataTableColumn<T4> Column4 => default;
        public DataTableColumn<T5> Column5 => default;
        public DataTableColumn<T6> Column6 => default;
        public DataTableColumn<T7> Column7 => default;
        public DataTableColumn<T8> Column8 => default;
        public DataTableColumn<T9> Column9 => default;
        public DataTableColumn<T10> Column10 => default;
        public DataTableColumn<T11> Column11 => default;
    }

    public class DataTable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    {
        /// <summary>
        /// Constructs a new data table programatically.
        /// </summary>
        /// <param name="name">The name of the data table</param>
        /// <param name="rows">An enumerable that describes the cell values for each row</param>
        public DataTable(string name, IEnumerable<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> rows) { }

        /// <summary>The number of rows in the data table</summary>
        public int RowCount => default;

        /// <summary>The number of columns in the data table</summary>
        public int ColumnCount => default;

        public DataTableColumn<T0> Column0 => default;
        public DataTableColumn<T1> Column1 => default;
        public DataTableColumn<T2> Column2 => default;
        public DataTableColumn<T3> Column3 => default;
        public DataTableColumn<T4> Column4 => default;
        public DataTableColumn<T5> Column5 => default;
        public DataTableColumn<T6> Column6 => default;
        public DataTableColumn<T7> Column7 => default;
        public DataTableColumn<T8> Column8 => default;
        public DataTableColumn<T9> Column9 => default;
        public DataTableColumn<T10> Column10 => default;
        public DataTableColumn<T11> Column11 => default;
        public DataTableColumn<T12> Column12 => default;
    }

    public class DataTable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
    {
        /// <summary>
        /// Constructs a new data table programatically.
        /// </summary>
        /// <param name="name">The name of the data table</param>
        /// <param name="rows">An enumerable that describes the cell values for each row</param>
        public DataTable(string name, IEnumerable<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)> rows) { }

        /// <summary>The number of rows in the data table</summary>
        public int RowCount => default;

        /// <summary>The number of columns in the data table</summary>
        public int ColumnCount => default;

        public DataTableColumn<T0> Column0 => default;
        public DataTableColumn<T1> Column1 => default;
        public DataTableColumn<T2> Column2 => default;
        public DataTableColumn<T3> Column3 => default;
        public DataTableColumn<T4> Column4 => default;
        public DataTableColumn<T5> Column5 => default;
        public DataTableColumn<T6> Column6 => default;
        public DataTableColumn<T7> Column7 => default;
        public DataTableColumn<T8> Column8 => default;
        public DataTableColumn<T9> Column9 => default;
        public DataTableColumn<T10> Column10 => default;
        public DataTableColumn<T11> Column11 => default;
        public DataTableColumn<T12> Column12 => default;
        public DataTableColumn<T13> Column13 => default;
    }

    public class DataTable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
    {
        /// <summary>
        /// Constructs a new data table programatically.
        /// </summary>
        /// <param name="name">The name of the data table</param>
        /// <param name="rows">An enumerable that describes the cell values for each row</param>
        public DataTable(string name, IEnumerable<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)> rows) { }

        /// <summary>The number of rows in the data table</summary>
        public int RowCount => default;

        /// <summary>The number of columns in the data table</summary>
        public int ColumnCount => default;

        public DataTableColumn<T0> Column0 => default;
        public DataTableColumn<T1> Column1 => default;
        public DataTableColumn<T2> Column2 => default;
        public DataTableColumn<T3> Column3 => default;
        public DataTableColumn<T4> Column4 => default;
        public DataTableColumn<T5> Column5 => default;
        public DataTableColumn<T6> Column6 => default;
        public DataTableColumn<T7> Column7 => default;
        public DataTableColumn<T8> Column8 => default;
        public DataTableColumn<T9> Column9 => default;
        public DataTableColumn<T10> Column10 => default;
        public DataTableColumn<T11> Column11 => default;
        public DataTableColumn<T12> Column12 => default;
        public DataTableColumn<T13> Column13 => default;
        public DataTableColumn<T14> Column14 => default;
    }

    public class DataTable<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
    {
        /// <summary>
        /// Constructs a new data table programatically.
        /// </summary>
        /// <param name="name">The name of the data table</param>
        /// <param name="rows">An enumerable that describes the cell values for each row</param>
        public DataTable(string name, IEnumerable<(T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)> rows) { }

        /// <summary>The number of rows in the data table</summary>
        public int RowCount => default;

        /// <summary>The number of columns in the data table</summary>
        public int ColumnCount => default;

        public DataTableColumn<T0> Column0 => default;
        public DataTableColumn<T1> Column1 => default;
        public DataTableColumn<T2> Column2 => default;
        public DataTableColumn<T3> Column3 => default;
        public DataTableColumn<T4> Column4 => default;
        public DataTableColumn<T5> Column5 => default;
        public DataTableColumn<T6> Column6 => default;
        public DataTableColumn<T7> Column7 => default;
        public DataTableColumn<T8> Column8 => default;
        public DataTableColumn<T9> Column9 => default;
        public DataTableColumn<T10> Column10 => default;
        public DataTableColumn<T11> Column11 => default;
        public DataTableColumn<T12> Column12 => default;
        public DataTableColumn<T13> Column13 => default;
        public DataTableColumn<T14> Column14 => default;
        public DataTableColumn<T15> Column15 => default;
    }
    #endregion
}