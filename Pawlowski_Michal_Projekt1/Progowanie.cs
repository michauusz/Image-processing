using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pawlowski_Michal_Projekt1
{
    public partial class Progowanie : Form
    {

        public Bitmap bitmap; //bitmapa
        public int index; //index bitmapy
        public int type; //1- progowanie 2-odwrotne progowanie 3-progowanie z przedziałami 4- progwanie z zachowaniem poziomow szarosci 5-rozciaganie 6-jasnosc 7-kontrast 8-gamma
        public int variant = 0;  //wersja na 2 lub na 1 suwak
        
        public Progowanie()
        {
            InitializeComponent();
           
        }

        private void Progowanie_Load(object sender, EventArgs e)  //wczytanie formatki
        {
            progowaniePierw.Image = bitmap;
            if ( variant ==1 )  //jezeli wariant z 2 suwakami to odblokuj dodatkowe rzeczy
            {
                lbValue2.Visible = true;
                p2Value.Visible = true;
                p2Value.Enabled = true;
            }

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void check_Click(object sender, EventArgs e)
        {
            int value1=0;
            int value2=0;
            if (variant == 1)
            {
                if (p1Value.Value > p2Value.Value)
                {
                    MessageBox.Show("Wartosc P1 nie może być większa niż P2. " + Environment.NewLine +
                        "Zamieniam wartosci P1 z P2");
                     value1 = p2Value.Value;
                     value2 = p1Value.Value;
                }
                else
                {

                    value1 = p1Value.Value;
                    value2 = p2Value.Value;
                }
            }
            else
            {
                 value1 = p1Value.Value;
                 value2 = p2Value.Value;
            }
            if (type==1) progowaniePo.Image = JednoArgumentowe.Progowanie(bitmap, value1);
            else if(type==2) progowaniePo.Image = JednoArgumentowe.ProgowanieOdwrotne(bitmap, value1);
            else if (type == 3) progowaniePo.Image = JednoArgumentowe.ProgowanieZPrzedzialami(bitmap, value1, value2);
            else if (type == 4) progowaniePo.Image = JednoArgumentowe.ProgowanieZachowanie(bitmap, value1, value2);
            else if (type == 5) progowaniePo.Image = JednoArgumentowe.Rozciaganie(bitmap, value1, value2);
            else if (type == 6) progowaniePo.Image = JednoArgumentowe.Jasnosc(bitmap, value1);
            else if (type == 7) progowaniePo.Image = JednoArgumentowe.Kontrast(bitmap, value1);
            else if (type == 8) progowaniePo.Image = JednoArgumentowe.Gamma(bitmap, value1);

            apply.Enabled = true;


        }

       

        private void cancel_Click_1(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void apply_Click_1(object sender, EventArgs e)
        {
            bitmap = new Bitmap(progowaniePo.Image);
            ActiveForm.Close();
        }
    }
}
