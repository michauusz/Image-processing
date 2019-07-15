using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pawlowski_Michal_Projekt1
{
    public static class JednoArgumentowe
    {
        public static Bitmap Negacja(Bitmap bmp)  //negacja
        {
            Color val;  //zmienna do przechowywania rgb
            byte pVal; //zmienna do przechowyania trylko r/g/b
            Bitmap HelpBitMap = new Bitmap(bmp.Width, bmp.Height); //pomocnicza bitmapa
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++) //dla kazdego pixela
                {
                    val = bmp.GetPixel(x, y);  //pobierz kolor

                    pVal = (byte)(255 - val.R); 
                    val = Color.FromArgb(pVal, pVal, pVal); //utworz kolor
                    HelpBitMap.SetPixel(x, y, val); //wstaw do nowej bitmapy pixel

                }
            }
            return HelpBitMap;
        }


        public static Bitmap Progowanie(Bitmap bmp, int value)
        {

            Color val; //zmienna do przechowywania rgb
            byte pVal; //zmienna do przechowyania trylko r/g/b
            Bitmap HelpBitMap = new Bitmap(bmp.Width, bmp.Height);  //pomocnicza bitmapa

            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)  //dla kazdego pixela
                {
                    val = bmp.GetPixel(x, y);  //pobierz kolor
                    pVal = (byte)val.R;   //pobierz czerwony kolor
                    if (pVal > value) pVal = 255;
                    else pVal = 0;
                    val = Color.FromArgb(pVal, pVal, pVal);   //utworz kolor
                    HelpBitMap.SetPixel(x, y, val);  //wstaw do nowej bitmapy pixel
                }
            return HelpBitMap;
        }
        //opisy jak tw wyzej
        public static Bitmap ProgowanieOdwrotne(Bitmap bmp, int value)  //odwrotne progowanie
        {

            Color val;
            byte pVal;
            Bitmap HelpBitMap = new Bitmap(bmp.Width, bmp.Height);

            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {
                    val = bmp.GetPixel(x, y);
                    pVal = (byte)val.R;
                    if (pVal > value) pVal = 0;
                    else pVal = 255;
                    val = Color.FromArgb(pVal, pVal, pVal);
                    HelpBitMap.SetPixel(x, y, val);
                }
            return HelpBitMap;
        }
        public static Bitmap ProgowanieZPrzedzialami(Bitmap bmp, int value1, int value2) //progowanie z przedzialami
        {

            Color val;
            byte pVal;
            Bitmap HelpBitMap = new Bitmap(bmp.Width, bmp.Height);

            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {
                    val = bmp.GetPixel(x, y);
                    pVal = (byte)val.R;
                    if (pVal <value1 || value2<pVal) pVal = 255;            
                    else pVal = 0;
                    val = Color.FromArgb(pVal, pVal, pVal);
                    HelpBitMap.SetPixel(x, y, val);
                }
            return HelpBitMap;
        }
        public static Bitmap ProgowanieZachowanie(Bitmap bmp, int value1,int value2) //progowanie z zachowaniem poziomow szarosci
        {

            Color val;
            byte pVal;
            Bitmap HelpBitMap = new Bitmap(bmp.Width, bmp.Height);

            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {
                    val = bmp.GetPixel(x, y);
                    pVal = (byte)val.R;
                    if (pVal >= value1 && pVal <= value2) pVal = pVal;
                    else pVal = 0;

                    if (pVal >= value1 && pVal <= value2) pVal = (byte)(255 - pVal);
                    else pVal = 0;
                    val = Color.FromArgb(pVal, pVal, pVal);
                    HelpBitMap.SetPixel(x, y, val);
                }
            return HelpBitMap;
        }

        public static Bitmap Rozciaganie(Bitmap bmp, int value1, int value2) //rozciaganie
        {

            Color val;
            byte pVal;
            Bitmap HelpBitMap = new Bitmap(bmp.Width, bmp.Height);

            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {
                    val = bmp.GetPixel(x, y);
                    pVal = (byte)val.R;
                    if (value1 < pVal && pVal <= value2) pVal = (byte)((pVal - value1) * (255 / (value2 - value1)));
                    else pVal = 0;

                    if (pVal >= value1 && pVal <= value2) pVal = (byte)(255 - pVal);
                    else pVal = 0;
                    val = Color.FromArgb(pVal, pVal, pVal);
                    HelpBitMap.SetPixel(x, y, val);
                }
            return HelpBitMap;

        }

        public static Bitmap Jasnosc(Bitmap bmp, int value1)  //korekcja jasnosci
        {

            Color val;
            byte pVal;
            Bitmap HelpBitMap = new Bitmap(bmp.Width, bmp.Height);

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    val = bmp.GetPixel(x, y);
                    pVal = (byte)val.R;
                    double value = pVal + value1 * (256 / 256.0);
                    if (value < 0) pVal = 0;
                    else if (value > 256 - 1) pVal = (byte)(256 - 1);
                    else pVal = (byte)value;
                    val = Color.FromArgb(pVal, pVal, pVal);
                    HelpBitMap.SetPixel(x, y, val);
                }
            }
            
            return HelpBitMap;

        }
        public static Bitmap Kontrast(Bitmap bmp, int value1)  //korecka kontrastu
        {
            Color val;
            byte pVal;
            Bitmap HelpBitMap = new Bitmap(bmp.Width, bmp.Height);
            
            double multiplier = (100.0 + (double)value1) / 100.0;
            double lmax = (double)(256 - 1);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    val = bmp.GetPixel(x, y);
                    pVal = (byte)val.R;
                    double temp = ((double)pVal / lmax) - 0.5;
                    temp = temp * multiplier + 0.5;
                    pVal = (byte)Math.Max(0, Math.Min(256 - 1, (int)(temp * lmax)));
                    val = Color.FromArgb(pVal, pVal, pVal);
                    HelpBitMap.SetPixel(x, y, val);
                }
            }

            return HelpBitMap;

        }

        public static Bitmap Gamma(Bitmap bmp, int value1)  //korekcja  kanalami gammy
        {

            Color val;
            byte pVal;
            Bitmap HelpBitMap = new Bitmap(bmp.Width, bmp.Height);

           

            byte[] upo = new byte[256];
            double lmax = (double)(256 - 1);
            for (int i = 0; i < 256; ++i)
            {
                int pos = (int)((lmax * Math.Pow(i / lmax, 1.0 / value1)) + 0.5);
                pos = Math.Min(Math.Max(pos, 0), 256 - 1);
                upo[i] = (byte)pos;
            }

            for (int x = 0; x < bmp.Width; x++)
                for (int y = 0; y < bmp.Height; y++)
                {
                    val = bmp.GetPixel(x, y);
                    pVal = (byte)val.R;
                    val = Color.FromArgb(upo[pVal], upo[pVal], upo[pVal]);
                    HelpBitMap.SetPixel(x, y, val);
                }
                   


            return HelpBitMap;

        }

    }
}
