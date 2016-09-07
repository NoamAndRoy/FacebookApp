using System;
using System.Collections.Generic;
using System.Drawing;

namespace MosaicGenerator
{
    public class Mosaic
    {
        public Bitmap Image { get; set; }

        public Bitmap ImageMosaic { get; private set; }

        public Mosaic(Bitmap i_Image)
        {
            Image = i_Image;
        }

        public void GenerateMosaicFromList(List<Bitmap> i_Bitmaps, int i_PixelSize)
        {
            RGB[,] pixelatedMatrix = createPixelatedImage(Image, i_PixelSize);
            List<TileBitmap> tileBitmaps = createTileBitmapsFromBitMaps(i_Bitmaps);
            tileBitmaps.Sort();

            ImageMosaic = createMosaic(pixelatedMatrix, tileBitmaps, i_PixelSize);
        }

        private List<TileBitmap> createTileBitmapsFromBitMaps(List<Bitmap> i_Bitmaps)
        {
            List<TileBitmap> bitmaps = new List<TileBitmap>(i_Bitmaps.Count);

            for (int i = 0; i < i_Bitmaps.Count; i++)
            {
                bitmaps.Add(new TileBitmap(i_Bitmaps[i]));
            }

            return bitmaps;
        }

        private Bitmap createMosaic(RGB[,] i_PixelatedMatrix, List<TileBitmap> i_Bitmaps, int i_PixelSize)
        {
            Bitmap mosaic = new Bitmap(i_PixelatedMatrix.GetLength(0) * i_PixelSize, i_PixelatedMatrix.GetLength(1) * i_PixelSize);
            Graphics g = Graphics.FromImage(mosaic);
            int xLength = mosaic.Width / i_PixelSize;
            int yLength = mosaic.Height / i_PixelSize;

            for (int i = 0; i < yLength * i_PixelSize; i += i_PixelSize)
            {
                for (int j = 0; j < xLength * i_PixelSize; j += i_PixelSize)
                {
                    Bitmap bitmapToDraw = getBestMatchBitmap(i_PixelatedMatrix, i_Bitmaps, j / i_PixelSize, i / i_PixelSize);
                    g.DrawImage(bitmapToDraw, j, i, i_PixelSize, i_PixelSize);
                }
            }

            return mosaic;
        }

        private Bitmap getBestMatchBitmap(RGB[,] i_PixelatedMatrix, List<TileBitmap> i_Bitmaps, int i_X, int i_Y)
        {
            RGB pixelRgb = i_PixelatedMatrix[i_X, i_Y];
            List<RGB> bitMapsRgbs = new List<RGB>(i_Bitmaps.Count);

            foreach (TileBitmap bitmap in i_Bitmaps)
            {
                bitMapsRgbs.Add(bitmap.AvgColor);
            }

            int index = bitMapsRgbs.BinarySearch(pixelRgb);
            if (index < 0)
            {
                index = ~index;
                if (index == i_Bitmaps.Count)
                {
                    index -= 1;
                }
                else if (index > 0)
                {
                    if (i_Bitmaps[index].AvgColor.GetAverageColorDistance(pixelRgb) > i_Bitmaps[index - 1].AvgColor.GetAverageColorDistance(pixelRgb))
                    {
                        index -= 1;
                    }
                }
            }

            return i_Bitmaps[index].Bitmap;
        }

        private RGB[,] createPixelatedImage(Bitmap i_Image, int i_PixelSize)
        {
            int width = (int)Math.Ceiling((double)i_Image.Width / i_PixelSize);
            int height = (int)Math.Ceiling((double)i_Image.Height / i_PixelSize);
            RGB[,] rgbPixelatedMatrix = new RGB[width, height];

            for (int i = 0; i < i_Image.Height && i * i_PixelSize < height * i_PixelSize; i++)
            {
                for (int j = 0; j < i_Image.Width && j * i_PixelSize < width * i_PixelSize; j++)
                {
                    rgbPixelatedMatrix[j, i] = getAverageRGB(i_Image, i * i_PixelSize, j * i_PixelSize, i_PixelSize);
                }
            }

            return rgbPixelatedMatrix;
        }

        private RGB getAverageRGB(Bitmap i_Image, int i_StartY, int i_StartX, int i_PixelateSize)
        {
            int red = 0;
            int green = 0;
            int blue = 0;
            int amountOfPixels = 0;

            for (int i = i_StartY; i < i_StartY + i_PixelateSize && i < i_Image.Height; i++)
            {
                for (int j = i_StartX; j < i_StartX + i_PixelateSize && j < i_Image.Width; j++)
                {
                    Color pixel = i_Image.GetPixel(j, i);
                    red += pixel.R;
                    green += pixel.G;
                    blue += pixel.B;
                    amountOfPixels++;
                }
            }

            return new RGB((byte)(red / amountOfPixels), (byte)(green / amountOfPixels), (byte)(blue / amountOfPixels));
        }
    }
}
