using System;

namespace RRCGBuild
{
    public class Delay
    {
        Node delayNode;

        public Delay(FloatPort delay)
        {
            CircuitBuilder.InlineGraph(() => ChipBuilder.Delay(delay, () => { }, () => { }));
            delayNode = Context.lastSpawnedNode;
        }

        bool hasRunBeenCalled = false;
        bool hasAwaitBeenCalled = false;
        bool hasCancelBeenCalled = false;

        public Delay Run()
        {
            var execOut = hasRunBeenCalled ? null : delayNode.Port(0, 0);
            ExecFlow.current.Advance(Context.current, delayNode.Port(0, 0), execOut);
            hasRunBeenCalled = true;
            return this;
        }

        public Delay Await()
        {
            if (hasAwaitBeenCalled) throw new Exception("Await can only be called once");
            ExecFlow.current.Advance(Context.current, null, delayNode.Port(0, 1));
            hasAwaitBeenCalled = true;
            return this;
        }

        public Delay Cancel()
        {
            var execOut = hasCancelBeenCalled ? null : delayNode.Port(0, 2);
            ExecFlow.current.Advance(Context.current, delayNode.Port(0, 2), execOut);
            hasCancelBeenCalled = true;
            return this;
        }
    }
}
