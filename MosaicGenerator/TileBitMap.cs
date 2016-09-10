using System;
using System.Drawing;

namespace MosaicGenerator
{
    public class TileBitmap : IComparable<TileBitmap>
    {
        public Bitmap Bitmap { get; private set; }

        public RGB AvgColor { get; private set; }

        public TileBitmap(Bitmap i_Bitmap)
        {
            Bitmap = new Bitmap(i_Bitmap);
            AvgColor = getAvgColor();
        }

        public TileBitmap(string i_FileName)
        {
            Bitmap = new Bitmap(i_FileName);
            AvgColor = getAvgColor();
        }

        private RGB getAvgColor()
        {
            int red = 0;
            int green = 0;
            int blue = 0;
            int amountOfPixels = 0;

            for (int i = 0; i < Bitmap.Height; i++)
            {
                for (int j = 0; j < Bitmap.Width; j++)
                {
                    Color pixel = Bitmap.GetPixel(j, i);
                    red += pixel.R;
                    green += pixel.G;
                    blue += pixel.B;

                    amountOfPixels++;
                }
            }

            return new RGB((byte)(red / amountOfPixels), (byte)(green / amountOfPixels), (byte)(blue / amountOfPixels));
        }

        public int CompareTo(TileBitmap i_Other)
        {
            return AvgColor.CompareTo(i_Other.AvgColor);
        }
    }
}
