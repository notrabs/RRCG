using RRCGSource;

internal class EventDefintionTest : CircuitDescriptor
{
    public override void CircuitGraph()
    {
        ParamCounts();

        SendTypes();

        Existing();
    }

    void ParamCounts()
    {
        var params0 = new EventDefinition();
        params0.Receiver();
        params0.SendLocal();

        var params1 = new EventDefinition<int>("param0");
        var params1Value = params1.Receiver();
        params1.SendLocal(params1Value);

        var params2 = new EventDefinition<string, bool>("param0", "param1");
        var params2Value = params2.Receiver();
        params2.SendLocal(params2Value.Item1, params2Value.Item2);
    }

    void SendTypes()
    {
        var params0 = new EventDefinition();
        params0.Receiver();
        params0.SendLocal();
        params0.SendOthers();
        params0.SendAll();
        params0.SendAuthority();
        params0.SendRoomAuthority();
        params0.SendPlayer(Player.Local);
        params0.SendPlayer(GetLocalPlayer());
    }

    void Existing()
    {
        var params0 = ExistingEvent("Existing0");
        params0.Receiver();
        params0.SendLocal(); 

        var params1 = ExistingEvent<int>("Existing1");
        var params1Value = params1.Receiver();
        params1.SendLocal(params1Value);

        var params2 = ExistingEvent<int, string>("Existing2");
        var params2Value = params2.Receiver();
        params2.SendLocal(params2Value.Item1, params2Value.Item2);
    }
}

