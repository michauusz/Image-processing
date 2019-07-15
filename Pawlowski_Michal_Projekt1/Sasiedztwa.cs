using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pawlowski_Michal_Projekt1
{
   public static class Sasiedztwa
    {
        public static Bitmap Medianowe(Bitmap bmp, int value1, int value2)
        {
            Color val;
            byte pVal;
            Bitmap HelpBitMap = new Bitmap(bmp.Width, bmp.Height);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    int[] arr = new int[value1 * value2];
                    for(int i=0; i<value1; ++i )
                    {
                        for(int j=0; j<value2; ++j)
                        {
                            
                        }
                    }


                }

            }
                    return HelpBitMap;
        }

    }
}
