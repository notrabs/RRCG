using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRCG
{
    public struct WorldUIBar
    {
        public bool Enabled;
        public int Value;
        public int MaxValue;
        public bool Animated;

        public WorldUIBar(bool Enabled, int Value, int MaxValue, bool Animated)
        {
            this.Enabled = Enabled;
            this.Value = Value;
            this.MaxValue = MaxValue;
            this.Animated = Animated;
        }
    }

    public struct SFXConstantData
    {
        public string ClipName;
        public float Volume;
        public float SpeedShift;
        public float SpeedVariation;

        public SFXConstantData(string ClipName, float Volume, float SpeedShift, float SpeedVariation)
        {
            this.ClipName = ClipName;
            this.Volume = Volume;
            this.SpeedShift = SpeedShift;
            this.SpeedVariation = SpeedVariation;
        }
    }
}
