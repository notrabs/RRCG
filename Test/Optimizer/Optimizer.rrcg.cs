using RRCG;
using RRCGSource;

#pragma warning disable CS0162 // Unreachable code detected
public class Optimizer : CircuitDescriptor
{
    public override void CircuitGraph()
    {
        TestNotIfOptimizer();

        TestIfLocalPlayerIsAuthorityOptimizer();
        TestIfLocalPlayerIsRoomAuthorityOptimizer();
        TestIfLocalPlayerShouldRunOptimizer();
        TestIfPlayerHasRoleOptimizer();
        TestIfPlayerIsLocalOptimizer();
        TestIfPlayerIsValidOptimizer();

        TestKnownSingletonChipsOptimizer();

        TestVariableCollapseOptimizer();

        TestAssociativeOperationCollapseOptimizer();
    }

    void TestNotIfOptimizer()
    {
        new EventDefinition("TestNotIfOptimizer").Receiver();

        var optimizableBool = ParseBool("true").Result;

        if (true) LogString("true");
        else LogString("false");

        if (!true) LogString("true");
        else LogString("false");

        if (Not(true)) LogString("true");
        else LogString("false");

        var optimizableButNotDeletable = !ParseBool("true").Result;

        if (optimizableButNotDeletable) LogString("true");
        else LogString("false");

        ChipLib.Log(optimizableButNotDeletable);

        if (optimizableBool) LogString("true");
        else LogString("false");

        if (!optimizableBool) LogString("true");
        else LogString("false");

        if (ParseInt("1").Result == 1) LogString("true");
        else LogString("false");

        if (ParseInt("1").Result != 1) LogString("true");
        else LogString("false");

        // Test single branches
        if (true) LogString("true");
        if (!true) LogString("true");

        // Test chains of nots
        if (!!true) LogString("true");
        if (!!!true) LogString("true");
        if (!!!!true) LogString("true");

        if (Not(Not(true))) LogString("true");
        if (Not(Not(Not(true)))) LogString("true");
        if (Not(Not(Not(Not(true))))) LogString("true");

        throw null;
    }

    void TestIfLocalPlayerIsAuthorityOptimizer()
    {
        new EventDefinition("TestIfLocalPlayerIsAuthorityOptimizer").Receiver();

        if (GetAuthority() == Player.Local) LogString("true");
        else LogString("false");

        if (Player.Local == GetAuthority()) LogString("true");
        else LogString("false");

        if (GetAuthority() == GetLocalPlayer()) LogString("true");
        else LogString("false");

        if (GetLocalPlayer() == GetAuthority()) LogString("true");
        else LogString("false");

        // Test negation
        if (GetAuthority() != Player.Local) LogString("true");
        else LogString("false");

        if (Player.Local != GetAuthority()) LogString("true");
        else LogString("false");

        if (GetAuthority() != GetLocalPlayer()) LogString("true");
        else LogString("false");

        if (GetLocalPlayer() != GetAuthority()) LogString("true");
        else LogString("false");

        // Test only one branch
        if (GetAuthority() == Player.Local) LogString("true");
        if (GetAuthority() != Player.Local) LogString("true");
    }

    void TestIfLocalPlayerIsRoomAuthorityOptimizer()
    {
        new EventDefinition("TestIfLocalPlayerIsRoomAuthorityOptimizer").Receiver();

        if (GetRoomAuthority() == Player.Local) LogString("true");
        else LogString("false");

        if (Player.Local == GetRoomAuthority()) LogString("true");
        else LogString("false");

        if (GetRoomAuthority() == GetLocalPlayer()) LogString("true");
        else LogString("false");

        if (GetLocalPlayer() == GetRoomAuthority()) LogString("true");
        else LogString("false");

        // Test negation
        if (GetRoomAuthority() != Player.Local) LogString("true");
        else LogString("false");

        if (Player.Local != GetRoomAuthority()) LogString("true");
        else LogString("false");

        if (GetRoomAuthority() != GetLocalPlayer()) LogString("true");
        else LogString("false");

        if (GetLocalPlayer() != GetRoomAuthority()) LogString("true");
        else LogString("false");

        // Test only one branch
        if (GetRoomAuthority() == Player.Local) LogString("true");
        if (GetRoomAuthority() != Player.Local) LogString("true");
    }

    void TestIfLocalPlayerShouldRunOptimizer()
    {
        new EventDefinition("TestIfLocalPlayerShouldRunOptimizer").Receiver();

        var player = GetLocalPlayer();

        if (player.IsValid ? player.IsLocal : GetAuthority() == player) LogString("true");
        else LogString("false");

        var nonLocalPlayer = PlayerGetFirstWithTag("tag");

        if (nonLocalPlayer.IsValid ? nonLocalPlayer.IsLocal : GetAuthority() == nonLocalPlayer) LogString("true");
        else LogString("false");

        // Test only one branch
        if (nonLocalPlayer.IsValid ? nonLocalPlayer.IsLocal : GetAuthority() == nonLocalPlayer) LogString("true");

        // Test with a wrong player in comparison
        if (GetLocalPlayer().IsValid ? nonLocalPlayer.IsLocal : GetAuthority() == nonLocalPlayer) LogString("true");
        if (nonLocalPlayer.IsValid ? GetLocalPlayer().IsLocal : GetAuthority() == nonLocalPlayer) LogString("true");
        if (nonLocalPlayer.IsValid ? nonLocalPlayer.IsLocal : GetAuthority() == GetLocalPlayer()) LogString("true");
    }

    void TestIfPlayerHasRoleOptimizer()
    {
        new EventDefinition("TestIfPlayerHasRoleOptimizer").Receiver();

        if (Player.Local.HasRole("testrole")) LogString("true");
        else LogString("false");

        if (GetLocalPlayer().HasRole("testrole")) LogString("true");
        else LogString("false");

        if (PlayerGetFirstWithTag("tag").HasRole("testrole")) LogString("true");
        else LogString("false");

        // Test negation
        if (!Player.Local.HasRole("testrole")) LogString("true");
        else LogString("false");

        // Test only one branch
        if (Player.Local.HasRole("testrole")) LogString("true");

        // non-dangling condition
        var condition = PlayerGetFirstWithTag("tag").HasRole("testrole");
        if (condition) ChipLib.Log(condition);
    }

    void TestIfPlayerIsLocalOptimizer()
    {
        new EventDefinition("TestIfPlayerIsLocalOptimizer").Receiver();

        if (Player.Local.IsLocal) LogString("true");
        else LogString("false");

        if (GetLocalPlayer().IsLocal) LogString("true");
        else LogString("false");

        if (PlayerGetFirstWithTag("tag").IsLocal) LogString("true");
        else LogString("false");

        // Test negation
        if (!Player.Local.IsLocal) LogString("true");
        else LogString("false");

        // Test only one branch
        if (Player.Local.IsLocal) LogString("true");

        // non-dangling condition
        var condition = PlayerGetFirstWithTag("tag").IsLocal;
        if (condition) ChipLib.Log(condition);
    }

    void TestIfPlayerIsValidOptimizer()
    {
        new EventDefinition("TestIfPlayerIsValidOptimizer").Receiver();

        // This would technically not work in game, but there is no reason to not optimize it
        if (Player.Local.IsValid) LogString("true");
        else LogString("false");

        if (GetLocalPlayer().IsLocal) LogString("true");
        else LogString("false");

        if (PlayerGetFirstWithTag("tag").IsLocal) LogString("true");
        else LogString("false");

        // Test only one branch
        if (Player.Local.IsLocal) LogString("true");
    }

    void TestKnownSingletonChipsOptimizer()
    {
        new EventDefinition("TestKnownSingletonChipsOptimizer").Receiver();

        var floatVar = new Variable<float>();

        // All these Time Get Precise Seconds nodes
        // will be collapsed into a single node.
        floatVar.Value = TimeGetPreciseSeconds();
        floatVar.Value = TimeGetPreciseSeconds();
        floatVar.Value = TimeGetPreciseSeconds();
        floatVar.Value = TimeGetPreciseSeconds();
        floatVar.Value = TimeGetPreciseSeconds();
        floatVar.Value = TimeGetPreciseSeconds();

        throw null;
    }

    void TestVariableCollapseOptimizer()
    {
        new EventDefinition("TestVariableCollapseOptimiser").Receiver();

        var var0 = new Variable<float>();
        var var1 = new Variable<float>();
        var var2 = new Variable<float>();
        var var3 = new Variable<float>();

        // All read-only instances of each
        // variable will be collapsed into
        // the "writing" instance.
        var0.Value = RandomFloat(0, 100);
        ChipLib.Log(var0.Value);

        var1.Value = RandomFloat(0, 100);
        ChipLib.Log(var1.Value);

        var2.Value = RandomFloat(0, 100);
        ChipLib.Log(var2.Value);

        var3.Value = RandomFloat(0, 100);
        ChipLib.Log(var3.Value);

        throw null;
    }

    void TestAssociativeOperationCollapseOptimizer()
    {
        new EventDefinition("TestAssociativeOperationCollapseOptimizer").Receiver();

        // Addition
        var variable = new Variable<float>();
        variable.Value = variable.Value + 2f + 3f + 4f + 5f + 6f * 7f * 8f * 9f * 10f;

        float undeletableAdd = variable.Value + 5f;
        float collapsible = undeletableAdd + 1f + 2f + 3f + 4f;
        ChipLib.Log(undeletableAdd); // Log directly to make it undeletable
        ChipLib.Log(collapsible);

        // String concatenation
        var spacePort = Reroute<string>(" ");
        ChipLib.Log("Hello" + spacePort + "World");

        var undeletableConcat = "Undeletable" + spacePort + "concat";
        ChipLib.Log(undeletableConcat); // Log directly to make it undeletable
        ChipLib.Log("Here's the undeletable concat: " + undeletableConcat);

        // Subtraction
        var undeletableSubtract = ChipLib.FloatConst(50f) - ChipLib.FloatConst(10f) - (ChipLib.FloatConst(5f) - ChipLib.FloatConst(3f));
        ChipLib.Log(undeletableSubtract); // Log to make it undeletable

        ChipLib.Log(undeletableSubtract - 5f);

        // Division
        var undeletableDivide = ChipLib.FloatConst(50f) / ChipLib.FloatConst(0.2f) / (ChipLib.FloatConst(0.4f) / ChipLib.FloatConst(0.8f));
        ChipLib.Log(undeletableDivide); // Log to make it undeletable

        ChipLib.Log(undeletableDivide / 5f);
        throw null;
    }
}
#pragma warning restore CS0162 // Unreachable code detected
