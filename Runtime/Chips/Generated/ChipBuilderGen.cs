using System.Collections.Generic;
using UnityEngine;
using RRCGBuild;
using RRCG;

namespace RRCGGenerated
{
    public class ChipBuilderGen
    {
        public static FloatPort AbsoluteValue(FloatPort value)
        {
            Node node = new Node()
            {Name = "Absolute Value", Type = "98b99011-9be8-43b3-89cc-1e9d55bd8b51", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort AbsoluteValue(IntPort value)
        {
            Node node = new Node()
            {Name = "Absolute Value", Type = "98b99011-9be8-43b3-89cc-1e9d55bd8b51", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Acos(FloatPort value)
        {
            Node node = new Node()
            {Name = "Acos", Type = "46ce50b8-0a20-43d2-9646-484ce2a6752c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static IntPort Add(IntPort value)
        {
            Node node = new Node()
            {Name = "Add", Type = "0ccb153c-dd08-4f22-80fd-9d8c5940928c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static FloatPort Add(FloatPort value)
        {
            Node node = new Node()
            {Name = "Add", Type = "0ccb153c-dd08-4f22-80fd-9d8c5940928c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static Vector3Port Add(Vector3Port value)
        {
            Node node = new Node()
            {Name = "Add", Type = "0ccb153c-dd08-4f22-80fd-9d8c5940928c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void AddTag(PlayerPort target, StringPort tag)
        {
            Node node = new Node()
            {Name = "Add Tag", Type = "953fb21b-c9f0-46fc-a0f1-ee1a937854f8", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(tag, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AddTag(RecRoomObjectPort target, StringPort tag)
        {
            Node node = new Node()
            {Name = "Add Tag", Type = "953fb21b-c9f0-46fc-a0f1-ee1a937854f8", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(tag, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AddTags(PlayerPort target, ListPort<StringPort> tags)
        {
            Node node = new Node()
            {Name = "Add Tags", Type = "81939b0e-428f-481c-9fba-453b4c84f01e", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(tags, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AddTags(RecRoomObjectPort target, ListPort<StringPort> tags)
        {
            Node node = new Node()
            {Name = "Add Tags", Type = "81939b0e-428f-481c-9fba-453b4c84f01e", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(tags, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static (StringPort VisionType, FloatPort VisionRange, FloatPort VisionConeAngle, FloatPort HearingRange) AIGetLineOfSightParametersR1(AIPort aI)
        {
            Node node = new Node()
            {Name = "AI Get Line of Sight Parameters", Type = "3edc785f-46ef-4f30-b101-a07126d3a370", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 0});
            var output_ports = (new StringPort{Port = new Port{Node = node, Index = 0}}, new FloatPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}}, new FloatPort{Port = new Port{Node = node, Index = 3}});
            return output_ports;
        }

        public static CombatantPort AIGetTargetR1(AIPort aI)
        {
            Node node = new Node()
            {Name = "AI Get Target", Type = "1637b250-e497-4f4a-9d5e-64206488391c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 0});
            var output_ports = new CombatantPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort AIHasLineOfSightToTargetR1(AIPort aI, AIPort target)
        {
            Node node = new Node()
            {Name = "AI Has Line of Sight To Target", Type = "5858a52e-54fb-4bb2-80a0-ec5fce88b3ef", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 0});
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort AIHasLineOfSightToTargetR1(AIPort aI, CombatantPort target)
        {
            Node node = new Node()
            {Name = "AI Has Line of Sight To Target", Type = "5858a52e-54fb-4bb2-80a0-ec5fce88b3ef", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 0});
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort AIHasLineOfSightToTargetR1(AIPort aI, RecRoomObjectPort target)
        {
            Node node = new Node()
            {Name = "AI Has Line of Sight To Target", Type = "5858a52e-54fb-4bb2-80a0-ec5fce88b3ef", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 0});
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort AIHasLineOfSightToTargetR1(AIPort aI, PatrolPointPort target)
        {
            Node node = new Node()
            {Name = "AI Has Line of Sight To Target", Type = "5858a52e-54fb-4bb2-80a0-ec5fce88b3ef", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 0});
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort AIHasLineOfSightToTargetR1(AIPort aI, PlayerPort target)
        {
            Node node = new Node()
            {Name = "AI Has Line of Sight To Target", Type = "5858a52e-54fb-4bb2-80a0-ec5fce88b3ef", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 0});
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort AIHasLineOfSightToTargetR1(AIPort aI, Vector3Port target)
        {
            Node node = new Node()
            {Name = "AI Has Line of Sight To Target", Type = "5858a52e-54fb-4bb2-80a0-ec5fce88b3ef", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 0});
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void AILookAtR1(AIPort aI, AIPort lookTarget, BoolPort lookTargetIsDirection)
        {
            Node node = new Node()
            {Name = "AI Look At", Type = "b5badf49-acfe-4a42-80e2-5262878e2d89", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(lookTarget, new Port{Node = node, Index = 2});
            node.ConnectInputPort(lookTargetIsDirection, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AILookAtR1(AIPort aI, CombatantPort lookTarget, BoolPort lookTargetIsDirection)
        {
            Node node = new Node()
            {Name = "AI Look At", Type = "b5badf49-acfe-4a42-80e2-5262878e2d89", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(lookTarget, new Port{Node = node, Index = 2});
            node.ConnectInputPort(lookTargetIsDirection, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AILookAtR1(AIPort aI, RecRoomObjectPort lookTarget, BoolPort lookTargetIsDirection)
        {
            Node node = new Node()
            {Name = "AI Look At", Type = "b5badf49-acfe-4a42-80e2-5262878e2d89", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(lookTarget, new Port{Node = node, Index = 2});
            node.ConnectInputPort(lookTargetIsDirection, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AILookAtR1(AIPort aI, PatrolPointPort lookTarget, BoolPort lookTargetIsDirection)
        {
            Node node = new Node()
            {Name = "AI Look At", Type = "b5badf49-acfe-4a42-80e2-5262878e2d89", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(lookTarget, new Port{Node = node, Index = 2});
            node.ConnectInputPort(lookTargetIsDirection, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AILookAtR1(AIPort aI, PlayerPort lookTarget, BoolPort lookTargetIsDirection)
        {
            Node node = new Node()
            {Name = "AI Look At", Type = "b5badf49-acfe-4a42-80e2-5262878e2d89", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(lookTarget, new Port{Node = node, Index = 2});
            node.ConnectInputPort(lookTargetIsDirection, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AILookAtR1(AIPort aI, Vector3Port lookTarget, BoolPort lookTargetIsDirection)
        {
            Node node = new Node()
            {Name = "AI Look At", Type = "b5badf49-acfe-4a42-80e2-5262878e2d89", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(lookTarget, new Port{Node = node, Index = 2});
            node.ConnectInputPort(lookTargetIsDirection, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIPathToR1(AIPort aI, AIPort target)
        {
            Node node = new Node()
            {Name = "AI Path To", Type = "7b05df01-d4c8-490c-9442-55aa3b4975fa", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(target, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIPathToR1(AIPort aI, CombatantPort target)
        {
            Node node = new Node()
            {Name = "AI Path To", Type = "7b05df01-d4c8-490c-9442-55aa3b4975fa", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(target, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIPathToR1(AIPort aI, RecRoomObjectPort target)
        {
            Node node = new Node()
            {Name = "AI Path To", Type = "7b05df01-d4c8-490c-9442-55aa3b4975fa", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(target, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIPathToR1(AIPort aI, PatrolPointPort target)
        {
            Node node = new Node()
            {Name = "AI Path To", Type = "7b05df01-d4c8-490c-9442-55aa3b4975fa", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(target, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIPathToR1(AIPort aI, PlayerPort target)
        {
            Node node = new Node()
            {Name = "AI Path To", Type = "7b05df01-d4c8-490c-9442-55aa3b4975fa", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(target, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIPathToR1(AIPort aI, Vector3Port target)
        {
            Node node = new Node()
            {Name = "AI Path To", Type = "7b05df01-d4c8-490c-9442-55aa3b4975fa", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(target, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIRotateR1(AIPort aI, FloatPort rotation)
        {
            Node node = new Node()
            {Name = "AI Rotate", Type = "c2cb2ea2-f663-4aa6-9394-3b741f6b9064", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIRotateR1(AIPort aI, IntPort rotation)
        {
            Node node = new Node()
            {Name = "AI Rotate", Type = "c2cb2ea2-f663-4aa6-9394-3b741f6b9064", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIRotateR1(AIPort aI, Vector3Port rotation)
        {
            Node node = new Node()
            {Name = "AI Rotate", Type = "c2cb2ea2-f663-4aa6-9394-3b741f6b9064", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AISetLineOfSightParametersR1(AIPort aI, StringPort visionType, FloatPort visionRange, FloatPort visionConeAngle, FloatPort hearingRange, BoolPort requireLoSForTargeting)
        {
            Node node = new Node()
            {Name = "AI Set Line of Sight Parameters", Type = "02557d1f-2265-4b6d-8177-92f1802dc106", InputCount = 7};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(visionType, new Port{Node = node, Index = 2});
            node.ConnectInputPort(visionRange, new Port{Node = node, Index = 3});
            node.ConnectInputPort(visionConeAngle, new Port{Node = node, Index = 4});
            node.ConnectInputPort(hearingRange, new Port{Node = node, Index = 5});
            node.ConnectInputPort(requireLoSForTargeting, new Port{Node = node, Index = 6});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AISetPathingSpeedR1(AIPort aI, FloatPort speed)
        {
            Node node = new Node()
            {Name = "AI Set Pathing Speed", Type = "cd85a0c7-789b-41a2-aeda-40925b73738c", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(speed, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AISetPatrolPointR1(AIPort aI, PatrolPointPort patrolPoint)
        {
            Node node = new Node()
            {Name = "AI Set Patrol Point", Type = "6370b8d9-8c72-4e6b-a623-acb7202a3110", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(patrolPoint, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AISetTargetR1(AIPort aI, CombatantPort target)
        {
            Node node = new Node()
            {Name = "AI Set Target", Type = "73652899-2656-4aa4-a1b0-4de8d8e56095", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 1});
            node.ConnectInputPort(target, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIStartCombatBehaviorR1(AIPort aI)
        {
            Node node = new Node()
            {Name = "AI Start Combat Behavior", Type = "b169c26e-3c2c-4058-bae7-dbbc3ee856a4", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIStopCombatBehaviorR1(AIPort aI)
        {
            Node node = new Node()
            {Name = "AI Stop Combat Behavior", Type = "6e244bf2-cf71-4baa-912d-3e61c7fcd1be", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AIStopLookingR1(AIPort aI)
        {
            Node node = new Node()
            {Name = "AI Stop Looking", Type = "f211a503-a237-41bc-875e-ae3ef62d745b", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(aI, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static AIPort AIVariableR1(AIPort port1, VariableData config)
        {
            Node node = new Node()
            {Name = "AI Variable", Type = "0e92a7fb-fb38-418c-af39-9afec92112ee", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new AIPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static AudioPort AmbienceConstant()
        {
            Node node = new Node()
            {Name = "Ambience Constant", Type = "1ad615de-65ea-40a3-b500-3a5b56b2a65d", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new AudioPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static BoolPort And(BoolPort input)
        {
            Node node = new Node()
            {Name = "And", Type = "3fb9fd93-8d45-4395-b9a3-63a99a14442b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(input, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort AngularVelocityAdd(RecRoomObjectPort target, Vector3Port angularVelocity, FloatPort speedMultiplier, FloatPort maxAngularSpeed)
        {
            Node node = new Node()
            {Name = "Angular Velocity Add", Type = "956ccd66-4406-42a3-b08c-78d3efdd5fec", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(angularVelocity, new Port{Node = node, Index = 2});
            node.ConnectInputPort(speedMultiplier, new Port{Node = node, Index = 3});
            node.ConnectInputPort(maxAngularSpeed, new Port{Node = node, Index = 4});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static void AngularVelocityAddDeprecated(RecRoomObjectPort target, Vector3Port rotation, FloatPort velocityMultiplier, FloatPort maxAngularVelocityApplied)
        {
            Node node = new Node()
            {Name = "Angular Velocity Add (Deprecated)", Type = "87f6886f-fa2b-4961-b0ed-c8014aadc56b", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 2});
            node.ConnectInputPort(velocityMultiplier, new Port{Node = node, Index = 3});
            node.ConnectInputPort(maxAngularVelocityApplied, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AngularVelocityAddDeprecated(RecRoomObjectPort target, QuaternionPort rotation, FloatPort velocityMultiplier, FloatPort maxAngularVelocityApplied)
        {
            Node node = new Node()
            {Name = "Angular Velocity Add (Deprecated)", Type = "87f6886f-fa2b-4961-b0ed-c8014aadc56b", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 2});
            node.ConnectInputPort(velocityMultiplier, new Port{Node = node, Index = 3});
            node.ConnectInputPort(maxAngularVelocityApplied, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort AngularVelocitySet(RecRoomObjectPort target, Vector3Port angularVelocity, FloatPort speedMultiplier)
        {
            Node node = new Node()
            {Name = "Angular Velocity Set", Type = "85dbc1d1-759a-4d08-b129-bf9372188348", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(angularVelocity, new Port{Node = node, Index = 2});
            node.ConnectInputPort(speedMultiplier, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static void AngularVelocitySetDeprecated(RecRoomObjectPort target, Vector3Port rotation, FloatPort velocityMultiplier)
        {
            Node node = new Node()
            {Name = "Angular Velocity Set (Deprecated)", Type = "98b24bc7-32d8-4386-9348-d44ad00d7702", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 2});
            node.ConnectInputPort(velocityMultiplier, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AngularVelocitySetDeprecated(RecRoomObjectPort target, QuaternionPort rotation, FloatPort velocityMultiplier)
        {
            Node node = new Node()
            {Name = "Angular Velocity Set (Deprecated)", Type = "98b24bc7-32d8-4386-9348-d44ad00d7702", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 2});
            node.ConnectInputPort(velocityMultiplier, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static IntPort AnimationGetFrame(AnimationControllerPort animator)
        {
            Node node = new Node()
            {Name = "Animation Get Frame", Type = "5460ad14-4d51-4925-bd27-1ced46f10cb4", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(animator, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort AnimationGetIsPlaying(AnimationControllerPort animator)
        {
            Node node = new Node()
            {Name = "Animation Get Is Playing", Type = "b45a0e10-189e-4211-b152-f04863d36e8c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(animator, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort AnimationGetSpeed(AnimationControllerPort animator)
        {
            Node node = new Node()
            {Name = "Animation Get Speed", Type = "e73794bd-fd60-4284-90ca-f5169700fa23", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(animator, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort AnimationGetTimeStamp(AnimationControllerPort animator)
        {
            Node node = new Node()
            {Name = "Animation Get Time Stamp", Type = "19a1867b-8322-45b5-9971-c91b246663f3", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(animator, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void AnimationPause(AnimationControllerPort animator)
        {
            Node node = new Node()
            {Name = "Animation Pause", Type = "16144990-d5b0-4143-83f2-0df3cd30b3f2", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(animator, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AnimationPlay(AnimationControllerPort animator)
        {
            Node node = new Node()
            {Name = "Animation Play", Type = "c2dc73dd-5317-45bf-892a-46864b468960", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(animator, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AnimationSetFrame(AnimationControllerPort animator, IntPort frameNumber)
        {
            Node node = new Node()
            {Name = "Animation Set Frame", Type = "c7ae96f2-1792-40ab-a367-6cc159f27080", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(animator, new Port{Node = node, Index = 1});
            node.ConnectInputPort(frameNumber, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AnimationSetSpeed(AnimationControllerPort animator, FloatPort speed)
        {
            Node node = new Node()
            {Name = "Animation Set Speed", Type = "ca4d8318-ff8a-4c05-8628-2573d3c0ab4b", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(animator, new Port{Node = node, Index = 1});
            node.ConnectInputPort(speed, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AnimationSetTimeStamp(AnimationControllerPort animator, FloatPort timeStamp)
        {
            Node node = new Node()
            {Name = "Animation Set Time Stamp", Type = "2cee5b7c-d9d1-455d-913c-10441527c798", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(animator, new Port{Node = node, Index = 1});
            node.ConnectInputPort(timeStamp, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AnimationStop(AnimationControllerPort animator)
        {
            Node node = new Node()
            {Name = "Animation Stop", Type = "454c3ee3-5030-4a63-8ae9-1a0c61568f8c", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(animator, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort Asin(FloatPort value)
        {
            Node node = new Node()
            {Name = "Asin", Type = "aaa4e58f-16df-426a-b7a7-a654eab97037", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Atan(FloatPort value)
        {
            Node node = new Node()
            {Name = "Atan", Type = "84646ed2-015e-4a8b-9d37-5115cb9ebadc", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Atan2(FloatPort y, FloatPort x)
        {
            Node node = new Node()
            {Name = "Atan2", Type = "02d62908-550d-4f8b-8bc7-0960fb1b547f", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(y, new Port{Node = node, Index = 0});
            node.ConnectInputPort(x, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort AudioFXZoneGetIntensity(AudioFXZonePort target)
        {
            Node node = new Node()
            {Name = "Audio FX Zone Get Intensity", Type = "26000298-f08f-4600-b100-3ee0076b2b63", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort AudioFXZoneGetPriority(AudioFXZonePort target)
        {
            Node node = new Node()
            {Name = "Audio FX Zone Get Priority", Type = "bbf3d871-ab5d-4405-ab53-aec19cdc6c8a", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void AudioFXZoneSetEffect(AudioFXZonePort target)
        {
            Node node = new Node()
            {Name = "Audio FX Zone Set Effect", Type = "c4fcf47f-84fe-4e4c-865c-3010f67bdea7", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AudioFXZoneSetIntensity(AudioFXZonePort target, FloatPort intensity)
        {
            Node node = new Node()
            {Name = "Audio FX Zone Set Intensity", Type = "7cd9ebf1-d935-4a98-914e-504180537519", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(intensity, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AudioFXZoneSetPriority(AudioFXZonePort target, IntPort priority)
        {
            Node node = new Node()
            {Name = "Audio FX Zone Set Priority", Type = "19605859-538d-4e1d-9d62-b00abb3e294a", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(priority, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort AudioGetLength(AudioPort audio)
        {
            Node node = new Node()
            {Name = "Audio Get Length", Type = "be5262f0-1f67-4be7-aa8c-967c30bd5487", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(audio, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static AudioPort AudioPlayerGetAudio(AudioPlayerPort target)
        {
            Node node = new Node()
            {Name = "Audio Player Get Audio", Type = "0f4433b6-425d-4172-968a-2c867bc0fef5", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new AudioPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort AudioPlayerGetMaxRolloffDistance(AudioPlayerPort target)
        {
            Node node = new Node()
            {Name = "Audio Player Get Max Rolloff Distance", Type = "2db28fb7-0edb-4f09-8d74-ed5614dfaf11", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort AudioPlayerGetPlaying(AudioPlayerPort target)
        {
            Node node = new Node()
            {Name = "Audio Player Get Playing", Type = "00443d01-632e-4f75-ac6f-23b3e224e791", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort AudioPlayerGetSpeed(AudioPlayerPort target)
        {
            Node node = new Node()
            {Name = "Audio Player Get Speed", Type = "931ebb4f-3424-4aa3-bee3-5e039ba210e4", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort AudioPlayerGetTimeStamp(AudioPlayerPort target)
        {
            Node node = new Node()
            {Name = "Audio Player Get Time Stamp", Type = "61e8293d-5d5a-4dbc-9505-0a13faf8b4cc", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort AudioPlayerGetVolume(AudioPlayerPort target)
        {
            Node node = new Node()
            {Name = "Audio Player Get Volume", Type = "1bbabac2-f316-4e07-9eb6-fd65848a5b90", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void AudioPlayerPause(AudioPlayerPort target)
        {
            Node node = new Node()
            {Name = "Audio Player Pause", Type = "e6391f35-dd8b-4e99-a0f9-7dc44b6c1893", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AudioPlayerPlay(AudioPlayerPort target, AudioPort audio)
        {
            Node node = new Node()
            {Name = "Audio Player Play", Type = "38f16370-7224-40d0-a551-665bb9fb6f8b", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(audio, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AudioPlayerSetMaxRolloffDistance(AudioPlayerPort target, FloatPort maxRolloffDistance)
        {
            Node node = new Node()
            {Name = "Audio Player Set Max Rolloff Distance", Type = "c8b0ee69-7b27-4805-b809-438b1c59f472", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(maxRolloffDistance, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AudioPlayerSetSpeed(AudioPlayerPort target, FloatPort speed)
        {
            Node node = new Node()
            {Name = "Audio Player Set Speed", Type = "a59e93b4-f949-47b4-af73-fb6e110392fa", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(speed, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AudioPlayerSetTimeStamp(AudioPlayerPort target, FloatPort timeStamp)
        {
            Node node = new Node()
            {Name = "Audio Player Set Time Stamp", Type = "d30959ca-fa17-498b-88da-a83a46c34b97", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(timeStamp, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AudioPlayerSetVolume(AudioPlayerPort target, FloatPort volume)
        {
            Node node = new Node()
            {Name = "Audio Player Set Volume", Type = "cdedf5fe-9d4f-4811-9883-160b04695657", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(volume, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void AudioPlayerStop(AudioPlayerPort target)
        {
            Node node = new Node()
            {Name = "Audio Player Stop", Type = "f6c546cc-becd-44cc-999b-bf2031b5f737", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort AwardConsumableR1(ConsumablePort consumable, PlayerPort player, IntPort quantity, AlternativeExec<BoolPort> onAwardConsumableComplete)
        {
            Node node = new Node()
            {Name = "Award Consumable", Type = "9ceb3e5a-2030-4034-98a4-dc2809828b63", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(consumable, new Port{Node = node, Index = 1});
            node.ConnectInputPort(player, new Port{Node = node, Index = 2});
            node.ConnectInputPort(quantity, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            onAwardConsumableComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static (BoolPort Success, IntPort TotalBalance) AwardCurrencyDeprecatedR1(PlayerPort player, IntPort amount, AlternativeExec<(BoolPort Success, IntPort TotalBalance)> onAwardCurrencyComplete)
        {
            Node node = new Node()
            {Name = "Award Currency", Type = "03461631-734f-491b-ab86-6bdf66947556", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(amount, new Port{Node = node, Index = 2});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 2}}, new IntPort{Port = new Port{Node = node, Index = 3}});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            onAwardCurrencyComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static (BoolPort Success, IntPort TotalBalance) AwardCurrencyR1(RoomCurrencyPort currency, PlayerPort player, IntPort amount, AlternativeExec<(BoolPort Success, IntPort TotalBalance)> onAwardCurrencyComplete)
        {
            Node node = new Node()
            {Name = "Award Currency", Type = "9ad9cfa5-da73-4bc6-b53e-e2fdc265998f", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(currency, new Port{Node = node, Index = 1});
            node.ConnectInputPort(player, new Port{Node = node, Index = 2});
            node.ConnectInputPort(amount, new Port{Node = node, Index = 3});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 2}}, new IntPort{Port = new Port{Node = node, Index = 3}});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            onAwardCurrencyComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static BoolPort AwardRoomKeyR1(RoomKeyPort roomKey, PlayerPort player, AlternativeExec<BoolPort> onAwardRoomKeyComplete)
        {
            Node node = new Node()
            {Name = "Award Room Key", Type = "7e40f770-c9a4-4233-8845-cac6ec99ae67", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(roomKey, new Port{Node = node, Index = 1});
            node.ConnectInputPort(player, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            onAwardRoomKeyComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static BackgroundObjectsPort BackgroundObjectsConstant()
        {
            Node node = new Node()
            {Name = "Background Objects Constant", Type = "c6e9ffef-b505-41d3-bb2d-ff86838398c6", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new BackgroundObjectsPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort BeaconGetColor(BeaconPort target)
        {
            Node node = new Node()
            {Name = "Beacon Get Color", Type = "5f7cd28c-bafc-409d-8872-f21ccec5f022", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort BeaconGetEnabled(BeaconPort target)
        {
            Node node = new Node()
            {Name = "Beacon Get Enabled", Type = "5646ab78-1388-44de-84a7-8c50f28cc88e", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort BeaconGetHeight(BeaconPort target)
        {
            Node node = new Node()
            {Name = "Beacon Get Height", Type = "dbadcaaa-d673-4e35-bb29-c9c2a5c3d93e", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void BeaconSetColor(BeaconPort target, ColorPort color)
        {
            Node node = new Node()
            {Name = "Beacon Set Color", Type = "6e01d9d9-fd3d-4248-b954-df283ceb1316", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void BeaconSetEnabled(BeaconPort target, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Beacon Set Enabled", Type = "d8a84892-15a7-4069-800d-f77ea4ed6bea", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void BeaconSetHeight(BeaconPort target, FloatPort height)
        {
            Node node = new Node()
            {Name = "Beacon Set Height", Type = "a93f6c3f-232a-470a-9f01-f1b591200ad7", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(height, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static IntPort BitAnd(IntPort port0, IntPort port1)
        {
            Node node = new Node()
            {Name = "Bit And", Type = "28a95bc3-ab08-48ae-b0c0-16b41168bf47", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port0, new Port{Node = node, Index = 0});
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort BitLeadingZeros(IntPort value)
        {
            Node node = new Node()
            {Name = "Bit Leading Zeros", Type = "d6e62624-06b0-416e-8e3c-ca058efd3c46", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort BitNand(IntPort port0, IntPort port1)
        {
            Node node = new Node()
            {Name = "Bit Nand", Type = "05305e33-a809-4751-b928-2c8a5bbc6dc9", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port0, new Port{Node = node, Index = 0});
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort BitNot(IntPort port0)
        {
            Node node = new Node()
            {Name = "Bit Not", Type = "ec74ea41-24e5-491c-8919-a502638583f9", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(port0, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort BitOr(IntPort port0, IntPort port1)
        {
            Node node = new Node()
            {Name = "Bit Or", Type = "2c24bc11-9543-4738-8c6c-0c5e3fadd944", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port0, new Port{Node = node, Index = 0});
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort BitPopCount(IntPort value)
        {
            Node node = new Node()
            {Name = "Bit Pop Count", Type = "6982e235-5814-4c5a-8bc8-fdbcc9a73eb8", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort BitRotateLeft(IntPort value, IntPort shift)
        {
            Node node = new Node()
            {Name = "Bit Rotate Left", Type = "bd013fe7-3799-46b5-b1f3-66a3f5add5ed", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            node.ConnectInputPort(shift, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort BitRotateRight(IntPort value, IntPort shift)
        {
            Node node = new Node()
            {Name = "Bit Rotate Right", Type = "b5f36fdf-0a2e-489a-bbdf-f17c50974cc1", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            node.ConnectInputPort(shift, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort BitShiftLeft(IntPort value, IntPort shift)
        {
            Node node = new Node()
            {Name = "Bit Shift Left", Type = "0a7b4058-b1da-442f-8341-81df66979663", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            node.ConnectInputPort(shift, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort BitShiftRight(IntPort value, IntPort shift)
        {
            Node node = new Node()
            {Name = "Bit Shift Right", Type = "4024b483-ab3d-4fa0-b399-b3350b800081", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            node.ConnectInputPort(shift, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort BitTrailingZeros(IntPort value)
        {
            Node node = new Node()
            {Name = "Bit Trailing Zeros", Type = "773d361e-3761-497b-9dec-b5e5313a5a2c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort BitXor(IntPort port0, IntPort port1)
        {
            Node node = new Node()
            {Name = "Bit Xor", Type = "a3899394-1ed9-4d41-a836-22fffaf4e90d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port0, new Port{Node = node, Index = 0});
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort BoolVariable(BoolPort port1, VariableData config)
        {
            Node node = new Node()
            {Name = "bool Variable", Type = "80955588-7f7a-4f7c-b46f-6d1e9057fba0", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static (T0 Item1, T1 Item2) BreakTuple<T0, T1>(RRTuplePort<T0, T1> tuple)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Break Tuple", Type = "9478334a-451d-4802-bab1-4b05f00d45e4", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(tuple, new Port{Node = node, Index = 0});
            var output_ports = (new T0{Port = new Port{Node = node, Index = 0}}, new T1{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static BoolPort ButtonGetIsPressed(ButtonPort target)
        {
            Node node = new Node()
            {Name = "Button Get Is Pressed", Type = "fe32ba92-9018-4575-92e2-3b0d82c9419b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort ButtonGetText(ButtonPort target)
        {
            Node node = new Node()
            {Name = "Button Get Text", Type = "70e7663d-a5fd-435d-8995-942b4babc262", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void ButtonSetText(ButtonPort target, StringPort text)
        {
            Node node = new Node()
            {Name = "Button Set Text", Type = "21bbaa09-6bcf-435c-86da-e853a78bc27b", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(text, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort Ceil(FloatPort value)
        {
            Node node = new Node()
            {Name = "Ceil", Type = "f4cbc476-bc98-4cbf-bf47-de4baedddf79", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort CeilToInt(FloatPort value)
        {
            Node node = new Node()
            {Name = "Ceil to Int", Type = "38b502dc-dd35-4083-a2b0-8a8e5f69a958", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void CircuitBoard()
        {
            Node node = new Node()
            {Name = "Circuit Board", Type = "14ebde7a-76c0-47df-b0dd-01b1daa50821", InputCount = 0};
            Context.current.AddNode(node);
            return;
        }

        public static FloatPort Clamp(FloatPort value, FloatPort min, FloatPort max)
        {
            Node node = new Node()
            {Name = "Clamp", Type = "f95735f1-1db8-4bf4-8198-03b2595fa741", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            node.ConnectInputPort(min, new Port{Node = node, Index = 1});
            node.ConnectInputPort(max, new Port{Node = node, Index = 2});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort Clamp(IntPort value, IntPort min, IntPort max)
        {
            Node node = new Node()
            {Name = "Clamp", Type = "f95735f1-1db8-4bf4-8198-03b2595fa741", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            node.ConnectInputPort(min, new Port{Node = node, Index = 1});
            node.ConnectInputPort(max, new Port{Node = node, Index = 2});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void ClearPlayerVignette(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Clear Player Vignette", Type = "161bdcc8-4156-4c8f-9792-2a1285b97e68", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ClearPlayerWorldUI(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Clear Player World UI", Type = "c25487e3-657a-4ee8-b766-c2a1b10ec481", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ClearScreen(TextScreenPort target)
        {
            Node node = new Node()
            {Name = "Clear Screen", Type = "142438cd-1bd2-4df2-b2fa-c93aaf99f771", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort CollisionDataGetDistance(CollisionDataPort target)
        {
            Node node = new Node()
            {Name = "Collision Data Get Distance", Type = "c3fc963c-6d73-4d88-9c9b-95e9faae219f", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port CollisionDataGetNormal(CollisionDataPort target)
        {
            Node node = new Node()
            {Name = "Collision Data Get Normal", Type = "ced470f8-dd9d-4e67-a654-7c7e1a3e7819", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static RecRoomObjectPort CollisionDataGetObject(CollisionDataPort target)
        {
            Node node = new Node()
            {Name = "Collision Data Get Object", Type = "8c8931da-1a8e-4164-a3a5-0f68db8cafb5", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort CollisionDataGetPlayer(CollisionDataPort target)
        {
            Node node = new Node()
            {Name = "Collision Data Get Player", Type = "2729e8db-62d1-4f9e-b076-74f27cd43332", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port CollisionDataGetPosition(CollisionDataPort target)
        {
            Node node = new Node()
            {Name = "Collision Data Get Position", Type = "5910618b-f862-49ce-9779-46130e47f985", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort CollisionDetectionVolumeGetEnabled(CollisionDetectionVolumePort target)
        {
            Node node = new Node()
            {Name = "Collision Detection Volume Get Enabled", Type = "9b5e9c57-babc-4e7a-a728-97bef7a11cfc", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void CollisionDetectionVolumeSetEnabled(CollisionDetectionVolumePort target, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Collision Detection Volume Set Enabled", Type = "711cadd1-24b0-4969-9fba-f65cbaeab3c5", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static ColorPort ColorConstant()
        {
            Node node = new Node()
            {Name = "Color Constant", Type = "87a8e178-b15c-4c38-9da0-95ba74f9f4ec", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (FloatPort Hue, FloatPort Saturation, FloatPort Value) ColorToHSV(ColorPort color)
        {
            Node node = new Node()
            {Name = "Color To HSV", Type = "d697171e-56ac-41b7-aa1e-dabc4538c029", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(color, new Port{Node = node, Index = 0});
            var output_ports = (new FloatPort{Port = new Port{Node = node, Index = 0}}, new FloatPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static IntPort ColorToIntDeprecated(ColorPort color)
        {
            Node node = new Node()
            {Name = "Color To Int", Type = "8e412141-635d-435c-a900-f40d8a261906", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(color, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (FloatPort Red, FloatPort Green, FloatPort Blue) ColorToRGB(ColorPort color)
        {
            Node node = new Node()
            {Name = "Color To RGB", Type = "52565e5d-73d1-4f29-bca7-0c8ae9afcc57", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(color, new Port{Node = node, Index = 0});
            var output_ports = (new FloatPort{Port = new Port{Node = node, Index = 0}}, new FloatPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static ColorPort ColorVariable(ColorPort port1, VariableData config)
        {
            Node node = new Node()
            {Name = "Color Variable", Type = "3d2fd0b5-eeac-45cc-a622-1701710f0792", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static Vector3Port CombatantGetGroundPositionR1(AIPort combatant)
        {
            Node node = new Node()
            {Name = "Combatant Get Ground Position", Type = "c0ee02f4-bbab-40ea-88a0-7441d7e7094c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(combatant, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port CombatantGetGroundPositionR1(CombatantPort combatant)
        {
            Node node = new Node()
            {Name = "Combatant Get Ground Position", Type = "c0ee02f4-bbab-40ea-88a0-7441d7e7094c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(combatant, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port CombatantGetGroundPositionR1(PlayerPort combatant)
        {
            Node node = new Node()
            {Name = "Combatant Get Ground Position", Type = "c0ee02f4-bbab-40ea-88a0-7441d7e7094c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(combatant, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (IntPort Health, IntPort Shield, IntPort MaxHealth) CombatantGetHealthR1(AIPort @object)
        {
            Node node = new Node()
            {Name = "Combatant Get Health", Type = "3967a8ad-4237-4ae7-8cbf-850d8e24fe30", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(@object, new Port{Node = node, Index = 0});
            var output_ports = (new IntPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new IntPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (IntPort Health, IntPort Shield, IntPort MaxHealth) CombatantGetHealthR1(CombatantPort @object)
        {
            Node node = new Node()
            {Name = "Combatant Get Health", Type = "3967a8ad-4237-4ae7-8cbf-850d8e24fe30", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(@object, new Port{Node = node, Index = 0});
            var output_ports = (new IntPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new IntPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (IntPort Health, IntPort Shield, IntPort MaxHealth) CombatantGetHealthR1(PlayerPort @object)
        {
            Node node = new Node()
            {Name = "Combatant Get Health", Type = "3967a8ad-4237-4ae7-8cbf-850d8e24fe30", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(@object, new Port{Node = node, Index = 0});
            var output_ports = (new IntPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new IntPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static BoolPort CombatantGetIsAliveR1(AIPort @object)
        {
            Node node = new Node()
            {Name = "Combatant Get Is Alive", Type = "2a12c389-c3c6-4484-8c63-21cdaf0fac6c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(@object, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort CombatantGetIsAliveR1(CombatantPort @object)
        {
            Node node = new Node()
            {Name = "Combatant Get Is Alive", Type = "2a12c389-c3c6-4484-8c63-21cdaf0fac6c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(@object, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort CombatantGetIsAliveR1(PlayerPort @object)
        {
            Node node = new Node()
            {Name = "Combatant Get Is Alive", Type = "2a12c389-c3c6-4484-8c63-21cdaf0fac6c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(@object, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (Vector3Port Velocity, FloatPort Speed) CombatantGetVelocityR1(AIPort combatant)
        {
            Node node = new Node()
            {Name = "Combatant Get Velocity", Type = "b4eadbfa-cdbe-42e6-9481-5197de58e272", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(combatant, new Port{Node = node, Index = 0});
            var output_ports = (new Vector3Port{Port = new Port{Node = node, Index = 0}}, new FloatPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static (Vector3Port Velocity, FloatPort Speed) CombatantGetVelocityR1(CombatantPort combatant)
        {
            Node node = new Node()
            {Name = "Combatant Get Velocity", Type = "b4eadbfa-cdbe-42e6-9481-5197de58e272", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(combatant, new Port{Node = node, Index = 0});
            var output_ports = (new Vector3Port{Port = new Port{Node = node, Index = 0}}, new FloatPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static (Vector3Port Velocity, FloatPort Speed) CombatantGetVelocityR1(PlayerPort combatant)
        {
            Node node = new Node()
            {Name = "Combatant Get Velocity", Type = "b4eadbfa-cdbe-42e6-9481-5197de58e272", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(combatant, new Port{Node = node, Index = 0});
            var output_ports = (new Vector3Port{Port = new Port{Node = node, Index = 0}}, new FloatPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static void CombatantReceiveDamageR1(AIPort target, IntPort damage, BoolPort ignoreShield, AIPort damageSource)
        {
            Node node = new Node()
            {Name = "Combatant Receive Damage", Type = "67aca89c-f753-4f94-87df-1ce1d4fcb8b0", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(damage, new Port{Node = node, Index = 2});
            node.ConnectInputPort(ignoreShield, new Port{Node = node, Index = 3});
            node.ConnectInputPort(damageSource, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantReceiveDamageR1(AIPort target, IntPort damage, BoolPort ignoreShield, CombatantPort damageSource)
        {
            Node node = new Node()
            {Name = "Combatant Receive Damage", Type = "67aca89c-f753-4f94-87df-1ce1d4fcb8b0", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(damage, new Port{Node = node, Index = 2});
            node.ConnectInputPort(ignoreShield, new Port{Node = node, Index = 3});
            node.ConnectInputPort(damageSource, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantReceiveDamageR1(AIPort target, IntPort damage, BoolPort ignoreShield, PlayerPort damageSource)
        {
            Node node = new Node()
            {Name = "Combatant Receive Damage", Type = "67aca89c-f753-4f94-87df-1ce1d4fcb8b0", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(damage, new Port{Node = node, Index = 2});
            node.ConnectInputPort(ignoreShield, new Port{Node = node, Index = 3});
            node.ConnectInputPort(damageSource, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantReceiveDamageR1(CombatantPort target, IntPort damage, BoolPort ignoreShield, AIPort damageSource)
        {
            Node node = new Node()
            {Name = "Combatant Receive Damage", Type = "67aca89c-f753-4f94-87df-1ce1d4fcb8b0", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(damage, new Port{Node = node, Index = 2});
            node.ConnectInputPort(ignoreShield, new Port{Node = node, Index = 3});
            node.ConnectInputPort(damageSource, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantReceiveDamageR1(CombatantPort target, IntPort damage, BoolPort ignoreShield, CombatantPort damageSource)
        {
            Node node = new Node()
            {Name = "Combatant Receive Damage", Type = "67aca89c-f753-4f94-87df-1ce1d4fcb8b0", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(damage, new Port{Node = node, Index = 2});
            node.ConnectInputPort(ignoreShield, new Port{Node = node, Index = 3});
            node.ConnectInputPort(damageSource, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantReceiveDamageR1(CombatantPort target, IntPort damage, BoolPort ignoreShield, PlayerPort damageSource)
        {
            Node node = new Node()
            {Name = "Combatant Receive Damage", Type = "67aca89c-f753-4f94-87df-1ce1d4fcb8b0", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(damage, new Port{Node = node, Index = 2});
            node.ConnectInputPort(ignoreShield, new Port{Node = node, Index = 3});
            node.ConnectInputPort(damageSource, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantReceiveDamageR1(PlayerPort target, IntPort damage, BoolPort ignoreShield, AIPort damageSource)
        {
            Node node = new Node()
            {Name = "Combatant Receive Damage", Type = "67aca89c-f753-4f94-87df-1ce1d4fcb8b0", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(damage, new Port{Node = node, Index = 2});
            node.ConnectInputPort(ignoreShield, new Port{Node = node, Index = 3});
            node.ConnectInputPort(damageSource, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantReceiveDamageR1(PlayerPort target, IntPort damage, BoolPort ignoreShield, CombatantPort damageSource)
        {
            Node node = new Node()
            {Name = "Combatant Receive Damage", Type = "67aca89c-f753-4f94-87df-1ce1d4fcb8b0", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(damage, new Port{Node = node, Index = 2});
            node.ConnectInputPort(ignoreShield, new Port{Node = node, Index = 3});
            node.ConnectInputPort(damageSource, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantReceiveDamageR1(PlayerPort target, IntPort damage, BoolPort ignoreShield, PlayerPort damageSource)
        {
            Node node = new Node()
            {Name = "Combatant Receive Damage", Type = "67aca89c-f753-4f94-87df-1ce1d4fcb8b0", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(damage, new Port{Node = node, Index = 2});
            node.ConnectInputPort(ignoreShield, new Port{Node = node, Index = 3});
            node.ConnectInputPort(damageSource, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantSetHealthR1(AIPort target, IntPort health)
        {
            Node node = new Node()
            {Name = "Combatant Set Health", Type = "3dc4807f-2acd-446d-928f-5d301d0795d6", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(health, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantSetHealthR1(CombatantPort target, IntPort health)
        {
            Node node = new Node()
            {Name = "Combatant Set Health", Type = "3dc4807f-2acd-446d-928f-5d301d0795d6", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(health, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantSetHealthR1(PlayerPort target, IntPort health)
        {
            Node node = new Node()
            {Name = "Combatant Set Health", Type = "3dc4807f-2acd-446d-928f-5d301d0795d6", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(health, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantSetMaxHealthR1(AIPort target, IntPort maxHealth)
        {
            Node node = new Node()
            {Name = "Combatant Set Max Health", Type = "82f71bcc-5e83-4825-8306-6a2bb2a296dd", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(maxHealth, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantSetMaxHealthR1(CombatantPort target, IntPort maxHealth)
        {
            Node node = new Node()
            {Name = "Combatant Set Max Health", Type = "82f71bcc-5e83-4825-8306-6a2bb2a296dd", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(maxHealth, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void CombatantSetMaxHealthR1(PlayerPort target, IntPort maxHealth)
        {
            Node node = new Node()
            {Name = "Combatant Set Max Health", Type = "82f71bcc-5e83-4825-8306-6a2bb2a296dd", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(maxHealth, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static (BoolPort IsPlayer, PlayerPort Player, AIPort AI) CombatantSplitR1(CombatantPort combatant)
        {
            Node node = new Node()
            {Name = "Combatant Split", Type = "81b08e44-0a1e-40da-b8a1-79f416691dcf", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(combatant, new Port{Node = node, Index = 0});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new PlayerPort{Port = new Port{Node = node, Index = 1}}, new AIPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static CombatantPort CombatantVariableR1(CombatantPort port1, VariableData config)
        {
            Node node = new Node()
            {Name = "Combatant Variable", Type = "cfd8e246-8682-4707-a0ae-da55bacfbf72", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new CombatantPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static void Comment()
        {
            Node node = new Node()
            {Name = "Comment", Type = "83623f53-86b2-477d-bb2f-fe68f68ba617", InputCount = 0};
            Context.current.AddNode(node);
            return;
        }

        public static AnyPort CommunityEventConstant()
        {
            Node node = new Node()
            {Name = "Community Event Constant", Type = "ab9cf11c-a9fa-41e0-91ac-c241e152e986", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new AnyPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static AnyPort CommunityEventVariable(AnyPort port1, VariableData config)
        {
            Node node = new Node()
            {Name = "Community Event Variable", Type = "355870c7-e058-4f34-8fcc-d0a8ef797fd6", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new AnyPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static void ConsumableActivateR1(ConsumablePort consumable)
        {
            Node node = new Node()
            {Name = "Consumable Activate", Type = "d7ea08ab-aee6-43d0-99e1-54478ac3db7f", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(consumable, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static ConsumablePort ConsumableConstantR1(RoomConsumableData config)
        {
            Node node = new Node()
            {Name = "Consumable Constant", Type = "3dc63876-39a9-4828-9967-67821e620cb1", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new ConsumablePort{Port = new Port{Node = node, Index = 0}};
            node.RoomConsumableData = config;
            return output_ports;
        }

        public static void ConsumableDeactivateR1(ConsumablePort consumable)
        {
            Node node = new Node()
            {Name = "Consumable Deactivate", Type = "6809978a-e1fc-403a-a41a-d4e94f22281f", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(consumable, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static StringPort ControlPanel()
        {
            Node node = new Node()
            {Name = "Control Panel", Type = "0e7f87db-1745-482b-993b-68211255fbbd", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Cos(FloatPort value)
        {
            Node node = new Node()
            {Name = "Cos", Type = "e8659a59-9e11-4403-8bbc-f4a3961cbf21", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void CostumeEquip(CostumePort target, PlayerPort player)
        {
            Node node = new Node()
            {Name = "Costume Equip", Type = "1f57e165-dee2-470d-9ab2-9c836aeccccf", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(player, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static PlayerPort CostumeGetWearer(CostumePort target)
        {
            Node node = new Node()
            {Name = "Costume Get Wearer", Type = "f28d1a5e-a08c-471b-89e6-5ee6372d9897", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort CostumeUnequip(CostumePort target)
        {
            Node node = new Node()
            {Name = "Costume Unequip", Type = "d5070b89-da23-4e4b-848c-07bb22c0420e", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static void DataTable(AnyPort port0, DataTableDefinitionData config)
        {
            Node node = new Node()
            {Name = "Data Table", Type = "cf314640-805c-4ebc-958c-d10ed65ca9b8", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(port0, new Port{Node = node, Index = 0});
            node.DataTableDefinitionData = config;
            return;
        }

        internal static ListPort<IntPort> DataTableGetAllRowsContaining(DataTableColumnData config)
        {
            Node node = new Node()
            {Name = "Data Table Get All Rows Containing", Type = "0a04aa3b-22bd-44a8-8613-9c02db855e88", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new ListPort<IntPort>{Port = new Port{Node = node, Index = 0}};
            node.DataTableColumnData = config;
            return output_ports;
        }

        public static IntPort DataTableGetColumnCount(DataTableData config)
        {
            Node node = new Node()
            {Name = "Data Table Get Column Count", Type = "bf05749e-c89e-4aa2-97f8-31c105f45b49", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            node.DataTableData = config;
            return output_ports;
        }

        internal static IntPort DataTableGetFirstRowContaining(DataTableColumnData config)
        {
            Node node = new Node()
            {Name = "Data Table Get First Row Containing", Type = "699f2839-0742-4b3d-80ca-4394fb60e7e2", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            node.DataTableColumnData = config;
            return output_ports;
        }

        public static IntPort DataTableGetRowCount(DataTableData config)
        {
            Node node = new Node()
            {Name = "Data Table Get Row Count", Type = "e32052ce-0f54-4875-aa11-39e8c2761deb", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            node.DataTableData = config;
            return output_ports;
        }

        internal static void DataTableReadCell(IntPort row, DataTableColumnData config)
        {
            Node node = new Node()
            {Name = "Data Table Read Cell", Type = "4b6cff3d-0ead-43cd-bfa7-a22c87b31b0a", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(row, new Port{Node = node, Index = 0});
            node.DataTableColumnData = config;
            return;
        }

        public static void Delay(FloatPort delay, AlternativeExec afterDelay, AlternativeExec cancel)
        {
            Node node = new Node()
            {Name = "Delay", Type = "cefee2a5-d4a8-4dff-8c4e-bad684ca8d34", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(delay, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            afterDelay();
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 2});
            cancel();
            ExecFlow.current = mainFlow;
            return;
        }

        public static DestinationRoomPort DestinationRoomConstant()
        {
            Node node = new Node()
            {Name = "Destination Room Constant", Type = "330f3621-0d37-4cd7-8b92-270c7df43fcb", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new DestinationRoomPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static DestinationRoomPort DestinationRoomVariable(DestinationRoomPort port1, VariableData config)
        {
            Node node = new Node()
            {Name = "Destination Room Variable", Type = "31eab00d-a6f7-4505-9f84-02d3e1eedd86", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new DestinationRoomPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static Vector3Port DialogueUIGetBillboardingPivotOffset(DialogueUIPort target)
        {
            Node node = new Node()
            {Name = "Dialogue UI Get Billboarding Pivot Offset", Type = "e0065ec4-332b-4b5d-8f60-70daa3a4af03", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (StringPort BodyText, BoolPort IsInteractive) DialogueUIGetDialogueText(DialogueUIPort target)
        {
            Node node = new Node()
            {Name = "Dialogue UI Get Dialogue Text", Type = "ecd48cf6-f25a-4650-a120-4bbf05fbfa1c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = (new StringPort{Port = new Port{Node = node, Index = 0}}, new BoolPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static BoolPort DialogueUIGetIsEnabled(DialogueUIPort target)
        {
            Node node = new Node()
            {Name = "Dialogue UI Get Is Enabled", Type = "24e650ed-b099-44ba-944a-d33ea34fff8b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort DialogueUIGetTitleIsEnabled(DialogueUIPort target)
        {
            Node node = new Node()
            {Name = "Dialogue UI Get Title Is Enabled", Type = "44661525-612e-4032-8278-fcb15a72aee0", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort DialogueUIGetTitleText(DialogueUIPort target)
        {
            Node node = new Node()
            {Name = "Dialogue UI Get Title Text", Type = "17a13c0d-f5c0-4806-b6ee-1af03eb81bdb", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void DialogueUISetBillboardingPivotOffset(DialogueUIPort target, Vector3Port offset)
        {
            Node node = new Node()
            {Name = "Dialogue UI Set Billboarding Pivot Offset", Type = "beeef46e-fdb0-4842-ad97-be5271efe837", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(offset, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void DialogueUISetButtonState(DialogueUIPort target, BoolPort button1Enabled, StringPort button1Text, BoolPort button2Enabled, StringPort button2Text, BoolPort button3Enabled, StringPort button3Text, BoolPort button4Enabled, StringPort button4Text)
        {
            Node node = new Node()
            {Name = "Dialogue UI Set Button State", Type = "f4772dae-d4e3-489c-8943-8fe88160ab5c", InputCount = 10};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(button1Enabled, new Port{Node = node, Index = 2});
            node.ConnectInputPort(button1Text, new Port{Node = node, Index = 3});
            node.ConnectInputPort(button2Enabled, new Port{Node = node, Index = 4});
            node.ConnectInputPort(button2Text, new Port{Node = node, Index = 5});
            node.ConnectInputPort(button3Enabled, new Port{Node = node, Index = 6});
            node.ConnectInputPort(button3Text, new Port{Node = node, Index = 7});
            node.ConnectInputPort(button4Enabled, new Port{Node = node, Index = 8});
            node.ConnectInputPort(button4Text, new Port{Node = node, Index = 9});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void DialogueUISetDialogueText(DialogueUIPort target, StringPort bodyText, BoolPort isInteractive)
        {
            Node node = new Node()
            {Name = "Dialogue UI Set Dialogue Text", Type = "bc6602e4-e88b-4db4-9655-0a6baf50997e", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(bodyText, new Port{Node = node, Index = 2});
            node.ConnectInputPort(isInteractive, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void DialogueUISetIsEnabled(DialogueUIPort target, BoolPort isEnabled)
        {
            Node node = new Node()
            {Name = "Dialogue UI Set Is Enabled", Type = "a348af16-bd74-4da6-a3e1-1bf1e2456eba", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(isEnabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void DialogueUISetTitleIsEnabled(DialogueUIPort target, BoolPort isEnabled)
        {
            Node node = new Node()
            {Name = "Dialogue UI Set Title Is Enabled", Type = "54a8ee30-21fa-4f74-8f54-5c8936a2e7bb", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(isEnabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void DialogueUISetTitleText(DialogueUIPort target, StringPort titleText)
        {
            Node node = new Node()
            {Name = "Dialogue UI Set Title Text", Type = "45566130-ee6e-4eca-8f05-7e264001afc1", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(titleText, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static PlayerPort DiceGetPlayerRolled(DiePort target)
        {
            Node node = new Node()
            {Name = "Dice Get Player Rolled", Type = "c1fdc4fa-fcb4-4ea4-b505-7b1d15fb8117", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort DiceGetResult(DiePort target)
        {
            Node node = new Node()
            {Name = "Dice Get Result", Type = "c80e2979-c672-4e7a-81fb-0ed1964e3ea6", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort DiceGetRollFinished(DiePort target)
        {
            Node node = new Node()
            {Name = "Dice Get Roll finished", Type = "b8735ad9-cd89-4d81-ab9b-be3eb50e3b5a", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void DisplayPlayerWorldUI(PlayerWorldUIPort target, PlayerPort player)
        {
            Node node = new Node()
            {Name = "Display Player World UI", Type = "dfbf7060-c08a-4f20-818c-02afe1c36b38", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(player, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort Distance(AIPort a, AIPort b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(AIPort a, CombatantPort b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(AIPort a, RecRoomObjectPort b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(AIPort a, PlayerPort b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(AIPort a, Vector3Port b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(CombatantPort a, AIPort b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(CombatantPort a, CombatantPort b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(CombatantPort a, RecRoomObjectPort b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(CombatantPort a, PlayerPort b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(CombatantPort a, Vector3Port b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(RecRoomObjectPort a, AIPort b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(RecRoomObjectPort a, CombatantPort b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(RecRoomObjectPort a, RecRoomObjectPort b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(RecRoomObjectPort a, PlayerPort b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(RecRoomObjectPort a, Vector3Port b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(PlayerPort a, AIPort b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(PlayerPort a, CombatantPort b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(PlayerPort a, RecRoomObjectPort b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(PlayerPort a, PlayerPort b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(PlayerPort a, Vector3Port b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(Vector3Port a, AIPort b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(Vector3Port a, CombatantPort b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(Vector3Port a, RecRoomObjectPort b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(Vector3Port a, PlayerPort b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Distance(Vector3Port a, Vector3Port b)
        {
            Node node = new Node()
            {Name = "Distance", Type = "da92dbd5-5bbd-4afa-8eb1-2e88fff2380d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(AIPort a, AIPort b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(AIPort a, CombatantPort b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(AIPort a, RecRoomObjectPort b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(AIPort a, PlayerPort b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(AIPort a, Vector3Port b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(CombatantPort a, AIPort b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(CombatantPort a, CombatantPort b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(CombatantPort a, RecRoomObjectPort b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(CombatantPort a, PlayerPort b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(CombatantPort a, Vector3Port b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(RecRoomObjectPort a, AIPort b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(RecRoomObjectPort a, CombatantPort b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(RecRoomObjectPort a, RecRoomObjectPort b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(RecRoomObjectPort a, PlayerPort b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(RecRoomObjectPort a, Vector3Port b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(PlayerPort a, AIPort b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(PlayerPort a, CombatantPort b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(PlayerPort a, RecRoomObjectPort b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(PlayerPort a, PlayerPort b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(PlayerPort a, Vector3Port b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(Vector3Port a, AIPort b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(Vector3Port a, CombatantPort b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(Vector3Port a, RecRoomObjectPort b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(Vector3Port a, PlayerPort b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort DistanceDeprecated(Vector3Port a, Vector3Port b)
        {
            Node node = new Node()
            {Name = "Distance (Deprecated)", Type = "182e1ae2-1183-4741-af6e-f307b788a857", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static IntPort Divide(IntPort value)
        {
            Node node = new Node()
            {Name = "Divide", Type = "f2eafd78-5f23-44c9-a271-8ff2f0762e71", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static FloatPort Divide(FloatPort value)
        {
            Node node = new Node()
            {Name = "Divide", Type = "f2eafd78-5f23-44c9-a271-8ff2f0762e71", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static Vector3Port Divide(Vector3Port value)
        {
            Node node = new Node()
            {Name = "Divide", Type = "f2eafd78-5f23-44c9-a271-8ff2f0762e71", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static DestinationRoomPort DoorGetDestinationR1(RoomDoorPort target)
        {
            Node node = new Node()
            {Name = "Door Get Destination", Type = "5f0eb749-1c4e-46fb-b2d1-4faaf69446bb", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new DestinationRoomPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort DoorGetLockedR1(RoomDoorPort target)
        {
            Node node = new Node()
            {Name = "Door Get Locked", Type = "f2918d8a-444c-429d-ab79-e2d445695a57", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void DoorSetDestinationR1(RoomDoorPort target, DestinationRoomPort room)
        {
            Node node = new Node()
            {Name = "Door Set Destination", Type = "5b9dc865-0fac-4d3a-9edc-68184ee189a2", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(room, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void DoorSetLockedR1(RoomDoorPort target, BoolPort locked)
        {
            Node node = new Node()
            {Name = "Door Set Locked", Type = "7ca4abb2-d705-4c17-b713-7525122ef286", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(locked, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort EmitterGetLooping(EmitterPort target)
        {
            Node node = new Node()
            {Name = "Emitter Get Looping", Type = "f8c91da0-bb4f-4958-9016-546a387f45dd", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort EmitterGetPlaying(EmitterPort target)
        {
            Node node = new Node()
            {Name = "Emitter Get Playing", Type = "9fbee635-c6a4-4a02-a67b-295e075db7c9", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort EmitterGetSize(EmitterPort target)
        {
            Node node = new Node()
            {Name = "Emitter Get Size", Type = "08c3c01c-2c40-4b92-a913-e5a8cbbbe352", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort EmitterGetSpeed(EmitterPort target)
        {
            Node node = new Node()
            {Name = "Emitter Get Speed", Type = "df10f3b8-e5b8-49ad-9112-22cc0e3bdb9f", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void EmitterSetColor(EmitterPort target, ColorPort color)
        {
            Node node = new Node()
            {Name = "Emitter Set Color", Type = "4263768a-035b-4d8b-b17c-1a7bb0b9b96d", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void EmitterSetColorIdDeprecated(EmitterPort target, IntPort value)
        {
            Node node = new Node()
            {Name = "Emitter Set Color Id", Type = "15e42063-cbae-40f9-a9e4-8226e83217ec", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void EmitterSetLooping(EmitterPort target, BoolPort value)
        {
            Node node = new Node()
            {Name = "Emitter Set Looping", Type = "36881bd0-7da0-44a7-b6ef-8cd3770fed78", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void EmitterSetSize(EmitterPort target, FloatPort value)
        {
            Node node = new Node()
            {Name = "Emitter Set Size", Type = "1fdf4bab-c868-4ffb-8bfc-b2e360450495", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void EmitterSetSpeed(EmitterPort target, FloatPort value)
        {
            Node node = new Node()
            {Name = "Emitter Set Speed", Type = "12446960-d971-475f-b64e-b5c7bb422eca", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void EmitterStart(EmitterPort target)
        {
            Node node = new Node()
            {Name = "Emitter Start", Type = "56ebaa0b-256a-40ed-a066-f5663dfa2b59", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void EmitterStop(EmitterPort target)
        {
            Node node = new Node()
            {Name = "Emitter Stop", Type = "23b278c4-5d3d-439d-afa3-ff30c949df97", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        internal static BoolPort Equals<T>(T value)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Equals", Type = "e1f1b65e-8d82-47af-8637-ae2d0afa431f", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort EqualsDeprecated<T>(T a, T b)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Equals", Type = "3663225d-e18d-40e6-a234-ef10378528be", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static EquipmentSlotPort EquipmentSlotR2()
        {
            Node node = new Node()
            {Name = "Equipment Slot", Type = "1abf31dd-fa6e-43bb-9eb4-94a06e62f139", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new EquipmentSlotPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort EquipObjectToDominantHand(PlayerPort player, RecRoomObjectPort objectToEquip, BoolPort forceEquip, BoolPort steal)
        {
            Node node = new Node()
            {Name = "Equip Object to Dominant Hand", Type = "c840f770-80aa-4e96-8677-963a2ca3cff1", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(objectToEquip, new Port{Node = node, Index = 2});
            node.ConnectInputPort(forceEquip, new Port{Node = node, Index = 3});
            node.ConnectInputPort(steal, new Port{Node = node, Index = 4});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort EquipObjectToOffHand(PlayerPort player, RecRoomObjectPort objectToEquip, BoolPort forceEquip, BoolPort steal)
        {
            Node node = new Node()
            {Name = "Equip Object to Off Hand", Type = "52da50b9-2d34-4128-a1bd-3e056f236e2c", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(objectToEquip, new Port{Node = node, Index = 2});
            node.ConnectInputPort(forceEquip, new Port{Node = node, Index = 3});
            node.ConnectInputPort(steal, new Port{Node = node, Index = 4});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort EquipShareCamera(PlayerPort player, BoolPort forceEquip)
        {
            Node node = new Node()
            {Name = "Equip Share Camera", Type = "2d9b5795-efca-48a6-9270-d1804ec69bb4", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(forceEquip, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static void EventDefinition(EventDefinitionData config)
        {
            Node node = new Node()
            {Name = "Event Definition", Type = "7d72a1fa-a434-4437-a73a-51f306a3f55f", InputCount = 0};
            Context.current.AddNode(node);
            node.EventDefinitionData = config;
            return;
        }

        public static void EventReceiver(EventReceiverData config)
        {
            Node node = new Node()
            {Name = "Event Receiver", Type = "8b533ccb-643a-491d-982c-94417ce99954", InputCount = 0};
            Context.current.AddNode(node);
            ExecFlow.current.Advance(Context.current, null, new Port{Node = node});
            node.EventReceiverData = config;
            return;
        }

        public static void EventSender(EventSenderData config)
        {
            Node node = new Node()
            {Name = "Event Sender", Type = "96a8fe50-bc37-458b-bac9-582d45314779", InputCount = 1};
            Context.current.AddNode(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.EventSenderData = config;
            return;
        }

        public static void ExecutionIntegerSwitch(IntPort match)
        {
            Node node = new Node()
            {Name = "Execution Integer Switch", Type = "0387e4c7-b917-4d19-937f-5da37b9f41cc", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(match, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ExecutionStringSwitch(StringPort match)
        {
            Node node = new Node()
            {Name = "Execution String Switch", Type = "80c7d803-df40-45a5-ac7b-bfccb0b511c7", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(match, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ExplosionEmitterExplode(ExplosionEmitterPort target)
        {
            Node node = new Node()
            {Name = "Explosion Emitter Explode", Type = "49774675-e750-441f-9e92-8455232f1703", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static IntPort ExplosionEmitterGetDamage(ExplosionEmitterPort target)
        {
            Node node = new Node()
            {Name = "Explosion Emitter Get Damage", Type = "87d94359-da69-49ed-8b61-fbf78d79fa48", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort ExplosionEmitterGetExplosionColor(ExplosionEmitterPort target)
        {
            Node node = new Node()
            {Name = "Explosion Emitter Get Explosion Color", Type = "6039d63b-f484-4436-bb7c-ea58529ed4ec", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort ExplosionEmitterGetExplosionRadius(ExplosionEmitterPort target)
        {
            Node node = new Node()
            {Name = "Explosion Emitter Get Explosion Radius", Type = "eff7cfca-dcee-4ea1-887f-e4c60f3c8269", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort ExplosionEmitterGetFiringPlayer(ExplosionEmitterPort target)
        {
            Node node = new Node()
            {Name = "Explosion Emitter Get Firing Player", Type = "36cd4562-2c1f-43e3-ba90-56daa0cb7339", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void ExplosionEmitterSetDamage(ExplosionEmitterPort target, IntPort damage)
        {
            Node node = new Node()
            {Name = "Explosion Emitter Set Damage", Type = "748f210d-f9e2-4dca-a29a-8eacf99daff7", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(damage, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ExplosionEmitterSetExplosionColor(ExplosionEmitterPort target, ColorPort color)
        {
            Node node = new Node()
            {Name = "Explosion Emitter Set Explosion Color", Type = "a3211c4f-9924-4a9a-afea-ab48f37bbc67", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ExplosionEmitterSetExplosionRadius(ExplosionEmitterPort target, FloatPort radius)
        {
            Node node = new Node()
            {Name = "Explosion Emitter Set Explosion Radius", Type = "672e473f-7099-4f76-aead-8b3df7c2fcd2", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(radius, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ExplosionEmitterSetFiringPlayer(ExplosionEmitterPort target, PlayerPort player)
        {
            Node node = new Node()
            {Name = "Explosion Emitter Set Firing Player", Type = "d39b968d-bdab-4548-aaa7-745e3155789e", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(player, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort FloatVariable(FloatPort port1, VariableData config)
        {
            Node node = new Node()
            {Name = "float Variable", Type = "04a31ca5-91d2-4a69-bf3d-484d18411cc0", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static FloatPort Floor(FloatPort value)
        {
            Node node = new Node()
            {Name = "Floor", Type = "c90d9339-cdce-4d22-a885-f142fd5567ab", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort FloorToInt(FloatPort value)
        {
            Node node = new Node()
            {Name = "Floor to Int", Type = "bc451cab-2292-4e60-832d-31060eb82bd0", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FogPort FogConstant(FogData config)
        {
            Node node = new Node()
            {Name = "Fog Constant", Type = "3026a5c6-232f-4961-b18a-5ad179e6b24d", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new FogPort{Port = new Port{Node = node, Index = 0}};
            node.FogData = config;
            return output_ports;
        }

        internal static IntPort For(IntPort from, IntPort to, AlternativeExec<IntPort> done)
        {
            Node node = new Node()
            {Name = "For", Type = "8f945c22-988b-45d2-b7f2-409ba304fef4", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(from, new Port{Node = node, Index = 1});
            node.ConnectInputPort(to, new Port{Node = node, Index = 2});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 2});
            done(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static T ForEach<T>(ListPort<T> items, AlternativeExec<T> done)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "For Each", Type = "744e5311-6cc7-4130-962e-fe050a475d43", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(items, new Port{Node = node, Index = 1});
            var output_ports = new T{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 2});
            done(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static T FromRecRoomObject<T>(RecRoomObjectPort target)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "From Rec Room Object", Type = "7ff685a6-f59c-4c6c-b559-f343d81ea1d4", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new T{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void FunctionDefinition()
        {
            Node node = new Node()
            {Name = "Function Definition", Type = "49937daa-4f6d-442c-a0d8-0095b675250d", InputCount = 0};
            Context.current.AddNode(node);
            return;
        }

        public static void FunctionOut()
        {
            Node node = new Node()
            {Name = "Out", Type = "3b63e0ee-4cc6-40f0-b789-b8f6d93e0a6e", InputCount = 0};
            Context.current.AddNode(node);
            return;
        }

        public static HUDElementPort GameHUDElementConstant()
        {
            Node node = new Node()
            {Name = "Game HUD Element Constant", Type = "4a3c3d38-f1a4-493b-977f-5444ab2d404b", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new HUDElementPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<InventoryItemPort> GetAllInventoryItemsInRoomR2()
        {
            Node node = new Node()
            {Name = "Get All Inventory Items In Room", Type = "5ad0cd6b-90ad-4425-a43a-7ac7ec0d0141", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new ListPort<InventoryItemPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<InventoryItemPort> GetAllInventoryItemsWithTagR2(StringPort tag)
        {
            Node node = new Node()
            {Name = "Get All Inventory Items With Tag", Type = "80ad6681-f1b1-448e-acc2-0736e4f6841d", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(tag, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<InventoryItemPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<PlayerPort> GetAllPlayers()
        {
            Node node = new Node()
            {Name = "Get All Players", Type = "3f4346b1-bc6f-4aca-9650-d43cbd4acc5b", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new ListPort<PlayerPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<PlayerPort> GetAllPlayersDeprecated()
        {
            Node node = new Node()
            {Name = "Get All Players (Deprecated)", Type = "09b0bf5b-95df-474b-b81a-4e8e2c78ed0a", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new ListPort<PlayerPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<PlayerPort> GetAllPlayersWithRoleR1(StringPort roleName)
        {
            Node node = new Node()
            {Name = "Get All Players With Role", Type = "1c0a6bd4-bcac-40a9-8bae-fceff7ff7cff", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(roleName, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<PlayerPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetAngularVelocity(RecRoomObjectPort target)
        {
            Node node = new Node()
            {Name = "Get Angular Velocity", Type = "0922120c-c5b8-4109-8001-61b3131072a4", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort GetAnyPlayerWithRoleR1(StringPort role)
        {
            Node node = new Node()
            {Name = "Get Any Player with Role", Type = "a924cac0-0245-4846-862d-df4092c5e1c2", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(role, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort GetAuthority()
        {
            Node node = new Node()
            {Name = "Get Authority", Type = "eaf712f8-3257-4415-9f88-ae94e308396e", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (IntPort AudienceCount, IntPort BroadcasterCount, BoolPort IsBroadcastActive) GetBroadcastingAttendance()
        {
            Node node = new Node()
            {Name = "Get Broadcasting Attendance", Type = "78f5a9f2-4e3d-4534-aada-4af3a551a953", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = (new IntPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new BoolPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (RecRoomObjectPort Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(RecRoomObjectPort origin, ListPort<RecRoomObjectPort> targets)
        {
            Node node = new Node()
            {Name = "Get Closest", Type = "49fa5928-1af5-49e3-96d0-5ae67e6d81c9", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(targets, new Port{Node = node, Index = 1});
            var output_ports = (new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (PlayerPort Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(RecRoomObjectPort origin, ListPort<PlayerPort> targets)
        {
            Node node = new Node()
            {Name = "Get Closest", Type = "49fa5928-1af5-49e3-96d0-5ae67e6d81c9", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(targets, new Port{Node = node, Index = 1});
            var output_ports = (new PlayerPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (Vector3Port Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(RecRoomObjectPort origin, ListPort<Vector3Port> targets)
        {
            Node node = new Node()
            {Name = "Get Closest", Type = "49fa5928-1af5-49e3-96d0-5ae67e6d81c9", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(targets, new Port{Node = node, Index = 1});
            var output_ports = (new Vector3Port{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (RecRoomObjectPort Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(PlayerPort origin, ListPort<RecRoomObjectPort> targets)
        {
            Node node = new Node()
            {Name = "Get Closest", Type = "49fa5928-1af5-49e3-96d0-5ae67e6d81c9", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(targets, new Port{Node = node, Index = 1});
            var output_ports = (new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (PlayerPort Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(PlayerPort origin, ListPort<PlayerPort> targets)
        {
            Node node = new Node()
            {Name = "Get Closest", Type = "49fa5928-1af5-49e3-96d0-5ae67e6d81c9", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(targets, new Port{Node = node, Index = 1});
            var output_ports = (new PlayerPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (Vector3Port Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(PlayerPort origin, ListPort<Vector3Port> targets)
        {
            Node node = new Node()
            {Name = "Get Closest", Type = "49fa5928-1af5-49e3-96d0-5ae67e6d81c9", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(targets, new Port{Node = node, Index = 1});
            var output_ports = (new Vector3Port{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (RecRoomObjectPort Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(Vector3Port origin, ListPort<RecRoomObjectPort> targets)
        {
            Node node = new Node()
            {Name = "Get Closest", Type = "49fa5928-1af5-49e3-96d0-5ae67e6d81c9", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(targets, new Port{Node = node, Index = 1});
            var output_ports = (new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (PlayerPort Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(Vector3Port origin, ListPort<PlayerPort> targets)
        {
            Node node = new Node()
            {Name = "Get Closest", Type = "49fa5928-1af5-49e3-96d0-5ae67e6d81c9", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(targets, new Port{Node = node, Index = 1});
            var output_ports = (new PlayerPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (Vector3Port Closest, IntPort ClosestIndex, FloatPort Distance) GetClosest(Vector3Port origin, ListPort<Vector3Port> targets)
        {
            Node node = new Node()
            {Name = "Get Closest", Type = "49fa5928-1af5-49e3-96d0-5ae67e6d81c9", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(targets, new Port{Node = node, Index = 1});
            var output_ports = (new Vector3Port{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (BoolPort Success, IntPort TotalBalance) GetCurrencyBalanceDeprecatedR1(PlayerPort player, AlternativeExec<(BoolPort Success, IntPort TotalBalance)> onGetBalanceComplete)
        {
            Node node = new Node()
            {Name = "Get Currency Balance", Type = "a4b0c860-e7f0-4abf-ad7c-9be1805c3d01", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 2}}, new IntPort{Port = new Port{Node = node, Index = 3}});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            onGetBalanceComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static (BoolPort Success, IntPort TotalBalance) GetCurrencyBalanceR1(RoomCurrencyPort currency, PlayerPort player, AlternativeExec<(BoolPort Success, IntPort TotalBalance)> onGetBalanceComplete)
        {
            Node node = new Node()
            {Name = "Get Currency Balance", Type = "01659b8a-db44-4b5e-9a58-c366dcfff666", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(currency, new Port{Node = node, Index = 1});
            node.ConnectInputPort(player, new Port{Node = node, Index = 2});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 2}}, new IntPort{Port = new Port{Node = node, Index = 3}});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            onGetBalanceComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static (RecRoomObjectPort Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(RecRoomObjectPort origin, ListPort<RecRoomObjectPort> targets)
        {
            Node node = new Node()
            {Name = "Get Farthest", Type = "8e17bef6-59ea-4ff0-999a-a158800b22da", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(targets, new Port{Node = node, Index = 1});
            var output_ports = (new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (PlayerPort Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(RecRoomObjectPort origin, ListPort<PlayerPort> targets)
        {
            Node node = new Node()
            {Name = "Get Farthest", Type = "8e17bef6-59ea-4ff0-999a-a158800b22da", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(targets, new Port{Node = node, Index = 1});
            var output_ports = (new PlayerPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (Vector3Port Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(RecRoomObjectPort origin, ListPort<Vector3Port> targets)
        {
            Node node = new Node()
            {Name = "Get Farthest", Type = "8e17bef6-59ea-4ff0-999a-a158800b22da", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(targets, new Port{Node = node, Index = 1});
            var output_ports = (new Vector3Port{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (RecRoomObjectPort Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(PlayerPort origin, ListPort<RecRoomObjectPort> targets)
        {
            Node node = new Node()
            {Name = "Get Farthest", Type = "8e17bef6-59ea-4ff0-999a-a158800b22da", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(targets, new Port{Node = node, Index = 1});
            var output_ports = (new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (PlayerPort Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(PlayerPort origin, ListPort<PlayerPort> targets)
        {
            Node node = new Node()
            {Name = "Get Farthest", Type = "8e17bef6-59ea-4ff0-999a-a158800b22da", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(targets, new Port{Node = node, Index = 1});
            var output_ports = (new PlayerPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (Vector3Port Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(PlayerPort origin, ListPort<Vector3Port> targets)
        {
            Node node = new Node()
            {Name = "Get Farthest", Type = "8e17bef6-59ea-4ff0-999a-a158800b22da", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(targets, new Port{Node = node, Index = 1});
            var output_ports = (new Vector3Port{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (RecRoomObjectPort Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(Vector3Port origin, ListPort<RecRoomObjectPort> targets)
        {
            Node node = new Node()
            {Name = "Get Farthest", Type = "8e17bef6-59ea-4ff0-999a-a158800b22da", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(targets, new Port{Node = node, Index = 1});
            var output_ports = (new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (PlayerPort Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(Vector3Port origin, ListPort<PlayerPort> targets)
        {
            Node node = new Node()
            {Name = "Get Farthest", Type = "8e17bef6-59ea-4ff0-999a-a158800b22da", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(targets, new Port{Node = node, Index = 1});
            var output_ports = (new PlayerPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (Vector3Port Farthest, IntPort FarthestIndex, FloatPort Distance) GetFarthest(Vector3Port origin, ListPort<Vector3Port> targets)
        {
            Node node = new Node()
            {Name = "Get Farthest", Type = "8e17bef6-59ea-4ff0-999a-a158800b22da", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(origin, new Port{Node = node, Index = 0});
            node.ConnectInputPort(targets, new Port{Node = node, Index = 1});
            var output_ports = (new Vector3Port{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static StringPort GetFirstTag(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get First Tag", Type = "cb909206-8627-4c66-ac8d-47b1a046ef8b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort GetFirstTag(RecRoomObjectPort target)
        {
            Node node = new Node()
            {Name = "Get First Tag", Type = "cb909206-8627-4c66-ac8d-47b1a046ef8b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort GetFormattedTime(FloatPort universalSeconds, StringPort format)
        {
            Node node = new Node()
            {Name = "Get Formatted Time", Type = "7dfed109-e641-47f3-8844-fd0753e4e764", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(universalSeconds, new Port{Node = node, Index = 0});
            node.ConnectInputPort(format, new Port{Node = node, Index = 1});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort GetFormattedTime(IntPort universalSeconds, StringPort format)
        {
            Node node = new Node()
            {Name = "Get Formatted Time", Type = "7dfed109-e641-47f3-8844-fd0753e4e764", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(universalSeconds, new Port{Node = node, Index = 0});
            node.ConnectInputPort(format, new Port{Node = node, Index = 1});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetForwardVector(RecRoomObjectPort target)
        {
            Node node = new Node()
            {Name = "Get Forward Vector", Type = "4536e1df-1138-4a2c-9117-475bb3f38eae", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetForwardVector(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Forward Vector", Type = "4536e1df-1138-4a2c-9117-475bb3f38eae", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetForwardVectorDeprecated(RecRoomObjectPort target)
        {
            Node node = new Node()
            {Name = "Get Forward Vector (Deprecated)", Type = "88f95338-d1a6-4fad-8424-d714d651f6ac", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetForwardVectorDeprecated(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Forward Vector (Deprecated)", Type = "88f95338-d1a6-4fad-8424-d714d651f6ac", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort GetHUDElementColor(HUDConstantPort target)
        {
            Node node = new Node()
            {Name = "Get HUD Element Color", Type = "119d2860-e05c-4140-ba5f-c24139b78652", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GetHUDElementEnabled(HUDConstantPort target)
        {
            Node node = new Node()
            {Name = "Get HUD Element Enabled", Type = "a970b2bd-0224-4b1e-9839-111315b28986", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort GetHUDElementLabel(HUDConstantPort target)
        {
            Node node = new Node()
            {Name = "Get HUD Element Label", Type = "98ef89de-7a1b-4043-8071-b5cda41030cd", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort GetHUDElementMaxValue(HUDConstantPort target)
        {
            Node node = new Node()
            {Name = "Get HUD Element Max Value", Type = "f59d4537-e8b4-4d19-b29f-d5203ce562af", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort GetHUDElementValue(HUDConstantPort target)
        {
            Node node = new Node()
            {Name = "Get HUD Element Value", Type = "d9cbf25f-01c6-468f-8607-d1dd8317bb2f", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static InventoryItemPort GetInventoryItemFromNameR2(StringPort name)
        {
            Node node = new Node()
            {Name = "Get Inventory Item From Name", Type = "f54582a2-90b1-4be4-a6c0-0d688b4f8067", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(name, new Port{Node = node, Index = 0});
            var output_ports = new InventoryItemPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort GetLoadingPlayers()
        {
            Node node = new Node()
            {Name = "Get Loading Players", Type = "2e02d617-5ada-4876-84ac-d1b6d6270fc4", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetLocalCameraForward()
        {
            Node node = new Node()
            {Name = "Get Local Camera Forward", Type = "70c830bb-223a-4a7c-b0ae-df240c6f1f33", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetLocalCameraPosition()
        {
            Node node = new Node()
            {Name = "Get Local Camera Position", Type = "c19eff8a-980c-444a-983f-bb4c53a94daf", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort GetLocalCameraRotation()
        {
            Node node = new Node()
            {Name = "Get Local Camera Rotation", Type = "912f0e1b-267d-4424-8002-3f82a2d835fe", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetLocalCameraUp()
        {
            Node node = new Node()
            {Name = "Get Local Camera Up", Type = "5d9da95f-a64f-4660-a11f-bf0855769659", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort GetLocalPlayer()
        {
            Node node = new Node()
            {Name = "Get Local Player", Type = "fdf733a8-bdd6-4800-b1d4-95b06b3d6f02", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort GetNewLine()
        {
            Node node = new Node()
            {Name = "Get New Line", Type = "975fde92-136c-4ce5-b749-bf149b817695", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<PlayerPort> GetPartyOfPlayer(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Party Of Player", Type = "dcbd4d6a-8f42-48ef-ad66-e1f245228d84", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<PlayerPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort GetPlayerAccountName(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Get Player Account Name", Type = "6141ff64-412b-452f-beb0-f338eb6abfb5", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort GetPlayerByAccountName(StringPort name)
        {
            Node node = new Node()
            {Name = "Get Player By Account Name", Type = "2ee5a268-9d44-4326-8a34-ad126a3218f2", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(name, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort GetPlayerByDisplayName(StringPort name)
        {
            Node node = new Node()
            {Name = "Get Player By Display Name", Type = "637e07e4-9b93-44b6-bba3-68966080d064", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(name, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort GetPlayerSeasonLeagueNameDeprecated(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Get Player Season League Name", Type = "288083ac-338d-410f-9395-fbd7c6e41207", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GetPlayerWorldUIEnabled(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Enabled", Type = "36ad6c98-0fb8-43a0-bf8d-0784394d2d28", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort GetPlayerWorldUIPrimaryBarColor(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Primary Bar Color", Type = "72101b8c-e522-43ad-ad96-7332f7962c10", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GetPlayerWorldUIPrimaryBarEnabled(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Primary Bar Enabled", Type = "125d57be-9afa-46b3-a1c4-0c967d044334", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort GetPlayerWorldUIPrimaryBarMaxValue(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Primary Bar Max Value", Type = "30eb2838-1409-4266-96ed-31b3e1e25408", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort GetPlayerWorldUIPrimaryBarValue(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Primary Bar Value", Type = "84f241f5-fa59-43a3-9b2d-029b831e9275", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort GetPlayerWorldUISecondaryBarColor(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Secondary Bar Color", Type = "2e537d07-930e-44f6-8757-ff34c365fd06", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GetPlayerWorldUISecondaryBarEnabled(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Secondary Bar Enabled", Type = "eaddf07d-4beb-4841-990c-a6b674a66126", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort GetPlayerWorldUISecondaryBarMaxValue(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Secondary Bar Max Value", Type = "b23bdd96-7676-4236-a5ab-ca0aae513916", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort GetPlayerWorldUISecondaryBarValue(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Secondary Bar Value", Type = "cafb066f-d6f5-4a1a-a833-e1a0186c6d8e", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort GetPlayerWorldUITextColor(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Text Color", Type = "a8cdbc23-b8de-431e-9428-10b7ccc07192", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GetPlayerWorldUITextEnabled(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Text Enabled", Type = "cd1b799d-855a-4ade-b62f-043a0db60a44", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort GetPlayerWorldUITextValue(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Player World UI Text Value", Type = "447bbb2e-11e4-408c-b4a9-b758e3e07ee7", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPosition(AIPort target)
        {
            Node node = new Node()
            {Name = "Get Position", Type = "5f6a8ee8-8a87-4da2-851f-fda89cc62344", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPosition(CombatantPort target)
        {
            Node node = new Node()
            {Name = "Get Position", Type = "5f6a8ee8-8a87-4da2-851f-fda89cc62344", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPosition(RecRoomObjectPort target)
        {
            Node node = new Node()
            {Name = "Get Position", Type = "5f6a8ee8-8a87-4da2-851f-fda89cc62344", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPosition(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Position", Type = "5f6a8ee8-8a87-4da2-851f-fda89cc62344", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionDeprecated(AIPort target)
        {
            Node node = new Node()
            {Name = "Get Position (Deprecated)", Type = "a8c52ef2-17bf-47e6-9084-3e5623584b48", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionDeprecated(CombatantPort target)
        {
            Node node = new Node()
            {Name = "Get Position (Deprecated)", Type = "a8c52ef2-17bf-47e6-9084-3e5623584b48", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionDeprecated(RecRoomObjectPort target)
        {
            Node node = new Node()
            {Name = "Get Position (Deprecated)", Type = "a8c52ef2-17bf-47e6-9084-3e5623584b48", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionDeprecated(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Position (Deprecated)", Type = "a8c52ef2-17bf-47e6-9084-3e5623584b48", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionInReferenceObjectSpace(AIPort target, AIPort referenceObject)
        {
            Node node = new Node()
            {Name = "Get Position in Reference Object Space", Type = "72be9974-9713-415c-a29e-4a39a5ac4737", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionInReferenceObjectSpace(AIPort target, CombatantPort referenceObject)
        {
            Node node = new Node()
            {Name = "Get Position in Reference Object Space", Type = "72be9974-9713-415c-a29e-4a39a5ac4737", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionInReferenceObjectSpace(AIPort target, RecRoomObjectPort referenceObject)
        {
            Node node = new Node()
            {Name = "Get Position in Reference Object Space", Type = "72be9974-9713-415c-a29e-4a39a5ac4737", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionInReferenceObjectSpace(AIPort target, PlayerPort referenceObject)
        {
            Node node = new Node()
            {Name = "Get Position in Reference Object Space", Type = "72be9974-9713-415c-a29e-4a39a5ac4737", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionInReferenceObjectSpace(CombatantPort target, AIPort referenceObject)
        {
            Node node = new Node()
            {Name = "Get Position in Reference Object Space", Type = "72be9974-9713-415c-a29e-4a39a5ac4737", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionInReferenceObjectSpace(CombatantPort target, CombatantPort referenceObject)
        {
            Node node = new Node()
            {Name = "Get Position in Reference Object Space", Type = "72be9974-9713-415c-a29e-4a39a5ac4737", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionInReferenceObjectSpace(CombatantPort target, RecRoomObjectPort referenceObject)
        {
            Node node = new Node()
            {Name = "Get Position in Reference Object Space", Type = "72be9974-9713-415c-a29e-4a39a5ac4737", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionInReferenceObjectSpace(CombatantPort target, PlayerPort referenceObject)
        {
            Node node = new Node()
            {Name = "Get Position in Reference Object Space", Type = "72be9974-9713-415c-a29e-4a39a5ac4737", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionInReferenceObjectSpace(RecRoomObjectPort target, AIPort referenceObject)
        {
            Node node = new Node()
            {Name = "Get Position in Reference Object Space", Type = "72be9974-9713-415c-a29e-4a39a5ac4737", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionInReferenceObjectSpace(RecRoomObjectPort target, CombatantPort referenceObject)
        {
            Node node = new Node()
            {Name = "Get Position in Reference Object Space", Type = "72be9974-9713-415c-a29e-4a39a5ac4737", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionInReferenceObjectSpace(RecRoomObjectPort target, RecRoomObjectPort referenceObject)
        {
            Node node = new Node()
            {Name = "Get Position in Reference Object Space", Type = "72be9974-9713-415c-a29e-4a39a5ac4737", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionInReferenceObjectSpace(RecRoomObjectPort target, PlayerPort referenceObject)
        {
            Node node = new Node()
            {Name = "Get Position in Reference Object Space", Type = "72be9974-9713-415c-a29e-4a39a5ac4737", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionInReferenceObjectSpace(PlayerPort target, AIPort referenceObject)
        {
            Node node = new Node()
            {Name = "Get Position in Reference Object Space", Type = "72be9974-9713-415c-a29e-4a39a5ac4737", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionInReferenceObjectSpace(PlayerPort target, CombatantPort referenceObject)
        {
            Node node = new Node()
            {Name = "Get Position in Reference Object Space", Type = "72be9974-9713-415c-a29e-4a39a5ac4737", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionInReferenceObjectSpace(PlayerPort target, RecRoomObjectPort referenceObject)
        {
            Node node = new Node()
            {Name = "Get Position in Reference Object Space", Type = "72be9974-9713-415c-a29e-4a39a5ac4737", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetPositionInReferenceObjectSpace(PlayerPort target, PlayerPort referenceObject)
        {
            Node node = new Node()
            {Name = "Get Position in Reference Object Space", Type = "72be9974-9713-415c-a29e-4a39a5ac4737", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort GetRoomAuthority()
        {
            Node node = new Node()
            {Name = "Get Room Authority", Type = "d7557465-963e-4451-a55a-dea2050e9b74", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort GetRotation(RecRoomObjectPort target)
        {
            Node node = new Node()
            {Name = "Get Rotation", Type = "d750b619-1dd8-4099-a1dd-627050cd5d41", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort GetRotation(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Rotation", Type = "d750b619-1dd8-4099-a1dd-627050cd5d41", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort GetRotationDeprecated(RecRoomObjectPort target)
        {
            Node node = new Node()
            {Name = "Get Rotation (Deprecated)", Type = "c453fa47-d0db-4c4a-a6a1-dac4ebad0aca", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort GetRotationDeprecated(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Rotation (Deprecated)", Type = "c453fa47-d0db-4c4a-a6a1-dac4ebad0aca", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort GetRotationInReferenceObjectSpace(RecRoomObjectPort target, RecRoomObjectPort referenceObject)
        {
            Node node = new Node()
            {Name = "Get Rotation in Reference Object Space", Type = "14bf5961-9d94-4ce0-a97a-37f5f382376c", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 1});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort GetRotationInReferenceObjectSpace(RecRoomObjectPort target, PlayerPort referenceObject)
        {
            Node node = new Node()
            {Name = "Get Rotation in Reference Object Space", Type = "14bf5961-9d94-4ce0-a97a-37f5f382376c", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 1});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort GetRotationInReferenceObjectSpace(PlayerPort target, RecRoomObjectPort referenceObject)
        {
            Node node = new Node()
            {Name = "Get Rotation in Reference Object Space", Type = "14bf5961-9d94-4ce0-a97a-37f5f382376c", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 1});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort GetRotationInReferenceObjectSpace(PlayerPort target, PlayerPort referenceObject)
        {
            Node node = new Node()
            {Name = "Get Rotation in Reference Object Space", Type = "14bf5961-9d94-4ce0-a97a-37f5f382376c", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 1});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<StringPort> GetTags(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Tags", Type = "e67cfcb7-03e8-4152-ba41-af8ca61d93fb", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<StringPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<StringPort> GetTags(RecRoomObjectPort target)
        {
            Node node = new Node()
            {Name = "Get Tags", Type = "e67cfcb7-03e8-4152-ba41-af8ca61d93fb", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<StringPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetUpVector(RecRoomObjectPort target)
        {
            Node node = new Node()
            {Name = "Get Up Vector", Type = "824f6801-17b6-4ada-9a97-4f36cef02e8b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetUpVector(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Up Vector", Type = "824f6801-17b6-4ada-9a97-4f36cef02e8b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetUpVectorDeprecated(RecRoomObjectPort target)
        {
            Node node = new Node()
            {Name = "Get Up Vector (Deprecated)", Type = "830f781d-2522-4ec0-9d6f-ecfc0bf695f6", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetUpVectorDeprecated(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Up Vector (Deprecated)", Type = "830f781d-2522-4ec0-9d6f-ecfc0bf695f6", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetVelocity(RecRoomObjectPort target)
        {
            Node node = new Node()
            {Name = "Get Velocity", Type = "0310de62-2ede-4af0-b551-0228290fc54c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetVelocity(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Velocity", Type = "0310de62-2ede-4af0-b551-0228290fc54c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetVelocityDeprecated(RecRoomObjectPort target)
        {
            Node node = new Node()
            {Name = "Get Velocity (Deprecated)", Type = "e9c65fbe-9d0f-4373-bd45-fe620de801b4", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GetVelocityDeprecated(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Get Velocity (Deprecated)", Type = "e9c65fbe-9d0f-4373-bd45-fe620de801b4", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void GoToEvent(PlayerPort player, AnyPort communityEvent)
        {
            Node node = new Node()
            {Name = "Go To Event", Type = "9c9f756e-f972-49a4-bd1d-82225d43b350", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(communityEvent, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GoToRoom(PlayerPort player, DestinationRoomPort destination)
        {
            Node node = new Node()
            {Name = "Go To Room", Type = "bad6a57b-2af8-4526-8caa-e07476da4a5b", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(destination, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GoToState(StatePort state)
        {
            Node node = new Node()
            {Name = "Go To State", Type = "ecf53690-1d60-4971-b057-f601d49975ab", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(state, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static (BoolPort HasHeldObject, RecRoomObjectPort HeldObject) GrabberGetHeldObjectR2(GrabberPort target)
        {
            Node node = new Node()
            {Name = "Grabber Get Held Object", Type = "338a3300-ad0d-40d9-a9a7-ff57f5401905", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new RecRoomObjectPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static BoolPort GrabberGrabObjectR2(GrabberPort target, RecRoomObjectPort @object, BoolPort stealFromPlayer, BoolPort snapToGrabber)
        {
            Node node = new Node()
            {Name = "Grabber Grab Object", Type = "36668004-5384-44df-901e-bd3324675838", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(@object, new Port{Node = node, Index = 2});
            node.ConnectInputPort(stealFromPlayer, new Port{Node = node, Index = 3});
            node.ConnectInputPort(snapToGrabber, new Port{Node = node, Index = 4});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static RecRoomObjectPort GrabberReleaseR2(GrabberPort target)
        {
            Node node = new Node()
            {Name = "Grabber Release", Type = "051648c8-f13b-4e75-b5e0-33fc834485c6", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            var output_ports = new RecRoomObjectPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static void GrabberSetPlayerCanStealFromGrabberR2(GrabberPort target, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Grabber Set Player Can Steal From Grabber", Type = "a02cf9d4-fa6b-41c7-bcbb-262489fa52ad", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort GrantReward(PlayerPort player, RewardPort reward, AlternativeExec<BoolPort> onAwardComplete)
        {
            Node node = new Node()
            {Name = "Grant Reward", Type = "8b38e01f-9c85-47bb-abda-85e354c15d41", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(reward, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            onAwardComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static BoolPort GraphGetIsActive()
        {
            Node node = new Node()
            {Name = "Graph Get Is Active", Type = "539cb9a4-39a4-4932-8f36-b249748cff9e", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GreaterOrEqual(IntPort a, IntPort b)
        {
            Node node = new Node()
            {Name = "Greater or Equal", Type = "f3ced0d8-396e-4311-a807-8ffd9b147060", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GreaterOrEqual(FloatPort a, FloatPort b)
        {
            Node node = new Node()
            {Name = "Greater or Equal", Type = "f3ced0d8-396e-4311-a807-8ffd9b147060", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GreaterOrEqualDeprecated(IntPort a, IntPort b)
        {
            Node node = new Node()
            {Name = "Greater or Equal", Type = "a10e7788-f016-4390-a68e-87d93b47edb1", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GreaterOrEqualDeprecated(FloatPort a, FloatPort b)
        {
            Node node = new Node()
            {Name = "Greater or Equal", Type = "a10e7788-f016-4390-a68e-87d93b47edb1", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GreaterThan(IntPort a, IntPort b)
        {
            Node node = new Node()
            {Name = "Greater Than", Type = "65aa2570-98b8-413b-a9a9-2eae9f562871", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GreaterThan(FloatPort a, FloatPort b)
        {
            Node node = new Node()
            {Name = "Greater Than", Type = "65aa2570-98b8-413b-a9a9-2eae9f562871", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GreaterThanDeprecated(IntPort a, IntPort b)
        {
            Node node = new Node()
            {Name = "Greater Than", Type = "110c29b1-ac90-4a71-b3c0-53372aa134bc", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GreaterThanDeprecated(FloatPort a, FloatPort b)
        {
            Node node = new Node()
            {Name = "Greater Than", Type = "110c29b1-ac90-4a71-b3c0-53372aa134bc", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void GroundVehicleAddBoostFuel(GroundVehiclePort target, IntPort boostAmount)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Add Boost Fuel", Type = "dc78ca9e-29c4-4cba-a6cb-3ea87ffbe780", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(boostAmount, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GroundVehicleApplyBoost(GroundVehiclePort target, AlternativeExec failure)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Apply Boost", Type = "29dd429b-81e5-40c7-b3b6-8d03bcc1eec3", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            failure();
            ExecFlow.current = mainFlow;
            return;
        }

        public static IntPort GroundVehicleGetBoostFuel(GroundVehiclePort target)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Get Boost Fuel", Type = "76d46244-7b8e-43de-bd8c-55375411ffe1", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GroundVehicleGetDrivingEnabled(GroundVehiclePort target)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Get Driving Enabled", Type = "f41ae49a-dbf3-4b4b-87dc-68614da242cc", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort GroundVehicleGetEngineTorqueMultiplier(GroundVehiclePort target)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Get Engine Torque Multiplier", Type = "390257d5-e382-4416-81f7-40562d5473d3", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort GroundVehicleGetSeatedPlayer(GroundVehiclePort target, IntPort seatIndex)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Get Seated Player", Type = "d150c8fa-91fd-4483-a8b5-ca6c62f2c648", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(seatIndex, new Port{Node = node, Index = 1});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort GroundVehicleGetWheelFrictionMultiplier(GroundVehiclePort target)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Get Wheel Friction Multiplier", Type = "0fcc3c15-5ee0-4af9-a4de-94627fbba6ec", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void GroundVehicleSetDrivingEnabled(GroundVehiclePort target, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Set Driving Enabled", Type = "6c7a86cc-2145-404c-b029-31d22f9811e7", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GroundVehicleSetEngineTorqueMultiplier(GroundVehiclePort target, FloatPort torqueMultiplier)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Set Engine Torque Multiplier", Type = "128116c8-591f-44bc-97cd-f787d660cfb5", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(torqueMultiplier, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GroundVehicleSetSeatedPlayer(GroundVehiclePort target, IntPort seatIndex, PlayerPort player, AlternativeExec failure)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Set Seated Player", Type = "50458d97-a7cf-45e3-892b-fb67c0fbe64b", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(seatIndex, new Port{Node = node, Index = 2});
            node.ConnectInputPort(player, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            failure();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void GroundVehicleSetWheelFrictionMultiplier(GroundVehiclePort target, FloatPort frictionMultiplier)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Set Wheel Friction Multiplier", Type = "d00aed86-97ac-4717-872e-ca6646ee266d", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(frictionMultiplier, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GroundVehicleUnseatPlayer(GroundVehiclePort target, PlayerPort player, AlternativeExec failure)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Unseat Player", Type = "5815406b-a3f2-471e-88ec-dffc212293be", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(player, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            failure();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void GroundVehicleUnseatPlayerFromSeat(GroundVehiclePort target, IntPort seatIndex, AlternativeExec failure)
        {
            Node node = new Node()
            {Name = "Ground Vehicle Unseat Player From Seat", Type = "4bb12ec4-780e-4186-a597-36bdc5c67b43", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(seatIndex, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            failure();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void GunHandleAddAutoAimRoleDeprecatedR1(GunHandlePort target, StringPort role)
        {
            Node node = new Node()
            {Name = "Gun Handle Add Auto Aim Role", Type = "5db71859-228a-41d9-8742-99bf9aa1df2a", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(role, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GunHandleApplyRecoil(GunHandlePort target, FloatPort angleX, FloatPort angleY, FloatPort duration, FloatPort returnDuration)
        {
            Node node = new Node()
            {Name = "Gun Handle Apply Recoil", Type = "dca5d998-4ce5-4121-9915-bc4f54df595d", InputCount = 6};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(angleX, new Port{Node = node, Index = 2});
            node.ConnectInputPort(angleY, new Port{Node = node, Index = 3});
            node.ConnectInputPort(duration, new Port{Node = node, Index = 4});
            node.ConnectInputPort(returnDuration, new Port{Node = node, Index = 5});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort GunHandleGetContinuousFire(GunHandlePort target)
        {
            Node node = new Node()
            {Name = "Gun Handle Get Continuous Fire", Type = "bb9b601a-b501-434d-9df7-1b66c393fd8c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort GunHandleGetCurrentAmmo(GunHandlePort target)
        {
            Node node = new Node()
            {Name = "Gun Handle Get Current Ammo", Type = "9e2bb0fe-6179-4ffc-92df-6f3b43bca52d", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port GunHandleGetFiringDirection(GunHandlePort target, RecRoomObjectPort source)
        {
            Node node = new Node()
            {Name = "Gun Handle Get Firing Direction", Type = "1521eb32-29db-4708-81de-71398c29e76d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(source, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GunHandleGetIsReloading(GunHandlePort target)
        {
            Node node = new Node()
            {Name = "Gun Handle Get Is Reloading", Type = "f3ef0346-e593-47c9-85f0-f551efe0a9b6", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort GunHandleGetMaxAmmo(GunHandlePort target)
        {
            Node node = new Node()
            {Name = "Gun Handle Get Max Ammo", Type = "0d6de11b-5487-4e61-9b4b-d6719b3aeb0f", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort GunHandleGetRateOfFire(GunHandlePort target)
        {
            Node node = new Node()
            {Name = "Gun Handle Get Rate Of Fire", Type = "a06ad097-0666-42ff-ab3d-0f00c383e9a1", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort GunHandleGetReloadDuration(GunHandlePort target)
        {
            Node node = new Node()
            {Name = "Gun Handle Get Reload Duration", Type = "ce696294-0c85-4823-8fe3-5fd6a41df2c9", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort GunHandleGetSupportsReload(GunHandlePort target)
        {
            Node node = new Node()
            {Name = "Gun Handle Get Supports Reload", Type = "ec1f7c92-8484-4d00-b820-32726299f67a", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void GunHandleRemoveAutoAimRoleDeprecated(GunHandlePort target, StringPort role)
        {
            Node node = new Node()
            {Name = "Gun Handle Remove Auto Aim Role", Type = "16e9da8d-137b-4b51-bc8c-12b32314363b", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(role, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GunHandleSetADSEnabled(GunHandlePort target, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Gun Handle Set ADS Enabled", Type = "eaab4d32-95ed-4c98-83bd-fa9d99300255", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GunHandleSetAutoAimRolesDeprecated(GunHandlePort target, ListPort<StringPort> roles)
        {
            Node node = new Node()
            {Name = "Gun Handle Set Auto Aim Roles", Type = "e9c22501-3d32-4f9e-a6fb-322bad4eaca1", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(roles, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GunHandleSetContinuousFire(GunHandlePort target, BoolPort continuousFire)
        {
            Node node = new Node()
            {Name = "Gun Handle Set Continuous Fire", Type = "d539bb9a-5e64-43df-a8f9-16839ede0027", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(continuousFire, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GunHandleSetCurrentAmmo(GunHandlePort target, IntPort ammo)
        {
            Node node = new Node()
            {Name = "Gun Handle Set Current Ammo", Type = "75c94e14-2fd9-4097-93c4-ee5b56a27b64", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(ammo, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GunHandleSetMaxAmmo(GunHandlePort target, IntPort maxAmmo)
        {
            Node node = new Node()
            {Name = "Gun Handle Set Max Ammo", Type = "d0ace61e-9d6f-440a-839c-65a3e6aa1e9b", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(maxAmmo, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GunHandleSetRateOfFire(GunHandlePort target, FloatPort rateOfFire)
        {
            Node node = new Node()
            {Name = "Gun Handle Set Rate Of Fire", Type = "0f501beb-e2d2-471b-a8f9-054ac8e006ca", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(rateOfFire, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GunHandleSetReloadDuration(GunHandlePort target, FloatPort reloadDuration)
        {
            Node node = new Node()
            {Name = "Gun Handle Set Reload Duration", Type = "c03abed2-ec9b-494b-89c2-9bbf741d490f", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(reloadDuration, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void GunHandleSetSupportsReload(GunHandlePort target, BoolPort canReload)
        {
            Node node = new Node()
            {Name = "Gun Handle Set Supports Reload", Type = "27566004-ad66-4498-91d9-5e29b1f35d2e", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(canReload, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static StringPort HandleGetControlPrompt(HandlePort target)
        {
            Node node = new Node()
            {Name = "Handle Get Control Prompt", Type = "9af47a88-a066-4923-928d-50a8ff99eaaa", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<StringPort> HandleGetPlayerFilterTagsR2(HandlePort target)
        {
            Node node = new Node()
            {Name = "Handle Get Player Filter Tags", Type = "37545ad5-40c3-49c0-9c32-1c4ccdd27f83", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<StringPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void HandleSetControlPrompt(HandlePort target, StringPort controlPrompt)
        {
            Node node = new Node()
            {Name = "Handle Set Control Prompt", Type = "7900ebde-9abd-4f84-b471-94c69bae2a65", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(controlPrompt, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void HandleSetPlayerFilterTagsR2(HandlePort target, ListPort<StringPort> value)
        {
            Node node = new Node()
            {Name = "Handle Set Player Filter Tags", Type = "fa0d31e8-149d-4554-9994-894cb3d79f3d", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort HasTag(PlayerPort target, StringPort tag)
        {
            Node node = new Node()
            {Name = "Has Tag", Type = "bc3011d2-c085-490e-a450-195ff3a27009", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(tag, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort HasTag(RecRoomObjectPort target, StringPort tag)
        {
            Node node = new Node()
            {Name = "Has Tag", Type = "bc3011d2-c085-490e-a450-195ff3a27009", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(tag, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort HolotarProjectorGetCurrentTime(HolotarProjectorPort target)
        {
            Node node = new Node()
            {Name = "Holotar Projector Get Current Time", Type = "9cf6397d-6e8f-4945-95ac-65ec01530d57", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort HolotarProjectorGetVolume(HolotarProjectorPort target)
        {
            Node node = new Node()
            {Name = "Holotar Projector Get Volume", Type = "973bc740-7e2b-48ac-911d-7eadfdc1833e", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void HolotarProjectorPause(HolotarProjectorPort target)
        {
            Node node = new Node()
            {Name = "Holotar Projector Pause", Type = "8554d9ff-4ac3-4214-872b-4274fe5a8549", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void HolotarProjectorPlay(HolotarProjectorPort target, HolotarRecordingPort holotar)
        {
            Node node = new Node()
            {Name = "Holotar Projector Play", Type = "17fa140e-4112-4362-8d04-16aa2ae95d44", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(holotar, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void HolotarProjectorResume(HolotarProjectorPort target)
        {
            Node node = new Node()
            {Name = "Holotar Projector Resume", Type = "df1624a8-1f41-4ff9-b893-1cf16c2a942d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void HolotarProjectorSetCurrentTime(HolotarProjectorPort target, FloatPort time)
        {
            Node node = new Node()
            {Name = "Holotar Projector Set Current Time", Type = "4529edc7-0fb7-48b0-a685-8600ac73b7df", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(time, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void HolotarProjectorSetVolume(HolotarProjectorPort target, FloatPort volume)
        {
            Node node = new Node()
            {Name = "Holotar Projector Set Volume", Type = "4cc01ea7-d5ce-4877-883a-9492e6e48c9e", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(volume, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void HolotarProjectorStop(HolotarProjectorPort target)
        {
            Node node = new Node()
            {Name = "Holotar Projector Stop", Type = "943fdeaa-a9d8-4ddf-aa21-04bc3f022f58", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static HolotarRecordingPort HolotarRecordingConstant()
        {
            Node node = new Node()
            {Name = "Holotar Recording Constant", Type = "a01d55f9-3a69-4edf-bdfa-20beff06148a", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new HolotarRecordingPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort HolsterObject(PlayerPort player, RecRoomObjectPort objectToHolster, BoolPort forceHolster, BoolPort steal)
        {
            Node node = new Node()
            {Name = "Holster Object", Type = "d619a625-f624-491a-9f53-3bf969f1ae14", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(objectToHolster, new Port{Node = node, Index = 2});
            node.ConnectInputPort(forceHolster, new Port{Node = node, Index = 3});
            node.ConnectInputPort(steal, new Port{Node = node, Index = 4});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static ColorPort HSVToColor(FloatPort hue, FloatPort saturation, FloatPort value)
        {
            Node node = new Node()
            {Name = "HSV To Color", Type = "2e8d2d58-a73d-407a-9892-6cac4cb9ce9a", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(hue, new Port{Node = node, Index = 0});
            node.ConnectInputPort(saturation, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void If(BoolPort condition, AlternativeExec @else)
        {
            Node node = new Node()
            {Name = "If", Type = "7adc6ab1-fcab-4746-aec6-006352e29cdc", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(condition, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            @else();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void IfHasTag(PlayerPort target, StringPort tag, AlternativeExec doesNotHaveTag)
        {
            Node node = new Node()
            {Name = "If Has Tag", Type = "f64272d9-4aca-4170-8dee-bb711d97921c", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(tag, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            doesNotHaveTag();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void IfHasTag(RecRoomObjectPort target, StringPort tag, AlternativeExec doesNotHaveTag)
        {
            Node node = new Node()
            {Name = "If Has Tag", Type = "f64272d9-4aca-4170-8dee-bb711d97921c", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(tag, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            doesNotHaveTag();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void IfLocalPlayerIsAuthority(AlternativeExec imNotAuthority)
        {
            Node node = new Node()
            {Name = "If Local Player Is Authority", Type = "b8b667b9-7b55-4b8d-b116-abef220777e2", InputCount = 1};
            Context.current.AddNode(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            imNotAuthority();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void IfLocalPlayerIsRoomAuthority(AlternativeExec imNotAuthority)
        {
            Node node = new Node()
            {Name = "If Local Player Is Room Authority", Type = "5e28057f-214b-4ff8-81bc-512be207c9d7", InputCount = 1};
            Context.current.AddNode(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            imNotAuthority();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void IfLocalPlayerShouldRun(PlayerPort actingPlayer, AlternativeExec shouldNotRun)
        {
            Node node = new Node()
            {Name = "If Local Player Should Run", Type = "6d69bee8-0d77-4d5f-bf35-9794eaaabe81", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(actingPlayer, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            shouldNotRun();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void IfPlayerHasRoleR1(PlayerPort player, StringPort role, AlternativeExec doesNotHaveRole)
        {
            Node node = new Node()
            {Name = "If Player Has Role", Type = "502d09f5-85ce-45fc-b6a1-3a3eecce8562", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(role, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            doesNotHaveRole();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void IfPlayerIsLocal(PlayerPort player, AlternativeExec isNotLocal)
        {
            Node node = new Node()
            {Name = "If Player Is Local", Type = "c7643011-f320-4155-89b8-d693730c1935", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            isNotLocal();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void IfPlayerIsValid(PlayerPort player, AlternativeExec isNotValid)
        {
            Node node = new Node()
            {Name = "If Player Is Valid", Type = "ec2ceb32-db91-4f65-8b0a-b66d7f2a7f2d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            isNotValid();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void IfPlayerIsValidAndLocal(PlayerPort player, AlternativeExec isNotValid, AlternativeExec isValidAndNotLocal)
        {
            Node node = new Node()
            {Name = "If Player Is Valid And Local", Type = "c1049bfc-902d-4a1a-8b28-1a80b6f26588", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            isNotValid();
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 2});
            isValidAndNotLocal();
            ExecFlow.current = mainFlow;
            return;
        }

        public static T IfValue<T>(BoolPort @if, T then, T @else)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "If Value", Type = "a4f8a9a1-fd7b-4702-8345-93ae4d57f333", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(@if, new Port{Node = node, Index = 0});
            node.ConnectInputPort(then, new Port{Node = node, Index = 1});
            node.ConnectInputPort(@else, new Port{Node = node, Index = 2});
            var output_ports = new T{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void In()
        {
            Node node = new Node()
            {Name = "In", Type = "13e02b88-46f5-4602-9735-8856aeb3eb7b", InputCount = 0};
            Context.current.AddNode(node);
            return;
        }

        public static BoolPort InstanceGetIsEvent()
        {
            Node node = new Node()
            {Name = "Instance Get Is Event", Type = "f24d537e-da9e-47bf-8764-fba6eeefb043", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort InstanceGetIsMultiInstanceEvent()
        {
            Node node = new Node()
            {Name = "Instance Get Is Multi-Instance Event", Type = "bcaa0819-f788-49ed-91d5-767484c48dea", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort InstanceGetIsPrivate()
        {
            Node node = new Node()
            {Name = "Instance Get Is Private", Type = "aa263220-c6aa-4789-b09c-c73d7fa144fd", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort InstanceGetLifetime()
        {
            Node node = new Node()
            {Name = "Instance Get Lifetime", Type = "e05bd0b5-bbcd-46d2-827c-063020bd9f1b", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort InstanceGetMaxPlayers()
        {
            Node node = new Node()
            {Name = "Instance Get Max Players", Type = "af660f62-d086-4731-ab9d-9a8e8a25c77e", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort InteractionVolumeGetHoldTime(InteractionVolumePort target)
        {
            Node node = new Node()
            {Name = "Interaction Volume Get Hold Time", Type = "90e2d8e3-6cdc-4b52-b7e9-529c98e5ee09", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort InteractionVolumeGetInteractionPrompt(InteractionVolumePort target)
        {
            Node node = new Node()
            {Name = "Interaction Volume Get Interaction Prompt", Type = "0c351297-db4d-43e7-81a3-95dc5ddde401", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort InteractionVolumeGetIsLocked(InteractionVolumePort target)
        {
            Node node = new Node()
            {Name = "Interaction Volume Get Is Locked", Type = "c536089c-e2c3-4a6a-a4fa-aba8dca6b810", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort InteractionVolumeGetNormalizedHoldProgress(InteractionVolumePort target)
        {
            Node node = new Node()
            {Name = "Interaction Volume Get Normalized Hold Progress", Type = "4cdfcf23-e5dc-4b81-a500-189dba609d0f", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void InteractionVolumeSetHoldTime(InteractionVolumePort target, FloatPort holdTime)
        {
            Node node = new Node()
            {Name = "Interaction Volume Set Hold Time", Type = "47546f8a-f7b9-4b8a-a4a6-1298f130f65c", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(holdTime, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void InteractionVolumeSetInteractionPrompt(InteractionVolumePort target, StringPort interactionPrompt)
        {
            Node node = new Node()
            {Name = "Interaction Volume Set Interaction Prompt", Type = "380d8467-bdfa-4724-a62c-1955831f994a", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(interactionPrompt, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void InteractionVolumeSetLocked(InteractionVolumePort target, BoolPort locked)
        {
            Node node = new Node()
            {Name = "Interaction Volume Set Locked", Type = "a1e57113-f0b5-45c5-b1e0-95163674daa4", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(locked, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void InteractionVolumeSetNormalizedHoldProgress(InteractionVolumePort target, FloatPort normalizedHoldProgress)
        {
            Node node = new Node()
            {Name = "Interaction Volume Set Normalized Hold Progress", Type = "714654bc-7266-4088-8efe-287bdca164fd", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(normalizedHoldProgress, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort IntToFloat(IntPort value)
        {
            Node node = new Node()
            {Name = "Int to Float", Type = "65cfba8a-b5dc-4946-b824-e6efc5719f3a", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort IntVariable(IntPort port1, VariableData config)
        {
            Node node = new Node()
            {Name = "int Variable", Type = "33224907-68ff-4102-802e-7c3eed481d37", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static (BoolPort Success, IntPort TotalCount) InventoryItemAddR2(InventoryItemPort inventoryItem, PlayerPort player, IntPort quantity, AlternativeExec<(BoolPort Success, IntPort TotalCount)> complete)
        {
            Node node = new Node()
            {Name = "Inventory Item Add", Type = "41d040f2-f8c6-45ec-b6c8-2c31a95e6951", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(inventoryItem, new Port{Node = node, Index = 1});
            node.ConnectInputPort(player, new Port{Node = node, Index = 2});
            node.ConnectInputPort(quantity, new Port{Node = node, Index = 3});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 2}}, new IntPort{Port = new Port{Node = node, Index = 3}});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            complete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static InventoryItemPort InventoryItemConstantR2()
        {
            Node node = new Node()
            {Name = "Inventory Item Constant", Type = "04cc0f81-b7d4-4469-aaa4-428b6e0c1f02", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new InventoryItemPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort InventoryItemGetCountR2(InventoryItemPort inventoryItem, PlayerPort player, AlternativeExec<IntPort> complete)
        {
            Node node = new Node()
            {Name = "Inventory Item Get Count", Type = "2e1cb4fa-a341-40fe-acba-e8621f7c69ca", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(inventoryItem, new Port{Node = node, Index = 1});
            node.ConnectInputPort(player, new Port{Node = node, Index = 2});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            complete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static (StringPort Name, StringPort Description, BoolPort SupportsUseAction, RecNetImagePort Image) InventoryItemGetDefinitionR2(InventoryItemPort inventoryItem)
        {
            Node node = new Node()
            {Name = "Inventory Item Get Definition", Type = "93ad7158-81eb-453c-b3db-222b9630ae0e", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(inventoryItem, new Port{Node = node, Index = 0});
            var output_ports = (new StringPort{Port = new Port{Node = node, Index = 0}}, new StringPort{Port = new Port{Node = node, Index = 1}}, new BoolPort{Port = new Port{Node = node, Index = 2}}, new RecNetImagePort{Port = new Port{Node = node, Index = 3}});
            return output_ports;
        }

        public static RecNetImagePort InventoryItemGetImageR2(InventoryItemPort inventoryItem)
        {
            Node node = new Node()
            {Name = "Inventory Item Get Image", Type = "aaa5f89c-abb4-42ef-a300-6a3acf528ea4", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(inventoryItem, new Port{Node = node, Index = 0});
            var output_ports = new RecNetImagePort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (BoolPort Success, IntPort TotalCount) InventoryItemRemoveR2(InventoryItemPort inventoryItem, PlayerPort player, IntPort quantity, AlternativeExec<(BoolPort Success, IntPort TotalCount)> complete)
        {
            Node node = new Node()
            {Name = "Inventory Item Remove", Type = "736abfd6-5a44-4c74-9fc2-663adf6cbbdf", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(inventoryItem, new Port{Node = node, Index = 1});
            node.ConnectInputPort(player, new Port{Node = node, Index = 2});
            node.ConnectInputPort(quantity, new Port{Node = node, Index = 3});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 2}}, new IntPort{Port = new Port{Node = node, Index = 3}});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            complete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static void InventoryItemUseR2(InventoryItemPort inventoryItem)
        {
            Node node = new Node()
            {Name = "Inventory Item Use", Type = "ead258fa-43c8-4504-b5e5-1dc5bf47c7c7", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(inventoryItem, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort InverseLerp(FloatPort start, FloatPort end, FloatPort value)
        {
            Node node = new Node()
            {Name = "Inverse Lerp", Type = "9d811bd5-2a4a-4368-80ea-635004b6c06b", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(end, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort InverseLerp(ColorPort start, ColorPort end, ColorPort value)
        {
            Node node = new Node()
            {Name = "Inverse Lerp", Type = "9d811bd5-2a4a-4368-80ea-635004b6c06b", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(end, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort InverseLerp(Vector3Port start, Vector3Port end, Vector3Port value)
        {
            Node node = new Node()
            {Name = "Inverse Lerp", Type = "9d811bd5-2a4a-4368-80ea-635004b6c06b", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(end, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort InverseLerpUnclamped(FloatPort start, FloatPort end, FloatPort value)
        {
            Node node = new Node()
            {Name = "Inverse Lerp Unclamped", Type = "d33e7a63-ec6b-40b2-9f81-ab110457a9f2", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(end, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort InverseLerpUnclamped(ColorPort start, ColorPort end, ColorPort value)
        {
            Node node = new Node()
            {Name = "Inverse Lerp Unclamped", Type = "d33e7a63-ec6b-40b2-9f81-ab110457a9f2", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(end, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort InverseLerpUnclamped(Vector3Port start, Vector3Port end, Vector3Port value)
        {
            Node node = new Node()
            {Name = "Inverse Lerp Unclamped", Type = "d33e7a63-ec6b-40b2-9f81-ab110457a9f2", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(end, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort InvisibleCollisionGetBlocksPlayers(InvisibleCollisionPort target)
        {
            Node node = new Node()
            {Name = "Invisible Collision Get Blocks Players", Type = "0938d870-2f6d-4144-ba3d-c73af0e46348", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort InvisibleCollisionGetEnabled(InvisibleCollisionPort target)
        {
            Node node = new Node()
            {Name = "Invisible Collision Get Enabled", Type = "de407f3c-2fb0-4c9a-9dc4-fb6d6709737e", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void InvisibleCollisionSetBlocksPlayers(InvisibleCollisionPort target, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Invisible Collision Set Blocks Players", Type = "ed61effe-a684-4c1a-92c8-79fc6df010fb", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void InvisibleCollisionSetEnabled(InvisibleCollisionPort target, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Invisible Collision Set Enabled", Type = "a5b78c7e-d718-44d4-91c4-7f795bf73814", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort IsValid<T>(T port0)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Is Valid", Type = "24a1be50-ef1b-4e54-836b-4a2a95780b4e", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(port0, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort LaserPointerGetColor(LaserPointerPort target)
        {
            Node node = new Node()
            {Name = "Laser Pointer Get Color", Type = "cb035f05-f3dc-4550-bd64-27cb96bd6be0", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LaserPointerGetEnabled(LaserPointerPort target)
        {
            Node node = new Node()
            {Name = "Laser Pointer Get Enabled", Type = "54fc909a-a864-4e89-be6e-e7f92b7f275a", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort LaserPointerGetLength(LaserPointerPort target)
        {
            Node node = new Node()
            {Name = "Laser Pointer Get Length", Type = "a839c882-9317-4b99-92e6-c3815532b479", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void LaserPointerSetColor(LaserPointerPort target, ColorPort color)
        {
            Node node = new Node()
            {Name = "Laser Pointer Set Color", Type = "1fe56621-d070-43bd-a268-13538b401356", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LaserPointerSetEnabled(LaserPointerPort target, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Laser Pointer Set Enabled", Type = "92c74863-0142-4c4a-b619-199793b75c3b", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LaserPointerSetLength(LaserPointerPort target, FloatPort length)
        {
            Node node = new Node()
            {Name = "Laser Pointer Set Length", Type = "085cb783-a29a-4e0e-93ba-c86b4bff4856", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(length, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static IntPort LeaderboardGetPlayerStat(PlayerPort player, IntPort channel, AlternativeExec<IntPort> onGetStatComplete)
        {
            Node node = new Node()
            {Name = "Leaderboard Get Player Stat", Type = "12cf9781-1e1b-4e59-a783-c7214b66be8a", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(channel, new Port{Node = node, Index = 2});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            onGetStatComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static BoolPort LeaderboardGetProjectorEnabled(LeaderboardProjectorPort target)
        {
            Node node = new Node()
            {Name = "Leaderboard Get Projector Enabled", Type = "17d59d6e-c4c5-48de-b113-d708b740b48d", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void LeaderboardSetLocalPlayerStat(IntPort channel, IntPort value)
        {
            Node node = new Node()
            {Name = "Leaderboard Set Local Player Stat", Type = "57a1553a-ba24-4422-903a-e610a03e7994", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(channel, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LeaderboardSetProjectorEnabled(LeaderboardProjectorPort target, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Leaderboard Set Projector Enabled", Type = "a7b12a2f-2a22-4332-a810-f9497eb91ac4", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort Lerp(FloatPort start, FloatPort end, FloatPort progress)
        {
            Node node = new Node()
            {Name = "Lerp", Type = "91b0ffa8-4eb1-4a30-aaf3-7a049071cb42", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(end, new Port{Node = node, Index = 1});
            node.ConnectInputPort(progress, new Port{Node = node, Index = 2});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort Lerp(QuaternionPort start, QuaternionPort end, FloatPort progress)
        {
            Node node = new Node()
            {Name = "Lerp", Type = "91b0ffa8-4eb1-4a30-aaf3-7a049071cb42", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(end, new Port{Node = node, Index = 1});
            node.ConnectInputPort(progress, new Port{Node = node, Index = 2});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Lerp(Vector3Port start, Vector3Port end, FloatPort progress)
        {
            Node node = new Node()
            {Name = "Lerp", Type = "91b0ffa8-4eb1-4a30-aaf3-7a049071cb42", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(end, new Port{Node = node, Index = 1});
            node.ConnectInputPort(progress, new Port{Node = node, Index = 2});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort Lerp(ColorPort start, ColorPort end, FloatPort progress)
        {
            Node node = new Node()
            {Name = "Lerp", Type = "91b0ffa8-4eb1-4a30-aaf3-7a049071cb42", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(end, new Port{Node = node, Index = 1});
            node.ConnectInputPort(progress, new Port{Node = node, Index = 2});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort LerpUnclamped(FloatPort start, FloatPort end, FloatPort progress)
        {
            Node node = new Node()
            {Name = "Lerp Unclamped", Type = "6e9219ab-89d2-47e3-a105-562a9a1fddda", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(end, new Port{Node = node, Index = 1});
            node.ConnectInputPort(progress, new Port{Node = node, Index = 2});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort LerpUnclamped(QuaternionPort start, QuaternionPort end, FloatPort progress)
        {
            Node node = new Node()
            {Name = "Lerp Unclamped", Type = "6e9219ab-89d2-47e3-a105-562a9a1fddda", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(end, new Port{Node = node, Index = 1});
            node.ConnectInputPort(progress, new Port{Node = node, Index = 2});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port LerpUnclamped(Vector3Port start, Vector3Port end, FloatPort progress)
        {
            Node node = new Node()
            {Name = "Lerp Unclamped", Type = "6e9219ab-89d2-47e3-a105-562a9a1fddda", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(end, new Port{Node = node, Index = 1});
            node.ConnectInputPort(progress, new Port{Node = node, Index = 2});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort LerpUnclamped(ColorPort start, ColorPort end, FloatPort progress)
        {
            Node node = new Node()
            {Name = "Lerp Unclamped", Type = "6e9219ab-89d2-47e3-a105-562a9a1fddda", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(end, new Port{Node = node, Index = 1});
            node.ConnectInputPort(progress, new Port{Node = node, Index = 2});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LessOrEqual(IntPort a, IntPort b)
        {
            Node node = new Node()
            {Name = "Less or Equal", Type = "8c78eedf-f79e-4f70-b187-65092893d1b6", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LessOrEqual(FloatPort a, FloatPort b)
        {
            Node node = new Node()
            {Name = "Less or Equal", Type = "8c78eedf-f79e-4f70-b187-65092893d1b6", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LessOrEqualDeprecated(IntPort a, IntPort b)
        {
            Node node = new Node()
            {Name = "Less or Equal", Type = "a027073f-9189-457f-a53d-8562e8829daf", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LessOrEqualDeprecated(FloatPort a, FloatPort b)
        {
            Node node = new Node()
            {Name = "Less or Equal", Type = "a027073f-9189-457f-a53d-8562e8829daf", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LessThan(IntPort a, IntPort b)
        {
            Node node = new Node()
            {Name = "Less Than", Type = "a05cd0de-609a-4d92-93ad-65b635306233", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LessThan(FloatPort a, FloatPort b)
        {
            Node node = new Node()
            {Name = "Less Than", Type = "a05cd0de-609a-4d92-93ad-65b635306233", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LessThanDeprecated(IntPort a, IntPort b)
        {
            Node node = new Node()
            {Name = "Less Than", Type = "7e58b3f4-2694-4ced-b3a8-0fe23f48f60f", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LessThanDeprecated(FloatPort a, FloatPort b)
        {
            Node node = new Node()
            {Name = "Less Than", Type = "7e58b3f4-2694-4ced-b3a8-0fe23f48f60f", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(a, new Port{Node = node, Index = 0});
            node.ConnectInputPort(b, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort LightGetAngle(LightPort target)
        {
            Node node = new Node()
            {Name = "Light Get Angle", Type = "8a6c0623-7585-402c-8734-7fa7248b15a0", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort LightGetColor(LightPort target)
        {
            Node node = new Node()
            {Name = "Light Get Color", Type = "bc45bb9f-619a-48c4-a3ed-14596c83424f", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LightGetEnabled(LightPort target)
        {
            Node node = new Node()
            {Name = "Light Get Enabled", Type = "d5eafcf1-1762-4ece-bc31-7e2eddac253e", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort LightGetIntensity(LightPort target)
        {
            Node node = new Node()
            {Name = "Light Get Intensity", Type = "67bf3eac-2273-4345-94b3-8288f63f9a0e", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort LightGetRange(LightPort target)
        {
            Node node = new Node()
            {Name = "Light Get Range", Type = "e218e55a-3307-4839-a3d4-b7cc72e1e3bc", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort LightGetSoftness(LightPort target)
        {
            Node node = new Node()
            {Name = "Light Get Softness", Type = "afc674dc-06b5-44fc-9d01-95d8ca56db41", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort LightGetSpecularContribution(LightPort target)
        {
            Node node = new Node()
            {Name = "Light Get Specular Contribution", Type = "b7e74ebc-9ed7-4302-abf1-d2fe42b92a6d", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void LightSetAngle(LightPort target, FloatPort angle)
        {
            Node node = new Node()
            {Name = "Light Set Angle", Type = "494ceaa7-3520-4f5b-87e0-7dd08334730c", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(angle, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightSetAngleDeprecated(LightPort target, IntPort angle)
        {
            Node node = new Node()
            {Name = "Light Set Angle", Type = "873d8765-9dc7-41ea-87ef-dd6e32119af8", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(angle, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightSetColor(LightPort target, ColorPort color)
        {
            Node node = new Node()
            {Name = "Light Set Color", Type = "b2698906-68bd-4ea3-be98-35a23615b522", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightSetColorIdDeprecated(LightPort target, IntPort color)
        {
            Node node = new Node()
            {Name = "Light Set Color Id", Type = "2b6d9368-2ddc-41fb-ac14-b1a3561b19fc", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightSetEnabled(LightPort target, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Light Set Enabled", Type = "e30a20e6-8c98-4c9c-b0bc-bf8b0e11a74f", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightSetIntensity(LightPort target, FloatPort intensity)
        {
            Node node = new Node()
            {Name = "Light Set Intensity", Type = "aa6dc013-3f5b-45f4-87a2-8aa4d16cc375", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(intensity, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightSetIntensityDeprecated(LightPort target, IntPort intensity)
        {
            Node node = new Node()
            {Name = "Light Set Intensity", Type = "902a47c8-3834-4858-bbae-5357281a507d", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(intensity, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightSetRange(LightPort target, FloatPort range)
        {
            Node node = new Node()
            {Name = "Light Set Range", Type = "214bb1b7-f808-4a36-9c10-113045b4fe44", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(range, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightSetRangeDeprecated(LightPort target, IntPort range)
        {
            Node node = new Node()
            {Name = "Light Set Range", Type = "c3d0ef1f-921c-4602-a6eb-b03ed46d556f", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(range, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightSetSoftness(LightPort target, FloatPort softness)
        {
            Node node = new Node()
            {Name = "Light Set Softness", Type = "7876451d-982d-4880-b78b-b3d02389af2c", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(softness, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightSetSpecularContribution(LightPort target, FloatPort specularContribution)
        {
            Node node = new Node()
            {Name = "Light Set Specular Contribution", Type = "723817f6-9562-4f36-b3cc-1c66da5ac3c6", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(specularContribution, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightTurnOff(LightPort target)
        {
            Node node = new Node()
            {Name = "Light Turn Off", Type = "0f96406e-af69-4f6c-a430-c6b004457ef4", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LightTurnOn(LightPort target)
        {
            Node node = new Node()
            {Name = "Light Turn On", Type = "5452c480-62f9-4d4e-b615-0f59e645d8db", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ListAdd<T>(ListPort<T> target, T item)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Add", Type = "f716c3f3-0c7c-42a4-bf55-12b7e1cd9040", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(item, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort ListAddIfNotContains<T>(ListPort<T> target, T item)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Add If Not Contains", Type = "a107765d-643e-4b61-b144-7b8f4712f143", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(item, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort ListAllTrue(ListPort<BoolPort> target)
        {
            Node node = new Node()
            {Name = "List All True", Type = "7d474bd7-ee53-4e6d-a45f-cd64fce1c0dc", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort ListAnyTrue(ListPort<BoolPort> target)
        {
            Node node = new Node()
            {Name = "List Any True", Type = "f9589495-685e-4e14-af2e-5cd45f860021", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<BoolPort> ListBoolVariable(ListPort<BoolPort> port1, VariableData config)
        {
            Node node = new Node()
            {Name = "List<bool> Variable", Type = "e0ef8c83-e5a6-4272-a102-07bfc0a40fd5", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<BoolPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static void ListClear<T>(ListPort<T> list)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Clear", Type = "2314f2f2-979b-4d4a-ab02-fc3e7fdddad6", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(list, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static ListPort<ColorPort> ListColorVariable(ListPort<ColorPort> port1, VariableData config)
        {
            Node node = new Node()
            {Name = "List<Color> Variable", Type = "9216dded-da74-49a7-a327-5750f4809787", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<ColorPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static ListPort<AnyPort> ListCommunityEventVariable(ListPort<AnyPort> port1, VariableData config)
        {
            Node node = new Node()
            {Name = "List<Community Event> Variable", Type = "2be6c6b9-39da-4efd-abfa-c531d91aa641", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<AnyPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static ListPort<T> ListConcat<T>(ListPort<T> list1, ListPort<T> list2)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Concat", Type = "0e2f21e0-bc71-423a-a983-72e27193ca8b", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(list1, new Port{Node = node, Index = 0});
            node.ConnectInputPort(list2, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<T>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort ListContains<T>(ListPort<T> target, T item)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Contains", Type = "73f261e2-d65d-4607-858d-3f4c37c76963", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(item, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<T> ListCopy<T>(ListPort<T> target)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Copy", Type = "b336b889-407a-45c8-ad82-a89f4e033c05", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<T>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static ListPort<T> ListCreate<T>(T item)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Create", Type = "542d3256-0d51-4c33-a2a1-fbc44b7e1f07", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(item, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<T>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<DestinationRoomPort> ListDestinationRoomVariable(ListPort<DestinationRoomPort> port1, VariableData config)
        {
            Node node = new Node()
            {Name = "List<Destination Room> Variable", Type = "fff164aa-d775-4d67-a6b0-d1396cb74161", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<DestinationRoomPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static ListPort<T> ListDistinct<T>(ListPort<T> list)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Distinct", Type = "7f15baa5-f804-4754-9cec-d1fe76a458b1", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(list, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<T>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort ListDivide(ListPort<FloatPort> target)
        {
            Node node = new Node()
            {Name = "List Divide", Type = "7e5af908-533d-4d42-b3c9-0159e2b5fd55", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort ListDivide(ListPort<IntPort> target)
        {
            Node node = new Node()
            {Name = "List Divide", Type = "7e5af908-533d-4d42-b3c9-0159e2b5fd55", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port ListDivide(ListPort<Vector3Port> target)
        {
            Node node = new Node()
            {Name = "List Divide", Type = "7e5af908-533d-4d42-b3c9-0159e2b5fd55", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<T> ListExcept<T>(ListPort<T> value)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Except", Type = "2333a01b-6b6f-43c0-b7c3-ea89df868a10", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<T>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<FloatPort> ListFloatVariable(ListPort<FloatPort> port1, VariableData config)
        {
            Node node = new Node()
            {Name = "List<float> Variable", Type = "9bcd36e6-c293-432a-8d90-f6391fe06c62", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<FloatPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static ListPort<IntPort> ListGetAllIndicesOf<T>(ListPort<T> target, T item)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Get All Indices Of", Type = "09066fc7-c88e-49f2-992c-5ed10f4ee682", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(item, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<IntPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort ListGetCount<T>(ListPort<T> list)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Get Count", Type = "0493204d-9815-49a9-8c87-4dedf5ccf7e8", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(list, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static T ListGetElement<T>(ListPort<T> list, IntPort index)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Get Element", Type = "e8c5082f-0a75-4025-9679-293bc8d72989", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(list, new Port{Node = node, Index = 0});
            node.ConnectInputPort(index, new Port{Node = node, Index = 1});
            var output_ports = new T{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort ListGetFirstIndexOf<T>(ListPort<T> target, T item)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Get First Index Of", Type = "d8926108-6c7d-4c78-8fbd-baac2b210e03", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(item, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void ListInsert<T>(ListPort<T> target, T item, IntPort index)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Insert", Type = "592c8aab-9489-492f-a4aa-1e558e6a8ce7", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(item, new Port{Node = node, Index = 2});
            node.ConnectInputPort(index, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static ListPort<T> ListIntersect<T>(ListPort<T> value)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Intersect", Type = "ddee857a-4be4-47a8-9dd7-782c02d5d1f6", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<T>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<IntPort> ListIntVariable(ListPort<IntPort> port1, VariableData config)
        {
            Node node = new Node()
            {Name = "List<int> Variable", Type = "fe2f9c12-d213-4234-a387-9d2ec1ad7fc1", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<IntPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static FloatPort ListMax(ListPort<FloatPort> target)
        {
            Node node = new Node()
            {Name = "List Max", Type = "47428133-4492-422a-aeab-82c21667543e", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort ListMax(ListPort<IntPort> target)
        {
            Node node = new Node()
            {Name = "List Max", Type = "47428133-4492-422a-aeab-82c21667543e", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort ListMin(ListPort<FloatPort> target)
        {
            Node node = new Node()
            {Name = "List Min", Type = "73e9cc79-66cc-4526-8ed7-87500e208c6b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort ListMin(ListPort<IntPort> target)
        {
            Node node = new Node()
            {Name = "List Min", Type = "73e9cc79-66cc-4526-8ed7-87500e208c6b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort ListMultiply(ListPort<FloatPort> target)
        {
            Node node = new Node()
            {Name = "List Multiply", Type = "585aebe5-5df3-423a-8bc4-66b4e2b8bc5b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort ListMultiply(ListPort<IntPort> target)
        {
            Node node = new Node()
            {Name = "List Multiply", Type = "585aebe5-5df3-423a-8bc4-66b4e2b8bc5b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort ListMultiply(ListPort<QuaternionPort> target)
        {
            Node node = new Node()
            {Name = "List Multiply", Type = "585aebe5-5df3-423a-8bc4-66b4e2b8bc5b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port ListMultiply(ListPort<Vector3Port> target)
        {
            Node node = new Node()
            {Name = "List Multiply", Type = "585aebe5-5df3-423a-8bc4-66b4e2b8bc5b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<ObjectiveMarkerPort> ListObjectiveMarkerVariable(ListPort<ObjectiveMarkerPort> port1, VariableData config)
        {
            Node node = new Node()
            {Name = "List<Objective Marker> Variable", Type = "2aa2fe68-18bf-4f63-9ed9-2fc237b60df9", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<ObjectiveMarkerPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static ListPort<PlayerPort> ListPlayerVariable(ListPort<PlayerPort> port1, VariableData config)
        {
            Node node = new Node()
            {Name = "List<Player> Variable", Type = "32837e14-12de-465f-89dc-ceddb64cdd6c", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<PlayerPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static ListPort<QuaternionPort> ListQuaternionVariable(ListPort<QuaternionPort> port1, VariableData config)
        {
            Node node = new Node()
            {Name = "List<Quaternion> Variable", Type = "e8cfde19-33a4-4826-a032-4b9bd50aa171", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<QuaternionPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static ListPort<RecRoomObjectPort> ListRecRoomObjectVariable(ListPort<RecRoomObjectPort> port1, VariableData config)
        {
            Node node = new Node()
            {Name = "List<Rec Room Object> Variable", Type = "536e376c-087d-4909-9412-3fcee5d6f52b", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<RecRoomObjectPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static void ListRemoveAt<T>(ListPort<T> target, IntPort index)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Remove At", Type = "02774487-d41a-4b59-9aa9-2aeb0aad9e37", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(index, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ListRemoveItemAll<T>(ListPort<T> target, T item)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Remove Item (All)", Type = "370f1016-69e0-4265-a4a2-7841067f1fa7", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(item, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static IntPort ListRemoveItemFirst<T>(ListPort<T> target, T item)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Remove Item (First)", Type = "1657cd3d-6bc5-41d2-b70f-1854f9288ffa", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(item, new Port{Node = node, Index = 2});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static void ListRemoveLast<T>(ListPort<T> target)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Remove Last", Type = "2687fb17-96ea-4106-94d7-be8854cfa978", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static ListPort<RewardPort> ListRewardVariable(ListPort<RewardPort> port1, VariableData config)
        {
            Node node = new Node()
            {Name = "List<Reward> Variable", Type = "40a49ce8-a734-4e3e-bb59-00a4698a942e", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<RewardPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static void ListSetElement<T>(ListPort<T> list, IntPort index, T value)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Set Element", Type = "88daacc5-7652-4d3a-b505-ba256ce3fd9d", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(list, new Port{Node = node, Index = 1});
            node.ConnectInputPort(index, new Port{Node = node, Index = 2});
            node.ConnectInputPort(value, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ListShuffle<T>(ListPort<T> target)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Shuffle", Type = "26a97d16-34e6-48c7-83a3-6cf74c1e4985", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ListSort(ListPort<FloatPort> target, BoolPort ascending)
        {
            Node node = new Node()
            {Name = "List Sort", Type = "cc967d66-b201-464e-bddd-a7cf47124fec", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(ascending, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ListSort(ListPort<IntPort> target, BoolPort ascending)
        {
            Node node = new Node()
            {Name = "List Sort", Type = "cc967d66-b201-464e-bddd-a7cf47124fec", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(ascending, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ListSort(ListPort<StringPort> target, BoolPort ascending)
        {
            Node node = new Node()
            {Name = "List Sort", Type = "cc967d66-b201-464e-bddd-a7cf47124fec", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(ascending, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static ListPort<StringPort> ListStringVariable(ListPort<StringPort> port1, VariableData config)
        {
            Node node = new Node()
            {Name = "List<string> Variable", Type = "94fb596f-6b3f-4981-bc2d-1bb693c45ae6", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<StringPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static FloatPort ListSubtract(ListPort<FloatPort> target)
        {
            Node node = new Node()
            {Name = "List Subtract", Type = "20f069cb-30e5-4df8-8e2f-d91f322a83dd", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort ListSubtract(ListPort<IntPort> target)
        {
            Node node = new Node()
            {Name = "List Subtract", Type = "20f069cb-30e5-4df8-8e2f-d91f322a83dd", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port ListSubtract(ListPort<Vector3Port> target)
        {
            Node node = new Node()
            {Name = "List Subtract", Type = "20f069cb-30e5-4df8-8e2f-d91f322a83dd", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort ListSum(ListPort<FloatPort> target)
        {
            Node node = new Node()
            {Name = "List Sum", Type = "d080c9af-402f-4eb9-91d6-9eee945bf734", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort ListSum(ListPort<IntPort> target)
        {
            Node node = new Node()
            {Name = "List Sum", Type = "d080c9af-402f-4eb9-91d6-9eee945bf734", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port ListSum(ListPort<Vector3Port> target)
        {
            Node node = new Node()
            {Name = "List Sum", Type = "d080c9af-402f-4eb9-91d6-9eee945bf734", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<T> ListUnion<T>(ListPort<T> value)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "List Union", Type = "304c312c-f3bd-460b-b54a-90ba343f2a7c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<T>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<Vector3Port> ListVector3Variable(ListPort<Vector3Port> port1, VariableData config)
        {
            Node node = new Node()
            {Name = "List<Vector3> Variable", Type = "35f84cfc-b10e-451e-832e-c6ad8d99685d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<Vector3Port>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static void LocalPlayerClearPlayerVoiceRolloffOverrideR2(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Local Player Clear Player Voice Rolloff Override", Type = "1e33670b-5362-48d1-8f28-38df16e1b4c5", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocalPlayerDisableInteractionWithTargetPlayer(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Local Player Disable Interaction with Target Player", Type = "f99b0a80-f3a6-4e2d-8101-afe3d9e1008d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocalPlayerEnableInteractionWithTargetPlayer(PlayerPort player, FloatPort requiredHoldDuration, StringPort prompt)
        {
            Node node = new Node()
            {Name = "Local Player Enable Interaction with Target Player", Type = "47455638-8ac9-4b9c-8201-20a12d43d513", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(requiredHoldDuration, new Port{Node = node, Index = 2});
            node.ConnectInputPort(prompt, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static Vector3Port LocalPlayerGazeDirection()
        {
            Node node = new Node()
            {Name = "Local Player Gaze Direction", Type = "6b68c3d8-8e26-43d2-bd6d-37944ae80963", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port LocalPlayerGazeOrigin()
        {
            Node node = new Node()
            {Name = "Local Player Gaze Origin", Type = "44d9ad9e-8f31-4588-903d-1bbe8d3c3b70", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LocalPlayerGetIsThirdPersonActive()
        {
            Node node = new Node()
            {Name = "Local Player Get Is Third Person Active", Type = "d6d17e6f-855e-4f5a-9e33-843a788ce3a0", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (StringPort HeaderText, ColorPort HeaderTextColor, StringPort BodyText, ColorPort BodyTextColor) LocalPlayerGetObjectiveLogContent()
        {
            Node node = new Node()
            {Name = "Local Player Get Objective Log Content", Type = "809ba66c-8877-4d74-ac4b-2d0730a1b576", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = (new StringPort{Port = new Port{Node = node, Index = 0}}, new ColorPort{Port = new Port{Node = node, Index = 1}}, new StringPort{Port = new Port{Node = node, Index = 2}}, new ColorPort{Port = new Port{Node = node, Index = 3}});
            return output_ports;
        }

        public static BoolPort LocalPlayerGetObjectiveLogEnabled()
        {
            Node node = new Node()
            {Name = "Local Player Get Objective Log Enabled", Type = "ab20a5af-2d16-494c-b376-0fb5d2c59258", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LocalPlayerIsUsingController()
        {
            Node node = new Node()
            {Name = "Local Player Is Using Controller", Type = "00b3958e-4f84-42fa-acd8-cdb33dd44f25", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LocalPlayerIsUsingKeyboardAndMouse()
        {
            Node node = new Node()
            {Name = "Local Player Is Using Keyboard And Mouse", Type = "859d380b-573e-4db7-94dd-82729dcc2e39", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LocalPlayerIsUsingTouch()
        {
            Node node = new Node()
            {Name = "Local Player Is Using Touch", Type = "cbe72a5a-4616-4213-b2d7-660c58642bab", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort LocalPlayerIsVR()
        {
            Node node = new Node()
            {Name = "Local Player Is VR", Type = "f9101f3c-5b1d-4edc-b850-83bd72a4b1d4", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void LocalPlayerOverridePlayerVoiceRolloffR2(PlayerPort player, FloatPort voiceRolloffDistance)
        {
            Node node = new Node()
            {Name = "Local Player Override Player Voice Rolloff", Type = "bb4ff641-2267-45e0-9e07-fc480b04f478", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(voiceRolloffDistance, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocalPlayerRequestThirdPerson(BoolPort active)
        {
            Node node = new Node()
            {Name = "Local Player Request Third Person", Type = "039fdbe0-31f2-4743-81ef-aa326b5e410f", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(active, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocalPlayerSetGravityDisabledR2(BoolPort disabled)
        {
            Node node = new Node()
            {Name = "Local Player Set Gravity Disabled", Type = "6f88b273-5be6-4183-a772-902c45f4a5c7", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(disabled, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocalPlayerSetLocomotionVFXEnabledR2(AnyPort sprintWind, AnyPort wallRunWind, AnyPort slideStartWind, AnyPort slideWind, AnyPort slideSparks)
        {
            Node node = new Node()
            {Name = "Local Player Set Locomotion VFX Enabled", Type = "f2604270-0397-40ca-a5a4-b799727eccfd", InputCount = 6};
            Context.current.AddNode(node);
            node.ConnectInputPort(sprintWind, new Port{Node = node, Index = 1});
            node.ConnectInputPort(wallRunWind, new Port{Node = node, Index = 2});
            node.ConnectInputPort(slideStartWind, new Port{Node = node, Index = 3});
            node.ConnectInputPort(slideWind, new Port{Node = node, Index = 4});
            node.ConnectInputPort(slideSparks, new Port{Node = node, Index = 5});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocalPlayerSetObjectiveLogContent(StringPort headerText, ColorPort headerTextColor, StringPort bodyText, ColorPort bodyTextColor)
        {
            Node node = new Node()
            {Name = "Local Player Set Objective Log Content", Type = "a060bad3-3111-4b9d-add3-5e6af3a4a151", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(headerText, new Port{Node = node, Index = 1});
            node.ConnectInputPort(headerTextColor, new Port{Node = node, Index = 2});
            node.ConnectInputPort(bodyText, new Port{Node = node, Index = 3});
            node.ConnectInputPort(bodyTextColor, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocalPlayerSetObjectiveLogEnabled(BoolPort enable)
        {
            Node node = new Node()
            {Name = "Local Player Set Objective Log Enabled", Type = "5013021c-3243-4cc2-bd39-06abddb38c9c", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(enable, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocalPlayerSetPlayerNametagVisibility(PlayerPort player, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Local Player Set Player Nametag Visibility", Type = "a73655df-b37b-4c02-a19a-4eb05ce75a14", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocomotionRequestClamberR2(Vector3Port ledgePosition, Vector3Port wallNormal, RecRoomObjectPort wallObject, BoolPort mantle, FloatPort duration, FloatPort postClamberVelocityMultiplier)
        {
            Node node = new Node()
            {Name = "Locomotion Request Clamber", Type = "b179742a-bdd8-47b5-b439-6cdd5cf9484a", InputCount = 7};
            Context.current.AddNode(node);
            node.ConnectInputPort(ledgePosition, new Port{Node = node, Index = 1});
            node.ConnectInputPort(wallNormal, new Port{Node = node, Index = 2});
            node.ConnectInputPort(wallObject, new Port{Node = node, Index = 3});
            node.ConnectInputPort(mantle, new Port{Node = node, Index = 4});
            node.ConnectInputPort(duration, new Port{Node = node, Index = 5});
            node.ConnectInputPort(postClamberVelocityMultiplier, new Port{Node = node, Index = 6});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocomotionRequestCrouchR2()
        {
            Node node = new Node()
            {Name = "Locomotion Request Crouch", Type = "668d3245-34e3-4619-9881-eb8b49d2d638", InputCount = 1};
            Context.current.AddNode(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocomotionRequestFlyStartR2()
        {
            Node node = new Node()
            {Name = "Locomotion Request Fly Start", Type = "e555862a-7066-4fc3-ba3b-aa19ca7544e1", InputCount = 1};
            Context.current.AddNode(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocomotionRequestFlyStopR2()
        {
            Node node = new Node()
            {Name = "Locomotion Request Fly Stop", Type = "8670bf00-68b5-4d0c-abf3-a073407030ee", InputCount = 1};
            Context.current.AddNode(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocomotionRequestJumpCutoffR2()
        {
            Node node = new Node()
            {Name = "Locomotion Request Jump Cutoff", Type = "584c70a5-5bd1-448c-9dfa-45a0461481ef", InputCount = 1};
            Context.current.AddNode(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocomotionRequestJumpR2(FloatPort maxJumpHeight, Vector3Port direction)
        {
            Node node = new Node()
            {Name = "Locomotion Request Jump", Type = "33149283-60d0-4564-b989-db074573e857", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(maxJumpHeight, new Port{Node = node, Index = 1});
            node.ConnectInputPort(direction, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocomotionRequestProneR2()
        {
            Node node = new Node()
            {Name = "Locomotion Request Prone", Type = "3bff6eb2-3c82-4081-83e8-52032b1e28db", InputCount = 1};
            Context.current.AddNode(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocomotionRequestSlideR2(FloatPort slideSpeed, FloatPort minSlideSpeed, BoolPort slideWithGravity)
        {
            Node node = new Node()
            {Name = "Locomotion Request Slide", Type = "ae507f57-8840-493d-9014-38c6beb19e58", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(slideSpeed, new Port{Node = node, Index = 1});
            node.ConnectInputPort(minSlideSpeed, new Port{Node = node, Index = 2});
            node.ConnectInputPort(slideWithGravity, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocomotionRequestSprintStartR2()
        {
            Node node = new Node()
            {Name = "Locomotion Request Sprint Start", Type = "72e44053-7f7d-44f8-a45e-0d8eab06b13a", InputCount = 1};
            Context.current.AddNode(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocomotionRequestSprintStopR2()
        {
            Node node = new Node()
            {Name = "Locomotion Request Sprint Stop", Type = "804ac85f-1cd7-4da6-b81b-739971cfc387", InputCount = 1};
            Context.current.AddNode(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocomotionRequestStandR2()
        {
            Node node = new Node()
            {Name = "Locomotion Request Stand", Type = "b6169557-e604-47bf-b11b-939f53daf6e9", InputCount = 1};
            Context.current.AddNode(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocomotionRequestSteeringR2(Vector3Port direction, FloatPort normalizedSpeed, FloatPort maxSteeringSpeed, FloatPort accelerationTime)
        {
            Node node = new Node()
            {Name = "Locomotion Request Steering", Type = "0eead8ce-398b-4b0b-b16f-bad7be1bc11b", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(direction, new Port{Node = node, Index = 1});
            node.ConnectInputPort(normalizedSpeed, new Port{Node = node, Index = 2});
            node.ConnectInputPort(maxSteeringSpeed, new Port{Node = node, Index = 3});
            node.ConnectInputPort(accelerationTime, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocomotionRequestWallClimbStartR2()
        {
            Node node = new Node()
            {Name = "Locomotion Request Wall Climb Start", Type = "11d7b8df-d04f-4d5d-b4ec-604d8f363ab6", InputCount = 1};
            Context.current.AddNode(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocomotionRequestWallClimbStopR2()
        {
            Node node = new Node()
            {Name = "Locomotion Request Wall Climb Stop", Type = "78368adb-7593-41b7-b18b-924fcad7d3a5", InputCount = 1};
            Context.current.AddNode(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocomotionRequestWallRunR2(FloatPort gravityMultiplier)
        {
            Node node = new Node()
            {Name = "Locomotion Request Wall Run", Type = "13989690-57a9-432f-b79d-9e8a33c9888b", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(gravityMultiplier, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocomotionRequestWallRunStopR2()
        {
            Node node = new Node()
            {Name = "Locomotion Request Wall Run Stop", Type = "cc6e247e-8bce-481c-b68e-e2449a5cb1fd", InputCount = 1};
            Context.current.AddNode(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void LocomotionSetSteeringInputEnabled(BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Locomotion Set Steering Input Enabled", Type = "c6312c78-80fc-452c-9700-8b2dd67d13e9", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort Logarithm(FloatPort value, FloatPort @base)
        {
            Node node = new Node()
            {Name = "Logarithm", Type = "28a105ab-a947-4493-a51d-ced76a9601ee", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            node.ConnectInputPort(@base, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void LogError(StringPort error)
        {
            Node node = new Node()
            {Name = "Log Error", Type = "5aadca49-47b3-423e-b536-6b41b0acbfde", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(error, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, null);
            return;
        }

        public static void LogString(StringPort text)
        {
            Node node = new Node()
            {Name = "Log String", Type = "4047a8cc-3dcc-4fa8-85a7-41d569b8e547", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(text, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static RRTuplePort<T0, T1> MakeTuple<T0, T1>(T0 item0, T1 item1)
            where T0 : AnyPort, new()
            where T1 : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Make Tuple", Type = "bee72c1d-266b-4ea4-b185-7500618030c6", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(item0, new Port{Node = node, Index = 0});
            node.ConnectInputPort(item1, new Port{Node = node, Index = 1});
            var output_ports = new RRTuplePort<T0, T1>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static IntPort Max(IntPort value)
        {
            Node node = new Node()
            {Name = "Max", Type = "1cb807b1-85e7-4c14-b3ae-5775b7873b7d", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static FloatPort Max(FloatPort value)
        {
            Node node = new Node()
            {Name = "Max", Type = "1cb807b1-85e7-4c14-b3ae-5775b7873b7d", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static IntPort Min(IntPort value)
        {
            Node node = new Node()
            {Name = "Min", Type = "bfb1ad17-5ade-4bd8-9c31-6d4b1e47dae3", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static FloatPort Min(FloatPort value)
        {
            Node node = new Node()
            {Name = "Min", Type = "bfb1ad17-5ade-4bd8-9c31-6d4b1e47dae3", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static IntPort Modulo(IntPort value)
        {
            Node node = new Node()
            {Name = "Modulo", Type = "60da34d9-7e21-4cb6-a279-f083634c2979", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static FloatPort Modulo(FloatPort value)
        {
            Node node = new Node()
            {Name = "Modulo", Type = "60da34d9-7e21-4cb6-a279-f083634c2979", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static IntPort Multiply(IntPort value)
        {
            Node node = new Node()
            {Name = "Multiply", Type = "4738d696-d05a-42ee-a182-7641c429ae06", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static FloatPort Multiply(FloatPort value)
        {
            Node node = new Node()
            {Name = "Multiply", Type = "4738d696-d05a-42ee-a182-7641c429ae06", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static QuaternionPort Multiply(QuaternionPort value)
        {
            Node node = new Node()
            {Name = "Multiply", Type = "4738d696-d05a-42ee-a182-7641c429ae06", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static Vector3Port Multiply(Vector3Port value)
        {
            Node node = new Node()
            {Name = "Multiply", Type = "4738d696-d05a-42ee-a182-7641c429ae06", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static AudioPort MusicConstant()
        {
            Node node = new Node()
            {Name = "Music Constant", Type = "ce3cbe60-7983-4458-b44a-738ea7036155", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new AudioPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort Nand(BoolPort input)
        {
            Node node = new Node()
            {Name = "Nand", Type = "502e86d1-5b3a-4213-97e2-df25836ffcc4", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(input, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort NavMeshCanPathBetween(Vector3Port startPosition, Vector3Port endPosition, FloatPort maxDistance)
        {
            Node node = new Node()
            {Name = "NavMesh Can Path Between", Type = "42a50b22-bc74-4c79-8bd6-00f021f721b0", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(startPosition, new Port{Node = node, Index = 1});
            node.ConnectInputPort(endPosition, new Port{Node = node, Index = 2});
            node.ConnectInputPort(maxDistance, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static (BoolPort IsValid, Vector3Port HitPosition) NavMeshSamplePosition(Vector3Port sourcePosition, FloatPort maxDistance)
        {
            Node node = new Node()
            {Name = "NavMesh Sample Position", Type = "ebacb9b5-adb0-4f5b-94c4-973e89d30a65", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(sourcePosition, new Port{Node = node, Index = 0});
            node.ConnectInputPort(maxDistance, new Port{Node = node, Index = 1});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new Vector3Port{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static FloatPort Noise(Vector3Port point)
        {
            Node node = new Node()
            {Name = "Noise", Type = "06f8732b-b1cb-4b79-815e-5b389c1dd78f", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(point, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort Nor(BoolPort input)
        {
            Node node = new Node()
            {Name = "Nor", Type = "2891bcb4-a6ab-4a2e-a08d-dd2a55f1cf66", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(input, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort Not(BoolPort value)
        {
            Node node = new Node()
            {Name = "Not", Type = "ff551243-beb4-470e-ab48-9d616818d5e4", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort NotEquals<T>(T value, T value1)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Not Equals", Type = "98a46410-ddd1-46b8-a99e-0642f75a0861", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            node.ConnectInputPort(value1, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void ObjectiveMarkerAttachToPlayerOrObject(ObjectiveMarkerPort target, PlayerPort playerOrObject)
        {
            Node node = new Node()
            {Name = "Objective Marker Attach To Player Or Object", Type = "bb7c408a-1fad-4612-a637-0b1a365baa1c", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(playerOrObject, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ObjectiveMarkerAttachToPlayerOrObject(ObjectiveMarkerPort target, RecRoomObjectPort playerOrObject)
        {
            Node node = new Node()
            {Name = "Objective Marker Attach To Player Or Object", Type = "bb7c408a-1fad-4612-a637-0b1a365baa1c", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(playerOrObject, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static ObjectiveMarkerPort ObjectiveMarkerConstant()
        {
            Node node = new Node()
            {Name = "Objective Marker Constant", Type = "9ffb119b-dadc-4e50-af19-9bfd335a34ef", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new ObjectiveMarkerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort ObjectiveMarkerGetColor(ObjectiveMarkerPort target)
        {
            Node node = new Node()
            {Name = "Objective Marker Get Color", Type = "7c9d1838-0b70-4a77-8cec-b67758a9095e", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort ObjectiveMarkerGetCurrentDistance(ObjectiveMarkerPort target)
        {
            Node node = new Node()
            {Name = "Objective Marker Get Current Distance", Type = "a4ab4e75-1031-4f68-9631-ef31f131c708", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort ObjectiveMarkerGetDistanceEnabled(ObjectiveMarkerPort target)
        {
            Node node = new Node()
            {Name = "Objective Marker Get Distance Enabled", Type = "6bca2a96-0f30-438e-89d8-aa77ffce2b1c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort ObjectiveMarkerGetEnabled(ObjectiveMarkerPort target)
        {
            Node node = new Node()
            {Name = "Objective Marker Get Enabled", Type = "67f3297e-f498-4e87-a170-5f42b59b0b3a", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort ObjectiveMarkerGetFadeThreshold(ObjectiveMarkerPort target)
        {
            Node node = new Node()
            {Name = "Objective Marker Get Fade Threshold", Type = "6fe14d02-0382-4f94-a6ef-f3d414015e95", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort ObjectiveMarkerGetLabel(ObjectiveMarkerPort target)
        {
            Node node = new Node()
            {Name = "Objective Marker Get Label", Type = "38569dac-4cbc-487c-9ca6-14e2cc0fbf05", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort ObjectiveMarkerGetLabelEnabled(ObjectiveMarkerPort target)
        {
            Node node = new Node()
            {Name = "Objective Marker Get Label Enabled", Type = "79b28dea-36c7-4c4d-b523-7461667851a2", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port ObjectiveMarkerGetPosition(ObjectiveMarkerPort target)
        {
            Node node = new Node()
            {Name = "Objective Marker Get Position", Type = "0a6b285e-cfb2-4112-88c3-ebe2ba3269a5", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static RecRoomObjectPort ObjectiveMarkerGetTargetObject(ObjectiveMarkerPort target)
        {
            Node node = new Node()
            {Name = "Objective Marker Get Target Object", Type = "0a9761e3-44df-4ede-a1dd-6a8f4eb6a7c1", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort ObjectiveMarkerGetTargetPlayer(ObjectiveMarkerPort target)
        {
            Node node = new Node()
            {Name = "Objective Marker Get Target Player", Type = "f008de51-c5bb-4107-84e8-18a2d5b648bd", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void ObjectiveMarkerSetColor(ObjectiveMarkerPort target, ColorPort color)
        {
            Node node = new Node()
            {Name = "Objective Marker Set Color", Type = "9b701044-a1dc-4d74-830e-f0843b0c7056", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ObjectiveMarkerSetDistanceEnabled(ObjectiveMarkerPort target, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Objective Marker Set Distance Enabled", Type = "891ffa52-7430-4ffd-b26d-d067580eae22", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ObjectiveMarkerSetEnabled(ObjectiveMarkerPort target, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Objective Marker Set Enabled", Type = "8bc5eda2-94f1-4bae-879c-50f246155922", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ObjectiveMarkerSetFadeThreshold(ObjectiveMarkerPort target, FloatPort proximity)
        {
            Node node = new Node()
            {Name = "Objective Marker Set Fade Threshold", Type = "66e3efeb-c1df-45f2-ba9b-c261f938c80f", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(proximity, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ObjectiveMarkerSetLabel(ObjectiveMarkerPort target, StringPort label)
        {
            Node node = new Node()
            {Name = "Objective Marker Set Label", Type = "cc288016-09cf-4371-951c-082bd5adbd37", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(label, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ObjectiveMarkerSetLabelEnabled(ObjectiveMarkerPort target, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Objective Marker Set Label Enabled", Type = "d836b2c6-5cd1-43ac-878e-ea886932031d", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ObjectiveMarkerSetPosition(ObjectiveMarkerPort target, Vector3Port position)
        {
            Node node = new Node()
            {Name = "Objective Marker Set Position", Type = "89599e52-1537-4696-91ea-fca1eb0ba26a", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        internal static BoolPort Or(BoolPort input)
        {
            Node node = new Node()
            {Name = "Or", Type = "b5dcded0-eb2b-468d-a4b9-ffb1054f6214", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(input, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void Out()
        {
            Node node = new Node()
            {Name = "Out", Type = "312d4f26-9928-45d5-912e-67c85012b1d2", InputCount = 0};
            Context.current.AddNode(node);
            return;
        }

        public static ListPort<CollisionDataPort> OverlapBox(Vector3Port center, Vector3Port extents, QuaternionPort orientation, RaycastData config)
        {
            Node node = new Node()
            {Name = "Overlap Box", Type = "5df93bc7-4bb7-44c6-b260-d7b2836436c8", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(center, new Port{Node = node, Index = 1});
            node.ConnectInputPort(extents, new Port{Node = node, Index = 2});
            node.ConnectInputPort(orientation, new Port{Node = node, Index = 3});
            var output_ports = new ListPort<CollisionDataPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.RaycastData = config;
            return output_ports;
        }

        public static ListPort<CollisionDataPort> OverlapSphere(Vector3Port origin, FloatPort radius, RaycastData config)
        {
            Node node = new Node()
            {Name = "Overlap Sphere", Type = "23ce1dae-7585-43af-92c1-9a72fa5d0101", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(origin, new Port{Node = node, Index = 1});
            node.ConnectInputPort(radius, new Port{Node = node, Index = 2});
            var output_ports = new ListPort<CollisionDataPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.RaycastData = config;
            return output_ports;
        }

        public static (BoolPort Result, BoolPort ParseSuccess) ParseBool(StringPort @string)
        {
            Node node = new Node()
            {Name = "Parse Bool", Type = "92c05ebc-1967-49a4-94b5-2d01fe1e6b85", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(@string, new Port{Node = node, Index = 0});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new BoolPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static (ColorPort Result, BoolPort ParseSuccess) ParseColor(StringPort @string)
        {
            Node node = new Node()
            {Name = "Parse Color", Type = "7a36c4b7-fb89-4ddc-a3b2-bff8597f7b17", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(@string, new Port{Node = node, Index = 0});
            var output_ports = (new ColorPort{Port = new Port{Node = node, Index = 0}}, new BoolPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static (FloatPort Result, BoolPort ParseSuccess) ParseFloat(StringPort @string)
        {
            Node node = new Node()
            {Name = "Parse Float", Type = "5e25f40a-2b8c-4327-a89c-7a749838da7d", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(@string, new Port{Node = node, Index = 0});
            var output_ports = (new FloatPort{Port = new Port{Node = node, Index = 0}}, new BoolPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static (IntPort Result, BoolPort ParseSuccess) ParseInt(StringPort @string)
        {
            Node node = new Node()
            {Name = "Parse Int", Type = "00b49995-a322-47a3-a32b-5530f2ba7fed", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(@string, new Port{Node = node, Index = 0});
            var output_ports = (new IntPort{Port = new Port{Node = node, Index = 0}}, new BoolPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static (IntPort UniversalSeconds, BoolPort Success) ParseTime(StringPort time)
        {
            Node node = new Node()
            {Name = "Parse Time", Type = "836b64ad-0fd2-4936-bc1f-d25098df8b1d", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(time, new Port{Node = node, Index = 0});
            var output_ports = (new IntPort{Port = new Port{Node = node, Index = 0}}, new BoolPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static BoolPort PathfinderGetEnableGroundClampingR2(PathfinderPort pathfinder)
        {
            Node node = new Node()
            {Name = "Pathfinder Get Enable Ground Clamping", Type = "04dfa392-1f6d-4f7e-9c84-777846cf9ff8", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(pathfinder, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PathfinderGetMaxAccelerationR2(PathfinderPort pathfinder)
        {
            Node node = new Node()
            {Name = "Pathfinder Get Max Acceleration", Type = "af786307-3e91-4321-af54-6d2da29b070e", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(pathfinder, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PathfinderGetMaxAngularSpeedR2(PathfinderPort pathfinder)
        {
            Node node = new Node()
            {Name = "Pathfinder Get Max Angular Speed", Type = "de4897c7-a9d2-4219-8674-e1714e1fc9ab", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(pathfinder, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PathfinderGetMaxLinearSpeedR2(PathfinderPort pathfinder)
        {
            Node node = new Node()
            {Name = "Pathfinder Get Max Linear Speed", Type = "07dcdde1-97a5-4923-8d75-78a74c942731", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(pathfinder, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (BoolPort IsPathing, BoolPort HasArrived, BoolPort WithinSlowdownDistance) PathfinderGetPathingStateR2(PathfinderPort pathfinder)
        {
            Node node = new Node()
            {Name = "Pathfinder Get Pathing State", Type = "f39decac-fc9d-40fb-ae61-090946d64cfe", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(pathfinder, new Port{Node = node, Index = 0});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new BoolPort{Port = new Port{Node = node, Index = 1}}, new BoolPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (Vector3Port TargetPosition, FloatPort SlowdownDistance, FloatPort ArrivalDistance) PathfinderGetPathingTargetR2(PathfinderPort pathfinder)
        {
            Node node = new Node()
            {Name = "Pathfinder Get Pathing Target", Type = "9665db7b-085a-4453-9121-90e2d084e527", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(pathfinder, new Port{Node = node, Index = 0});
            var output_ports = (new Vector3Port{Port = new Port{Node = node, Index = 0}}, new FloatPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static (BoolPort IsRotating, BoolPort HasArrived) PathfinderGetRotationStateR2(PathfinderPort pathfinder)
        {
            Node node = new Node()
            {Name = "Pathfinder Get Rotation State", Type = "0e2cbe0b-53e5-41ad-807a-b8be7a8fd019", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(pathfinder, new Port{Node = node, Index = 0});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new BoolPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static (Vector3Port TargetDirection, FloatPort SlowdownAngle, FloatPort ArrivalAngle) PathfinderGetRotationTargetR2(PathfinderPort pathfinder)
        {
            Node node = new Node()
            {Name = "Pathfinder Get Rotation Target", Type = "0f6ac53c-d48b-4085-88b2-008a231c9716", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(pathfinder, new Port{Node = node, Index = 0});
            var output_ports = (new Vector3Port{Port = new Port{Node = node, Index = 0}}, new FloatPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static ListPort<StringPort> PathfinderGetTagsToIgnoreR2(PathfinderPort pathfinder)
        {
            Node node = new Node()
            {Name = "Pathfinder Get Tags To Ignore", Type = "11510599-9682-47ff-8218-91a83504275f", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(pathfinder, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<StringPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void PathfinderSetGroundClampingR2(PathfinderPort pathfinder, BoolPort enable)
        {
            Node node = new Node()
            {Name = "Pathfinder Set Ground Clamping", Type = "9806dabd-f9e6-416c-9fe7-e0346de88c49", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(pathfinder, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enable, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PathfinderSetMaxAccelerationR2(PathfinderPort pathfinder, FloatPort maxAcceleration)
        {
            Node node = new Node()
            {Name = "Pathfinder Set Max Acceleration", Type = "c299c80e-2406-456f-9455-bf61008d90a2", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(pathfinder, new Port{Node = node, Index = 1});
            node.ConnectInputPort(maxAcceleration, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PathfinderSetMaxAngularSpeedR2(PathfinderPort pathfinder, FloatPort maxAngularSpeed)
        {
            Node node = new Node()
            {Name = "Pathfinder Set Max Angular Speed", Type = "dea14fad-b6ba-4ce6-ac67-57dfe0f88b39", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(pathfinder, new Port{Node = node, Index = 1});
            node.ConnectInputPort(maxAngularSpeed, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PathfinderSetMaxLinearSpeedR2(PathfinderPort pathfinder, FloatPort maxLinearSpeed)
        {
            Node node = new Node()
            {Name = "Pathfinder Set Max Linear Speed", Type = "5ed82dc3-f83d-457a-9605-dbd3a323754e", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(pathfinder, new Port{Node = node, Index = 1});
            node.ConnectInputPort(maxLinearSpeed, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PathfinderSetTagsToIgnoreR2(PathfinderPort pathfinder, ListPort<StringPort> tagsToIgnore)
        {
            Node node = new Node()
            {Name = "Pathfinder Set Tags To Ignore", Type = "8b3b16ee-7078-4376-b56b-7da679c9ef14", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(pathfinder, new Port{Node = node, Index = 1});
            node.ConnectInputPort(tagsToIgnore, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PathfinderStartPathingToPositionR2(PathfinderPort pathfinder, Vector3Port targetPosition, FloatPort slowdownDistance, FloatPort arrivalDistance)
        {
            Node node = new Node()
            {Name = "Pathfinder Start Pathing to Position", Type = "9eb2c95e-9602-4a0c-a78f-3674e23291ec", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(pathfinder, new Port{Node = node, Index = 1});
            node.ConnectInputPort(targetPosition, new Port{Node = node, Index = 2});
            node.ConnectInputPort(slowdownDistance, new Port{Node = node, Index = 3});
            node.ConnectInputPort(arrivalDistance, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PathfinderStartRotatingToDirectionR2(PathfinderPort pathfinder, Vector3Port targetDirection, FloatPort slowdownAngle, FloatPort arrivalAngle)
        {
            Node node = new Node()
            {Name = "Pathfinder Start Rotating to Direction", Type = "d019ed0f-4fa9-464b-baad-22e5f89f25de", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(pathfinder, new Port{Node = node, Index = 1});
            node.ConnectInputPort(targetDirection, new Port{Node = node, Index = 2});
            node.ConnectInputPort(slowdownAngle, new Port{Node = node, Index = 3});
            node.ConnectInputPort(arrivalAngle, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PathfinderStopPathingR2(PathfinderPort pathfinder)
        {
            Node node = new Node()
            {Name = "Pathfinder Stop Pathing", Type = "03375be5-3c6e-4f11-8f65-3454c37ed9f6", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(pathfinder, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PathfinderStopRotatingR2(PathfinderPort pathfinder)
        {
            Node node = new Node()
            {Name = "Pathfinder Stop Rotating", Type = "4d13671f-026a-4eaa-8871-405c4c79f2b5", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(pathfinder, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort PistonGetAcceleration(PistonPort target)
        {
            Node node = new Node()
            {Name = "Piston Get Acceleration", Type = "5e002bc3-c667-441c-8098-4df2f956de5b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PistonGetDistance(PistonPort target)
        {
            Node node = new Node()
            {Name = "Piston Get Distance", Type = "e503b0e4-d295-48cc-bf95-1f1a8127a009", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PistonGetMaxDistance(PistonPort target)
        {
            Node node = new Node()
            {Name = "Piston Get Max Distance", Type = "bb702e97-9f40-45cb-b35d-3a2193ab6800", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PistonGetSpeed(PistonPort target)
        {
            Node node = new Node()
            {Name = "Piston Get Speed", Type = "1d989cd3-d6ae-4503-b80e-5e630ec3f308", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PistonGetTargetDistance(PistonPort target)
        {
            Node node = new Node()
            {Name = "Piston Get Target Distance", Type = "639a360e-aeb1-4c5d-8bc1-96bfaea8aef2", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void PistonSetAcceleration(PistonPort target, FloatPort value)
        {
            Node node = new Node()
            {Name = "Piston Set Acceleration", Type = "07c316df-cfa1-4ef8-ac3b-d7e9c4795812", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PistonSetDistance(PistonPort target, FloatPort value)
        {
            Node node = new Node()
            {Name = "Piston Set Distance", Type = "283cb154-76e8-4d60-9899-2a50b6e4c093", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PistonSetMaxDistance(PistonPort target, FloatPort value)
        {
            Node node = new Node()
            {Name = "Piston Set Max Distance", Type = "95431866-97f3-43b4-91f3-4bd3574b2b02", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PistonSetSpeed(PistonPort target, FloatPort value)
        {
            Node node = new Node()
            {Name = "Piston Set Speed", Type = "419d2d2f-18f8-4223-b2f7-a7d1450c242c", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PistonSetTargetDistance(PistonPort target, FloatPort value)
        {
            Node node = new Node()
            {Name = "Piston Set Target Distance", Type = "bf25fab6-14ef-4815-a7db-92d99fc627d3", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayAudioAtPosition(AudioPort audio, Vector3Port position, FloatPort volume, FloatPort playbackSpeed, BoolPort is2D, PlayAudioAtPositionData config)
        {
            Node node = new Node()
            {Name = "Play Audio At Position", Type = "9b26c819-856c-4678-a3dc-db070ba492cc", InputCount = 6};
            Context.current.AddNode(node);
            node.ConnectInputPort(audio, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(volume, new Port{Node = node, Index = 3});
            node.ConnectInputPort(playbackSpeed, new Port{Node = node, Index = 4});
            node.ConnectInputPort(is2D, new Port{Node = node, Index = 5});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.PlayAudioAtPositionData = config;
            return;
        }

        public static void PlayerAddAimAssistTag(PlayerPort player, StringPort tag)
        {
            Node node = new Node()
            {Name = "Player Add Aim Assist Tag", Type = "3ac91358-d131-4e01-95e0-a24d309886c1", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(tag, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerAddRoleR1(PlayerPort target, StringPort value)
        {
            Node node = new Node()
            {Name = "Player Add Role", Type = "7b725036-4996-441d-ac54-91ac2c23d6b3", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort PlayerAwardXP(PlayerPort player, IntPort amount, AlternativeExec<BoolPort> onAwardComplete)
        {
            Node node = new Node()
            {Name = "Player Award XP", Type = "beb93f31-9a12-4b47-a9cc-961febb623aa", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(amount, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            onAwardComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static QuaternionPort PlayerBodyOrientation(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Body Orientation", Type = "d5f0503f-eee6-4a2a-811d-33ead7122bd3", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerBodyPosition(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Body Position", Type = "5de67799-3301-48d8-ac08-0b371b418962", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void PlayerClearCurrentSubtitle(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Clear Current Subtitle", Type = "a542e800-22c8-4e0b-ac4d-ea712875a5f8", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerDefinitionBoardEmpty()
        {
            Node node = new Node()
            {Name = "Player Definition Board (Empty)", Type = "4c9e7840-0721-4d1c-b334-167f79d3bf40", InputCount = 0};
            Context.current.AddNode(node);
            return;
        }

        public static BoolPort PlayerEquipInventoryItemR2(PlayerPort player, InventoryItemPort inventoryItem, EquipmentSlotPort inventoryEquipmentSlot, AlternativeExec<BoolPort> onEquipComplete)
        {
            Node node = new Node()
            {Name = "Player Equip Inventory Item", Type = "ad1dc480-3932-482f-9609-ab0b01f234e8", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(inventoryItem, new Port{Node = node, Index = 2});
            node.ConnectInputPort(inventoryEquipmentSlot, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            onEquipComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static ListPort<StringPort> PlayerGetAimAssistTags(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Aim Assist Tags", Type = "5d6461e3-c6e0-40eb-8032-8595b6d9b0dc", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<StringPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static FloatPort PlayerGetAirControlPercentageR2(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Air Control Percentage", Type = "5d432b27-fe6d-49d0-a3cc-f013a4443bb1", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<PlayerPort> PlayerGetAllWithTag(StringPort tag)
        {
            Node node = new Node()
            {Name = "Player Get All with Tag", Type = "8286a047-19a2-4ad0-bdec-833f35adf4f2", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(tag, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<PlayerPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetCanFlyR2(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Can Fly", Type = "b9e436c5-970f-46c4-80a9-d2950a130f01", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetCanTeleportR2(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Can Teleport", Type = "52fcfdc0-5f37-4c4c-892a-f61ba6ebf686", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetCanWallClimbR2(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Can Wall Climb", Type = "71965d1e-aad0-4201-b75b-5e54499896fc", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static CostumePort PlayerGetCostume(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Costume", Type = "c6778471-488c-4bc8-8e05-c322b91e1180", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new CostumePort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetCrouchInputEnabledR2(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Crouch Input Enabled", Type = "974059d8-f0cf-4b33-a467-c3403d56f2a6", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PlayerGetCrouchSpeedR2(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Crouch Speed", Type = "c7e7881d-24aa-4308-af34-386daa6a9e12", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetDominantHandIsRight(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Dominant Hand Is Right", Type = "2cc92be4-ca23-4148-88d6-71cfb9b7fd58", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetEquipmentSlotIsEnabledR2(PlayerPort player, EquipmentSlotPort equipmentSlot)
        {
            Node node = new Node()
            {Name = "Player Get Equipment Slot Is Enabled", Type = "c8470b28-0f2c-4a60-80e5-e6dac582a0ab", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            node.ConnectInputPort(equipmentSlot, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (RecRoomObjectPort DominantHandObject, RecRoomObjectPort OffHandObject, RecRoomObjectPort LeftHipHolsterObject, RecRoomObjectPort RightHipHolsterObject, RecRoomObjectPort ShoulderHolsterObject) PlayerGetEquippedObjects(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Equipped Objects", Type = "f0827a17-7d21-45ba-b302-c2b068bd50ca", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = (new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}}, new RecRoomObjectPort{Port = new Port{Node = node, Index = 1}}, new RecRoomObjectPort{Port = new Port{Node = node, Index = 2}}, new RecRoomObjectPort{Port = new Port{Node = node, Index = 3}}, new RecRoomObjectPort{Port = new Port{Node = node, Index = 4}});
            return output_ports;
        }

        public static PlayerPort PlayerGetFirstWithTag(StringPort tag)
        {
            Node node = new Node()
            {Name = "Player Get First with Tag", Type = "48364320-cb02-41d8-9d8f-50291131dad2", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(tag, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetForceManualSprintR2(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Force Manual Sprint", Type = "7b099bfd-965c-4d78-9e7b-59114bf64dbb", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetForceVirtualHeightModeR2(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Force Virtual Height Mode", Type = "1f8923fe-d4dd-45c8-8161-b69bb4a1704e", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetForceVRWalkR2(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Force VR Walk", Type = "5711c16e-3550-4d35-a549-cfa704b9d556", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetIsAuthorityOf(PlayerPort target, RecRoomObjectPort @object)
        {
            Node node = new Node()
            {Name = "Player Get Is Authority Of", Type = "c35fe6fe-d231-4ee5-80ff-9e69f24eb29e", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(@object, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetIsClambering(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Is Clambering", Type = "fea61975-90b0-4187-b28a-b732a14834c0", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetIsCrouching(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Is Crouching", Type = "97a006a4-10fc-43ab-b222-e1d9b3d09d61", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetIsCustomFootstepAudioActive(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Is Custom Footstep Audio Active", Type = "d5a7f0e5-b0ab-4b6d-82d2-cdecade30009", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetIsFlying(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Is Flying", Type = "ee300d88-e1b7-4af5-b28e-cd983b9492d7", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (BoolPort IsGrounded, FloatPort TimeSinceLastGrounded, RecRoomObjectPort SurfaceObject, Vector3Port SurfaceNormal) PlayerGetIsGrounded(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Is Grounded", Type = "4db35e9d-3a1d-4823-a011-7f94e028a3e7", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new FloatPort{Port = new Port{Node = node, Index = 1}}, new RecRoomObjectPort{Port = new Port{Node = node, Index = 2}}, new Vector3Port{Port = new Port{Node = node, Index = 3}});
            return output_ports;
        }

        public static (BoolPort IsJumpingOrFalling, RecRoomObjectPort ContactSurface) PlayerGetIsJumpingOrFalling(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Is Jumping Or Falling", Type = "a474eca1-e820-4249-a314-fbc0ae223a5f", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new RecRoomObjectPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static BoolPort PlayerGetIsLocal(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Get Is Local", Type = "4646dbed-e616-470e-8e0c-eb446b91838b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetIsProne(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Is Prone", Type = "781ccd7b-a399-47dd-a174-fab918cea059", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetIsRoomContributor(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Get Is Room Contributor", Type = "7ff6c70e-d2df-4a57-980f-7bc8036e6e5d", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetIsRoomHost(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Get Is Room Host", Type = "6f4324c5-4c7a-4243-97d0-58f027996534", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetIsRoomMod(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Get Is Room Mod", Type = "8f9b0921-a92b-4d01-a4d5-a8d2e6fc6ca0", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetIsRoomOwner(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Get Is Room Owner", Type = "58c5cab7-ddf7-4de8-86c8-25f3d3c19d98", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetIsSliding(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Is Sliding", Type = "a6bf14e7-5f67-415e-b1c0-67adc223b01e", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetIsSprinting(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Is Sprinting", Type = "52544269-fc72-4b7e-97eb-23d9b84af1e2", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetIsWallClimbing(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Is Wall Climbing", Type = "2966113d-4046-462d-8fd1-62a5e0492ea6", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetIsWallRunning(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Is WallRunning", Type = "5078db49-c621-4491-af58-3d37973c613c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PlayerGetJumpHeightR2(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Jump Height", Type = "42dbf319-8d57-41d2-921f-f3f707e6ad81", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetJumpInputEnabledR2(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Jump Input Enabled", Type = "e6ec527a-be2e-438d-84f4-f60c4785206c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PlayerGetNormalizedSteeringSpeedDeprecated(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Normalized Steering Speed", Type = "1eb70662-4a75-4120-9713-11dbbeedc740", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerGetPhysicsVelocityR2(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Physics Velocity", Type = "12a87d99-c45a-48e3-b2e5-308ce3e51199", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<PlayerPort> PlayerGetPlayersInRadioChannel(IntPort channel)
        {
            Node node = new Node()
            {Name = "Player Get Players In Radio Channel", Type = "502c4b6c-47b6-4370-a1e0-9cab18b1af35", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(channel, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<PlayerPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static RecNetImagePort PlayerGetProfileImage(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Profile Image", Type = "6fc7e821-99b8-496e-9b42-2a1f088b7ba9", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new RecNetImagePort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PlayerGetProneSpeedR2(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Prone Speed", Type = "4d0f09da-4784-4b35-bf66-cdf818ea1a29", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort PlayerGetRadioChannel(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Radio Channel", Type = "be2f38d2-c6cb-4d9a-b74d-0a664c216a7b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort PlayerGetRoomIndex(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Room Index", Type = "7683e201-29d3-44d4-abb4-d75ef9233faa", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort PlayerGetRoomLevel(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Room Level", Type = "475ba7d2-6031-4ea7-b7b8-11028971e466", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static SeatPort PlayerGetSeat(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Seat", Type = "47038300-2f6d-4876-bbb7-7c2e64fd9364", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new SeatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PlayerGetSlideSpeedR2(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Slide Speed", Type = "87a7028f-cdde-4660-ade6-666509e137f8", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetSprintInputEnabledR2(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Sprint Input Enabled", Type = "0b931a90-b24c-4be8-8503-efeea655c660", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PlayerGetSprintSpeedR2(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Sprint Speed", Type = "345866e8-5b3b-41f1-84b7-e357643be3c7", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerGetSteeringDirection(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Steering Direction", Type = "119718a6-adb8-40b3-9e0c-b48dd5cb9ff3", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetSteeringInputEnabled(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Steering Input Enabled", Type = "1b936400-5666-42f6-8d7e-8f0957efebce", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PlayerGetSteeringSpeed(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Steering Speed", Type = "348bc4c8-3b3b-4c44-8c49-4f782e5c8039", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PlayerGetTeleportDelayR2(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Teleport Delay", Type = "aa63bd19-b0a1-441f-8d69-71591d9007b9", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PlayerGetTeleportDistanceR2(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Teleport Distance", Type = "08b53553-0368-4de9-bb59-57a4e2fdb2b2", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort PlayerGetTimeZone(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Time Zone", Type = "2d675f16-502a-489e-8fed-161935f32c04", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (FloatPort VoiceRolloffDistance, BoolPort HasLocalOverride) PlayerGetVoiceRolloffDistanceR2(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Voice Rolloff Distance", Type = "7dd7ea91-2600-4002-804d-3a88d8b3b8a5", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = (new FloatPort{Port = new Port{Node = node, Index = 0}}, new BoolPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static FloatPort PlayerGetVolume(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Volume", Type = "2045f21f-e117-4bbc-aa5b-547d11e4b1ae", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PlayerGetWalkSpeedR2(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Walk Speed", Type = "9decb308-a5c1-41d6-8d68-cfc96d894505", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerGetWallRunEnabledR2(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get Wall Run Enabled", Type = "ae54528b-eaf4-4247-a49e-29b9acbaf1b5", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort PlayerGetXP(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Get XP", Type = "88a12c40-5a38-4304-be23-36f769c2a4b8", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerHasPurchasedRoomOfferR2(PlayerPort player, RoomOfferPort roomOffer, AlternativeExec<BoolPort> onPlayerHasPurchasedRoomOfferComplete)
        {
            Node node = new Node()
            {Name = "Player Has Purchased Room Offer", Type = "d1261f45-8ee7-4d5e-8916-50c2e511ad84", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(roomOffer, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            onPlayerHasPurchasedRoomOfferComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static BoolPort PlayerHasRoleR1(PlayerPort target, StringPort value)
        {
            Node node = new Node()
            {Name = "Player Has Role", Type = "9b39ed47-e9a5-4f04-b4cd-80f5bbaff2f7", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            node.ConnectInputPort(value, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerHeadForwardVector(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Head Forward Vector", Type = "9fb898a5-f5f2-4d62-be3d-31381279d1d3", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort PlayerHeadHeight(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Head Height", Type = "6278538c-5ea9-4515-ba00-ffc4d5b99c3b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort PlayerHeadOrientation(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Head Orientation", Type = "21ee2f55-0414-4fd6-a915-a2577832d6bd", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerHeadPosition(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Head Position", Type = "2f3571aa-53bf-4f52-b8fe-d1c42eda6081", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerHeadUpVector(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Head Up Vector", Type = "5adbfc46-75b1-4b2f-b072-5531ebb0246b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerHeadVelocity(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Head Velocity", Type = "6577e6e8-8039-4843-aba1-993eb6967326", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerIsHoldingMakerPen(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Is Holding Maker Pen", Type = "554060d7-5631-40a0-8d75-5dca5b2b910b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerIsInParty(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Is In Party", Type = "7e6788b0-08a1-4c76-b591-9c8460bcf925", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerLeftHandFingerDirection(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Left Hand Finger Direction", Type = "6b5c4b0b-be26-4055-b26f-1e5f061c63ca", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerLeftHandPosition(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Left Hand Position", Type = "619b3bc8-bcb9-4812-86f5-f6442cdbb557", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort PlayerLeftHandRotation(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Left Hand Rotation", Type = "17e61429-059f-4b29-b8b8-f0bf3179f580", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerLeftHandThumbDirection(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Left Hand Thumb Direction", Type = "fc2a0141-4997-422c-bdd3-f7ecd7d4c996", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerLeftHandVelocity(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Left Hand Velocity", Type = "2607a0fe-f200-4f29-83ae-446db4b8e8ce", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort PlayerOwnsInventoryItemR2(PlayerPort player, InventoryItemPort inventoryItem, AlternativeExec<BoolPort> complete)
        {
            Node node = new Node()
            {Name = "Player Owns Inventory Item", Type = "68cc97a7-440a-450a-bf7f-b25091629c32", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(inventoryItem, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            complete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static BoolPort PlayerOwnsRoomKeyR1(PlayerPort player, RoomKeyPort roomKey, AlternativeExec<BoolPort> onPlayerOwnsRoomKeyComplete)
        {
            Node node = new Node()
            {Name = "Player Owns Room Key", Type = "e61558a9-0ce4-4dba-ac87-b16e61bcdb23", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(roomKey, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            onPlayerOwnsRoomKeyComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static (BoolPort Success, PlayerPort ReceivingPlayer, StringPort Response, IntPort ResponseIndex) PlayerPromptMultipleChoice(PlayerPort player, StringPort promptTitle, StringPort promptBody, ListPort<StringPort> answerChoices, AlternativeExec<(BoolPort Success, PlayerPort ReceivingPlayer, StringPort Response, IntPort ResponseIndex)> onPromptComplete)
        {
            Node node = new Node()
            {Name = "Player Prompt Multiple Choice", Type = "d376a3c7-67c2-4607-a124-e2b93dc256d8", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(promptTitle, new Port{Node = node, Index = 2});
            node.ConnectInputPort(promptBody, new Port{Node = node, Index = 3});
            node.ConnectInputPort(answerChoices, new Port{Node = node, Index = 4});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 2}}, new PlayerPort{Port = new Port{Node = node, Index = 3}}, new StringPort{Port = new Port{Node = node, Index = 4}}, new IntPort{Port = new Port{Node = node, Index = 5}});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            onPromptComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static (BoolPort Success, PlayerPort ReceivingPlayer, StringPort Response) PlayerPromptText(PlayerPort player, StringPort promptTitle, StringPort promptBody, AlternativeExec<(BoolPort Success, PlayerPort ReceivingPlayer, StringPort Response)> onPromptComplete)
        {
            Node node = new Node()
            {Name = "Player Prompt Text", Type = "da8c6b01-2f4c-4d5b-88b5-293e4682fcc9", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(promptTitle, new Port{Node = node, Index = 2});
            node.ConnectInputPort(promptBody, new Port{Node = node, Index = 3});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 2}}, new PlayerPort{Port = new Port{Node = node, Index = 3}}, new StringPort{Port = new Port{Node = node, Index = 4}});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            onPromptComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static void PlayerRemoveAimAssistTag(PlayerPort player, StringPort tag)
        {
            Node node = new Node()
            {Name = "Player Remove Aim Assist Tag", Type = "03d08e3c-b639-43ca-9443-dee4b160ad0e", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(tag, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerRemoveRoleR1(PlayerPort target, StringPort value)
        {
            Node node = new Node()
            {Name = "Player Remove Role", Type = "89981fe2-2e27-4b92-b8c2-c0159b62bccc", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerResetNameColor(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Player Reset Name Color", Type = "d492a0c8-2f55-428f-8960-60f15258681e", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static Vector3Port PlayerRightHandFingerDirection(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Right Hand Finger Direction", Type = "646ff790-c930-4565-ae38-99a798271a50", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerRightHandPosition(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Right Hand Position", Type = "e9d3330d-c290-41d5-aa37-cc5e43198836", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort PlayerRightHandRotation(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Right Hand Rotation", Type = "0afab661-0870-42bb-9256-891f1a876b3b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerRightHandThumbDirection(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Right Hand Thumb Direction", Type = "86e8581c-ddf9-4302-a06f-c451b5055a98", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port PlayerRightHandVelocity(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Right Hand Velocity", Type = "aba06411-9c8c-477a-bc7f-76ab5605c85d", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void PlayerSetAimAssistTags(PlayerPort player, ListPort<StringPort> tags)
        {
            Node node = new Node()
            {Name = "Player Set Aim Assist Tags", Type = "19883a68-58b5-480e-a5cd-97a526e08fdd", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(tags, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetAirControlPercentageR2(PlayerPort player, FloatPort airControlPercentage)
        {
            Node node = new Node()
            {Name = "Player Set Air Control Percentage", Type = "9fa0e65c-36f4-4c4e-969f-94ff82b35c99", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(airControlPercentage, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetCanFlyR2(PlayerPort player, BoolPort canFly)
        {
            Node node = new Node()
            {Name = "Player Set Can Fly", Type = "c860b9ba-b6ae-43fa-b013-b163a7fb49fe", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(canFly, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetCanTeleportR2(PlayerPort player, BoolPort canTeleport)
        {
            Node node = new Node()
            {Name = "Player Set Can Teleport", Type = "de2df219-9d85-4778-a9a3-255d912596a2", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(canTeleport, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetCanWallClimbR2(PlayerPort player, BoolPort wallClimbEnabled)
        {
            Node node = new Node()
            {Name = "Player Set Can Wall Climb", Type = "4dff30bf-ac85-4295-af6c-b481c8628aec", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(wallClimbEnabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetCrouchInputEnabledR2(PlayerPort player, BoolPort crouchInputEnabled)
        {
            Node node = new Node()
            {Name = "Player Set Crouch Input Enabled", Type = "046d23a2-5f34-40dc-a586-008c7bc391f0", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(crouchInputEnabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetCrouchSpeedR2(PlayerPort player, FloatPort crouchSpeed)
        {
            Node node = new Node()
            {Name = "Player Set Crouch Speed", Type = "0a83ea9a-7796-4f77-940e-1bb6593b1ac2", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(crouchSpeed, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetEquipmentSlotIsEnabledR2(PlayerPort player, EquipmentSlotPort equipmentSlot, BoolPort isEnabled)
        {
            Node node = new Node()
            {Name = "Player Set Equipment Slot Is Enabled", Type = "8557a9c5-2656-4245-ae4e-c04bb6de0cd8", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(equipmentSlot, new Port{Node = node, Index = 2});
            node.ConnectInputPort(isEnabled, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetForceManualSprintR2(PlayerPort player, BoolPort forceManualSprint)
        {
            Node node = new Node()
            {Name = "Player Set Force Manual Sprint", Type = "25663723-fc4c-454f-9d33-d28120163245", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(forceManualSprint, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetForceVirtualHeightModeR2(PlayerPort player, BoolPort forceVirtualHeightMode)
        {
            Node node = new Node()
            {Name = "Player Set Force Virtual Height Mode", Type = "2d73b51d-5703-4a1a-bb80-acc05161e3dc", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(forceVirtualHeightMode, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetForceVRWalkR2(PlayerPort player, BoolPort forceVRWalk)
        {
            Node node = new Node()
            {Name = "Player Set Force VR Walk", Type = "c4fa9164-e585-4813-93f4-b31da5635a8b", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(forceVRWalk, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetJumpHeightR2(PlayerPort player, FloatPort jumpHeight)
        {
            Node node = new Node()
            {Name = "Player Set Jump Height", Type = "5dae4912-b714-4cbe-91ab-c736b517d0d6", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(jumpHeight, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetJumpInputEnabledR2(PlayerPort player, BoolPort jumpInputEnabled)
        {
            Node node = new Node()
            {Name = "Player Set Jump Input Enabled", Type = "d837f992-bcc3-4571-b402-c39a5378e1ee", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(jumpInputEnabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetNameColor(PlayerPort player, ColorPort color)
        {
            Node node = new Node()
            {Name = "Player Set Name Color", Type = "19d7fe7e-99e9-444c-8e4f-12c5237abe90", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetPhysicsVelocityR2(PlayerPort player, Vector3Port physicsVelocity)
        {
            Node node = new Node()
            {Name = "Player Set Physics Velocity", Type = "b57b2efb-7ab5-47c0-808b-ac62651758c6", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(physicsVelocity, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetProneSpeedR2(PlayerPort player, FloatPort proneSpeed)
        {
            Node node = new Node()
            {Name = "Player Set Prone Speed", Type = "f7f503b5-58df-42b2-ab69-3d7f3b0f4a5d", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(proneSpeed, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetRadioChannel(PlayerPort player, IntPort channel)
        {
            Node node = new Node()
            {Name = "Player Set Radio Channel", Type = "231d05ba-8577-4d1e-888d-115e657dd525", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(channel, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetSlideSpeedR2(PlayerPort player, FloatPort slideSpeed)
        {
            Node node = new Node()
            {Name = "Player Set Slide Speed", Type = "e4f3a06c-b997-4186-a4a3-f435713a910b", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(slideSpeed, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetSprintInputEnabledR2(PlayerPort player, BoolPort sprintInputEnabled)
        {
            Node node = new Node()
            {Name = "Player Set Sprint Input Enabled", Type = "68b971bc-30af-44d0-ad2f-50a5bbad1f5e", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(sprintInputEnabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetSprintSpeedR2(PlayerPort player, FloatPort sprintSpeed)
        {
            Node node = new Node()
            {Name = "Player Set Sprint Speed", Type = "23e9efca-876b-4a5f-b813-770b9e77fbd4", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(sprintSpeed, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetSteeringInputEnabledR2(PlayerPort player, BoolPort steeringInputEnabled)
        {
            Node node = new Node()
            {Name = "Player Set Steering Input Enabled", Type = "e5f60f37-b6f5-45a8-9ef6-ea38dd908531", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(steeringInputEnabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetSteeringVelocityR2(PlayerPort player, Vector3Port steeringVelocity)
        {
            Node node = new Node()
            {Name = "Player Set Steering Velocity", Type = "50968d3b-7692-4531-826b-8dbbfd4c38f9", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(steeringVelocity, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetTeleportDelayR2(PlayerPort player, FloatPort teleportDelay)
        {
            Node node = new Node()
            {Name = "Player Set Teleport Delay", Type = "0d489d96-de0f-47c0-a629-ab7b22f18a21", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(teleportDelay, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetTeleportDistanceR2(PlayerPort player, FloatPort teleportDistance)
        {
            Node node = new Node()
            {Name = "Player Set Teleport Distance", Type = "39d0f90b-dc6c-4b8d-b103-f3f01228d08e", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(teleportDistance, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetVoiceRolloffDistanceR2(PlayerPort player, FloatPort voiceRolloffDistance)
        {
            Node node = new Node()
            {Name = "Player Set Voice Rolloff Distance", Type = "7fd128dd-189b-4454-9824-5f482f8f5ce6", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(voiceRolloffDistance, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetWalkSpeedR2(PlayerPort player, FloatPort walkSpeed)
        {
            Node node = new Node()
            {Name = "Player Set Walk Speed", Type = "56454777-7c0d-4d1c-acd2-112d7c7a0e31", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(walkSpeed, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerSetWallRunEnabledR2(PlayerPort player, BoolPort wallRunEnabled)
        {
            Node node = new Node()
            {Name = "Player Set Wall Run Enabled", Type = "8470f76b-a4c5-4b79-9651-5af1b9ed8b78", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(wallRunEnabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void PlayerShowSubtitle(PlayerPort player, StringPort subtitle, FloatPort duration, IntPort priority)
        {
            Node node = new Node()
            {Name = "Player Show Subtitle", Type = "abaae687-e943-4534-bb78-2c8d7e17c425", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(subtitle, new Port{Node = node, Index = 2});
            node.ConnectInputPort(duration, new Port{Node = node, Index = 3});
            node.ConnectInputPort(priority, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static (BoolPort Result, IntPort SecondsUntilEnabled) PlayerSubscribesToRoomOwnerDeprecated(PlayerPort target)
        {
            Node node = new Node()
            {Name = "Player Subscribes To Room Owner", Type = "7e321d9b-4500-4917-9361-a32e1463401c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static BoolPort PlayerUnequipFromSlotR2(PlayerPort player, EquipmentSlotPort equipmentSlot, AlternativeExec<BoolPort> onUnequipComplete)
        {
            Node node = new Node()
            {Name = "Player Unequip From Slot", Type = "a672e48b-931e-48d3-ba8c-34b3f415919c", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(equipmentSlot, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            onUnequipComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static BoolPort PlayerUnequipInventoryItemR2(PlayerPort player, InventoryItemPort inventoryItem, AlternativeExec<BoolPort> onUnequipComplete)
        {
            Node node = new Node()
            {Name = "Player Unequip Inventory Item", Type = "944c8ed8-a0da-465d-95f8-e1b7a850ef2d", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(inventoryItem, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            onUnequipComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static PlayerPort PlayerVariable(PlayerPort port1, VariableData config)
        {
            Node node = new Node()
            {Name = "Player Variable", Type = "ea61960b-3a53-426e-b87c-f0e94dd2c3da", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static PlayerPort PlayerVariableDeprecated(PlayerPort port1, VariableData config)
        {
            Node node = new Node()
            {Name = "Player Variable", Type = "1094590a-ca33-4ca0-8e6b-66d784f4b5d7", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static PlayerWorldUIPort PlayerWorldUI(PlayerWorldUIData config)
        {
            Node node = new Node()
            {Name = "Player World UI", Type = "ff2d1f81-d76c-456f-acf0-af1861822681", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new PlayerWorldUIPort{Port = new Port{Node = node, Index = 0}};
            node.PlayerWorldUIData = config;
            return output_ports;
        }

        public static void PlayHandleHaptics(HandlePort handle, IntPort duration, FloatPort intensity)
        {
            Node node = new Node()
            {Name = "Play Handle Haptics", Type = "da6980ad-92eb-4ce8-a643-291e2bf82bc7", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(handle, new Port{Node = node, Index = 1});
            node.ConnectInputPort(duration, new Port{Node = node, Index = 2});
            node.ConnectInputPort(intensity, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        internal static IntPort Power(IntPort value)
        {
            Node node = new Node()
            {Name = "Power", Type = "288d4e89-ebed-41ed-a522-4c79bd48471a", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static FloatPort Power(FloatPort value)
        {
            Node node = new Node()
            {Name = "Power", Type = "288d4e89-ebed-41ed-a522-4c79bd48471a", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void PrintTextToScreen(TextScreenPort target, StringPort text, ColorPort color)
        {
            Node node = new Node()
            {Name = "Print Text To Screen", Type = "5f9f8c85-8aaa-4c9d-9d9d-4c952053b623", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(text, new Port{Node = node, Index = 2});
            node.ConnectInputPort(color, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ProjectileLauncherFireProjectile(ProjectileLauncherPort target, Vector3Port direction)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Fire Projectile", Type = "27e235ea-7305-4f3e-a426-04a887cbde6d", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(direction, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static PlayerPort ProjectileLauncherGetFiringPlayer(ProjectileLauncherPort target)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Get Firing Player", Type = "9bc9def7-d7c3-4248-ba1c-35116f013768", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort ProjectileLauncherGetProjectileCount(ProjectileLauncherPort target)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Get Projectile Count", Type = "25f4df63-828a-482b-89e5-96e357575dfe", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort ProjectileLauncherGetProjectileLifetime(ProjectileLauncherPort target)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Get Projectile Lifetime", Type = "7af08c60-bd52-4733-9a9a-c22317f28738", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort ProjectileLauncherGetProjectileSpeed(ProjectileLauncherPort target)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Get Projectile Speed", Type = "1803843e-4e3b-4422-ada9-5f8959337ee5", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort ProjectileLauncherGetProjectileSpread(ProjectileLauncherPort target)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Get Projectile Spread", Type = "7c6fcbd2-d306-4824-ae11-73e2c133a7fb", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void ProjectileLauncherSetFiringPlayer(ProjectileLauncherPort target, PlayerPort player)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Set Firing Player", Type = "ebff1459-5eb7-456c-a753-f8267d45f79d", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(player, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ProjectileLauncherSetProjectileCount(ProjectileLauncherPort target, IntPort count)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Set Projectile Count", Type = "28132c36-99ac-405d-807e-aeacbc37a3f1", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(count, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ProjectileLauncherSetProjectileLifetime(ProjectileLauncherPort target, FloatPort lifetime)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Set Projectile Lifetime", Type = "b91d3e3d-7c6b-4fba-9505-66c8afd0245d", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(lifetime, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ProjectileLauncherSetProjectileSpeed(ProjectileLauncherPort target, FloatPort speed)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Set Projectile Speed", Type = "01cf75ba-b056-4226-b646-84fee1b7c9aa", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(speed, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ProjectileLauncherSetProjectileSpread(ProjectileLauncherPort target, FloatPort spread)
        {
            Node node = new Node()
            {Name = "Projectile Launcher Set Projectile Spread", Type = "c01cee87-a81e-4cdb-84c5-d443cfe53bce", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(spread, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static StringPort PromptLocalPlayer(StringPort promptTitle, StringPort prompt, AlternativeExec<StringPort> complete, AlternativeExec<StringPort> failed)
        {
            Node node = new Node()
            {Name = "Prompt Local Player", Type = "46e6b40e-2416-4078-b7dc-a0ecc2c2aa20", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(promptTitle, new Port{Node = node, Index = 1});
            node.ConnectInputPort(prompt, new Port{Node = node, Index = 2});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            complete(output_ports);
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 3});
            failed(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static QuaternionPort QuaternionCreate(FloatPort x, FloatPort y, FloatPort z, FloatPort w)
        {
            Node node = new Node()
            {Name = "Quaternion Create", Type = "cff17d2a-4333-41da-81ac-2825f25bf819", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(x, new Port{Node = node, Index = 0});
            node.ConnectInputPort(y, new Port{Node = node, Index = 1});
            node.ConnectInputPort(z, new Port{Node = node, Index = 2});
            node.ConnectInputPort(w, new Port{Node = node, Index = 3});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort QuaternionCreateAngleAxis(FloatPort angle, Vector3Port axis)
        {
            Node node = new Node()
            {Name = "Quaternion Create Angle Axis", Type = "d9096fb3-50c6-42f9-93bb-fc6df63d86a8", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(angle, new Port{Node = node, Index = 0});
            node.ConnectInputPort(axis, new Port{Node = node, Index = 1});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort QuaternionCreateEulerAngles(Vector3Port angles)
        {
            Node node = new Node()
            {Name = "Quaternion Create Euler Angles", Type = "e320278c-13f0-4fe3-b838-7e671bdd9b49", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(angles, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort QuaternionCreateFromTo(Vector3Port from, Vector3Port to)
        {
            Node node = new Node()
            {Name = "Quaternion Create From To", Type = "1069c5de-c7e3-40e0-bd90-52135873b36d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(from, new Port{Node = node, Index = 0});
            node.ConnectInputPort(to, new Port{Node = node, Index = 1});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort QuaternionCreateLook(Vector3Port forward, Vector3Port upwards)
        {
            Node node = new Node()
            {Name = "Quaternion Create Look", Type = "b28f369d-6758-4afc-80e2-8f09ea1df125", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(forward, new Port{Node = node, Index = 0});
            node.ConnectInputPort(upwards, new Port{Node = node, Index = 1});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort QuaternionDot(QuaternionPort lhs, QuaternionPort rhs)
        {
            Node node = new Node()
            {Name = "Quaternion Dot", Type = "268d931e-172b-48e8-8eb8-8ec2a9614f0d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(lhs, new Port{Node = node, Index = 0});
            node.ConnectInputPort(rhs, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port QuaternionEulerAngles(QuaternionPort value)
        {
            Node node = new Node()
            {Name = "Quaternion Euler Angles", Type = "81048ea5-2778-4816-99c5-1c50faad8a87", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (FloatPort Angle, Vector3Port Axis) QuaternionGetAngleAxis(QuaternionPort quaternion)
        {
            Node node = new Node()
            {Name = "Quaternion Get Angle Axis", Type = "b415c3ce-5f9f-472b-8d70-daeb728b7c2d", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(quaternion, new Port{Node = node, Index = 0});
            var output_ports = (new FloatPort{Port = new Port{Node = node, Index = 0}}, new Vector3Port{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static QuaternionPort QuaternionInverse(QuaternionPort value)
        {
            Node node = new Node()
            {Name = "Quaternion Inverse", Type = "2097bef3-9ed1-4601-ab5d-f620654bd1c4", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort QuaternionNormalize(QuaternionPort value)
        {
            Node node = new Node()
            {Name = "Quaternion Normalize", Type = "8157b896-fce8-45fc-957a-4407f0d6c42a", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort QuaternionRotateTowards(QuaternionPort from, QuaternionPort to, FloatPort maxDegreesDelta)
        {
            Node node = new Node()
            {Name = "Quaternion Rotate Towards", Type = "edfe7cbb-6973-4489-9b7a-75746243dd6d", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(from, new Port{Node = node, Index = 0});
            node.ConnectInputPort(to, new Port{Node = node, Index = 1});
            node.ConnectInputPort(maxDegreesDelta, new Port{Node = node, Index = 2});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (FloatPort X, FloatPort Y, FloatPort Z, FloatPort W) QuaternionSplit(QuaternionPort quaternion)
        {
            Node node = new Node()
            {Name = "Quaternion Split", Type = "1d2a37e1-428e-4385-bc96-4ad5adff0a05", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(quaternion, new Port{Node = node, Index = 0});
            var output_ports = (new FloatPort{Port = new Port{Node = node, Index = 0}}, new FloatPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}}, new FloatPort{Port = new Port{Node = node, Index = 3}});
            return output_ports;
        }

        public static QuaternionPort QuaternionVariable(QuaternionPort port1, VariableData config)
        {
            Node node = new Node()
            {Name = "Quaternion Variable", Type = "18a980ff-9a46-472c-b658-96bf42eb61c2", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static QuickChatTablePort QuickChatTable()
        {
            Node node = new Node()
            {Name = "Quick Chat Table", Type = "ac6e433a-503a-4a18-a591-1fe2a2f276bb", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new QuickChatTablePort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void QuickChatTableSetEnabled(QuickChatTablePort target, PlayerPort player, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Quick Chat Table Set Enabled", Type = "e148e9c2-2fb9-4b80-9996-d07a2b7c0a01", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(player, new Port{Node = node, Index = 2});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort RandomFloat(FloatPort min, FloatPort max)
        {
            Node node = new Node()
            {Name = "Random Float", Type = "4ecbf247-ab14-4f9e-8094-e40a45d283e6", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(min, new Port{Node = node, Index = 1});
            node.ConnectInputPort(max, new Port{Node = node, Index = 2});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static T RandomFromList<T>(ListPort<T> list)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Random From List", Type = "d253cef6-dd99-4357-b98a-e09a0c23bad7", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(list, new Port{Node = node, Index = 1});
            var output_ports = new T{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static T RandomFromListDeprecated<T>(ListPort<T> list)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Random From List (Deprecated)", Type = "0b18cef3-0ea5-4e3c-a0d5-c460f03dbe8c", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(list, new Port{Node = node, Index = 1});
            var output_ports = new T{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static IntPort RandomInt(IntPort min, IntPort max)
        {
            Node node = new Node()
            {Name = "Random Int", Type = "fb2645f0-4042-4ef1-b988-af2f80e651ec", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(min, new Port{Node = node, Index = 1});
            node.ConnectInputPort(max, new Port{Node = node, Index = 2});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static ColorPort RangedWeaponGetColor(RangedWeaponPort target)
        {
            Node node = new Node()
            {Name = "Ranged Weapon Get Color", Type = "7ef41c60-14b9-44fc-b3bf-bc1b22cc55a7", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort RangedWeaponGetHeadDamage(RangedWeaponPort target)
        {
            Node node = new Node()
            {Name = "Ranged Weapon Get Head Damage", Type = "7aa59933-c380-428e-aca9-2de2875cb38d", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort RangedWeaponGetLimbDamage(RangedWeaponPort target)
        {
            Node node = new Node()
            {Name = "Ranged Weapon Get Limb Damage", Type = "ed1f109d-bc85-4e4b-8f15-d33363aed7dd", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort RangedWeaponGetProjectileColor(RangedWeaponPort target)
        {
            Node node = new Node()
            {Name = "Ranged Weapon Get Projectile Color", Type = "29005ae6-2611-4ed3-9bed-e256749b487a", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort RangedWeaponGetRecRoomObjectDamage(RangedWeaponPort target)
        {
            Node node = new Node()
            {Name = "Ranged Weapon Get Rec Room Object Damage", Type = "630823d4-c27f-493e-81a3-ae482448403d", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort RangedWeaponGetTorsoDamage(RangedWeaponPort target)
        {
            Node node = new Node()
            {Name = "Ranged Weapon Get Torso Damage", Type = "0da5a0be-9c01-4fcc-83a4-a660971c8644", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void RangedWeaponSetColor(RangedWeaponPort target, ColorPort color)
        {
            Node node = new Node()
            {Name = "Ranged Weapon Set Color", Type = "06fb7191-217c-4834-8483-e61fa66c4a35", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RangedWeaponSetHeadDamage(RangedWeaponPort target, IntPort damage)
        {
            Node node = new Node()
            {Name = "Ranged Weapon Set Head Damage", Type = "f9eeb1b4-5721-4d30-82d4-3bfdea0b8617", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(damage, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RangedWeaponSetLimbDamage(RangedWeaponPort target, IntPort damage)
        {
            Node node = new Node()
            {Name = "Ranged Weapon Set Limb Damage", Type = "3dd1fa27-a800-4d05-8b47-16ad48311135", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(damage, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RangedWeaponSetProjectileColor(RangedWeaponPort target, ColorPort color)
        {
            Node node = new Node()
            {Name = "Ranged Weapon Set Projectile Color", Type = "3a253a6e-fc0f-4ae2-b669-0418c09fc553", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RangedWeaponSetRecRoomObjectDamage(RangedWeaponPort target, IntPort damage)
        {
            Node node = new Node()
            {Name = "Ranged Weapon Set Rec Room Object Damage", Type = "1fcd6f83-b403-426d-8ded-7064e8790b2d", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(damage, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RangedWeaponSetTorsoDamage(RangedWeaponPort target, IntPort damage)
        {
            Node node = new Node()
            {Name = "Ranged Weapon Set Torso Damage", Type = "531dc709-286e-429c-9d51-537a63d74f76", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(damage, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static (BoolPort Hit, PlayerPort Player, RecRoomObjectPort Object, FloatPort Distance, Vector3Port HitPosition, Vector3Port SurfaceNormal) Raycast(Vector3Port startPosition, Vector3Port direction, FloatPort maxDistance, RaycastData config)
        {
            Node node = new Node()
            {Name = "Raycast", Type = "af203a1f-f3c9-479b-86f0-72224b094179", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(startPosition, new Port{Node = node, Index = 0});
            node.ConnectInputPort(direction, new Port{Node = node, Index = 1});
            node.ConnectInputPort(maxDistance, new Port{Node = node, Index = 2});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new PlayerPort{Port = new Port{Node = node, Index = 1}}, new RecRoomObjectPort{Port = new Port{Node = node, Index = 2}}, new FloatPort{Port = new Port{Node = node, Index = 3}}, new Vector3Port{Port = new Port{Node = node, Index = 4}}, new Vector3Port{Port = new Port{Node = node, Index = 5}});
            node.RaycastData = config;
            return output_ports;
        }

        public static BoolPort RecalculateRoomAuthority()
        {
            Node node = new Node()
            {Name = "Recalculate Room Authority", Type = "d5df73b6-4b92-4867-ab3a-5d308876598b", InputCount = 1};
            Context.current.AddNode(node);
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static ListPort<RecRoomObjectPort> RecRoomObjectGetAllChildrenWithTagR2(RecRoomObjectPort @object, StringPort tag)
        {
            Node node = new Node()
            {Name = "Rec Room Object Get All Children with Tag", Type = "c8ead7ca-2727-4358-b52b-012d56aa707f", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(@object, new Port{Node = node, Index = 0});
            node.ConnectInputPort(tag, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<RecRoomObjectPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<RecRoomObjectPort> RecRoomObjectGetAllWithTag(StringPort tag)
        {
            Node node = new Node()
            {Name = "Rec Room Object Get All with Tag", Type = "02d69553-ae96-4c2d-8477-59ada6a66783", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(tag, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<RecRoomObjectPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<RecRoomObjectPort> RecRoomObjectGetAllWithTagNew(StringPort tag)
        {
            Node node = new Node()
            {Name = "Rec Room Object Get All with Tag (new)", Type = "6404b6b4-3bc4-4bbb-8d2c-058a6834e9e9", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(tag, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<RecRoomObjectPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort RecRoomObjectGetAuthority(RecRoomObjectPort target)
        {
            Node node = new Node()
            {Name = "Rec Room Object Get Authority", Type = "9e51fcdc-87b4-4eee-a7b1-8d6f86a5fa6b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static RecRoomObjectPort RecRoomObjectGetFirstWithTag(StringPort tag)
        {
            Node node = new Node()
            {Name = "Rec Room Object Get First with Tag", Type = "43ff2d3c-c3aa-45bc-a7b7-01587c8a61f6", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(tag, new Port{Node = node, Index = 0});
            var output_ports = new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (BoolPort IsHeld, PlayerPort HolderPlayer) RecRoomObjectGetHolderPlayer(RecRoomObjectPort @object)
        {
            Node node = new Node()
            {Name = "Rec Room Object Get Holder Player", Type = "cd10a7ff-0c35-4b46-abfb-8e2f18397ad5", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(@object, new Port{Node = node, Index = 0});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new PlayerPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static BoolPort RecRoomObjectGetIsLocalPlayerAuthority(RecRoomObjectPort target)
        {
            Node node = new Node()
            {Name = "Rec Room Object Get Is Local Player Authority", Type = "b0497de0-3dd3-470d-a421-8f0d321bfc3e", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (PlayerPort Player, BoolPort CurrentlyHeldOrEquipped) RecRoomObjectGetLastHoldingOrEquippingPlayer(RecRoomObjectPort @object)
        {
            Node node = new Node()
            {Name = "Rec Room Object Get Last Holding Or Equipping Player", Type = "a76a9898-4add-4765-9f5b-f366b586e51c", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(@object, new Port{Node = node, Index = 0});
            var output_ports = (new PlayerPort{Port = new Port{Node = node, Index = 0}}, new BoolPort{Port = new Port{Node = node, Index = 1}});
            return output_ports;
        }

        public static RecRoomObjectPort RecRoomObjectGetRootObject(RecRoomObjectPort targetObject)
        {
            Node node = new Node()
            {Name = "Rec Room Object Get Root Object", Type = "a2e31d7e-b107-49c1-a060-e9c417e8c59d", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(targetObject, new Port{Node = node, Index = 0});
            var output_ports = new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void RecRoomObjectReset(RecRoomObjectPort @object)
        {
            Node node = new Node()
            {Name = "Rec Room Object Reset", Type = "6ba175cf-493a-4790-b916-57259f94cd98", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(@object, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RecRoomObjectSetAuthority(RecRoomObjectPort target, PlayerPort authority)
        {
            Node node = new Node()
            {Name = "Rec Room Object Set Authority", Type = "191f8009-5a2e-4da4-8817-980842a08d48", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(authority, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static RecRoomObjectPort RecRoomObjectVariable(RecRoomObjectPort port1, VariableData config)
        {
            Node node = new Node()
            {Name = "Rec Room Object Variable", Type = "7077d139-9876-495e-9756-58150fef9f3b", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new RecRoomObjectPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static IntPort Remainder(IntPort value)
        {
            Node node = new Node()
            {Name = "Remainder", Type = "fe462e79-9e9f-4234-b594-7b6c0a69329b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Remainder(FloatPort value)
        {
            Node node = new Node()
            {Name = "Remainder", Type = "fe462e79-9e9f-4234-b594-7b6c0a69329b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void RemovePlayerFromRadioChannel(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Remove Player From Radio Channel", Type = "eb605a54-315e-495e-b051-8d113c32ed7c", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RemoveTag(PlayerPort target, StringPort tag)
        {
            Node node = new Node()
            {Name = "Remove Tag", Type = "207c6721-b242-4dc2-857d-ebd1ff7c8624", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(tag, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RemoveTag(RecRoomObjectPort target, StringPort tag)
        {
            Node node = new Node()
            {Name = "Remove Tag", Type = "207c6721-b242-4dc2-857d-ebd1ff7c8624", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(tag, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RemoveTags(PlayerPort target, ListPort<StringPort> tags)
        {
            Node node = new Node()
            {Name = "Remove Tags", Type = "fb368814-daaf-475f-ae08-1d01b9d63b8e", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(tags, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RemoveTags(RecRoomObjectPort target, ListPort<StringPort> tags)
        {
            Node node = new Node()
            {Name = "Remove Tags", Type = "fb368814-daaf-475f-ae08-1d01b9d63b8e", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(tags, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static IntPort ReplicatorGetActiveObjectsCountR2(ReplicatorPort target)
        {
            Node node = new Node()
            {Name = "Replicator Get Active Objects Count", Type = "62566b9c-6f09-46a0-8db9-8c4b895a2b79", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<RecRoomObjectPort> ReplicatorGetActiveObjectsR2(ReplicatorPort target)
        {
            Node node = new Node()
            {Name = "Replicator Get Active Objects", Type = "8cb80c1a-3b88-4fc0-a1ff-8c069a57e726", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<RecRoomObjectPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void ReplicatorReturnObjectR2(RecRoomObjectPort target)
        {
            Node node = new Node()
            {Name = "Replicator Return Object", Type = "c7d598f7-c8ea-4022-b0b3-a23356e71768", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static (RecRoomObjectPort Object, BoolPort Success) ReplicatorSpawnNextObjectR2(ReplicatorPort target, Vector3Port position, QuaternionPort orientation, BoolPort assignToPlayer, PlayerPort player, AlternativeExec<(RecRoomObjectPort Object, BoolPort Success)> onSpawnComplete)
        {
            Node node = new Node()
            {Name = "Replicator Spawn Next Object", Type = "fc467906-eb16-4d6f-9c51-e5bd0fbcd492", InputCount = 6};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(orientation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(assignToPlayer, new Port{Node = node, Index = 4});
            node.ConnectInputPort(player, new Port{Node = node, Index = 5});
            var output_ports = (new RecRoomObjectPort{Port = new Port{Node = node, Index = 2}}, new BoolPort{Port = new Port{Node = node, Index = 3}});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            onSpawnComplete(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static void RequestVelocitySetOverDuration(PlayerPort @object, FloatPort multiplier, Vector3Port velocity, FloatPort duration)
        {
            Node node = new Node()
            {Name = "Request Velocity Set Over Duration", Type = "73a26510-9160-4e68-93dc-da60aa68a514", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(@object, new Port{Node = node, Index = 1});
            node.ConnectInputPort(multiplier, new Port{Node = node, Index = 2});
            node.ConnectInputPort(velocity, new Port{Node = node, Index = 3});
            node.ConnectInputPort(duration, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RequestVelocitySetOverDuration(RecRoomObjectPort @object, FloatPort multiplier, Vector3Port velocity, FloatPort duration)
        {
            Node node = new Node()
            {Name = "Request Velocity Set Over Duration", Type = "73a26510-9160-4e68-93dc-da60aa68a514", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(@object, new Port{Node = node, Index = 1});
            node.ConnectInputPort(multiplier, new Port{Node = node, Index = 2});
            node.ConnectInputPort(velocity, new Port{Node = node, Index = 3});
            node.ConnectInputPort(duration, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static T Reroute<T>(T port0)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Reroute", Type = "f8db4ba2-7380-49a0-a0ba-bcdca11fec96", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(port0, new Port{Node = node, Index = 0});
            var output_ports = new T{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void ResetPlayerWorldUI(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Reset Player World UI", Type = "962aaeb2-b80a-4b5a-9b21-de0917c35a1c", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ResetRoom()
        {
            Node node = new Node()
            {Name = "Reset Room", Type = "e921b08d-10c2-4be4-86fe-b8c7155cb97b", InputCount = 1};
            Context.current.AddNode(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, null);
            return;
        }

        public static BoolPort Respawn(PlayerPort target, Vector3Port position, Vector3Port rotation, FloatPort spawnRadius, BoolPort clearVelocity, BoolPort useRezEffects)
        {
            Node node = new Node()
            {Name = "Respawn", Type = "950368dc-fbdd-4627-a0e3-157fd2955276", InputCount = 7};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(spawnRadius, new Port{Node = node, Index = 4});
            node.ConnectInputPort(clearVelocity, new Port{Node = node, Index = 5});
            node.ConnectInputPort(useRezEffects, new Port{Node = node, Index = 6});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort Respawn(PlayerPort target, Vector3Port position, QuaternionPort rotation, FloatPort spawnRadius, BoolPort clearVelocity, BoolPort useRezEffects)
        {
            Node node = new Node()
            {Name = "Respawn", Type = "950368dc-fbdd-4627-a0e3-157fd2955276", InputCount = 7};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(spawnRadius, new Port{Node = node, Index = 4});
            node.ConnectInputPort(clearVelocity, new Port{Node = node, Index = 5});
            node.ConnectInputPort(useRezEffects, new Port{Node = node, Index = 6});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort Respawn(RecRoomObjectPort target, Vector3Port position, Vector3Port rotation, FloatPort spawnRadius, BoolPort clearVelocity, BoolPort useRezEffects)
        {
            Node node = new Node()
            {Name = "Respawn", Type = "950368dc-fbdd-4627-a0e3-157fd2955276", InputCount = 7};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(spawnRadius, new Port{Node = node, Index = 4});
            node.ConnectInputPort(clearVelocity, new Port{Node = node, Index = 5});
            node.ConnectInputPort(useRezEffects, new Port{Node = node, Index = 6});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort Respawn(RecRoomObjectPort target, Vector3Port position, QuaternionPort rotation, FloatPort spawnRadius, BoolPort clearVelocity, BoolPort useRezEffects)
        {
            Node node = new Node()
            {Name = "Respawn", Type = "950368dc-fbdd-4627-a0e3-157fd2955276", InputCount = 7};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(spawnRadius, new Port{Node = node, Index = 4});
            node.ConnectInputPort(clearVelocity, new Port{Node = node, Index = 5});
            node.ConnectInputPort(useRezEffects, new Port{Node = node, Index = 6});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static void RespawnDeprecated(PlayerPort target, Vector3Port position, Vector3Port rotation, FloatPort spawnRadius, BoolPort clearVelocity, BoolPort useRezEffects, AlternativeExec failed)
        {
            Node node = new Node()
            {Name = "Respawn (Deprecated)", Type = "5898c7f7-cb5d-4344-a194-bd09260b12dd", InputCount = 7};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(spawnRadius, new Port{Node = node, Index = 4});
            node.ConnectInputPort(clearVelocity, new Port{Node = node, Index = 5});
            node.ConnectInputPort(useRezEffects, new Port{Node = node, Index = 6});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            failed();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void RespawnDeprecated(PlayerPort target, Vector3Port position, QuaternionPort rotation, FloatPort spawnRadius, BoolPort clearVelocity, BoolPort useRezEffects, AlternativeExec failed)
        {
            Node node = new Node()
            {Name = "Respawn (Deprecated)", Type = "5898c7f7-cb5d-4344-a194-bd09260b12dd", InputCount = 7};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(spawnRadius, new Port{Node = node, Index = 4});
            node.ConnectInputPort(clearVelocity, new Port{Node = node, Index = 5});
            node.ConnectInputPort(useRezEffects, new Port{Node = node, Index = 6});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            failed();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void RespawnDeprecated(RecRoomObjectPort target, Vector3Port position, Vector3Port rotation, FloatPort spawnRadius, BoolPort clearVelocity, BoolPort useRezEffects, AlternativeExec failed)
        {
            Node node = new Node()
            {Name = "Respawn (Deprecated)", Type = "5898c7f7-cb5d-4344-a194-bd09260b12dd", InputCount = 7};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(spawnRadius, new Port{Node = node, Index = 4});
            node.ConnectInputPort(clearVelocity, new Port{Node = node, Index = 5});
            node.ConnectInputPort(useRezEffects, new Port{Node = node, Index = 6});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            failed();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void RespawnDeprecated(RecRoomObjectPort target, Vector3Port position, QuaternionPort rotation, FloatPort spawnRadius, BoolPort clearVelocity, BoolPort useRezEffects, AlternativeExec failed)
        {
            Node node = new Node()
            {Name = "Respawn (Deprecated)", Type = "5898c7f7-cb5d-4344-a194-bd09260b12dd", InputCount = 7};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(spawnRadius, new Port{Node = node, Index = 4});
            node.ConnectInputPort(clearVelocity, new Port{Node = node, Index = 5});
            node.ConnectInputPort(useRezEffects, new Port{Node = node, Index = 6});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            failed();
            ExecFlow.current = mainFlow;
            return;
        }

        public static BoolPort RespawnPointAddAvoidRoleR1(PlayerSpawnPointV2Port spawnPoint, StringPort role)
        {
            Node node = new Node()
            {Name = "Respawn Point Add Avoid Role", Type = "e9b24d3a-7abc-4e97-99f9-e3d31d2c885c", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(spawnPoint, new Port{Node = node, Index = 1});
            node.ConnectInputPort(role, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static void RespawnPointAddAvoidTag(PlayerSpawnPointV2Port spawnPoint, StringPort tag)
        {
            Node node = new Node()
            {Name = "Respawn Point Add Avoid Tag", Type = "82122e0c-d393-4735-a7ad-2217b09eb73c", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(spawnPoint, new Port{Node = node, Index = 1});
            node.ConnectInputPort(tag, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort RespawnPointAddSpawnRoleR1(PlayerSpawnPointV2Port spawnPoint, StringPort role)
        {
            Node node = new Node()
            {Name = "Respawn Point Add Spawn Role", Type = "83bc6208-b272-46a7-add2-46178a71a9e6", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(spawnPoint, new Port{Node = node, Index = 1});
            node.ConnectInputPort(role, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static void RespawnPointAddSpawnTag(PlayerSpawnPointV2Port spawnPoint, StringPort tag)
        {
            Node node = new Node()
            {Name = "Respawn Point Add Spawn Tag", Type = "3e936c68-9fbf-4ace-89a3-68156859db19", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(spawnPoint, new Port{Node = node, Index = 1});
            node.ConnectInputPort(tag, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort RespawnPointGetActive(PlayerSpawnPointV2Port target)
        {
            Node node = new Node()
            {Name = "Respawn Point Get Active", Type = "49bab5c6-d519-4af5-a5ee-466798e3e8bd", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void RespawnPointRemoveAvoidRoleR1(PlayerSpawnPointV2Port spawnPoint, StringPort role)
        {
            Node node = new Node()
            {Name = "Respawn Point Remove Avoid Role", Type = "c1405f55-4980-40cb-9607-daf53073a79e", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(spawnPoint, new Port{Node = node, Index = 1});
            node.ConnectInputPort(role, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RespawnPointRemoveAvoidTag(PlayerSpawnPointV2Port spawnPoint, StringPort tag)
        {
            Node node = new Node()
            {Name = "Respawn Point Remove Avoid Tag", Type = "1a6a4fc0-6e4a-4768-abea-a71c10ffa612", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(spawnPoint, new Port{Node = node, Index = 1});
            node.ConnectInputPort(tag, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RespawnPointRemoveSpawnRoleR1(PlayerSpawnPointV2Port spawnPoint, StringPort role)
        {
            Node node = new Node()
            {Name = "Respawn Point Remove Spawn Role", Type = "22b02578-a084-42ac-a27f-72a1fcb7cd63", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(spawnPoint, new Port{Node = node, Index = 1});
            node.ConnectInputPort(role, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RespawnPointRemoveSpawnTag(PlayerSpawnPointV2Port spawnPoint, StringPort tag)
        {
            Node node = new Node()
            {Name = "Respawn Point Remove Spawn Tag", Type = "99cb7522-13a7-4aec-9166-dc0497057bbb", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(spawnPoint, new Port{Node = node, Index = 1});
            node.ConnectInputPort(tag, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RespawnPointRespawnPlayer(PlayerPort player, BoolPort clearVelocity, BoolPort useRezEffects)
        {
            Node node = new Node()
            {Name = "Respawn Point Respawn Player", Type = "350cda38-d7c5-4319-bb15-a06f49bbb0b9", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(clearVelocity, new Port{Node = node, Index = 2});
            node.ConnectInputPort(useRezEffects, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RespawnPointRespawnPlayerAtRespawnPoint(PlayerSpawnPointV2Port spawnPoint, PlayerPort player, BoolPort clearVelocity, BoolPort useRezEffects)
        {
            Node node = new Node()
            {Name = "Respawn Point Respawn Player At Respawn Point", Type = "c52419da-019e-4104-95e3-0f0adfa8ebf2", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(spawnPoint, new Port{Node = node, Index = 1});
            node.ConnectInputPort(player, new Port{Node = node, Index = 2});
            node.ConnectInputPort(clearVelocity, new Port{Node = node, Index = 3});
            node.ConnectInputPort(useRezEffects, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RespawnPointSetActive(PlayerSpawnPointV2Port target, BoolPort active)
        {
            Node node = new Node()
            {Name = "Respawn Point Set Active", Type = "bf3275dc-686f-4a63-87b7-5422a70cc4d2", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(active, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static RewardPort Reward()
        {
            Node node = new Node()
            {Name = "Reward", Type = "7f246785-9c56-4896-a1f4-f011988dcd32", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new RewardPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort RGBToColor(FloatPort red, FloatPort green, FloatPort blue)
        {
            Node node = new Node()
            {Name = "RGB To Color", Type = "c38b908d-df40-4bd0-bf8b-38afe6cbe9e2", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(red, new Port{Node = node, Index = 0});
            node.ConnectInputPort(green, new Port{Node = node, Index = 1});
            node.ConnectInputPort(blue, new Port{Node = node, Index = 2});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void RoomBackgroundObjectsClearPlayerOverrideR2(PlayerPort player, FloatPort blendTime, AlternativeExec blendFinished)
        {
            Node node = new Node()
            {Name = "Room Background Objects Clear Player Override", Type = "b890f7ef-5126-401c-8d66-794e9b1bc2a5", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(blendTime, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static BoolPort RoomBackgroundObjectsModifyR1(BackgroundObjectsPort backgroundObjectsConstant, AlternativeExec<BoolPort> blendFinished)
        {
            Node node = new Node()
            {Name = "Room Background Objects Modify", Type = "f16741ca-778f-44de-99e6-6a948c7aecfb", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(backgroundObjectsConstant, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static void RoomBackgroundObjectsModifyR2(BackgroundObjectsPort backgroundObjects, FloatPort blendTime, AlternativeExec blendFinished)
        {
            Node node = new Node()
            {Name = "Room Background Objects Modify", Type = "79b90cab-14e3-4a90-8975-163506809c7e", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(backgroundObjects, new Port{Node = node, Index = 1});
            node.ConnectInputPort(blendTime, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void RoomBackgroundObjectsPlayerOverrideR2(BackgroundObjectsPort backgroundObjects, PlayerPort player, FloatPort blendTime, AlternativeExec blendFinished)
        {
            Node node = new Node()
            {Name = "Room Background Objects Player Override", Type = "8ee487c2-9351-4f3b-9497-1e633d606f20", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(backgroundObjects, new Port{Node = node, Index = 1});
            node.ConnectInputPort(player, new Port{Node = node, Index = 2});
            node.ConnectInputPort(blendTime, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void RoomBackgroundObjectsResetR1(AlternativeExec blendFinished)
        {
            Node node = new Node()
            {Name = "Room Background Objects Reset", Type = "56c10ead-6198-4b13-b6de-d1df9080341b", InputCount = 1};
            Context.current.AddNode(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void RoomBackgroundObjectsResetR2(FloatPort blendTime, AlternativeExec blendFinished)
        {
            Node node = new Node()
            {Name = "Room Background Objects Reset", Type = "71b85a8d-cda7-481f-a795-156bd8318d95", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(blendTime, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static RoomCurrencyPort RoomCurrencyConstantR1(RoomCurrencyData config)
        {
            Node node = new Node()
            {Name = "Room Currency Constant", Type = "7e843432-afde-41c1-9bc1-194112d91226", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new RoomCurrencyPort{Port = new Port{Node = node, Index = 0}};
            node.RoomCurrencyData = config;
            return output_ports;
        }

        public static void RoomFogClearPlayerOverrideR2(PlayerPort player, FloatPort blendTime, AlternativeExec blendFinished)
        {
            Node node = new Node()
            {Name = "Room Fog Clear Player Override", Type = "415b92fb-53a3-4036-97ee-75146dcfd637", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(blendTime, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static BoolPort RoomFogModifyR1(FogPort fogConstant, AlternativeExec<BoolPort> blendFinished)
        {
            Node node = new Node()
            {Name = "Room Fog Modify", Type = "471f7cf9-a4e4-4162-a6e9-d594b6ec28ef", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(fogConstant, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static void RoomFogModifyR2(FogPort fog, FloatPort blendTime, AlternativeExec blendFinished)
        {
            Node node = new Node()
            {Name = "Room Fog Modify", Type = "2f9b5697-b309-474b-ad4d-361d17278f15", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(fog, new Port{Node = node, Index = 1});
            node.ConnectInputPort(blendTime, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void RoomFogPlayerOverrideR2(FogPort fog, PlayerPort player, FloatPort blendTime, AlternativeExec blendFinished)
        {
            Node node = new Node()
            {Name = "Room Fog Player Override", Type = "be4008ad-3f28-4a62-9b30-f479eb7c0542", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(fog, new Port{Node = node, Index = 1});
            node.ConnectInputPort(player, new Port{Node = node, Index = 2});
            node.ConnectInputPort(blendTime, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void RoomFogResetR1(AlternativeExec blendFinished)
        {
            Node node = new Node()
            {Name = "Room Fog Reset", Type = "2dd67fbd-eb84-4810-bfa7-55836139f8a2", InputCount = 1};
            Context.current.AddNode(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void RoomFogResetR2(FloatPort blendTime, AlternativeExec blendFinished)
        {
            Node node = new Node()
            {Name = "Room Fog Reset", Type = "8d447921-57aa-471c-9628-857071fc4a10", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(blendTime, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static BoolPort RoomGetMatchmakingState()
        {
            Node node = new Node()
            {Name = "Room Get Matchmaking State", Type = "2d358c91-9000-4851-ad37-65759a135ab7", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort RoomIndexGetPlayer(IntPort roomIndex)
        {
            Node node = new Node()
            {Name = "Room Index Get Player", Type = "61e30876-2f28-4ba6-9d70-dfa5cc2af1cc", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(roomIndex, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static RoomKeyPort RoomKeyConstantR1(RoomKeyData config)
        {
            Node node = new Node()
            {Name = "Room Key Constant", Type = "b9b000ca-eb3d-4b9f-9f45-0fd64045f63d", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new RoomKeyPort{Port = new Port{Node = node, Index = 0}};
            node.RoomKeyData = config;
            return output_ports;
        }

        public static RoomLevelHUDPort RoomLevelHUD()
        {
            Node node = new Node()
            {Name = "Room Level HUD", Type = "0681e9de-2f79-4f6a-9d8a-06140507760c", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new RoomLevelHUDPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void RoomLevels(AnyPort levels)
        {
            Node node = new Node()
            {Name = "Room Levels", Type = "a63f19b0-206f-4079-a5b0-4622619200a1", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(levels, new Port{Node = node, Index = 0});
            return;
        }

        public static RoomOfferPort RoomOfferConstantR2()
        {
            Node node = new Node()
            {Name = "Room Offer Constant", Type = "1d129345-7897-4a9c-b364-6aaf35333164", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new RoomOfferPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort RoomSetMatchmakingState(BoolPort matchmakingPermitted, AlternativeExec<BoolPort> onMatchmakingStateSet)
        {
            Node node = new Node()
            {Name = "Room Set Matchmaking State", Type = "be4decd2-56a0-46af-8e96-091261946fd9", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(matchmakingPermitted, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            onMatchmakingStateSet(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static void RoomSkydomeClearPlayerOverrideR2(PlayerPort player, FloatPort blendTime, AlternativeExec blendFinished)
        {
            Node node = new Node()
            {Name = "Room Skydome Clear Player Override", Type = "de67b647-5c82-4875-a6c4-051768c27c32", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(blendTime, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static BoolPort RoomSkydomeModifyR1(SkydomePort skydomeConstant, AlternativeExec<BoolPort> blendFinished)
        {
            Node node = new Node()
            {Name = "Room Skydome Modify", Type = "511e85c5-a359-49f1-a83c-a0550e98fe8e", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(skydomeConstant, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static void RoomSkydomeModifyR2(SkydomePort skydome, FloatPort blendTime, AlternativeExec blendFinished)
        {
            Node node = new Node()
            {Name = "Room Skydome Modify", Type = "fa6ebcdd-7551-4f05-91ca-101b2679cc0c", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(skydome, new Port{Node = node, Index = 1});
            node.ConnectInputPort(blendTime, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void RoomSkydomePlayerOverrideR2(SkydomePort skydome, PlayerPort player, FloatPort blendTime, AlternativeExec blendFinished)
        {
            Node node = new Node()
            {Name = "Room Skydome Player Override", Type = "f204d79b-fbd2-4b19-a4bf-b7eabe927bed", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(skydome, new Port{Node = node, Index = 1});
            node.ConnectInputPort(player, new Port{Node = node, Index = 2});
            node.ConnectInputPort(blendTime, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void RoomSkydomeResetR1(AlternativeExec blendFinished)
        {
            Node node = new Node()
            {Name = "Room Skydome Reset", Type = "b17f7045-6fa5-4fc5-84d5-def4f78d4f45", InputCount = 1};
            Context.current.AddNode(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void RoomSkydomeResetR2(FloatPort blendTime, AlternativeExec blendFinished)
        {
            Node node = new Node()
            {Name = "Room Skydome Reset", Type = "79581488-2095-4ccd-a597-e3ed4d172105", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(blendTime, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void RoomSunClearPlayerOverrideR2(PlayerPort player, FloatPort blendTime, AlternativeExec blendFinished)
        {
            Node node = new Node()
            {Name = "Room Sun Clear Player Override", Type = "c3c56056-ae0a-4576-a907-84c78a8cd3bf", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(blendTime, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static BoolPort RoomSunModifyR1(SunPort sunConstant, SunDirectionPort sunDirection, AlternativeExec<BoolPort> blendFinished)
        {
            Node node = new Node()
            {Name = "Room Sun Modify", Type = "884408a8-5884-41e4-9399-1b0ef5d353e0", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(sunConstant, new Port{Node = node, Index = 1});
            node.ConnectInputPort(sunDirection, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 2}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished(output_ports);
            ExecFlow.current = mainFlow;
            return output_ports;
        }

        public static void RoomSunModifyR2(SunPort sun, SunDirectionPort sunDirection, FloatPort blendTime, AlternativeExec blendFinished)
        {
            Node node = new Node()
            {Name = "Room Sun Modify", Type = "ecf6491d-782c-47b8-bb3e-b751de0f348f", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(sun, new Port{Node = node, Index = 1});
            node.ConnectInputPort(sunDirection, new Port{Node = node, Index = 2});
            node.ConnectInputPort(blendTime, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void RoomSunPlayerOverrideR2(SunPort sun, SunDirectionPort sunDirection, PlayerPort player, FloatPort blendTime, AlternativeExec blendFinished)
        {
            Node node = new Node()
            {Name = "Room Sun Player Override", Type = "6601dc45-6a5d-4a4d-986a-c3f265de9971", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(sun, new Port{Node = node, Index = 1});
            node.ConnectInputPort(sunDirection, new Port{Node = node, Index = 2});
            node.ConnectInputPort(player, new Port{Node = node, Index = 3});
            node.ConnectInputPort(blendTime, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void RoomSunResetR1(AlternativeExec blendFinished)
        {
            Node node = new Node()
            {Name = "Room Sun Reset", Type = "b38f186d-67b3-44a1-8a95-120123ddb182", InputCount = 1};
            Context.current.AddNode(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void RoomSunResetR2(FloatPort blendTime, AlternativeExec blendFinished)
        {
            Node node = new Node()
            {Name = "Room Sun Reset", Type = "f62876ea-8c18-4566-ae4e-224d39fdcd89", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(blendTime, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            blendFinished();
            ExecFlow.current = mainFlow;
            return;
        }

        public static FloatPort Root(FloatPort value, FloatPort root)
        {
            Node node = new Node()
            {Name = "Root", Type = "8b96e472-2b19-4265-aade-2c6202358d86", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            node.ConnectInputPort(root, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static RecRoomObjectPort RootObject()
        {
            Node node = new Node()
            {Name = "Root Object", Type = "85be495b-0d08-421c-b20f-72b38967d34a", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort RootPlayer()
        {
            Node node = new Node()
            {Name = "Root Player", Type = "2d92f1a6-f219-4163-99d9-42e71dbc5adf", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port RotateVector(QuaternionPort rotation, Vector3Port point)
        {
            Node node = new Node()
            {Name = "Rotate Vector", Type = "02c4048a-5f67-47ea-9f00-692f51c66e65", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 0});
            node.ConnectInputPort(point, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort RotatorGetRotation(RotatorPort target)
        {
            Node node = new Node()
            {Name = "Rotator Get Rotation", Type = "30fe0829-2f08-4bd2-b4b1-9a41764e5a76", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort RotatorGetRotationAcceleration(RotatorPort target)
        {
            Node node = new Node()
            {Name = "Rotator Get Rotation Acceleration", Type = "2d96da47-4d37-4463-a3bd-8f8cd2ab0c58", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort RotatorGetRotationSpeed(RotatorPort target)
        {
            Node node = new Node()
            {Name = "Rotator Get Rotation Speed", Type = "be834de9-91cb-4588-8988-3a6abfd56573", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort RotatorGetTargetRotation(RotatorPort target)
        {
            Node node = new Node()
            {Name = "Rotator Get Target Rotation", Type = "117b8c83-5ada-4665-a0c6-2c6ffdec98b9", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void RotatorSetRotation(RotatorPort target, FloatPort value)
        {
            Node node = new Node()
            {Name = "Rotator Set Rotation", Type = "07ae26b8-e0d7-49c0-bb2c-25d66d31fe3c", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RotatorSetRotationAcceleration(RotatorPort target, FloatPort value)
        {
            Node node = new Node()
            {Name = "Rotator Set Rotation Acceleration", Type = "db29fd41-9fb5-4c2a-8c72-c8d327b0f23f", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RotatorSetRotationSpeed(RotatorPort target, FloatPort value)
        {
            Node node = new Node()
            {Name = "Rotator Set Rotation Speed", Type = "9d0e3cf5-581d-4fb5-8346-c9e7d9877b3f", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void RotatorSetTargetRotation(RotatorPort target, FloatPort value)
        {
            Node node = new Node()
            {Name = "Rotator Set Target Rotation", Type = "0f9da436-0752-422d-8323-fa445a9ca06b", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort Round(FloatPort value)
        {
            Node node = new Node()
            {Name = "Round", Type = "c6cfe49a-4ffb-4714-9564-8ddda0300676", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort RoundToInt(FloatPort value)
        {
            Node node = new Node()
            {Name = "Round to Int", Type = "0d2a4771-0694-4b84-8e07-2080c26aae22", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static AudioPort SampleAudioConstant()
        {
            Node node = new Node()
            {Name = "Sample Audio Constant", Type = "2cb45825-f385-414f-9a65-2425963fa720", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new AudioPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort SeatGetLockPlayersIn(SeatPort target)
        {
            Node node = new Node()
            {Name = "Seat Get Lock Players In", Type = "e46a3c37-7d53-4d4c-9484-48b0ac0694c4", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort SeatGetLockPlayersOut(SeatPort target)
        {
            Node node = new Node()
            {Name = "Seat Get Lock Players Out", Type = "e0214877-5f0a-46a2-8278-580f2fd293e0", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static PlayerPort SeatGetSeatedPlayer(SeatPort target)
        {
            Node node = new Node()
            {Name = "Seat Get Seated Player", Type = "7fc01b3a-3f44-4cf1-ad2d-d5898fb35f4d", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new PlayerPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void SeatSetLockPlayersIn(SeatPort target, BoolPort lockPlayersIn)
        {
            Node node = new Node()
            {Name = "Seat Set Lock Players In", Type = "af071963-a0df-422e-8372-e561336921db", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(lockPlayersIn, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SeatSetLockPlayersOut(SeatPort target, BoolPort lockPlayersOut)
        {
            Node node = new Node()
            {Name = "Seat Set Lock Players Out", Type = "face947c-8ac1-4d8e-8318-e7ec98bf466d", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(lockPlayersOut, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SeatSetSeatedPlayer(SeatPort target, PlayerPort player, AlternativeExec fail)
        {
            Node node = new Node()
            {Name = "Seat Set Seated Player", Type = "d652ebe5-1367-44ed-a352-1e5ab84c32b0", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(player, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            fail();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void SeatUnseatPlayer(SeatPort target)
        {
            Node node = new Node()
            {Name = "Seat Unseat Player", Type = "70b682f5-5744-4a6a-beaa-a9dcd40066b6", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static IntPort Self()
        {
            Node node = new Node()
            {Name = "Self", Type = "3d7d40d6-885a-4fa5-bbaa-b19057291ddb", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static void Sequence<T>(AlternativeExec _2, SequenceData config)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Sequence", Type = "9e2ac049-e68e-4689-a288-bef8a62da316", InputCount = 1};
            Context.current.AddNode(node);
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            _2();
            ExecFlow.current = mainFlow;
            node.SequenceData = config;
            return;
        }

        public static void SetCameraShake(PlayerPort player, FloatPort intensity, FloatPort duration)
        {
            Node node = new Node()
            {Name = "Set Camera Shake", Type = "a4bf7bb6-6dd9-4b34-85ab-2aaa324647e4", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(intensity, new Port{Node = node, Index = 2});
            node.ConnectInputPort(duration, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetHUDElementColor(HUDConstantPort target, ColorPort color)
        {
            Node node = new Node()
            {Name = "Set HUD Element Color", Type = "47f61ea8-aab2-4b0e-8d59-351c0047d853", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetHUDElementContent(HUDConstantPort target)
        {
            Node node = new Node()
            {Name = "Set HUD Element Content", Type = "31295d8e-f416-4c44-b0bd-2eda32200365", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetHUDElementEnabled(HUDConstantPort target, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Set HUD Element Enabled", Type = "64ebc8ff-a7d0-47b3-b00b-3cd7e5927978", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetHUDElementLabel(HUDConstantPort target, StringPort label)
        {
            Node node = new Node()
            {Name = "Set HUD Element Label", Type = "04fb09fa-5be2-491b-9d16-d5b21083f528", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(label, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetHUDElementLabelEnabled(HUDConstantPort target, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Set HUD Element Label Enabled", Type = "2231d8fa-fa63-4952-8ba4-a8258ffb2f9b", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetHUDElementMaxValue(HUDConstantPort target, IntPort value)
        {
            Node node = new Node()
            {Name = "Set HUD Element Max Value", Type = "f258d689-3341-4383-a8f1-73ab7b2f37a1", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetHUDElementValue(HUDConstantPort target, IntPort value)
        {
            Node node = new Node()
            {Name = "Set HUD Element Value", Type = "61efbc78-9ddf-42bb-814a-3758a34f5faf", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetHUDElementValueTextEnabled(HUDConstantPort target, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Set HUD Element Value Text Enabled", Type = "a980fe11-65d0-4ae2-bd4c-6405cfc01ce0", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerVignette(PlayerPort player, FloatPort time, ColorPort color, FloatPort intensity)
        {
            Node node = new Node()
            {Name = "Set Player Vignette", Type = "fee486b2-823f-4110-b33a-241adb59b634", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(time, new Port{Node = node, Index = 2});
            node.ConnectInputPort(color, new Port{Node = node, Index = 3});
            node.ConnectInputPort(intensity, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerWorldUIPrimaryBarColor(PlayerPort player, ColorPort color)
        {
            Node node = new Node()
            {Name = "Set Player World UI Primary Bar Color", Type = "859086b7-8a86-4dde-b8cb-c3a361d13fe3", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerWorldUIPrimaryBarEnabled(PlayerPort player, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Set Player World UI Primary Bar Enabled", Type = "03c280c2-5f80-4ba9-8966-6c5d11da84a9", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerWorldUIPrimaryBarMaxValue(PlayerPort player, IntPort value)
        {
            Node node = new Node()
            {Name = "Set Player World UI Primary Bar Max Value", Type = "eafda897-0a2a-41a7-bce4-7f7b62c7e887", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerWorldUIPrimaryBarValue(PlayerPort player, IntPort value)
        {
            Node node = new Node()
            {Name = "Set Player World UI Primary Bar Value", Type = "7d868adf-0fe5-4a21-9dda-f04c4a6f77af", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerWorldUISecondaryBarColor(PlayerPort player, ColorPort color)
        {
            Node node = new Node()
            {Name = "Set Player World UI Secondary Bar Color", Type = "a94540da-0639-4e88-adf6-c90f6612fe05", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerWorldUISecondaryBarEnabled(PlayerPort player, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Set Player World UI Secondary Bar Enabled", Type = "fce830ef-b17c-4564-a74d-c819b0fedcf7", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerWorldUISecondaryBarMaxValue(PlayerPort player, IntPort value)
        {
            Node node = new Node()
            {Name = "Set Player World UI Secondary Bar Max Value", Type = "38fa1fe5-e9cf-45b4-8fa7-0633064e4cc3", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerWorldUISecondaryBarValue(PlayerPort player, IntPort value)
        {
            Node node = new Node()
            {Name = "Set Player World UI Secondary Bar Value", Type = "358e29c5-2aa5-4c9a-a9bf-7a18e1fc3148", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerWorldUITextColor(PlayerPort player, ColorPort color)
        {
            Node node = new Node()
            {Name = "Set Player World UI Text Color", Type = "31b7328c-f362-4473-88b9-c49092e97700", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerWorldUITextEnabled(PlayerPort player, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Set Player World UI Text Enabled", Type = "82787e0f-8a9c-4fb1-a087-f24b4461f8c9", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SetPlayerWorldUITextValue(PlayerPort player, StringPort value)
        {
            Node node = new Node()
            {Name = "Set Player World UI Text Value", Type = "cd09d0fa-1943-4838-a707-c9a902aff0ae", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort SetPosition(PlayerPort target, Vector3Port position)
        {
            Node node = new Node()
            {Name = "Set Position", Type = "6e68ede8-32de-455f-9449-83951b4e4f73", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetPosition(RecRoomObjectPort target, Vector3Port position)
        {
            Node node = new Node()
            {Name = "Set Position", Type = "6e68ede8-32de-455f-9449-83951b4e4f73", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static void SetPositionDeprecated(PlayerPort target, Vector3Port position, AlternativeExec failed)
        {
            Node node = new Node()
            {Name = "Set Position (Deprecated)", Type = "ff1c2a15-4099-4aaa-afe3-c217b2fca15b", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            failed();
            ExecFlow.current = mainFlow;
            return;
        }

        public static void SetPositionDeprecated(RecRoomObjectPort target, Vector3Port position, AlternativeExec failed)
        {
            Node node = new Node()
            {Name = "Set Position (Deprecated)", Type = "ff1c2a15-4099-4aaa-afe3-c217b2fca15b", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            var mainFlow = ExecFlow.current;
            ExecFlow.current = new ExecFlow();
            ExecFlow.current.Ports.Add(new Port{Node = node, Index = 1});
            failed();
            ExecFlow.current = mainFlow;
            return;
        }

        public static BoolPort SetPositionInReferenceObjectSpace(PlayerPort target, Vector3Port position, PlayerPort referenceObject)
        {
            Node node = new Node()
            {Name = "Set Position in Reference Object Space", Type = "aae0e3a1-96d3-44df-816c-ce1e2ed34f56", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetPositionInReferenceObjectSpace(PlayerPort target, Vector3Port position, RecRoomObjectPort referenceObject)
        {
            Node node = new Node()
            {Name = "Set Position in Reference Object Space", Type = "aae0e3a1-96d3-44df-816c-ce1e2ed34f56", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetPositionInReferenceObjectSpace(RecRoomObjectPort target, Vector3Port position, PlayerPort referenceObject)
        {
            Node node = new Node()
            {Name = "Set Position in Reference Object Space", Type = "aae0e3a1-96d3-44df-816c-ce1e2ed34f56", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetPositionInReferenceObjectSpace(RecRoomObjectPort target, Vector3Port position, RecRoomObjectPort referenceObject)
        {
            Node node = new Node()
            {Name = "Set Position in Reference Object Space", Type = "aae0e3a1-96d3-44df-816c-ce1e2ed34f56", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetRotation(PlayerPort target, Vector3Port rotation)
        {
            Node node = new Node()
            {Name = "Set Rotation", Type = "0a6f6078-8075-43c7-bbb2-32b63ae48e92", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetRotation(PlayerPort target, QuaternionPort rotation)
        {
            Node node = new Node()
            {Name = "Set Rotation", Type = "0a6f6078-8075-43c7-bbb2-32b63ae48e92", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetRotation(RecRoomObjectPort target, Vector3Port rotation)
        {
            Node node = new Node()
            {Name = "Set Rotation", Type = "0a6f6078-8075-43c7-bbb2-32b63ae48e92", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetRotation(RecRoomObjectPort target, QuaternionPort rotation)
        {
            Node node = new Node()
            {Name = "Set Rotation", Type = "0a6f6078-8075-43c7-bbb2-32b63ae48e92", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetRotationInReferenceObjectSpace(PlayerPort target, Vector3Port rotation, PlayerPort referenceObject)
        {
            Node node = new Node()
            {Name = "Set Rotation in Reference Object Space", Type = "64319731-bdb8-4a19-ad65-8e9e7100c0bf", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 2});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetRotationInReferenceObjectSpace(PlayerPort target, Vector3Port rotation, RecRoomObjectPort referenceObject)
        {
            Node node = new Node()
            {Name = "Set Rotation in Reference Object Space", Type = "64319731-bdb8-4a19-ad65-8e9e7100c0bf", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 2});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetRotationInReferenceObjectSpace(PlayerPort target, QuaternionPort rotation, PlayerPort referenceObject)
        {
            Node node = new Node()
            {Name = "Set Rotation in Reference Object Space", Type = "64319731-bdb8-4a19-ad65-8e9e7100c0bf", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 2});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetRotationInReferenceObjectSpace(PlayerPort target, QuaternionPort rotation, RecRoomObjectPort referenceObject)
        {
            Node node = new Node()
            {Name = "Set Rotation in Reference Object Space", Type = "64319731-bdb8-4a19-ad65-8e9e7100c0bf", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 2});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetRotationInReferenceObjectSpace(RecRoomObjectPort target, Vector3Port rotation, PlayerPort referenceObject)
        {
            Node node = new Node()
            {Name = "Set Rotation in Reference Object Space", Type = "64319731-bdb8-4a19-ad65-8e9e7100c0bf", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 2});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetRotationInReferenceObjectSpace(RecRoomObjectPort target, Vector3Port rotation, RecRoomObjectPort referenceObject)
        {
            Node node = new Node()
            {Name = "Set Rotation in Reference Object Space", Type = "64319731-bdb8-4a19-ad65-8e9e7100c0bf", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 2});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetRotationInReferenceObjectSpace(RecRoomObjectPort target, QuaternionPort rotation, PlayerPort referenceObject)
        {
            Node node = new Node()
            {Name = "Set Rotation in Reference Object Space", Type = "64319731-bdb8-4a19-ad65-8e9e7100c0bf", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 2});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetRotationInReferenceObjectSpace(RecRoomObjectPort target, QuaternionPort rotation, RecRoomObjectPort referenceObject)
        {
            Node node = new Node()
            {Name = "Set Rotation in Reference Object Space", Type = "64319731-bdb8-4a19-ad65-8e9e7100c0bf", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 2});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetTransform(PlayerPort target, Vector3Port position, Vector3Port rotation)
        {
            Node node = new Node()
            {Name = "Set Transform", Type = "6873f341-1ae8-4ddd-9f8c-892a977ef974", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetTransform(PlayerPort target, Vector3Port position, QuaternionPort rotation)
        {
            Node node = new Node()
            {Name = "Set Transform", Type = "6873f341-1ae8-4ddd-9f8c-892a977ef974", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetTransform(RecRoomObjectPort target, Vector3Port position, Vector3Port rotation)
        {
            Node node = new Node()
            {Name = "Set Transform", Type = "6873f341-1ae8-4ddd-9f8c-892a977ef974", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetTransform(RecRoomObjectPort target, Vector3Port position, QuaternionPort rotation)
        {
            Node node = new Node()
            {Name = "Set Transform", Type = "6873f341-1ae8-4ddd-9f8c-892a977ef974", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 3});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetTransformInReferenceObjectSpace(PlayerPort target, Vector3Port position, Vector3Port rotation, PlayerPort referenceObject)
        {
            Node node = new Node()
            {Name = "Set Transform in Reference Object Space", Type = "3a0a2da6-d4d2-42e5-be8d-cedc23fbe8a8", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 4});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetTransformInReferenceObjectSpace(PlayerPort target, Vector3Port position, Vector3Port rotation, RecRoomObjectPort referenceObject)
        {
            Node node = new Node()
            {Name = "Set Transform in Reference Object Space", Type = "3a0a2da6-d4d2-42e5-be8d-cedc23fbe8a8", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 4});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetTransformInReferenceObjectSpace(PlayerPort target, Vector3Port position, QuaternionPort rotation, PlayerPort referenceObject)
        {
            Node node = new Node()
            {Name = "Set Transform in Reference Object Space", Type = "3a0a2da6-d4d2-42e5-be8d-cedc23fbe8a8", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 4});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetTransformInReferenceObjectSpace(PlayerPort target, Vector3Port position, QuaternionPort rotation, RecRoomObjectPort referenceObject)
        {
            Node node = new Node()
            {Name = "Set Transform in Reference Object Space", Type = "3a0a2da6-d4d2-42e5-be8d-cedc23fbe8a8", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 4});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetTransformInReferenceObjectSpace(RecRoomObjectPort target, Vector3Port position, Vector3Port rotation, PlayerPort referenceObject)
        {
            Node node = new Node()
            {Name = "Set Transform in Reference Object Space", Type = "3a0a2da6-d4d2-42e5-be8d-cedc23fbe8a8", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 4});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetTransformInReferenceObjectSpace(RecRoomObjectPort target, Vector3Port position, Vector3Port rotation, RecRoomObjectPort referenceObject)
        {
            Node node = new Node()
            {Name = "Set Transform in Reference Object Space", Type = "3a0a2da6-d4d2-42e5-be8d-cedc23fbe8a8", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 4});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetTransformInReferenceObjectSpace(RecRoomObjectPort target, Vector3Port position, QuaternionPort rotation, PlayerPort referenceObject)
        {
            Node node = new Node()
            {Name = "Set Transform in Reference Object Space", Type = "3a0a2da6-d4d2-42e5-be8d-cedc23fbe8a8", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 4});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort SetTransformInReferenceObjectSpace(RecRoomObjectPort target, Vector3Port position, QuaternionPort rotation, RecRoomObjectPort referenceObject)
        {
            Node node = new Node()
            {Name = "Set Transform in Reference Object Space", Type = "3a0a2da6-d4d2-42e5-be8d-cedc23fbe8a8", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(position, new Port{Node = node, Index = 2});
            node.ConnectInputPort(rotation, new Port{Node = node, Index = 3});
            node.ConnectInputPort(referenceObject, new Port{Node = node, Index = 4});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static AudioPort SFXConstant(SFXConstantData config)
        {
            Node node = new Node()
            {Name = "SFX Constant", Type = "d65a4666-5036-436b-ad42-a20aafa2174d", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new AudioPort{Port = new Port{Node = node, Index = 0}};
            node.SFXConstantData = config;
            return output_ports;
        }

        public static BoolPort SFXGetIsPlaying(SFXPort target)
        {
            Node node = new Node()
            {Name = "SFX Get Is Playing", Type = "a0a17fe1-bdb0-4687-81de-141ce97710ed", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort SFXGetVolume(SFXPort target)
        {
            Node node = new Node()
            {Name = "SFX Get Volume", Type = "aaf39143-c5dc-47cd-ad85-c659c3035cab", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void SFXPlay(SFXPort target)
        {
            Node node = new Node()
            {Name = "SFX Play", Type = "5f8991bb-d1b8-4c74-a54a-86e7033b53a0", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SFXSetVolume(SFXPort target, IntPort value)
        {
            Node node = new Node()
            {Name = "SFX Set Volume", Type = "d2df4993-d858-4df1-aca2-fc0e7f479668", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SFXStop(SFXPort target)
        {
            Node node = new Node()
            {Name = "SFX Stop", Type = "3ad57fda-1fab-4b00-81b3-71d61af37c65", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort ShareCameraGetIsSpawned(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Share Camera Get Is Spawned", Type = "f28a5263-76d9-4bba-97f2-2654ae04ce61", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void ShowBannerNotification(PlayerPort player, StringPort title, StringPort mainText, FloatPort duration)
        {
            Node node = new Node()
            {Name = "Show Banner Notification", Type = "829b5788-efe0-4df4-91de-75c267ed3d57", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(title, new Port{Node = node, Index = 2});
            node.ConnectInputPort(mainText, new Port{Node = node, Index = 3});
            node.ConnectInputPort(duration, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ShowNotification<T>(PlayerPort player, StringPort value)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Show Notification", Type = "61bc2310-69f5-4dfa-b43c-12ae98dd05ab", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ShowPurchasePromptR1(RoomKeyPort inRoomPurchasable, PlayerPort player)
        {
            Node node = new Node()
            {Name = "Show Purchase Prompt", Type = "7a8d9550-41fa-42a3-8d52-0fc7e6ac3213", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(inRoomPurchasable, new Port{Node = node, Index = 1});
            node.ConnectInputPort(player, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ShowPurchasePromptR1(ConsumablePort inRoomPurchasable, PlayerPort player)
        {
            Node node = new Node()
            {Name = "Show Purchase Prompt", Type = "7a8d9550-41fa-42a3-8d52-0fc7e6ac3213", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(inRoomPurchasable, new Port{Node = node, Index = 1});
            node.ConnectInputPort(player, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ShowPurchasePromptR1(RoomCurrencyPort inRoomPurchasable, PlayerPort player)
        {
            Node node = new Node()
            {Name = "Show Purchase Prompt", Type = "7a8d9550-41fa-42a3-8d52-0fc7e6ac3213", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(inRoomPurchasable, new Port{Node = node, Index = 1});
            node.ConnectInputPort(player, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ShowPurchasePromptR2(RoomOfferPort inRoomPurchasable, PlayerPort player)
        {
            Node node = new Node()
            {Name = "Show Purchase Prompt", Type = "53a17ff2-a6fe-4b69-adb0-1b1fdf5a7de0", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(inRoomPurchasable, new Port{Node = node, Index = 1});
            node.ConnectInputPort(player, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ShowRewardNotification(PlayerPort player, RewardPort reward, FloatPort duration)
        {
            Node node = new Node()
            {Name = "Show Reward Notification", Type = "3d713e71-2729-4819-819c-bcbe6fb8d400", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(reward, new Port{Node = node, Index = 2});
            node.ConnectInputPort(duration, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ShowRewardNotification(PlayerPort player, ListPort<RewardPort> reward, FloatPort duration)
        {
            Node node = new Node()
            {Name = "Show Reward Notification", Type = "3d713e71-2729-4819-819c-bcbe6fb8d400", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(reward, new Port{Node = node, Index = 2});
            node.ConnectInputPort(duration, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort Sin(FloatPort value)
        {
            Node node = new Node()
            {Name = "Sin", Type = "ea824326-5061-411d-980c-30031511c821", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static SkydomePort SkydomeConstant()
        {
            Node node = new Node()
            {Name = "Skydome Constant", Type = "bff88a1e-4888-4e03-a1f4-804864a2f177", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new SkydomePort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort Slerp(QuaternionPort start, QuaternionPort end, FloatPort progress)
        {
            Node node = new Node()
            {Name = "Slerp", Type = "8d5f0586-1ecf-42ba-a34f-c6ccbb0eadb9", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(end, new Port{Node = node, Index = 1});
            node.ConnectInputPort(progress, new Port{Node = node, Index = 2});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Slerp(Vector3Port start, Vector3Port end, FloatPort progress)
        {
            Node node = new Node()
            {Name = "Slerp", Type = "8d5f0586-1ecf-42ba-a34f-c6ccbb0eadb9", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(start, new Port{Node = node, Index = 0});
            node.ConnectInputPort(end, new Port{Node = node, Index = 1});
            node.ConnectInputPort(progress, new Port{Node = node, Index = 2});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (FloatPort Result, FloatPort ResultVelocity) SmoothDamp(FloatPort current, FloatPort target, FloatPort currentVelocity, FloatPort smoothTime, FloatPort maxSpeed, FloatPort deltaTime)
        {
            Node node = new Node()
            {Name = "Smooth Damp", Type = "830600a6-ec28-46b0-9354-13e0a1061232", InputCount = 7};
            Context.current.AddNode(node);
            node.ConnectInputPort(current, new Port{Node = node, Index = 1});
            node.ConnectInputPort(target, new Port{Node = node, Index = 2});
            node.ConnectInputPort(currentVelocity, new Port{Node = node, Index = 3});
            node.ConnectInputPort(smoothTime, new Port{Node = node, Index = 4});
            node.ConnectInputPort(maxSpeed, new Port{Node = node, Index = 5});
            node.ConnectInputPort(deltaTime, new Port{Node = node, Index = 6});
            var output_ports = (new FloatPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static (Vector3Port Result, Vector3Port ResultVelocity) SmoothDamp(Vector3Port current, Vector3Port target, Vector3Port currentVelocity, FloatPort smoothTime, FloatPort maxSpeed, FloatPort deltaTime)
        {
            Node node = new Node()
            {Name = "Smooth Damp", Type = "830600a6-ec28-46b0-9354-13e0a1061232", InputCount = 7};
            Context.current.AddNode(node);
            node.ConnectInputPort(current, new Port{Node = node, Index = 1});
            node.ConnectInputPort(target, new Port{Node = node, Index = 2});
            node.ConnectInputPort(currentVelocity, new Port{Node = node, Index = 3});
            node.ConnectInputPort(smoothTime, new Port{Node = node, Index = 4});
            node.ConnectInputPort(maxSpeed, new Port{Node = node, Index = 5});
            node.ConnectInputPort(deltaTime, new Port{Node = node, Index = 6});
            var output_ports = (new Vector3Port{Port = new Port{Node = node, Index = 1}}, new Vector3Port{Port = new Port{Node = node, Index = 2}});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static void SpawnerInternalStartSpawningR1(RecRoomObjectPort spawner, IntPort amountOfObjectsToSpawn, FloatPort timeBetweenSpawns, Vector3Port spawnPosition)
        {
            Node node = new Node()
            {Name = "Spawner Internal Start Spawning", Type = "fb6a63b1-3f55-4dcf-9bf0-6ef82e3296d5", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(spawner, new Port{Node = node, Index = 1});
            node.ConnectInputPort(amountOfObjectsToSpawn, new Port{Node = node, Index = 2});
            node.ConnectInputPort(timeBetweenSpawns, new Port{Node = node, Index = 3});
            node.ConnectInputPort(spawnPosition, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void SpawnerResetR1(RecRoomObjectPort port1)
        {
            Node node = new Node()
            {Name = "Spawner Reset", Type = "6a669e6e-4ebf-434c-9c23-d2b769d49b47", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static (BoolPort Hit, PlayerPort Player, RecRoomObjectPort Object, FloatPort Distance, Vector3Port HitPosition, Vector3Port SurfaceNormal) Spherecast(Vector3Port startPosition, FloatPort radius, Vector3Port direction, FloatPort maxDistance, RaycastData config)
        {
            Node node = new Node()
            {Name = "Spherecast", Type = "0ea23792-e987-459e-8cd7-c0c60f667e08", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(startPosition, new Port{Node = node, Index = 0});
            node.ConnectInputPort(radius, new Port{Node = node, Index = 1});
            node.ConnectInputPort(direction, new Port{Node = node, Index = 2});
            node.ConnectInputPort(maxDistance, new Port{Node = node, Index = 3});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new PlayerPort{Port = new Port{Node = node, Index = 1}}, new RecRoomObjectPort{Port = new Port{Node = node, Index = 2}}, new FloatPort{Port = new Port{Node = node, Index = 3}}, new Vector3Port{Port = new Port{Node = node, Index = 4}}, new Vector3Port{Port = new Port{Node = node, Index = 5}});
            node.RaycastData = config;
            return output_ports;
        }

        public static void State()
        {
            Node node = new Node()
            {Name = "State", Type = "54fe9649-9512-4135-a6e5-9eea7d877fa5", InputCount = 0};
            Context.current.AddNode(node);
            return;
        }

        public static StatePort StateConstant()
        {
            Node node = new Node()
            {Name = "State Constant", Type = "bf4f0801-2e6b-4e4b-a2df-a005fe622087", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new StatePort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void StateMachine()
        {
            Node node = new Node()
            {Name = "State Machine", Type = "2963631f-bcd1-4712-9613-d304bc997248", InputCount = 0};
            Context.current.AddNode(node);
            return;
        }

        public static void StopCameraShake(PlayerPort player)
        {
            Node node = new Node()
            {Name = "Stop Camera Shake", Type = "a06b802b-bb80-4f66-937e-3a764a419c4d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort StorefrontGetIsEnabledR2(StorefrontPort storefront)
        {
            Node node = new Node()
            {Name = "Storefront Get Is Enabled", Type = "cf8756e6-97b9-4785-b926-057bb8ad7afd", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(storefront, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<RoomOfferPort> StorefrontGetOffersListR2(StorefrontPort storefront)
        {
            Node node = new Node()
            {Name = "Storefront Get Offers List", Type = "da53cfee-9e05-4ed0-adda-3086ddb3b9a9", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(storefront, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<RoomOfferPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void StorefrontSetIsEnabledR2(StorefrontPort storefront, BoolPort isEnabled)
        {
            Node node = new Node()
            {Name = "Storefront Set Is Enabled", Type = "c74e115e-60e3-40f3-bdb9-de480355be33", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(storefront, new Port{Node = node, Index = 1});
            node.ConnectInputPort(isEnabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void StorefrontSetOffersListR2(StorefrontPort storefront, ListPort<RoomOfferPort> offersList)
        {
            Node node = new Node()
            {Name = "Storefront Set Offers List", Type = "799fea09-63e3-495f-b516-014a7202dd0c", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(storefront, new Port{Node = node, Index = 1});
            node.ConnectInputPort(offersList, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        internal static StringPort StringConcat(StringPort separator, StringPort value)
        {
            Node node = new Node()
            {Name = "String Concat", Type = "73ed7ea2-cead-405a-b39c-1fec4bfd4236", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(separator, new Port{Node = node, Index = 0});
            node.ConnectInputPort(value, new Port{Node = node, Index = 1});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort StringContains(StringPort @string, StringPort sequence)
        {
            Node node = new Node()
            {Name = "String Contains", Type = "aa24edab-c707-4cff-8c73-07e479b4cd07", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(@string, new Port{Node = node, Index = 0});
            node.ConnectInputPort(sequence, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static StringPort StringFormat(StringPort format, StringPort value)
        {
            Node node = new Node()
            {Name = "String Format", Type = "77afc9dd-baa9-4312-b8b8-7ef479c840e6", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(format, new Port{Node = node, Index = 0});
            node.ConnectInputPort(value, new Port{Node = node, Index = 1});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort StringIndexOf(StringPort @string, StringPort substring)
        {
            Node node = new Node()
            {Name = "String Index Of", Type = "1af21999-38f8-4231-9de9-26b43f47fe0d", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(@string, new Port{Node = node, Index = 0});
            node.ConnectInputPort(substring, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort StringLength(StringPort @string)
        {
            Node node = new Node()
            {Name = "String Length", Type = "dcde9345-00f2-41fb-9a2d-5a938f39bfb5", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(@string, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort StringReplace(StringPort @string, StringPort pattern, StringPort replacement)
        {
            Node node = new Node()
            {Name = "String Replace", Type = "b394650e-7673-40a3-8b9e-3aa8eaa2a77e", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(@string, new Port{Node = node, Index = 0});
            node.ConnectInputPort(pattern, new Port{Node = node, Index = 1});
            node.ConnectInputPort(replacement, new Port{Node = node, Index = 2});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<StringPort> StringSplit(StringPort @string, StringPort divider)
        {
            Node node = new Node()
            {Name = "String Split", Type = "ad169649-1050-48c5-a540-f03a2059bcdb", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(@string, new Port{Node = node, Index = 0});
            node.ConnectInputPort(divider, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<StringPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<StringPort> StringSplitAtIndex(StringPort @string, IntPort index)
        {
            Node node = new Node()
            {Name = "String Split At Index", Type = "6b92c345-e6bc-40d9-aae9-4754e634777c", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(@string, new Port{Node = node, Index = 0});
            node.ConnectInputPort(index, new Port{Node = node, Index = 1});
            var output_ports = new ListPort<StringPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<StringPort> StringSplitWhitespace(StringPort @string)
        {
            Node node = new Node()
            {Name = "String Split Whitespace", Type = "7695ff77-5b9d-4a41-a894-6602b98f289f", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(@string, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<StringPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort StringSubstring(StringPort @string, IntPort index, IntPort length)
        {
            Node node = new Node()
            {Name = "String Substring", Type = "226fafe2-1ea8-4ae8-861e-ae4b1bd10bfe", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(@string, new Port{Node = node, Index = 0});
            node.ConnectInputPort(index, new Port{Node = node, Index = 1});
            node.ConnectInputPort(length, new Port{Node = node, Index = 2});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort StringToLower(StringPort @string)
        {
            Node node = new Node()
            {Name = "String To Lower", Type = "678f6d33-1e94-4be6-b959-0212c1a2207f", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(@string, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort StringToUpper(StringPort @string)
        {
            Node node = new Node()
            {Name = "String To Upper", Type = "8f5995c7-5af0-4064-9cb7-2b80d75d157f", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(@string, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort StringTrim(StringPort @string)
        {
            Node node = new Node()
            {Name = "String Trim", Type = "e6f056ee-cf6d-4696-b338-31418275af16", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(@string, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort StringVariable(StringPort port1, VariableData config)
        {
            Node node = new Node()
            {Name = "string Variable", Type = "66b6ea20-9a00-4f80-9636-2cfb676b3965", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static AudioPort StudioAudioConstant(SFXConstantData config)
        {
            Node node = new Node()
            {Name = "Studio Audio Constant", Type = "7dc47ad4-9b51-4cb3-8e40-6b76f1243e6f", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new AudioPort{Port = new Port{Node = node, Index = 0}};
            node.SFXConstantData = config;
            return output_ports;
        }

        public static void StudioEventSender(StudioObjectPort studioObject, StringPort @event)
        {
            Node node = new Node()
            {Name = "Studio Event Sender", Type = "e4f23e24-182a-4dac-b6ab-8baf94081762", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(studioObject, new Port{Node = node, Index = 1});
            node.ConnectInputPort(@event, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void StudioEventSenderBool(StudioObjectPort studioObject, StringPort @event, BoolPort value)
        {
            Node node = new Node()
            {Name = "Studio Event Sender - Bool", Type = "84efd7b3-fddc-4f50-b0b6-c728bef04f52", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(studioObject, new Port{Node = node, Index = 1});
            node.ConnectInputPort(@event, new Port{Node = node, Index = 2});
            node.ConnectInputPort(value, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void StudioEventSenderFloat(StudioObjectPort studioObject, StringPort @event, FloatPort value)
        {
            Node node = new Node()
            {Name = "Studio Event Sender - Float", Type = "441f3853-e402-4dfa-9d50-1453d243cb6d", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(studioObject, new Port{Node = node, Index = 1});
            node.ConnectInputPort(@event, new Port{Node = node, Index = 2});
            node.ConnectInputPort(value, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void StudioEventSenderInt(StudioObjectPort studioObject, StringPort @event, IntPort value)
        {
            Node node = new Node()
            {Name = "Studio Event Sender - Int", Type = "1a29d0ac-0372-4a8a-84cd-9df9af8920a1", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(studioObject, new Port{Node = node, Index = 1});
            node.ConnectInputPort(@event, new Port{Node = node, Index = 2});
            node.ConnectInputPort(value, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void StudioEventSenderString(StudioObjectPort studioObject, StringPort @event, StringPort value)
        {
            Node node = new Node()
            {Name = "Studio Event Sender - String", Type = "6bc4210c-dc16-4686-90bf-f95da3338b74", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(studioObject, new Port{Node = node, Index = 1});
            node.ConnectInputPort(@event, new Port{Node = node, Index = 2});
            node.ConnectInputPort(value, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void StudioEventSenderStringBool(StudioObjectPort studioObject, StringPort @event, StringPort value0, BoolPort value1)
        {
            Node node = new Node()
            {Name = "Studio Event Sender - String, Bool", Type = "91f2d5db-f6c6-4ef0-b134-056fa57c953d", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(studioObject, new Port{Node = node, Index = 1});
            node.ConnectInputPort(@event, new Port{Node = node, Index = 2});
            node.ConnectInputPort(value0, new Port{Node = node, Index = 3});
            node.ConnectInputPort(value1, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void StudioEventSenderStringFloat(StudioObjectPort studioObject, StringPort @event, StringPort value0, FloatPort value1)
        {
            Node node = new Node()
            {Name = "Studio Event Sender - String, Float", Type = "e394ced1-c594-4750-a4c1-6e861cfe57c0", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(studioObject, new Port{Node = node, Index = 1});
            node.ConnectInputPort(@event, new Port{Node = node, Index = 2});
            node.ConnectInputPort(value0, new Port{Node = node, Index = 3});
            node.ConnectInputPort(value1, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void StudioEventSenderStringInt(StudioObjectPort studioObject, StringPort @event, StringPort value0, IntPort value1)
        {
            Node node = new Node()
            {Name = "Studio Event Sender - String, Int", Type = "dabac52b-26ef-422d-bded-e9234449b989", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(studioObject, new Port{Node = node, Index = 1});
            node.ConnectInputPort(@event, new Port{Node = node, Index = 2});
            node.ConnectInputPort(value0, new Port{Node = node, Index = 3});
            node.ConnectInputPort(value1, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void StudioEventSenderStringString(StudioObjectPort studioObject, StringPort @event, StringPort value0, StringPort value1)
        {
            Node node = new Node()
            {Name = "Studio Event Sender - String, String", Type = "06225a58-e343-4cec-b93b-949f69a430c7", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(studioObject, new Port{Node = node, Index = 1});
            node.ConnectInputPort(@event, new Port{Node = node, Index = 2});
            node.ConnectInputPort(value0, new Port{Node = node, Index = 3});
            node.ConnectInputPort(value1, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        internal static void StudioFunction(StudioObjectPort studioObject, StudioFunctionData config)
        {
            Node node = new Node()
            {Name = "Studio Function", Type = "43847b33-9777-474f-be65-caccfffc8579", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(studioObject, new Port{Node = node, Index = 1});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.StudioFunctionData = config;
            return;
        }

        public static BoolPort StudioObjectGetPropertyBool(StudioObjectPort studioObject, StringPort property)
        {
            Node node = new Node()
            {Name = "Studio Object Get Property - Bool", Type = "7ab38485-8d7c-4c98-b8f3-55a11d4ab741", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(studioObject, new Port{Node = node, Index = 0});
            node.ConnectInputPort(property, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort StudioObjectGetPropertyColor(StudioObjectPort studioObject, StringPort property)
        {
            Node node = new Node()
            {Name = "Studio Object Get Property - Color", Type = "a7f4e64d-41cf-4000-ab55-efbf0ea5d777", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(studioObject, new Port{Node = node, Index = 0});
            node.ConnectInputPort(property, new Port{Node = node, Index = 1});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort StudioObjectGetPropertyFloat(StudioObjectPort studioObject, StringPort property)
        {
            Node node = new Node()
            {Name = "Studio Object Get Property - Float", Type = "0dda9345-0211-4757-8fea-03e05fac89c3", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(studioObject, new Port{Node = node, Index = 0});
            node.ConnectInputPort(property, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort StudioObjectGetPropertyInt(StudioObjectPort studioObject, StringPort property)
        {
            Node node = new Node()
            {Name = "Studio Object Get Property - Int", Type = "4467dc43-b07c-41fc-9e43-21ebf8f86554", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(studioObject, new Port{Node = node, Index = 0});
            node.ConnectInputPort(property, new Port{Node = node, Index = 1});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static QuaternionPort StudioObjectGetPropertyQuaternion(StudioObjectPort studioObject, StringPort property)
        {
            Node node = new Node()
            {Name = "Studio Object Get Property - Quaternion", Type = "4ea0cf52-729d-459b-b70c-93306246da2c", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(studioObject, new Port{Node = node, Index = 0});
            node.ConnectInputPort(property, new Port{Node = node, Index = 1});
            var output_ports = new QuaternionPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort StudioObjectGetPropertyString(StudioObjectPort studioObject, StringPort property)
        {
            Node node = new Node()
            {Name = "Studio Object Get Property - String", Type = "a0708f14-89b6-4ef7-97eb-38359a57422f", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(studioObject, new Port{Node = node, Index = 0});
            node.ConnectInputPort(property, new Port{Node = node, Index = 1});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port StudioObjectGetPropertyVector3(StudioObjectPort studioObject, StringPort property)
        {
            Node node = new Node()
            {Name = "Studio Object Get Property - Vector3", Type = "b96ed765-58d1-46f1-afa8-1b85a40fba50", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(studioObject, new Port{Node = node, Index = 0});
            node.ConnectInputPort(property, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static IntPort Subtract(IntPort value)
        {
            Node node = new Node()
            {Name = "Subtract", Type = "1fbb364c-1af0-44bb-a82b-905caeb6819a", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static FloatPort Subtract(FloatPort value)
        {
            Node node = new Node()
            {Name = "Subtract", Type = "1fbb364c-1af0-44bb-a82b-905caeb6819a", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        internal static Vector3Port Subtract(Vector3Port value)
        {
            Node node = new Node()
            {Name = "Subtract", Type = "1fbb364c-1af0-44bb-a82b-905caeb6819a", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static SunPort SunConstant()
        {
            Node node = new Node()
            {Name = "Sun Constant", Type = "26062297-4aab-4fd4-bfb8-95fbf64f6bb7", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new SunPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort SwingHandleGetIsSwinging(SwingHandlePort target)
        {
            Node node = new Node()
            {Name = "Swing Handle Get Is Swinging", Type = "cdebca62-2e6c-4353-8691-d1daae868f5f", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Tan(FloatPort value)
        {
            Node node = new Node()
            {Name = "Tan", Type = "13dbbd78-11c0-4b4f-9098-1ef59e584324", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ColorPort TextGetColor(TextPort target)
        {
            Node node = new Node()
            {Name = "Text Get Color", Type = "2b28277e-29a1-4b97-b151-2f23ff28c4c2", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort TextGetText(TextPort target)
        {
            Node node = new Node()
            {Name = "Text Get Text", Type = "3e8fbb88-3179-4a4c-9f8f-d9c2db35b9b5", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void TextSetColor(TextPort target, ColorPort color)
        {
            Node node = new Node()
            {Name = "Text Set Color", Type = "0bfaa337-46a1-472f-beac-12faa21867d4", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void TextSetColorIdDeprecated(TextPort target, IntPort color)
        {
            Node node = new Node()
            {Name = "Text Set Color Id", Type = "20b2528d-96a9-4be8-9782-aa75959f5232", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void TextSetMaterial(TextPort target, IntPort material)
        {
            Node node = new Node()
            {Name = "Text Set Material", Type = "ef6fcf56-1b3f-42bc-af50-019ff0a9cfc5", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(material, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void TextSetText(TextPort target, StringPort text)
        {
            Node node = new Node()
            {Name = "Text Set Text", Type = "c941f3a3-d3f6-49cc-a6a4-b7a4e95fd173", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(text, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static FloatPort TimeGetPreciseSeconds()
        {
            Node node = new Node()
            {Name = "Time Get Precise Seconds", Type = "8722445f-e552-4d4a-bced-8afa63bbf70b", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort TimeGetUniversalSeconds()
        {
            Node node = new Node()
            {Name = "Time Get Universal Seconds", Type = "bc3059d8-b613-4e91-ac7f-4c3566e01dc2", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (IntPort Year, IntPort Month, IntPort Day, IntPort Hour, IntPort Minute, IntPort Second) TimeGetUniversalTime()
        {
            Node node = new Node()
            {Name = "Time Get Universal Time", Type = "1b220886-d851-474c-a79e-0a18d0893ee9", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = (new IntPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new IntPort{Port = new Port{Node = node, Index = 2}}, new IntPort{Port = new Port{Node = node, Index = 3}}, new IntPort{Port = new Port{Node = node, Index = 4}}, new IntPort{Port = new Port{Node = node, Index = 5}});
            return output_ports;
        }

        public static IntPort TimeGetUnsyncedUniversalSeconds()
        {
            Node node = new Node()
            {Name = "Time Get Unsynced Universal Seconds", Type = "d46f6fdc-480c-41e6-9a27-87fadb0ab0fc", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (IntPort Year, IntPort Month, IntPort Day, IntPort Hour, IntPort Minute, IntPort Second) TimeGetUnsyncedUniversalTime()
        {
            Node node = new Node()
            {Name = "Time Get Unsynced Universal Time", Type = "f33e3fb6-79f1-43da-93c1-553d022b9f37", InputCount = 0};
            Context.current.AddNode(node);
            var output_ports = (new IntPort{Port = new Port{Node = node, Index = 0}}, new IntPort{Port = new Port{Node = node, Index = 1}}, new IntPort{Port = new Port{Node = node, Index = 2}}, new IntPort{Port = new Port{Node = node, Index = 3}}, new IntPort{Port = new Port{Node = node, Index = 4}}, new IntPort{Port = new Port{Node = node, Index = 5}});
            return output_ports;
        }

        public static CombatantPort ToCombatantR1(AIPort playerOrAI)
        {
            Node node = new Node()
            {Name = "To Combatant", Type = "75a3a9c2-da17-4762-b87b-1735b44af659", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(playerOrAI, new Port{Node = node, Index = 0});
            var output_ports = new CombatantPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static CombatantPort ToCombatantR1(PlayerPort playerOrAI)
        {
            Node node = new Node()
            {Name = "To Combatant", Type = "75a3a9c2-da17-4762-b87b-1735b44af659", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(playerOrAI, new Port{Node = node, Index = 0});
            var output_ports = new CombatantPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort ToggleButtonGetIsPressed(ToggleButtonPort target)
        {
            Node node = new Node()
            {Name = "Toggle Button Get Is Pressed", Type = "f8a9cb84-dcb1-4a12-ae29-4d7711e14506", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void ToggleButtonSetIsPressed(ToggleButtonPort target, BoolPort value)
        {
            Node node = new Node()
            {Name = "Toggle Button Set Is Pressed", Type = "4b4857a2-db4d-497e-a135-05b02842fd4e", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void ToggleButtonSetIsPressedDeprecated(ToggleButtonPort target, BoolPort value)
        {
            Node node = new Node()
            {Name = "Toggle Button Set Is Pressed", Type = "fdfb3857-3d13-4d66-9a05-f88586e9f821", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static RecRoomObjectPort ToRecRoomObject<T>(T target)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "To Rec Room Object", Type = "315a494e-84cc-4e3c-acff-389bb932b5d0", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new RecRoomObjectPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort ToString<T>(T value)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "To String", Type = "bddc8e4e-b496-48ee-8e25-5b9fe8e1c6c9", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static StringPort ToStringDeprecated<T>(T value)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "To String", Type = "74e81edb-84bd-4e52-b2f3-a73a62a6b3aa", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (BoolPort IsTouchActive, Vector3Port TouchPosition, Vector3Port WorldPosition) TouchpadComponentGetActiveTouch(TouchpadPort target)
        {
            Node node = new Node()
            {Name = "Touchpad Component Get Active Touch", Type = "b83d2e2f-61e8-4490-8a81-d38c88fff8d1", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = (new BoolPort{Port = new Port{Node = node, Index = 0}}, new Vector3Port{Port = new Port{Node = node, Index = 1}}, new Vector3Port{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static StringPort TouchpadComponentGetInteractionLabel(TouchpadPort target)
        {
            Node node = new Node()
            {Name = "Touchpad Component Get Interaction Label", Type = "32aa1ef2-a230-430b-9809-19c114b1fe44", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort TouchpadComponentGetIsEnabled(TouchpadPort target)
        {
            Node node = new Node()
            {Name = "Touchpad Component Get Is Enabled", Type = "64ca9ac0-04a8-4460-afe5-64a927f1ca4a", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void TouchpadComponentSetInteractionLabel(TouchpadPort target, StringPort label)
        {
            Node node = new Node()
            {Name = "Touchpad Component Set Interaction Label", Type = "41643ef3-6003-43d5-9bc7-d520e7aa5fcf", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(label, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void TouchpadComponentSetIsEnabled(TouchpadPort target, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Touchpad Component Set Is Enabled", Type = "1f27359f-71ca-4827-ab17-5acbdb027837", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static ColorPort TrailGetColor(MotionTrailPort target)
        {
            Node node = new Node()
            {Name = "Trail Get Color", Type = "f8c16cc7-ceaf-471a-b196-5d46ec7ab72a", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ColorPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort TrailGetEnabled(MotionTrailPort target)
        {
            Node node = new Node()
            {Name = "Trail Get Enabled", Type = "f3e39f47-1835-4d09-8e19-d3e9d661990b", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort TrailGetLifetime(MotionTrailPort target)
        {
            Node node = new Node()
            {Name = "Trail Get Lifetime", Type = "0f069b0b-6f70-4386-9c7f-1343661e8df6", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort TrailGetOpacity(MotionTrailPort target)
        {
            Node node = new Node()
            {Name = "Trail Get Opacity", Type = "6dcc7a44-0163-4058-97a9-1ef7f482a3d5", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void TrailSetColor(MotionTrailPort target, ColorPort color)
        {
            Node node = new Node()
            {Name = "Trail Set Color", Type = "d326ebc4-1653-4c1d-886c-c1bd4c06db86", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(color, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void TrailSetEnabled(MotionTrailPort target, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Trail Set Enabled", Type = "0bf0dcf8-0731-40d4-883d-288862c98aed", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void TrailSetLifetime(MotionTrailPort target, FloatPort lifetime)
        {
            Node node = new Node()
            {Name = "Trail Set Lifetime", Type = "eb69e7ac-e579-463c-9da9-643e639cf333", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(lifetime, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void TrailSetOpacity(MotionTrailPort target, FloatPort maxOpacity)
        {
            Node node = new Node()
            {Name = "Trail Set Opacity", Type = "bb79cf12-6d38-4691-a004-c2b3ad963374", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(maxOpacity, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static StringPort TriggerHandleGetControlPromptDeprecated(TriggerHandlePort target)
        {
            Node node = new Node()
            {Name = "Trigger Handle Get Control Prompt", Type = "8ea2fd23-02c2-4055-ab39-68acd0b6ce67", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static BoolPort TriggerHandleGetPrimaryActionHeld(TriggerHandlePort target)
        {
            Node node = new Node()
            {Name = "Trigger Handle Get Primary Action Held", Type = "b309c032-1bcd-4ca1-83cf-b8871e65fb16", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void TriggerHandleSetControlPromptDeprecated(TriggerHandlePort target, StringPort controlPrompt)
        {
            Node node = new Node()
            {Name = "Trigger Handle Set Control Prompt", Type = "f4bc9ad9-6050-4c89-b33d-3c780b357d95", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(controlPrompt, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static StringPort TriggerVolumeGetFilterRoleR1(TriggerVolumePort target)
        {
            Node node = new Node()
            {Name = "Trigger Volume Get Filter Role", Type = "b49c4e16-93c5-45c3-b457-fb960c661bc5", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new StringPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort TriggerVolumeGetObjectCount(TriggerVolumePort target)
        {
            Node node = new Node()
            {Name = "Trigger Volume Get Object Count", Type = "338c7e0a-fa55-49e1-91e8-1609d00f1fd0", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<StringPort> TriggerVolumeGetObjectFilterTags(TriggerVolumePort target)
        {
            Node node = new Node()
            {Name = "Trigger Volume Get Object Filter Tags", Type = "8f42f9b7-87fb-4f4b-9160-a45baf269650", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<StringPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<RecRoomObjectPort> TriggerVolumeGetObjects(TriggerVolumePort target)
        {
            Node node = new Node()
            {Name = "Trigger Volume Get Objects", Type = "530932a7-8781-4b09-a945-b33af6675809", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<RecRoomObjectPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static IntPort TriggerVolumeGetPlayerCount(TriggerVolumePort target)
        {
            Node node = new Node()
            {Name = "Trigger Volume Get Player Count", Type = "4cbe661b-7053-4c19-9ccf-1600c7a41016", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new IntPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<StringPort> TriggerVolumeGetPlayerFilterTagsR2(TriggerVolumePort target)
        {
            Node node = new Node()
            {Name = "Trigger Volume Get Player Filter Tags", Type = "7c71350c-67fe-4e57-953b-0b4230a77878", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<StringPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static ListPort<PlayerPort> TriggerVolumeGetPlayers(TriggerVolumePort target)
        {
            Node node = new Node()
            {Name = "Trigger Volume Get Players", Type = "4c23af85-e05c-4be7-a708-c2f0cc67ebec", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new ListPort<PlayerPort>{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void TriggerVolumeSetFilterRoleR1(TriggerVolumePort target, StringPort value)
        {
            Node node = new Node()
            {Name = "Trigger Volume Set Filter Role", Type = "55cfecf9-2623-4aad-948c-6ca89f11911b", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(value, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void TriggerVolumeSetObjectFilterTags(TriggerVolumePort target, ListPort<StringPort> tags)
        {
            Node node = new Node()
            {Name = "Trigger Volume Set Object Filter Tags", Type = "6668fd38-076e-4d03-b9a1-02eca5edd0b7", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(tags, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void TriggerVolumeSetPlayerFilterTagsR2(TriggerVolumePort target, ListPort<StringPort> tags)
        {
            Node node = new Node()
            {Name = "Trigger Volume Set Player Filter Tags", Type = "e53a6e31-af8f-4579-87ba-7e2e49991b04", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(tags, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort UnequipFromPlayer(PlayerPort player, RecRoomObjectPort @object)
        {
            Node node = new Node()
            {Name = "Unequip From Player", Type = "cb633ba9-ae99-43ae-b848-ffcea0b44a4a", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(@object, new Port{Node = node, Index = 2});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static ListPort<RecRoomObjectPort> UnequipFromSlotsR1(PlayerPort player, BoolPort dominantHand, BoolPort offHand, BoolPort leftHipHolster, BoolPort rightHipHolster, BoolPort shoulderHolster)
        {
            Node node = new Node()
            {Name = "Unequip from Slots", Type = "13a06844-ab37-41d6-9358-0383cf3c35d7", InputCount = 7};
            Context.current.AddNode(node);
            node.ConnectInputPort(player, new Port{Node = node, Index = 1});
            node.ConnectInputPort(dominantHand, new Port{Node = node, Index = 2});
            node.ConnectInputPort(offHand, new Port{Node = node, Index = 3});
            node.ConnectInputPort(leftHipHolster, new Port{Node = node, Index = 4});
            node.ConnectInputPort(rightHipHolster, new Port{Node = node, Index = 5});
            node.ConnectInputPort(shoulderHolster, new Port{Node = node, Index = 6});
            var output_ports = new ListPort<RecRoomObjectPort>{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static BoolPort UnequipObject(RecRoomObjectPort @object)
        {
            Node node = new Node()
            {Name = "Unequip Object", Type = "df6cdb0c-24d7-447d-b29b-3979e51fb865", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(@object, new Port{Node = node, Index = 1});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return output_ports;
        }

        public static T ValueIntegerSwitch<T>(IntPort match, T @default)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Value Integer Switch", Type = "be534038-473e-40ad-b4e2-abd38a76711b", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(match, new Port{Node = node, Index = 0});
            node.ConnectInputPort(@default, new Port{Node = node, Index = 1});
            var output_ports = new T{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static T ValueStringSwitch<T>(StringPort match, T @default)
            where T : AnyPort, new()
        {
            Node node = new Node()
            {Name = "Value String Switch", Type = "2c9dcd54-dd65-498e-8a13-50c221448358", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(match, new Port{Node = node, Index = 0});
            node.ConnectInputPort(@default, new Port{Node = node, Index = 1});
            var output_ports = new T{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3ClampMagnitude(Vector3Port vector, FloatPort maxLength)
        {
            Node node = new Node()
            {Name = "Vector3 Clamp Magnitude", Type = "c12ba6c4-51f6-478c-96a7-b989dbe6df80", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(vector, new Port{Node = node, Index = 0});
            node.ConnectInputPort(maxLength, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3ClosestPointOnPlane(Vector3Port position, Vector3Port planePosition, Vector3Port planeNormal)
        {
            Node node = new Node()
            {Name = "Vector3 Closest Point On Plane", Type = "abb84e7e-c879-4744-8f29-5392f975d8a0", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(position, new Port{Node = node, Index = 0});
            node.ConnectInputPort(planePosition, new Port{Node = node, Index = 1});
            node.ConnectInputPort(planeNormal, new Port{Node = node, Index = 2});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3Create(FloatPort x, FloatPort y, FloatPort z)
        {
            Node node = new Node()
            {Name = "Vector3 Create", Type = "814e9337-7542-4851-9da0-c73885ab0b4f", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(x, new Port{Node = node, Index = 0});
            node.ConnectInputPort(y, new Port{Node = node, Index = 1});
            node.ConnectInputPort(z, new Port{Node = node, Index = 2});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3Cross(Vector3Port lhs, Vector3Port rhs)
        {
            Node node = new Node()
            {Name = "Vector3 Cross", Type = "6bd92538-6889-41f3-b819-9511e6f81944", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(lhs, new Port{Node = node, Index = 0});
            node.ConnectInputPort(rhs, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort Vector3Dot(Vector3Port lhs, Vector3Port rhs)
        {
            Node node = new Node()
            {Name = "Vector3 Dot", Type = "498c4e25-f73b-49a6-912e-ae148ed50dca", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(lhs, new Port{Node = node, Index = 0});
            node.ConnectInputPort(rhs, new Port{Node = node, Index = 1});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3Inverse(Vector3Port value)
        {
            Node node = new Node()
            {Name = "Vector3 Inverse", Type = "429fc835-d971-48fd-a030-d8f7d5a96437", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3InverseTransform(Vector3Port worldPoint, Vector3Port worldOrigin, QuaternionPort worldOrientation)
        {
            Node node = new Node()
            {Name = "Vector3 Inverse Transform", Type = "97b150f5-7bd0-4649-96d7-fdf0b5e88ffb", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(worldPoint, new Port{Node = node, Index = 0});
            node.ConnectInputPort(worldOrigin, new Port{Node = node, Index = 1});
            node.ConnectInputPort(worldOrientation, new Port{Node = node, Index = 2});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3MoveTowards(Vector3Port current, Vector3Port target, FloatPort maxDelta)
        {
            Node node = new Node()
            {Name = "Vector3 Move Towards", Type = "266d90c7-403e-4059-a481-ce3e22d61420", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(current, new Port{Node = node, Index = 0});
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(maxDelta, new Port{Node = node, Index = 2});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3Normalize(Vector3Port value)
        {
            Node node = new Node()
            {Name = "Vector3 Normalize", Type = "92ded211-17d6-4c73-b29c-71323c6a40ee", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3Project(Vector3Port vector, Vector3Port onNormal)
        {
            Node node = new Node()
            {Name = "Vector3 Project", Type = "11dcd185-ffb5-476e-a469-d0588f36a2f8", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(vector, new Port{Node = node, Index = 0});
            node.ConnectInputPort(onNormal, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3ProjectOnPlane(Vector3Port vector, Vector3Port planeNormal)
        {
            Node node = new Node()
            {Name = "Vector3 Project On Plane", Type = "f874d150-7d49-4f10-ac51-50dd9bd29c4f", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(vector, new Port{Node = node, Index = 0});
            node.ConnectInputPort(planeNormal, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3Scale(Vector3Port value, IntPort scalar)
        {
            Node node = new Node()
            {Name = "Vector3 Scale", Type = "87aa17b1-7760-4b07-8c44-a2d530590597", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            node.ConnectInputPort(scalar, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3Scale(Vector3Port value, FloatPort scalar)
        {
            Node node = new Node()
            {Name = "Vector3 Scale", Type = "87aa17b1-7760-4b07-8c44-a2d530590597", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(value, new Port{Node = node, Index = 0});
            node.ConnectInputPort(scalar, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static (FloatPort X, FloatPort Y, FloatPort Z) Vector3Split(Vector3Port vector3)
        {
            Node node = new Node()
            {Name = "Vector3 Split", Type = "2d677241-61b7-45d2-aec2-4a302e3483a0", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(vector3, new Port{Node = node, Index = 0});
            var output_ports = (new FloatPort{Port = new Port{Node = node, Index = 0}}, new FloatPort{Port = new Port{Node = node, Index = 1}}, new FloatPort{Port = new Port{Node = node, Index = 2}});
            return output_ports;
        }

        public static Vector3Port Vector3Transform(Vector3Port localPoint, Vector3Port worldOrigin, QuaternionPort worldOrientation)
        {
            Node node = new Node()
            {Name = "Vector3 Transform", Type = "64924217-da3a-4a6f-b84d-e499634d763b", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(localPoint, new Port{Node = node, Index = 0});
            node.ConnectInputPort(worldOrigin, new Port{Node = node, Index = 1});
            node.ConnectInputPort(worldOrientation, new Port{Node = node, Index = 2});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static Vector3Port Vector3Variable(Vector3Port port1, VariableData config)
        {
            Node node = new Node()
            {Name = "Vector3 Variable", Type = "fba2accf-44e2-412d-a204-ae3bd04f7dfa", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(port1, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 1}};
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            node.VariableData = config;
            return output_ports;
        }

        public static Vector3Port VectorComponentGetVector(VectorComponentPort direction, FloatPort magnitude)
        {
            Node node = new Node()
            {Name = "Vector Component Get Vector", Type = "74ba9189-2880-46fa-b4b0-3c9a7152489e", InputCount = 2};
            Context.current.AddNode(node);
            node.ConnectInputPort(direction, new Port{Node = node, Index = 0});
            node.ConnectInputPort(magnitude, new Port{Node = node, Index = 1});
            var output_ports = new Vector3Port{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static FloatPort VectorGetMagnitude(Vector3Port vector3)
        {
            Node node = new Node()
            {Name = "Vector Get Magnitude", Type = "c3b9ba98-6c4a-44c2-9125-043314fba4a6", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(vector3, new Port{Node = node, Index = 0});
            var output_ports = new FloatPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void VelocityAdd(PlayerPort target, FloatPort multiplier, Vector3Port velocity, FloatPort maximumSpeed)
        {
            Node node = new Node()
            {Name = "Velocity Add", Type = "f94206bd-1903-492f-85fc-07f8f756b9f5", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(multiplier, new Port{Node = node, Index = 2});
            node.ConnectInputPort(velocity, new Port{Node = node, Index = 3});
            node.ConnectInputPort(maximumSpeed, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void VelocityAdd(RecRoomObjectPort target, FloatPort multiplier, Vector3Port velocity, FloatPort maximumSpeed)
        {
            Node node = new Node()
            {Name = "Velocity Add", Type = "f94206bd-1903-492f-85fc-07f8f756b9f5", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(multiplier, new Port{Node = node, Index = 2});
            node.ConnectInputPort(velocity, new Port{Node = node, Index = 3});
            node.ConnectInputPort(maximumSpeed, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void VelocityAddDeprecated(PlayerPort target, FloatPort speed, Vector3Port direction, FloatPort maximumSpeed)
        {
            Node node = new Node()
            {Name = "Velocity Add", Type = "1b5eca75-0e7e-4aff-8adc-c5e043cac29e", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(speed, new Port{Node = node, Index = 2});
            node.ConnectInputPort(direction, new Port{Node = node, Index = 3});
            node.ConnectInputPort(maximumSpeed, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void VelocityAddDeprecated(RecRoomObjectPort target, FloatPort speed, Vector3Port direction, FloatPort maximumSpeed)
        {
            Node node = new Node()
            {Name = "Velocity Add", Type = "1b5eca75-0e7e-4aff-8adc-c5e043cac29e", InputCount = 5};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(speed, new Port{Node = node, Index = 2});
            node.ConnectInputPort(direction, new Port{Node = node, Index = 3});
            node.ConnectInputPort(maximumSpeed, new Port{Node = node, Index = 4});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void VelocityReflect(PlayerPort target, FloatPort additionalSpeed, FloatPort speedMultiplier, Vector3Port direction, FloatPort maximumSpeed)
        {
            Node node = new Node()
            {Name = "Velocity Reflect", Type = "f0137efc-b3b7-4217-ba8b-1d2e78d451bd", InputCount = 6};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(additionalSpeed, new Port{Node = node, Index = 2});
            node.ConnectInputPort(speedMultiplier, new Port{Node = node, Index = 3});
            node.ConnectInputPort(direction, new Port{Node = node, Index = 4});
            node.ConnectInputPort(maximumSpeed, new Port{Node = node, Index = 5});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void VelocityReflect(RecRoomObjectPort target, FloatPort additionalSpeed, FloatPort speedMultiplier, Vector3Port direction, FloatPort maximumSpeed)
        {
            Node node = new Node()
            {Name = "Velocity Reflect", Type = "f0137efc-b3b7-4217-ba8b-1d2e78d451bd", InputCount = 6};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(additionalSpeed, new Port{Node = node, Index = 2});
            node.ConnectInputPort(speedMultiplier, new Port{Node = node, Index = 3});
            node.ConnectInputPort(direction, new Port{Node = node, Index = 4});
            node.ConnectInputPort(maximumSpeed, new Port{Node = node, Index = 5});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void VelocitySet(PlayerPort target, FloatPort multiplier, Vector3Port velocity)
        {
            Node node = new Node()
            {Name = "Velocity Set", Type = "ea00c655-56ff-4406-8d65-b8399e6d0169", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(multiplier, new Port{Node = node, Index = 2});
            node.ConnectInputPort(velocity, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void VelocitySet(RecRoomObjectPort target, FloatPort multiplier, Vector3Port velocity)
        {
            Node node = new Node()
            {Name = "Velocity Set", Type = "ea00c655-56ff-4406-8d65-b8399e6d0169", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(multiplier, new Port{Node = node, Index = 2});
            node.ConnectInputPort(velocity, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void VelocitySetDeprecated(PlayerPort target, FloatPort speed, Vector3Port direction)
        {
            Node node = new Node()
            {Name = "Velocity Set (Deprecated)", Type = "f97c530d-03bf-498c-8854-33e814d2600b", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(speed, new Port{Node = node, Index = 2});
            node.ConnectInputPort(direction, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static void VelocitySetDeprecated(RecRoomObjectPort target, FloatPort speed, Vector3Port direction)
        {
            Node node = new Node()
            {Name = "Velocity Set (Deprecated)", Type = "f97c530d-03bf-498c-8854-33e814d2600b", InputCount = 4};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(speed, new Port{Node = node, Index = 2});
            node.ConnectInputPort(direction, new Port{Node = node, Index = 3});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort WelcomeMatGetEnabled(WelcomeMatPort target)
        {
            Node node = new Node()
            {Name = "Welcome Mat Get Enabled", Type = "d26c3f7a-7204-471b-a0bb-5e52960983f8", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }

        public static void WelcomeMatSetEnabled(WelcomeMatPort target, BoolPort enabled)
        {
            Node node = new Node()
            {Name = "Welcome Mat Set Enabled", Type = "d503f1b3-7c5e-4eba-85ac-b89be2d2360f", InputCount = 3};
            Context.current.AddNode(node);
            node.ConnectInputPort(target, new Port{Node = node, Index = 1});
            node.ConnectInputPort(enabled, new Port{Node = node, Index = 2});
            ExecFlow.current.Advance(Context.current, new Port{Node = node}, new Port{Node = node});
            return;
        }

        public static BoolPort Xor(BoolPort input)
        {
            Node node = new Node()
            {Name = "Xor", Type = "6db8f573-5300-4aa0-bbfa-b5f01533069a", InputCount = 1};
            Context.current.AddNode(node);
            node.ConnectInputPort(input, new Port{Node = node, Index = 0});
            var output_ports = new BoolPort{Port = new Port{Node = node, Index = 0}};
            return output_ports;
        }
    }
}