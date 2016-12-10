using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Visualization_of_Temperature_Flow
{
    public struct NormColor
    {
        double r, g, b;
        public double R
        {
            get { return r; }
            set { if (value >= 0 && value <= 1) r = value; }
        }
        public double G
        {
            get { return g; }
            set { if (value >= 0 && value <= 1) g = value; }
        }
        public double B
        {
            get { return b; }
            set { if (value >= 0 && value <= 1) b = value; }
        }
    }
    public enum Mapping_Mode { Discrete, Continuous }
   
    /*NormColor NormalizeColor(Color color)
        {
            NormColor normColor = new NormColor();
            normColor.R = (double)color.R / 255.0;
            normColor.G = (double)color.G / 255.0;
            normColor.B = (double)color.B / 255.0;
            return normColor;
        }*/
    public static class Color_Mapper
    {
        public static float minValue;
        public static float maxValue;
        public static Color[] colors = { Color.Blue,Color.Aqua, Color.Green, Color.Yellow, Color.Red };
        public static Color ValueToColor(float value, Mapping_Mode mode)
        {
            Color resultColor = Color.White;
            switch (mode)
            {
                case Mapping_Mode.Discrete:
                    resultColor = ValueToColor_LookUpTable(value);
                    break;
                case Mapping_Mode.Continuous:
                    resultColor = ValueToColor_TransferFunction(value);
                    break;
            }
            return resultColor;
        }
        static Color ValueToColor_TransferFunction(float value)
        {
            int numberOfColors = colors.Length;
            float deltaS = (maxValue - minValue) / (numberOfColors - 1);
            float d_S = (value - minValue) / deltaS;
            int i1 = Math.Max((int)d_S, 0);
            int i2 = Math.Min(i1 + 1, numberOfColors - 1);
            float alpha = d_S - i1;

            int R = (int)(colors[i1].R + alpha * (colors[i2].R - colors[i1].R));
            int G = (int)(colors[i1].G + alpha * (colors[i2].G - colors[i1].G));
            int B = (int)(colors[i1].B + alpha * (colors[i2].B - colors[i1].B));
            return Color.FromArgb(R, G, B);

        }
        static Color ValueToColor_LookUpTable(float value)
        {
            int numberOfColors = colors.Length;
            float delta = maxValue - minValue;
            int index = (int)(numberOfColors * (value - minValue) / delta);

            index = Math.Min(index, numberOfColors - 1);
            return colors[index];
        }
    }
}
