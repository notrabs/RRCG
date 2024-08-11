using RRCGSource;

public class MemberVariables : CircuitDescriptor
{
    // Fields
    [Variable]
    public int FieldVariable = 1000;

    [SyncedVariable]
    public string SyncedFieldVariable = "Home value";

    [CloudVariable("FieldCloudVariable")]
    public bool CloudFieldVariable;

    // Properties
    [Variable]
    public int PropertyVariable { get; private set; } = 2000;

    [SyncedVariable]
    public string SyncedPropertyVariable { get; set; } = "Home value";

    [CloudVariable("PropertyCloudVariable")]
    public bool CloudPropertyVariable { private get; set; }

    // Some invalid member variables..

    // Number of cloud variable arguments must match the number of declared variables
    //[CloudVariable("Too", "Many")]
    //int CloudVariable1;

    //[CloudVariable("Too", "Many")] // Multiple member decls. in a single property decl. do not work, unlike fields!
    //int CloudVariable2 { get; set; }

    //[CloudVariable("Too", "Little")]
    //int CloudVariable3, CloudVariable4, CloudVariable5;

    // Cloud variable arguments must be unique
    //[CloudVariable("SameName", "SameName")]
    //int CloudVariable6, CloudVariable7;

    // Properties must be auto-implemented to be member variables
    //[Variable]
    //string PropertyVariable2 => "Constant";

    //[SyncedVariable]
    //string PropertyVariable3
    //{
    //    get => UnderlyingField3;
    //    set
    //    {
    //        UnderlyingField3 = value;
    //    }
    //}
    //string UnderlyingField3 = "Manual";

    // Properties must define a getter and setter to be member variables
    //[Variable]
    //string PropertyVariable4 { get; }

    public override void CircuitGraph()
    {
        RoomEvent.TestEvent();

        // Test assignments..
        FieldVariable = FieldVariable + 1;
        SyncedFieldVariable = SyncedFieldVariable + ", assigned suffix (field)";
        CloudFieldVariable = false;

        PropertyVariable += 1;
        SyncedPropertyVariable += ", assigned suffix (property)";
        CloudPropertyVariable = true;

        // Test reads...
        ChipLib.Log(FieldVariable);
        ChipLib.Log(SyncedFieldVariable);
        ChipLib.Log(CloudFieldVariable);

        ChipLib.Log(PropertyVariable);
        ChipLib.Log(SyncedPropertyVariable);
        ChipLib.Log(CloudPropertyVariable);

        // Test change events...
        TestChangeEvent("FieldVariable", FieldVariable);
        TestChangeEvent("SyncedFieldVariable", SyncedFieldVariable);
        TestChangeEvent("CloudFieldVariable", CloudFieldVariable);
    }

    void TestChangeEvent<T>(string name, T member)
    {
        MemberVariableChanged(member, (value) =>
        {
            LogString($"Change event fired for member: {name}");
            LogString($"Got value: {value}");
        });
    }
}