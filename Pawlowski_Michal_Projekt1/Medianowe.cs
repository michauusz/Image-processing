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
    public partial class Medianowe : Form
    {
        public Bitmap bitmap;
        public int index;
        public Medianowe()
        {
            InitializeComponent();
        }

        private void Obraz1_Click(object sender, EventArgs e)
        {
            
        }

        private void Medianowe_Load(object sender, EventArgs e)
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
            int value1 = (int)numericUpDown4.Value;
            int value2 = (int)numericUpDown3.Value;
            ObrazPo.Image = Sasiedztwa.Medianowe(bitmap, value1, value2);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
