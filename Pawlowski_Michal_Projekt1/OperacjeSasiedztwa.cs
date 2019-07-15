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
    public partial class OperacjeSasiedztwa : Form
    {
        public Bitmap bitmap; //bitmapa
        public int index; //index - ktora opcja wybrana
        public OperacjeSasiedztwa()
        {
            InitializeComponent();
        }

        private void check_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {
                Blur();
            }
            else if (radioButton4.Checked || radioButton5.Checked || radioButton6.Checked || radioButton7.Checked || radioButton8.Checked)
            {
                Sharp();
            }
            else if (radioButton9.Checked || radioButton10.Checked || radioButton11.Checked)
            {
                EdgeDetection();
            }



            apply.Enabled = true;
        }
        void Blur()
        {
            double TAB;
            int pix;

            Bitmap newbitmap = new Bitmap(bitmap.Width, bitmap.Height);
            if (radioButton1.Checked)
            {
                TAB = 1.0 / 9;
            }
            else if (radioButton2.Checked)
            {
                TAB = 1.0 / 10;
            }
            else if (radioButton3.Checked)
            {
                TAB = 1.0 / 16;
            }
            else TAB = 1.0 / 9;




            for (int x = 1; x < bitmap.Width - 1; x++)
            {
                for (int y = 1; y < bitmap.Height - 1; y++)
                {
                    pix = (int)((TAB * bitmap.GetPixel(x - 1, y - 1).R) +
                          (TAB * bitmap.GetPixel(x - 1, y).R) +
                          (TAB * bitmap.GetPixel(x - 1, y + 1).R) +
                          (TAB * bitmap.GetPixel(x, y - 1).R) +
                          (TAB * bitmap.GetPixel(x, y).R) +
                          (TAB * bitmap.GetPixel(x, y + 1).R) +
                          (TAB * bitmap.GetPixel(x + 1, y - 1).R) +
                          (TAB * bitmap.GetPixel(x + 1, y).R) +
                          (TAB * bitmap.GetPixel(x + 1, y + 1).R));

                    newbitmap.SetPixel(x, y, Color.FromArgb(pix, pix, pix));
                }
            }
            po.Image = newbitmap;

        }
       

        private void apply_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(po.Image);
            ActiveForm.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
        void EdgeDetection()
        {
            int pix;
            int[,] TAB = new int[3, 3];
            Bitmap newbitmap = new Bitmap(bitmap.Width, bitmap.Height);
            if (radioButton9.Checked)
            {
                TAB = Masks.EdgeDetectionA;
            }
            else if (radioButton10.Checked)
            {
                TAB = Masks.EdgeDetectionB;
            }
            else if (radioButton11.Checked)
            {
                TAB = Masks.EdgeDetectionC;
            }
            else
            {

                TAB = Masks.EdgeDetectionA;
            }
            for (int x = 1; x < bitmap.Width - 1; x++)
            {
                for (int y = 1; y < bitmap.Height - 1; y++)
                {
                    pix = (int)(((TAB[0, 0] * bitmap.GetPixel(x - 1, y - 1).R) +
                          (TAB[0, 1] * bitmap.GetPixel(x - 1, y).R) +
                          (TAB[0, 2] * bitmap.GetPixel(x - 1, y + 1).R) +
                          (TAB[1, 0] * bitmap.GetPixel(x, y - 1).R) +
                          (TAB[1, 1] * bitmap.GetPixel(x, y).R) +
                          (TAB[1, 2] * bitmap.GetPixel(x, y + 1).R) +
                          (TAB[2, 0] * bitmap.GetPixel(x + 1, y - 1).R) +
                          (TAB[2, 1] * bitmap.GetPixel(x + 1, y).R) +
                          (TAB[2, 2] * bitmap.GetPixel(x + 1, y + 1).R)));
                    if (pix < 0)
                    {
                        pix = 0;
                    }
                    if (pix > 255)
                    {
                        pix = 255;
                    }

                    newbitmap.SetPixel(x, y, Color.FromArgb(pix, pix, pix));
                }
            }
            po.Image = newbitmap;
        }
        void Sharp()
        {
            int pix;
            int[,] TAB = new int[3, 3];
            Bitmap newbitmap = new Bitmap(bitmap.Width, bitmap.Height);
            if (radioButton4.Checked)
            {
                TAB = Masks.LaplacianBasic;
            }
            else if (radioButton5.Checked)
            {
                TAB = Masks.LaplacianA;
            }
            else if (radioButton6.Checked)
            {
                TAB = Masks.LaplacianB;
            }
            else if (radioButton7.Checked)
            {
                TAB = Masks.LaplacianC;
            }
            else if (radioButton8.Checked)
            {
                TAB = Masks.LaplacianD;
            }
            else
            {

                TAB = Masks.LaplacianBasic;
            }
            for (int x = 1; x < bitmap.Width - 1; x++)
            {
                for (int y = 1; y < bitmap.Height - 1; y++)
                {
                    pix = (int)(((TAB[0, 0] * bitmap.GetPixel(x - 1, y - 1).R) +
                          (TAB[0, 1] * bitmap.GetPixel(x - 1, y).R) +
                          (TAB[0, 2] * bitmap.GetPixel(x - 1, y + 1).R) +
                          (TAB[1, 0] * bitmap.GetPixel(x, y - 1).R) +
                          (TAB[1, 1] * bitmap.GetPixel(x, y).R) +
                          (TAB[1, 2] * bitmap.GetPixel(x, y + 1).R) +
                          (TAB[2, 0] * bitmap.GetPixel(x + 1, y - 1).R) +
                          (TAB[2, 1] * bitmap.GetPixel(x + 1, y).R) +
                          (TAB[2, 2] * bitmap.GetPixel(x + 1, y + 1).R)));
                    if (pix < 0)
                    {
                        pix = 0;
                    }
                    if (pix > 255)
                    {
                        pix = 255;
                    }

                    newbitmap.SetPixel(x, y, Color.FromArgb(pix, pix, pix));
                }
            }
            po.Image = newbitmap;

        }

        private void pierw_Click(object sender, EventArgs e)
        {

        }

        private void OperacjeSasiedztwa_Load_1(object sender, EventArgs e)
        {
            pierw.Image = bitmap;
        }

        private void apply_Click_1(object sender, EventArgs e)
        {

        }
    }
}
