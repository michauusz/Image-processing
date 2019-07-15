using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pawlowski_Michal_Projekt1
{
    class BMP
    {
        public int[] getArrayBMP(String fileName) //pobierz tablice bitmapy z nazwy pliku
        {
            int[] arr = new int[256];

            Bitmap myBitmap = new Bitmap(fileName);
            Color beb;
            for (int i = 0; i < arr.Length; ++i) arr[i] = 0;







            for (int i = 0; i < myBitmap.Width; ++i)
            {
                for (int j = 0; j < myBitmap.Height; ++j)
                {
                    beb = myBitmap.GetPixel(i, j);
                    arr[beb.R]++;
                }

            }



            return arr;
        }

        public int[] getArrayBMP(Bitmap myBitmap) //pobierz tablice bitmapy z gotowej bitmapy
        {
            int[] arr = new int[256];

            // Bitmap myBitmap = new Bitmap();
            Color beb;
            for (int i = 0; i < arr.Length; ++i) arr[i] = 0;







            for (int i = 0; i < myBitmap.Width; ++i)
            {
                for (int j = 0; j < myBitmap.Height; ++j)
                {
                    beb = myBitmap.GetPixel(i, j);
                    arr[beb.R]++;
                }

            }



            return arr;
        }
    }
}
