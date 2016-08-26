using System;
using System.Drawing;

namespace MosaicGenerator
{
    public struct RGB : IComparable<RGB>
    {
        public byte Red { get; set; }

        public byte Green { get; set; }

        public byte Blue { get; set; }

        public RGB(Color i_Color)
        {
            Red = i_Color.R;
            Green = i_Color.G;
            Blue = i_Color.B;
        }

        public RGB(byte i_Red, byte i_Green, byte i_Blue)
        {
            Red = i_Red;
            Green = i_Green;
            Blue = i_Blue;
        }

        public float GetAverageColorDistance(RGB i_Other)
        {
            int distanceRed = 0;
            int distanceGreen = 0;
            int distanceBlue = 0;

            distanceRed = Red - i_Other.Red;
            distanceGreen = Green - i_Other.Green;
            distanceBlue = Blue - i_Other.Blue;

            return (distanceRed + distanceGreen + distanceBlue) / 3f;
        }

        public int CompareTo(RGB i_Other)
        {
            float avgDistance = GetAverageColorDistance(i_Other);
            int sortOrder;

            if (avgDistance > 0)
            {
                sortOrder = 1;
            }
            else if (avgDistance < 0)
            {
                sortOrder = -1;
            }
            else
            {
                sortOrder = 0;
            }

            return sortOrder;
        }

        public override string ToString()
        {
            return "[" + Red + "," + Green + "," + Blue + "]";
        }
    }
}
