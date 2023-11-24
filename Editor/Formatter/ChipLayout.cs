using RRCGBuild;
using RRCGGenerated;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RRCG.Formatter
{
    public abstract class ChipLayout
    {
        public Vector2 WorldPos { get; protected set; } = Vector2.zero;

        public Vector2 Size { get; protected set; } = Vector2.zero;

        public ChipLayoutPadding Padding = new ChipLayoutPadding(0);

        public List<ChipLayout> children = new List<ChipLayout>();

        // Updates the layout world positions by passing down the top-left position and returning the size bottom-up
        public abstract Vector2 CalculateLayout(Vector2 worldPos);

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
        float depth = 0;
        Node node;
        GameObject instance;

        public ChipLayoutNode(Node node, GameObject instance, bool isExec)
        {
            this.node = node;
            this.instance = instance;

            var size = new Vector2(0.4f, 0.2f);

            if (instance != null)
            {
                size.x += instance.name.Length * 0.01f;
            }

            size.y += Math.Max(node.InputCount, node.SwitchCases?.Count ?? 0) * 0.03f;

            depth = isExec ? -0.025f : -0.015f;

            Size = size;
        }

        public override Vector2 CalculateLayout(Vector2 worldPos)
        {
            WorldPos = worldPos;
            return Size + Padding.Size;
        }

        public override void ApplyLayoutToChips(Vector3 rootPos, Quaternion rootRot)
        {
            if (instance == null) return;

            // Chips have their pivot in the top-center, the layout in the top-left
            var chipPivot = WorldPos + new Vector2(Size.x / 2, 0);

            var chipPos = new Vector3(chipPivot.x, chipPivot.y + HeightOffset(), depth);

            instance.transform.rotation = rootRot;
            instance.transform.position = rootPos + rootRot * chipPos;
        }

        // Some nodes have their exec pins at different heights. This offset is meant to align them.
        private float HeightOffset()
        {
            // Headless chips have a bit of margin in their 
            if (ChipTypeUtils.HeadlessChips.Contains(node.Type)) return 0.02f;

            // Variables have a special shape
            if (ChipTypeUtils.VariableTypes.Contains(node.Type)) return 0.07f;

            // Align as if the first pin of the board was an exec pin
            if (node.Type == ChipType.CircuitBoard || node.Type == ChipType.ControlPanel) return 0.04f;

            return 0f;
        }
    }

    public class ChipLayoutVertical : ChipLayout
    {
        public override Vector2 CalculateLayout(Vector2 worldPos)
        {
            WorldPos = worldPos;

            var nextChildWorldPos = worldPos + Padding.TopLeft;

            foreach (var child in children)
            {
                var childSize = child.CalculateLayout(nextChildWorldPos);

                Size = new Vector2(
                    Mathf.Max(childSize.x, Size.x),
                    Size.y + childSize.y
                );

                nextChildWorldPos += new Vector2(0, -childSize.y);
            }

            return Size + Padding.Size;
        }
    }

    public class ChipLayoutHorizontal : ChipLayout
    {
        public override Vector2 CalculateLayout(Vector2 worldPos)
        {
            WorldPos = worldPos;

            var nextChildWorldPos = worldPos + Padding.TopLeft;

            foreach (var child in children)
            {
                var childSize = child.CalculateLayout(nextChildWorldPos);

                Size = new Vector2(
                    Size.x + childSize.x,
                    Mathf.Max(childSize.y, Size.y)
                );

                nextChildWorldPos += new Vector2(childSize.x, 0);
            }

            return Size + Padding.Size;
        }
    }
}
