using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class TupleUtils
{
    public static dynamic UnwrapTuple(Type tupleType, dynamic[] tupleSource)
    {
        dynamic tuple = Activator.CreateInstance(tupleType);

        switch (tupleSource.Count())
        {
            case 0:
            case 1:
                throw new Exception("tuple must have at least two elements");
            case 2:
                tuple.Item1 = tupleSource[0];
                tuple.Item2 = tupleSource[1];
                return tuple;
            case 3:
                tuple.Item1 = tupleSource[0];
                tuple.Item2 = tupleSource[1];
                tuple.Item3 = tupleSource[2];
                return tuple;
            case 4:
                tuple.Item1 = tupleSource[0];
                tuple.Item2 = tupleSource[1];
                tuple.Item3 = tupleSource[2];
                tuple.Item4 = tupleSource[3];
                return tuple;
            case 5:
                tuple.Item1 = tupleSource[0];
                tuple.Item2 = tupleSource[1];
                tuple.Item3 = tupleSource[2];
                tuple.Item4 = tupleSource[3];
                tuple.Item5 = tupleSource[4];
                return tuple;
            default:
                throw new Exception("UnwrapTuple: length not implemented");
        }
    }
}
