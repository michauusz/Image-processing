using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pawlowski_Michal_Projekt1
{
    public static class Dwuargumentowe
    {

        //arytmetyczne
        public static Bitmap Dodawanie(Bitmap bmp1, Bitmap bmp2)  //dodawanie
        {
            Color val; //kolor pixela
            byte p1Val, p2Val, p3Val; //wartosci pixela dla 3ch obrazow
            Bitmap HelpBitMap = new Bitmap(bmp1.Width, bmp1.Height); //nowa bitmapa
            for (int x = 0; x < bmp1.Width; x++)
            {
                for (int y = 0; y < bmp1.Height; y++) //dla kazdego pixela
                {
                    val = bmp1.GetPixel(x, y);
                    p1Val = (byte)val.R;
                    val = bmp2.GetPixel(x, y);
                    p2Val = (byte)val.R;
                    p3Val = (byte)((p1Val + p2Val)/2);
                    p3Val = (byte)Math.Min(p3Val, (byte)255);


                    val = Color.FromArgb(p3Val, p3Val, p3Val);
                    HelpBitMap.SetPixel(x, y, val); //wpisz do nowej bitmapy nowy kolor

                }
            }




            return HelpBitMap;
        }

        public static Bitmap Odejmowanie(Bitmap bmp1, Bitmap bmp2)  //odejmowanie
        {
            Color val;
            byte p1Val, p2Val, p3Val;
            Bitmap HelpBitMap = new Bitmap(bmp1.Width, bmp1.Height);
            for (int x = 0; x < bmp1.Width; x++)
            {
                for (int y = 0; y < bmp1.Height; y++)
                {
                    val = bmp1.GetPixel(x, y);
                    p1Val = (byte)val.R;
                    val = bmp2.GetPixel(x, y);
                    p2Val = (byte)val.R;
                    p3Val = (byte)(p1Val - p2Val);
                    if (p3Val < 0) p3Val = (byte)(p3Val *(-1));
                    val = Color.FromArgb(p3Val, p3Val, p3Val);
                    HelpBitMap.SetPixel(x, y, val);

                }
            }




            return HelpBitMap;
        }
        public static Bitmap Mnozenie(Bitmap bmp1, Bitmap bmp2) //Mnozenie
        {
            Color val;
            byte p1Val, p2Val, p3Val;
            Bitmap HelpBitMap = new Bitmap(bmp1.Width, bmp1.Height);
            Random rand = new Random();
            float num;
            for (int x = 0; x < bmp1.Width; x++)
            {
                for (int y = 0; y < bmp1.Height; y++)
                {
                    val = bmp1.GetPixel(x, y);
                    p1Val = (byte)val.R;
                    val = bmp2.GetPixel(x, y);
                    p2Val = (byte)val.R;
                    num = rand.Next(10);
                    num = num /10f;
                    p3Val = (byte)((p1Val * num) + p1Val);



                    val = Color.FromArgb(p3Val, p3Val, p3Val);
                    HelpBitMap.SetPixel(x, y, val);

                }
            }




            return HelpBitMap;
        }

        public static Bitmap Dzielenie(Bitmap bmp1, Bitmap bmp2)  //dzielenie
        {
            Color val;
            byte p1Val, p2Val, p3Val;
            Bitmap HelpBitMap = new Bitmap(bmp1.Width, bmp1.Height);
            for (int x = 0; x < bmp1.Width; x++)
            {
                for (int y = 0; y < bmp1.Height; y++)
                {
                    val = bmp1.GetPixel(x, y);
                    p1Val = (byte)val.R;
                    val = bmp2.GetPixel(x, y);
                    p2Val = (byte)val.R;


                    if (p2Val > 0) p3Val = (byte)Math.Min(p1Val / p2Val, 255);
                    else p3Val = p1Val;

                    val = Color.FromArgb(p3Val, p3Val, p3Val);
                    HelpBitMap.SetPixel(x, y, val);

                }
            }




            return HelpBitMap;
        }
        public static Bitmap Roznica(Bitmap bmp1, Bitmap bmp2) //roznica
        {
            Color val;
            byte p1Val, p2Val, p3Val;
            Bitmap HelpBitMap = new Bitmap(bmp1.Width, bmp1.Height);
            for (int x = 0; x < bmp1.Width; x++)
            {
                for (int y = 0; y < bmp1.Height; y++)
                {
                    val = bmp1.GetPixel(x, y);
                    p1Val = (byte)val.R;
                    val = bmp2.GetPixel(x, y);
                    p2Val = (byte)val.R;

                    p3Val = (byte)Math.Min(Math.Abs(p1Val - p2Val), 255);


                    val = Color.FromArgb(p3Val, p3Val, p3Val);
                    HelpBitMap.SetPixel(x, y, val);

                }
            }




            return HelpBitMap;
        }
        public static Bitmap Srednia(Bitmap bmp1, Bitmap bmp2) //srednia
        {
            Color val;
            byte p1Val, p2Val, p3Val;
            Bitmap HelpBitMap = new Bitmap(bmp1.Width, bmp1.Height);
            for (int x = 0; x < bmp1.Width; x++)
            {
                for (int y = 0; y < bmp1.Height; y++)
                {
                    val = bmp1.GetPixel(x, y);
                    p1Val = (byte)val.R;
                    val = bmp2.GetPixel(x, y);
                    p2Val = (byte)val.R;
                    p3Val = (byte)Math.Min((p1Val + p2Val) / 2, 255);


                    val = Color.FromArgb(p3Val, p3Val, p3Val);
                    HelpBitMap.SetPixel(x, y, val);

                }
            }




            return HelpBitMap;
        }

        //logiczne
        public static Bitmap AND(Bitmap bmp1, Bitmap bmp2) //AND
        {
            Color val;
            byte p1Val, p2Val, p3Val;
            Bitmap HelpBitMap = new Bitmap(bmp1.Width, bmp1.Height);
            Random rand = new Random();
            
            for (int x = 0; x < bmp1.Width; x++)
            {
                for (int y = 0; y < bmp1.Height; y++)
                {
                    val = bmp1.GetPixel(x, y);
                    p1Val = (byte)val.R;
                    val = bmp2.GetPixel(x, y);
                    p2Val = (byte)val.R;
                    p3Val = (byte)Math.Min(p1Val & p2Val, 255);



                    val = Color.FromArgb(p3Val, p3Val, p3Val);
                    HelpBitMap.SetPixel(x, y, val);

                }
            }




            return HelpBitMap;
        }
        public static Bitmap OR(Bitmap bmp1, Bitmap bmp2) //OR
        {

            Color val;
            byte p1Val, p2Val, p3Val;
            Bitmap HelpBitMap = new Bitmap(bmp1.Width, bmp1.Height);
            Random rand = new Random();
            
            for (int x = 0; x < bmp1.Width; x++)
            {
                for (int y = 0; y < bmp1.Height; y++)
                {
                    val = bmp1.GetPixel(x, y);
                    p1Val = (byte)val.R;
                    val = bmp2.GetPixel(x, y);
                    p2Val = (byte)val.R;
                    p3Val = (byte)Math.Min(p1Val | p2Val, 255);



                    val = Color.FromArgb(p3Val, p3Val, p3Val);
                    HelpBitMap.SetPixel(x, y, val);

                }
            }
            return HelpBitMap;
        }
        public static Bitmap XOR(Bitmap bmp1, Bitmap bmp2) //XOR
        {
            Color val;
            byte p1Val, p2Val, p3Val;
            Bitmap HelpBitMap = new Bitmap(bmp1.Width, bmp1.Height);
            Random rand = new Random();
            
            for (int x = 0; x < bmp1.Width; x++)
            {
                for (int y = 0; y < bmp1.Height; y++)
                {
                    val = bmp1.GetPixel(x, y);
                    p1Val = (byte)val.R;
                    val = bmp2.GetPixel(x, y);
                    p2Val = (byte)val.R;
                    p3Val = (byte)Math.Min(p1Val ^ p2Val, 255);



                    val = Color.FromArgb(p3Val, p3Val, p3Val);
                    HelpBitMap.SetPixel(x, y, val);

                }
            }
            return HelpBitMap;
        }
       

    }
}
