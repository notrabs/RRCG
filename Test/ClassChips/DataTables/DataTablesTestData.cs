using RRCG;
using System.Collections.Generic;

//
// SOURCE DECLARATIONS
//
namespace RRCGSource
{
    public static class DataTablesTestData
    {
        // In the source realm, this method has no implementation.
        // It exists only as a declaration for your circuit descriptor to access.
        public static IEnumerable<(int, float, string)> GetThreeColumnData(int numRows) => default!;
    }
}

//
// BUILD DEFINITIONS
//
namespace RRCGBuild
{
    public static class DataTablesTestData
    {
        // In the build realm, however, an implementation is required.
        //
        // Remember -- all source-realm RRCG code is transpiled to build-realm code before execution.
        // So this would be where we calculate the values for our data table.
        //
        // Of course, now that we're in the build realm, we have to use the Port types.
        // Notice how the signature has changed from IEnumerable<(int, float, string)>.
        public static IEnumerable<(IntPort, FloatPort, StringPort)> GetThreeColumnData(IntPort numRows)
        {
            // This code does not get translated by the compiler. It is manually written build code.
            // So this for loop is, in-fact, a real for loop that is evaluated when building the Context.
            //
            // Note the use of AsData<> here. numRows is now an IntPort, but we expect a pure-data value.
            // AsData<> will extract this value for us, but it will throw if the port wasn't a data port.
            //
            // Be sure to check the implementation for each Port type, to know what type the underlying Data field is!

            int numRowsData = numRows.AsData<int>();
            for (int i = 0; i < numRowsData; i++)
            {
                // Because we're in the build realm, we can make use of C# features that RRCG doesn't translate.
                //
                // Here we are dynamically creating the rows for a Data Table. This is very powerful!
                // You could pre-compute information based on objects in your scene, for example.
                //
                // Note that most "primitive" port types support implicit conversions.
                // So for the simple types, you never need to construct them manually.
                // Just ensure the signature is correct!

                yield return (i, i / (float)numRowsData, $"Element {i}");
            }
        }
    }
}