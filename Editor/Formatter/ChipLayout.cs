using RRCGBuild;
using RRCGGenerated;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RRCG.Formatter
{
    public enum ChipLayoutAlignment
    {
        START = 0,
        CENTER = 1,
    }

    public abstract class ChipLayout
    {
        public Vector2 WorldPos { get; protected set; } = Vector2.zero;
        public Vector2 Size { get; protected set; } = Vector2.zero;

        public ChipLayoutPadding Padding = new ChipLayoutPadding(0);

        public ChipLayoutAlignment Alignment = ChipLayoutAlignment.START;

        public List<ChipLayout> children = new List<ChipLayout>();

        // Updates the layout world positions by passing down the top-left position and returning the size bottom-up
        public abstract Vector2 CalculateSize();
        public abstract void CalculateLayout(Vector2 worldPos);

        public Vector2 Calculate()
        {
            var size = CalculateSize();
            CalculateLayout(WorldPos);

            return size;
        }

        public virtual void ApplyLayoutToChips(Vector3 rootPos, Quaternion rootRot)
        {
            foreach (var child in children) child.ApplyLayoutToChips(rootPos, rootRot);
        }

        public T AddChild<T>(T child) where T : ChipLayout { children.Add(child); return child; }
    }

    public record ChipLayoutPadding(float Top, float Bottom, float Left, float Right)
    {
        public ChipLayoutPadding(float All) : this(All, All, All, All) { }

        public Vector2 Size { get => new Vector2(Left + Right, Top + Bottom); }
        public Vector2 TopLeft { get => new Vector2(Left, -Top); }
    }

    public class ChipLayoutNode : ChipLayout
    {
        bool isExec;
        Node node;

        public ChipLayoutNode(Node node, bool isExec)
        {
            this.node = node;
            this.isExec = isExec;

            Size = new Vector2(
                0.4f + node.Name.Length * 0.01f,
                0.2f + Math.Max(Math.Max(node.InputCount, node.SwitchCases?.Count ?? 0), node.SequenceData?.NumBranches ?? 0) * 0.03f
            );
        }
        public override Vector2 CalculateSize() => Size + Padding.Size;
        public override void CalculateLayout(Vector2 worldPos) => WorldPos = worldPos;

        public override void ApplyLayoutToChips(Vector3 rootPos, Quaternion rootRot)
        {
            // Chips have their pivot in the top-center, the layout in the top-left
            var chipPivot = WorldPos + new Vector2(Size.x / 2, 0);

            var depth = isExec ? -0.025f : -0.015f;

            var chipPos = new Vector3(chipPivot.x, chipPivot.y + HeightOffset(), depth);

            node.TransformData = new TransformData(
                rootPos + rootRot * chipPos,
                rootRot
            );
        }

        // Some nodes have their exec pins at different heights. This offset is meant to align them.
        private float HeightOffset()
        {
            // Headless chips have a bit of margin in their 
            if (ChipTypeUtils.HeadlessChips.Contains(node.Type)) return 0.02f;

            // Variables have a special shape
            if (ChipTypeUtils.VariableTypes.Contains(node.Type)) return 0.07f;

            // Align as if the first pin of the board was an exec pin, or align on top when it only has data pins
            if (node.Type == ChipType.CircuitBoard || node.Type == ChipType.ControlPanel)
                return isExec ? 0.04f : -0.02f;

            return 0f;
        }
    }

    public class ChipLayoutVertical : ChipLayout
    {
        public override Vector2 CalculateSize()
        {
            foreach (var child in children)
            {
                var childSize = child.CalculateSize();

                Size = new Vector2(
                    Mathf.Max(childSize.x, Size.x),
                    Size.y + childSize.y
                );
            }

            return Size + Padding.Size;
        }

        public override void CalculateLayout(Vector2 worldPos)
        {
            WorldPos = worldPos;

            var nextChildWorldPos = worldPos + Padding.TopLeft;

            foreach (var child in children)
            {
                var alignmentOffset = child.Alignment switch
                {
                    ChipLayoutAlignment.START => new Vector2(0, 0),
                    ChipLayoutAlignment.CENTER => new Vector2((Size.x - child.Size.x) / 2f, 0),
                    _ => throw new NotImplementedException(),
                };

                child.CalculateLayout(nextChildWorldPos + alignmentOffset);

                nextChildWorldPos += new Vector2(0, -child.Size.y);
            }
        }
    }

    public class ChipLayoutHorizontal : ChipLayout
    {
        public override Vector2 CalculateSize()
        {
            foreach (var child in children)
            {
                var childSize = child.CalculateSize();

                Size = new Vector2(
                    Size.x + childSize.x,
                    Mathf.Max(childSize.y, Size.y)
                );
            }

            return Size + Padding.Size;
        }

        public override void CalculateLayout(Vector2 worldPos)
        {
            WorldPos = worldPos;

            var nextChildWorldPos = worldPos + Padding.TopLeft;

            foreach (var child in children)
            {
                var alignmentOffset = child.Alignment switch
                {
                    ChipLayoutAlignment.START => new Vector2(0, 0),
                    ChipLayoutAlignment.CENTER => new Vector2(0, (Size.y - child.Size.y) / 2f),
                    _ => throw new NotImplementedException(),
                };

                child.CalculateLayout(nextChildWorldPos + alignmentOffset);

                nextChildWorldPos += new Vector2(child.Size.x, 0);
            }
        }
    }
}
