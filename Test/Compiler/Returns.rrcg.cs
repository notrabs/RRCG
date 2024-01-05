#pragma warning disable CS0162 // Unreachable code detected
using RRCG;
using RRCGSource;
using System;
using System.Collections.Generic;

public class Returns : CircuitDescriptor
{
    public override void CircuitGraph()
    {
        InlineTests();
        CircuitBoardTests();
        EventFunctionTests();
    }

    void InlineTests()
    {
        Test("InlineTests", () =>
        {
            // Test single non-tuple return
            LogString(SingleNonTupleReturn());

            // Test multiple non-tuple returns
            LogString(MultipleNonTupleReturns());

            // Test single tuple return
            var result0 = SingleTupleReturn();
            LogString($"Named: {result0.Named}, Item2: {result0.Item2}");

            // Test multiple tuple returns
            var result1 = MultipleTupleReturns();
            LogString($"Named: {result1.Named}, Item2: {result1.Item2}");

            // Test returns with variable promotions
            LogString(TestIfReturnWithPromoted());

            var list = ChipLib.EventCache(ListCreate("H", "e", "l", "l", "o", " ", "w", "o", "r", "l", "d", "!", "END"));
            LogString(TestWhileReturnWithPromoted(list));

            list[list.Count - 1] = "Not END";
            LogString(TestForEachReturnWithPromoted(list));
        });
    }

    void CircuitBoardTests()
    {
        Test("CircuitBoardTests", () =>
        {
            // Test single non-tuple return
            LogString(CircuitBoard(SingleNonTupleReturn));

            // Test multiple non-tuple returns
            LogString(CircuitBoard(MultipleNonTupleReturns));

            // Test single tuple return
            var result0 = CircuitBoard(SingleTupleReturn);
            LogString($"Named: {result0.Named}, Item2: {result0.Item2}");

            // Test multiple tuple returns
            var result1 = CircuitBoard(MultipleTupleReturns);
            LogString($"Named: {result1.Named}, Item2: {result1.Item2}");

            // Test returns with variable promotions
            LogString(CircuitBoard(TestIfReturnWithPromoted));

            var list = ChipLib.EventCache(ListCreate("H", "e", "l", "l", "o", " ", "w", "o", "r", "l", "d", "!", "END"));
            LogString(CircuitBoard(TestWhileReturnWithPromoted, list));

            list[list.Count - 1] = "Not END";
            LogString(CircuitBoard(TestForEachReturnWithPromoted, list));
        });
    }

    void EventFunctionTests()
    {
        Test("EventFunctionTests", () =>
        {
            // Test single non-tuple return
            LogString(EFSingleNonTupleReturn());

            // Test multiple non-tuple returns
            LogString(EFMultipleNonTupleReturns());

            // Test single tuple return
            var result0 = EFSingleTupleReturn();
            LogString($"Named: {result0.Named}, Item2: {result0.Item2}");

            // Test multiple tuple returns
            var result1 = EFMultipleTupleReturns();
            LogString($"Named: {result1.Named}, Item2: {result1.Item2}");

            // Test returns with variable promotions
            LogString(EFTestIfReturnWithPromoted());

            var list = ChipLib.EventCache(ListCreate("H", "e", "l", "l", "o", " ", "w", "o", "r", "l", "d", "!", "END"));
            LogString(EFTestWhileReturnWithPromoted(list));

            list[list.Count - 1] = "Not END";
            LogString(EFTestForEachReturnWithPromoted(list));
        });
    }

    string SingleNonTupleReturn()
    {
        return "Single Return";
    }

    string MultipleNonTupleReturns()
    {
        if (true)
            return "Return Value 1";
        else
            return "Return Value 2";
    }

    (string Named, int) SingleTupleReturn()
    {
        return ("Named Element", int.MaxValue);
    }

    (string Named, int) MultipleTupleReturns()
    {
        if (true)
            return ("Named 1", 1);
        else
            return ("Named 2", 2);
    }

    string TestIfReturnWithPromoted()
    {
        string promoted = Reroute("Hello");

        if (ParseBool("true").Result)
        {
            promoted += ", world!";
            return promoted;
        }

        return $"Default return: {promoted}";
    }

    string TestWhileReturnWithPromoted(List<string> list)
    {
        string output = "";
        int i = 0;
        while (i < list.Count)
        {
            var character = list[i];
            if (character == "END")
                return output;

            output += character;
            i++;
        }

        return "Failed to find END";
    }

    string TestForEachReturnWithPromoted(List<string> list)
    {
        string output = "";
        foreach (var character in list)
        {
            if (character == "END")
                return output;

            output += character;
        }

        return "Failed to find END";
    }

    [EventFunction]
    string EFSingleNonTupleReturn() => SingleNonTupleReturn();
    [EventFunction]
    string EFMultipleNonTupleReturns() => MultipleNonTupleReturns();
    [EventFunction]
    (string Named, int) EFSingleTupleReturn() => SingleTupleReturn();
    [EventFunction]
    (string Named, int) EFMultipleTupleReturns() => MultipleTupleReturns();
    [EventFunction]
    string EFTestIfReturnWithPromoted() => TestIfReturnWithPromoted();
    [EventFunction]
    string EFTestWhileReturnWithPromoted(List<string> list) => TestWhileReturnWithPromoted(list);
    [EventFunction]
    string EFTestForEachReturnWithPromoted(List<string> list) => TestForEachReturnWithPromoted(list);

    private void Test(string name, Action test)
    {
        new EventDefinition(name).Receiver();
        LogString($"Starting test {name}");

        test();

        LogString($"Finished test {name}");
        throw null;
    }
}
#pragma warning restore CS0162 // Unreachable code detected