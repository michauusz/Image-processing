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
    public partial class DwuargumentoweForm : Form
    {

        public Bitmap bitmap;
        public int index;
        public int type; //1-dodawanie 2-odejmowanie 3-mnożenie 4-AND 5-OR 6-XOR 7-dzielenie 8-różnica 9 - średnia

        public DwuargumentoweForm()
        {
            InitializeComponent();
        }

        private void DwuargumentoweForm_Load(object sender, EventArgs e)
        {
            Obraz1.Image = bitmap;
        }

        

        private void apply_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(ObrazPo.Image);
            ActiveForm.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void check_Click(object sender, EventArgs e)
        {
            if (type == 1) ObrazPo.Image = Dwuargumentowe.Dodawanie(bitmap, new Bitmap(Obraz2.Image));
            else if (type == 2) ObrazPo.Image = Dwuargumentowe.Odejmowanie(bitmap, new Bitmap(Obraz2.Image));
            else if (type == 3) ObrazPo.Image = Dwuargumentowe.Mnozenie(bitmap, new Bitmap(Obraz2.Image));
            else if (type == 4) ObrazPo.Image = Dwuargumentowe.AND(bitmap, new Bitmap(Obraz2.Image));
            else if (type == 5) ObrazPo.Image = Dwuargumentowe.OR(bitmap, new Bitmap(Obraz2.Image));
            else if (type == 6) ObrazPo.Image = Dwuargumentowe.XOR(bitmap, new Bitmap(Obraz2.Image));
            else if (type == 7) ObrazPo.Image = Dwuargumentowe.Dzielenie(bitmap, new Bitmap(Obraz2.Image));
            else if (type == 8) ObrazPo.Image = Dwuargumentowe.Roznica(bitmap, new Bitmap(Obraz2.Image));
            else if (type == 9) ObrazPo.Image = Dwuargumentowe.Srednia(bitmap, new Bitmap(Obraz2.Image));
            apply.Enabled = true;

        }

        private void otworz_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All bmp(*.bmp)|*.bmp";                     //kryteria do fileDialog
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Obraz2.Image = new Bitmap(openFileDialog1.FileName);
                otworz.Visible = false;
                check.Enabled = true;
            }
        }
    }
}
