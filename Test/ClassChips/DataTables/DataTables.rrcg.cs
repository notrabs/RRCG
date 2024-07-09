using RRCG;
using RRCGSource;
using UnityEngine;

public class DataTables : CircuitDescriptor
{
    public override void CircuitGraph()
    {
        // Create a Data Table
        var table = new DataTable<int, float, string>("Test Table 1", DataTablesTestData.GetThreeColumnData(50));

        // Access its columns
        var indexColumn = table.Column0;
        var percentageColumn = table.Column1;
        var nameColumn = table.Column2;

        // Access column names
        // This is provided as a convenience feature, mainly for existing data tables.
        // Data Tables created like above will give you autogenerated names like column0, etc.
        LogString($"Have columns: {indexColumn.Name}, {percentageColumn.Name}, {nameColumn.Name}");

        // Log all rows
        for (int i = 0; i < table.RowCount; i++)
        {
            LogString($"Row {i}: {indexColumn[i]}, {percentageColumn[i]}, {nameColumn[i]}");
            ChipLib.AwaitDelay();
        }

        // Test lookup features
        LogString($"{nameColumn.GetAllRowsContaining("Element 5")}");
        LogString($"{indexColumn.GetFirstRowContaining(25)}");

        // Test ReadCell method
        // (Equivalent to the indexer, provided as alternate syntax)
        LogString($"{percentageColumn.ReadCell(10)}");
    }
}
