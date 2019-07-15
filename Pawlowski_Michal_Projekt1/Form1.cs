using OxyPlot;
using OxyPlot.WindowsForms;
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
    public partial class Form1 : Form
    {
        int[] ArrayBMP; // tabblica histogramy
        public Bitmap[] ArrayBitMap = new Bitmap[10];  //tablica bitmap
        BMP bmp = new BMP();  //bitmapa
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; //Program ma się otwierać w pełnym oknie
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)  //otwieranie pliku
        {
            openFileDialog1.Filter = "All bmp(*.bmp)|*.bmp";                     //kryteria do fileDialog
            if (openFileDialog1.ShowDialog() == DialogResult.OK)     //sprawdzenie czy udało się otowrzyc openFilEDialog
            {
                TabPage newTabPage = new TabPage();   //tworzymy obiekt tabpage
                PictureBox newPictureBox = new PictureBox();   // tworzymy nowy obiekt picturebox

                tabControl1.TabPages.Add(newTabPage);   //dodajemy nowa karte
                newTabPage.Controls.Add(newPictureBox);  //na tej karcie dodajemy pictureboxa
                newPictureBox.Size = new Size(840, 900);  //zmieniamy jego rozmiary

                newPictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);  //ustawiamy przypiecia
                newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage; //tryb obrazu - rozciaganie
                newTabPage.Text = openFileDialog1.FileName;  //nazwa karty to nazwa pliku
                this.tabControl1.SelectedTab = newTabPage;  //nowa karta staje sie ta aktywna
                ArrayBitMap[this.tabControl1.SelectedIndex] = new Bitmap(openFileDialog1.FileName);  //do tablicy bitmap przypisujemy otworzony obraz
                newPictureBox.Image = ArrayBitMap[tabControl1.SelectedIndex];  //umieszaczmy go w picturebox



                ArrayBMP = bmp.getArrayBMP(openFileDialog1.FileName); //caly ten kawalek tworzenie histogramu
                PlotView myPlot = new PlotView();
                var myModel = new PlotModel { Title = "Histogram" };
                myModel.Series.Add(Histogram.GetFunction(ArrayBMP));
                myPlot.Model = myModel;
                myPlot.Dock = System.Windows.Forms.DockStyle.Right;
                myPlot.Location = new System.Drawing.Point(0, 0);
                myPlot.Size = new System.Drawing.Size(800, 500);
                myPlot.TabIndex = 0;
                newTabPage.Controls.Add(myPlot);




                en_button();  //ustawiamy przyscki jako aktywne
            }
        }

        void dis_button()                          //blokowanie przycisków metoda
        {

            operacjeToolStripMenuItem.Enabled = false;
            zapiszJakoToolStripMenuItem.Enabled = false;
            zapiszToolStripMenuItem.Enabled = false;
            zamknijToolStripMenuItem.Enabled = false;

        }
        void en_button()                                  //odblowowywanie przycisków metoda
        {

            operacjeToolStripMenuItem.Enabled = true;
            zapiszJakoToolStripMenuItem.Enabled = true;
            zapiszToolStripMenuItem.Enabled = true;
            zamknijToolStripMenuItem.Enabled = true;
        }




        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)  //zamknij obraz
        {
            tabControl1.TabPages[tabControl1.SelectedIndex].Dispose();
            if (tabControl1.TabCount == 0)
            {
                dis_button(); //blokowanie przycisków
            }
        }

        private void negacjaToolStripMenuItem_Click(object sender, EventArgs e) //operacja negacji
        {
            int TabPageIndex = this.tabControl1.SelectedIndex;
            ArrayBMP = bmp.getArrayBMP(ArrayBitMap[TabPageIndex]);
            ArrayBitMap[TabPageIndex] = JednoArgumentowe.Negacja(ArrayBitMap[TabPageIndex]);  //tu wywolujemy metoda ktora to robi
            tabControl1.SelectedTab.Controls.Clear();     //ustawianie nowej bitmapy oraz histogramu
            PictureBox newPictureBox = new PictureBox();
            tabControl1.SelectedTab.Controls.Add(newPictureBox);
            newPictureBox.Size = new Size(840, 900);

            newPictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            newPictureBox.Image = ArrayBitMap[TabPageIndex];


            PlotView myPlot = new PlotView();
            var myModel = new PlotModel { Title = "Histogram" };
            myModel.Series.Add(Histogram.GetFunction(bmp.getArrayBMP(ArrayBitMap[TabPageIndex])));
            myPlot.Model = myModel;
            myPlot.Dock = DockStyle.Right;
            myPlot.Location = new Point(0, 0);
            myPlot.Size = new Size(800, 500);
            myPlot.TabIndex = 0;
            tabControl1.SelectedTab.Controls.Add(myPlot);
        }

        private void operatorProgToolStripMenuItem_Click(object sender, EventArgs e)   //progowanie
        {
            int TabPageIndex = this.tabControl1.SelectedIndex;
            using (Progowanie window = new Progowanie())  //otwieramy nowa formatke do operacji jednoargumentowych
            {
                window.index = TabPageIndex;  //ustawiam zmienne w nowej formatce
                window.bitmap = ArrayBitMap[TabPageIndex];
                window.type = 1;
                window.ShowDialog();
                ArrayBitMap[TabPageIndex] = window.bitmap;

            }
            //ponizej formatowanie i ustawianie
            tabControl1.SelectedTab.Controls.Clear();
            PictureBox newPictureBox = new PictureBox();
            tabControl1.SelectedTab.Controls.Add(newPictureBox);
            newPictureBox.Size = new Size(840, 900);

            newPictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            newPictureBox.Image = ArrayBitMap[TabPageIndex];


            PlotView myPlot = new PlotView();
            var myModel = new PlotModel { Title = "Histogram" };
            myModel.Series.Add(Histogram.GetFunction(bmp.getArrayBMP(ArrayBitMap[TabPageIndex])));
            myPlot.Model = myModel;
            myPlot.Dock = DockStyle.Right;
            myPlot.Location = new Point(0, 0);
            myPlot.Size = new Size(800, 500);
            myPlot.TabIndex = 0;
            tabControl1.SelectedTab.Controls.Add(myPlot);

        }

        private void odwrotnaBinaryzacjaToolStripMenuItem_Click(object sender, EventArgs e) //odwrotna binazryzacja
        {
            int TabPageIndex = this.tabControl1.SelectedIndex;
            using (Progowanie window = new Progowanie())
            {
                window.index = TabPageIndex;
                window.bitmap = ArrayBitMap[TabPageIndex];
                window.type = 2;
                window.ShowDialog();
                ArrayBitMap[TabPageIndex] = window.bitmap;

            }

            tabControl1.SelectedTab.Controls.Clear();
            PictureBox newPictureBox = new PictureBox();
            tabControl1.SelectedTab.Controls.Add(newPictureBox);
            newPictureBox.Size = new Size(840, 900);

            newPictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            newPictureBox.Image = ArrayBitMap[TabPageIndex];


            PlotView myPlot = new PlotView();
            var myModel = new PlotModel { Title = "Histogram" };
            myModel.Series.Add(Histogram.GetFunction(bmp.getArrayBMP(ArrayBitMap[TabPageIndex])));
            myPlot.Model = myModel;
            myPlot.Dock = DockStyle.Right;
            myPlot.Location = new Point(0, 0);
            myPlot.Size = new Size(800, 500);
            myPlot.TabIndex = 0;
            tabControl1.SelectedTab.Controls.Add(myPlot);
        }

        private void binaryzacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TabPageIndex = this.tabControl1.SelectedIndex;
            using (Progowanie window = new Progowanie())
            {
                window.index = TabPageIndex;
                window.bitmap = ArrayBitMap[TabPageIndex];
                window.type = 3;
                window.variant = 1;
                window.ShowDialog();
                ArrayBitMap[TabPageIndex] = window.bitmap;

            }

            tabControl1.SelectedTab.Controls.Clear();
            PictureBox newPictureBox = new PictureBox();
            tabControl1.SelectedTab.Controls.Add(newPictureBox);
            newPictureBox.Size = new Size(840, 900);

            newPictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            newPictureBox.Image = ArrayBitMap[TabPageIndex];


            PlotView myPlot = new PlotView();
            var myModel = new PlotModel { Title = "Histogram" };
            myModel.Series.Add(Histogram.GetFunction(bmp.getArrayBMP(ArrayBitMap[TabPageIndex])));
            myPlot.Model = myModel;
            myPlot.Dock = DockStyle.Right;
            myPlot.Location = new Point(0, 0);
            myPlot.Size = new Size(800, 500);
            myPlot.TabIndex = 0;
            tabControl1.SelectedTab.Controls.Add(myPlot);
        }

        private void binaryzacjaZZachowaniemPoziomówSzarościToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TabPageIndex = this.tabControl1.SelectedIndex;
            using (Progowanie window = new Progowanie())
            {
                window.index = TabPageIndex;
                window.bitmap = ArrayBitMap[TabPageIndex];
                window.type = 4;
                window.variant = 1;
                window.ShowDialog();
                ArrayBitMap[TabPageIndex] = window.bitmap;

            }

            tabControl1.SelectedTab.Controls.Clear();
            PictureBox newPictureBox = new PictureBox();
            tabControl1.SelectedTab.Controls.Add(newPictureBox);
            newPictureBox.Size = new Size(840, 900);

            newPictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            newPictureBox.Image = ArrayBitMap[TabPageIndex];


            PlotView myPlot = new PlotView();
            var myModel = new PlotModel { Title = "Histogram" };
            myModel.Series.Add(Histogram.GetFunction(bmp.getArrayBMP(ArrayBitMap[TabPageIndex])));
            myPlot.Model = myModel;
            myPlot.Dock = DockStyle.Right;
            myPlot.Location = new Point(0, 0);
            myPlot.Size = new Size(800, 500);
            myPlot.TabIndex = 0;
            tabControl1.SelectedTab.Controls.Add(myPlot);
        }

        private void rozciaganieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TabPageIndex = this.tabControl1.SelectedIndex;
            using (Progowanie window = new Progowanie())
            {
                window.index = TabPageIndex;
                window.bitmap = ArrayBitMap[TabPageIndex];
                window.type = 5;
                window.variant = 1;
                window.ShowDialog();
                ArrayBitMap[TabPageIndex] = window.bitmap;

            }

            tabControl1.SelectedTab.Controls.Clear();
            PictureBox newPictureBox = new PictureBox();
            tabControl1.SelectedTab.Controls.Add(newPictureBox);
            newPictureBox.Size = new Size(840, 900);

            newPictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            newPictureBox.Image = ArrayBitMap[TabPageIndex];


            PlotView myPlot = new PlotView();
            var myModel = new PlotModel { Title = "Histogram" };
            myModel.Series.Add(Histogram.GetFunction(bmp.getArrayBMP(ArrayBitMap[TabPageIndex])));
            myPlot.Model = myModel;
            myPlot.Dock = DockStyle.Right;
            myPlot.Location = new Point(0, 0);
            myPlot.Size = new Size(800, 500);
            myPlot.TabIndex = 0;
            tabControl1.SelectedTab.Controls.Add(myPlot);
        }

        private void redukcjaPoziomówSzarośćiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //nie mam pojecia w sumie 
        }

        private void kontrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TabPageIndex = this.tabControl1.SelectedIndex;
            using (Progowanie window = new Progowanie())
            {
                window.index = TabPageIndex;
                window.bitmap = ArrayBitMap[TabPageIndex];
                window.type = 7;
                window.ShowDialog();
                ArrayBitMap[TabPageIndex] = window.bitmap;

            }

            tabControl1.SelectedTab.Controls.Clear();
            PictureBox newPictureBox = new PictureBox();
            tabControl1.SelectedTab.Controls.Add(newPictureBox);
            newPictureBox.Size = new Size(840, 900);

            newPictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            newPictureBox.Image = ArrayBitMap[TabPageIndex];


            PlotView myPlot = new PlotView();
            var myModel = new PlotModel { Title = "Histogram" };
            myModel.Series.Add(Histogram.GetFunction(bmp.getArrayBMP(ArrayBitMap[TabPageIndex])));
            myPlot.Model = myModel;
            myPlot.Dock = DockStyle.Right;
            myPlot.Location = new Point(0, 0);
            myPlot.Size = new Size(800, 500);
            myPlot.TabIndex = 0;
            tabControl1.SelectedTab.Controls.Add(myPlot);


        }

        private void jasnośćToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int TabPageIndex = this.tabControl1.SelectedIndex;
            using (Progowanie window = new Progowanie())
            {
                window.index = TabPageIndex;
                window.bitmap = ArrayBitMap[TabPageIndex];
                window.type = 6;
                window.ShowDialog();
                ArrayBitMap[TabPageIndex] = window.bitmap;

            }

            tabControl1.SelectedTab.Controls.Clear();
            PictureBox newPictureBox = new PictureBox();
            tabControl1.SelectedTab.Controls.Add(newPictureBox);
            newPictureBox.Size = new Size(840, 900);

            newPictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            newPictureBox.Image = ArrayBitMap[TabPageIndex];


            PlotView myPlot = new PlotView();
            var myModel = new PlotModel { Title = "Histogram" };
            myModel.Series.Add(Histogram.GetFunction(bmp.getArrayBMP(ArrayBitMap[TabPageIndex])));
            myPlot.Model = myModel;
            myPlot.Dock = DockStyle.Right;
            myPlot.Location = new Point(0, 0);
            myPlot.Size = new Size(800, 500);
            myPlot.TabIndex = 0;
            tabControl1.SelectedTab.Controls.Add(myPlot);

        }

        private void korekcjaGammaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int TabPageIndex = this.tabControl1.SelectedIndex;
            using (Progowanie window = new Progowanie())
            {
                window.index = TabPageIndex;
                window.bitmap = ArrayBitMap[TabPageIndex];
                window.type = 8;
                window.ShowDialog();
                ArrayBitMap[TabPageIndex] = window.bitmap;

            }

            tabControl1.SelectedTab.Controls.Clear();
            PictureBox newPictureBox = new PictureBox();
            tabControl1.SelectedTab.Controls.Add(newPictureBox);
            newPictureBox.Size = new Size(840, 900);

            newPictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            newPictureBox.Image = ArrayBitMap[TabPageIndex];


            PlotView myPlot = new PlotView();
            var myModel = new PlotModel { Title = "Histogram" };
            myModel.Series.Add(Histogram.GetFunction(bmp.getArrayBMP(ArrayBitMap[TabPageIndex])));
            myPlot.Model = myModel;
            myPlot.Dock = DockStyle.Right;
            myPlot.Location = new Point(0, 0);
            myPlot.Size = new Size(800, 500);
            myPlot.TabIndex = 0;
            tabControl1.SelectedTab.Controls.Add(myPlot);

        }

        private void dodawanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TabPageIndex = this.tabControl1.SelectedIndex;
            using (DwuargumentoweForm window = new DwuargumentoweForm())
            {
                window.index = TabPageIndex;
                window.bitmap = ArrayBitMap[TabPageIndex];
                window.type = 1;
                window.ShowDialog();
                ArrayBitMap[TabPageIndex] = window.bitmap;

            }

            tabControl1.SelectedTab.Controls.Clear();
            PictureBox newPictureBox = new PictureBox();
            tabControl1.SelectedTab.Controls.Add(newPictureBox);
            newPictureBox.Size = new Size(840, 900);

            newPictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            newPictureBox.Image = ArrayBitMap[TabPageIndex];


            PlotView myPlot = new PlotView();
            var myModel = new PlotModel { Title = "Histogram" };
            myModel.Series.Add(Histogram.GetFunction(bmp.getArrayBMP(ArrayBitMap[TabPageIndex])));
            myPlot.Model = myModel;
            myPlot.Dock = DockStyle.Right;
            myPlot.Location = new Point(0, 0);
            myPlot.Size = new Size(800, 500);
            myPlot.TabIndex = 0;
            tabControl1.SelectedTab.Controls.Add(myPlot);
        }

        private void odejmowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TabPageIndex = this.tabControl1.SelectedIndex;
            using (DwuargumentoweForm window = new DwuargumentoweForm())
            {
                window.index = TabPageIndex;
                window.bitmap = ArrayBitMap[TabPageIndex];
                window.type = 2;
                window.ShowDialog();
                ArrayBitMap[TabPageIndex] = window.bitmap;

            }

            tabControl1.SelectedTab.Controls.Clear();
            PictureBox newPictureBox = new PictureBox();
            tabControl1.SelectedTab.Controls.Add(newPictureBox);
            newPictureBox.Size = new Size(840, 900);

            newPictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            newPictureBox.Image = ArrayBitMap[TabPageIndex];


            PlotView myPlot = new PlotView();
            var myModel = new PlotModel { Title = "Histogram" };
            myModel.Series.Add(Histogram.GetFunction(bmp.getArrayBMP(ArrayBitMap[TabPageIndex])));
            myPlot.Model = myModel;
            myPlot.Dock = DockStyle.Right;
            myPlot.Location = new Point(0, 0);
            myPlot.Size = new Size(800, 500);
            myPlot.TabIndex = 0;
            tabControl1.SelectedTab.Controls.Add(myPlot);
        }

        private void mnożenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TabPageIndex = this.tabControl1.SelectedIndex;
            using (DwuargumentoweForm window = new DwuargumentoweForm())
            {
                window.index = TabPageIndex;
                window.bitmap = ArrayBitMap[TabPageIndex];
                window.type = 3;
                window.ShowDialog();
                ArrayBitMap[TabPageIndex] = window.bitmap;

            }

            tabControl1.SelectedTab.Controls.Clear();
            PictureBox newPictureBox = new PictureBox();
            tabControl1.SelectedTab.Controls.Add(newPictureBox);
            newPictureBox.Size = new Size(840, 900);

            newPictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            newPictureBox.Image = ArrayBitMap[TabPageIndex];


            PlotView myPlot = new PlotView();
            var myModel = new PlotModel { Title = "Histogram" };
            myModel.Series.Add(Histogram.GetFunction(bmp.getArrayBMP(ArrayBitMap[TabPageIndex])));
            myPlot.Model = myModel;
            myPlot.Dock = DockStyle.Right;
            myPlot.Location = new Point(0, 0);
            myPlot.Size = new Size(800, 500);
            myPlot.TabIndex = 0;
            tabControl1.SelectedTab.Controls.Add(myPlot);
        }

        private void aNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TabPageIndex = this.tabControl1.SelectedIndex;
            using (DwuargumentoweForm window = new DwuargumentoweForm())
            {
                window.index = TabPageIndex;
                window.bitmap = ArrayBitMap[TabPageIndex];
                window.type = 4;
                window.ShowDialog();
                ArrayBitMap[TabPageIndex] = window.bitmap;

            }

            tabControl1.SelectedTab.Controls.Clear();
            PictureBox newPictureBox = new PictureBox();
            tabControl1.SelectedTab.Controls.Add(newPictureBox);
            newPictureBox.Size = new Size(840, 900);

            newPictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            newPictureBox.Image = ArrayBitMap[TabPageIndex];


            PlotView myPlot = new PlotView();
            var myModel = new PlotModel { Title = "Histogram" };
            myModel.Series.Add(Histogram.GetFunction(bmp.getArrayBMP(ArrayBitMap[TabPageIndex])));
            myPlot.Model = myModel;
            myPlot.Dock = DockStyle.Right;
            myPlot.Location = new Point(0, 0);
            myPlot.Size = new Size(800, 500);
            myPlot.TabIndex = 0;
            tabControl1.SelectedTab.Controls.Add(myPlot);
        }

        private void oRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TabPageIndex = this.tabControl1.SelectedIndex;
            using (DwuargumentoweForm window = new DwuargumentoweForm())
            {
                window.index = TabPageIndex;
                window.bitmap = ArrayBitMap[TabPageIndex];
                window.type = 5;
                window.ShowDialog();
                ArrayBitMap[TabPageIndex] = window.bitmap;

            }

            tabControl1.SelectedTab.Controls.Clear();
            PictureBox newPictureBox = new PictureBox();
            tabControl1.SelectedTab.Controls.Add(newPictureBox);
            newPictureBox.Size = new Size(840, 900);

            newPictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            newPictureBox.Image = ArrayBitMap[TabPageIndex];


            PlotView myPlot = new PlotView();
            var myModel = new PlotModel { Title = "Histogram" };
            myModel.Series.Add(Histogram.GetFunction(bmp.getArrayBMP(ArrayBitMap[TabPageIndex])));
            myPlot.Model = myModel;
            myPlot.Dock = DockStyle.Right;
            myPlot.Location = new Point(0, 0);
            myPlot.Size = new Size(800, 500);
            myPlot.TabIndex = 0;
            tabControl1.SelectedTab.Controls.Add(myPlot);
        }

        private void xORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TabPageIndex = this.tabControl1.SelectedIndex;
            using (DwuargumentoweForm window = new DwuargumentoweForm())
            {
                window.index = TabPageIndex;
                window.bitmap = ArrayBitMap[TabPageIndex];
                window.type = 6;
                window.ShowDialog();
                ArrayBitMap[TabPageIndex] = window.bitmap;

            }

            tabControl1.SelectedTab.Controls.Clear();
            PictureBox newPictureBox = new PictureBox();
            tabControl1.SelectedTab.Controls.Add(newPictureBox);
            newPictureBox.Size = new Size(840, 900);

            newPictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            newPictureBox.Image = ArrayBitMap[TabPageIndex];


            PlotView myPlot = new PlotView();
            var myModel = new PlotModel { Title = "Histogram" };
            myModel.Series.Add(Histogram.GetFunction(bmp.getArrayBMP(ArrayBitMap[TabPageIndex])));
            myPlot.Model = myModel;
            myPlot.Dock = DockStyle.Right;
            myPlot.Location = new Point(0, 0);
            myPlot.Size = new Size(800, 500);
            myPlot.TabIndex = 0;
            tabControl1.SelectedTab.Controls.Add(myPlot);
        }

        private void dzielenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TabPageIndex = this.tabControl1.SelectedIndex;
            using (DwuargumentoweForm window = new DwuargumentoweForm())
            {
                window.index = TabPageIndex;
                window.bitmap = ArrayBitMap[TabPageIndex];
                window.type = 7;
                window.ShowDialog();
                ArrayBitMap[TabPageIndex] = window.bitmap;

            }

            tabControl1.SelectedTab.Controls.Clear();
            PictureBox newPictureBox = new PictureBox();
            tabControl1.SelectedTab.Controls.Add(newPictureBox);
            newPictureBox.Size = new Size(840, 900);

            newPictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            newPictureBox.Image = ArrayBitMap[TabPageIndex];


            PlotView myPlot = new PlotView();
            var myModel = new PlotModel { Title = "Histogram" };
            myModel.Series.Add(Histogram.GetFunction(bmp.getArrayBMP(ArrayBitMap[TabPageIndex])));
            myPlot.Model = myModel;
            myPlot.Dock = DockStyle.Right;
            myPlot.Location = new Point(0, 0);
            myPlot.Size = new Size(800, 500);
            myPlot.TabIndex = 0;
            tabControl1.SelectedTab.Controls.Add(myPlot);
        }

        private void różnicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TabPageIndex = this.tabControl1.SelectedIndex;
            using (DwuargumentoweForm window = new DwuargumentoweForm())
            {
                window.index = TabPageIndex;
                window.bitmap = ArrayBitMap[TabPageIndex];
                window.type = 8;
                window.ShowDialog();
                ArrayBitMap[TabPageIndex] = window.bitmap;

            }

            tabControl1.SelectedTab.Controls.Clear();
            PictureBox newPictureBox = new PictureBox();
            tabControl1.SelectedTab.Controls.Add(newPictureBox);
            newPictureBox.Size = new Size(840, 900);

            newPictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            newPictureBox.Image = ArrayBitMap[TabPageIndex];


            PlotView myPlot = new PlotView();
            var myModel = new PlotModel { Title = "Histogram" };
            myModel.Series.Add(Histogram.GetFunction(bmp.getArrayBMP(ArrayBitMap[TabPageIndex])));
            myPlot.Model = myModel;
            myPlot.Dock = DockStyle.Right;
            myPlot.Location = new Point(0, 0);
            myPlot.Size = new Size(800, 500);
            myPlot.TabIndex = 0;
            tabControl1.SelectedTab.Controls.Add(myPlot);
        }

        private void średniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TabPageIndex = this.tabControl1.SelectedIndex;
            using (DwuargumentoweForm window = new DwuargumentoweForm())
            {
                window.index = TabPageIndex;
                window.bitmap = ArrayBitMap[TabPageIndex];
                window.type = 9;
                window.ShowDialog();
                ArrayBitMap[TabPageIndex] = window.bitmap;

            }

            tabControl1.SelectedTab.Controls.Clear();
            PictureBox newPictureBox = new PictureBox();
            tabControl1.SelectedTab.Controls.Add(newPictureBox);
            newPictureBox.Size = new Size(840, 900);

            newPictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            newPictureBox.Image = ArrayBitMap[TabPageIndex];


            PlotView myPlot = new PlotView();
            var myModel = new PlotModel { Title = "Histogram" };
            myModel.Series.Add(Histogram.GetFunction(bmp.getArrayBMP(ArrayBitMap[TabPageIndex])));
            myPlot.Model = myModel;
            myPlot.Dock = DockStyle.Right;
            myPlot.Location = new Point(0, 0);
            myPlot.Size = new Size(800, 500);
            myPlot.TabIndex = 0;
            tabControl1.SelectedTab.Controls.Add(myPlot);
        }

        private void medianoweToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TabPageIndex = this.tabControl1.SelectedIndex;
            using (Medianowe window = new Medianowe())
            {
                window.index = TabPageIndex;
                window.bitmap = ArrayBitMap[TabPageIndex];

                window.ShowDialog();
                ArrayBitMap[TabPageIndex] = window.bitmap;

            }

            tabControl1.SelectedTab.Controls.Clear();
            PictureBox newPictureBox = new PictureBox();
            tabControl1.SelectedTab.Controls.Add(newPictureBox);
            newPictureBox.Size = new Size(840, 900);

            newPictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            newPictureBox.Image = ArrayBitMap[TabPageIndex];


            PlotView myPlot = new PlotView();
            var myModel = new PlotModel { Title = "Histogram" };
            myModel.Series.Add(Histogram.GetFunction(bmp.getArrayBMP(ArrayBitMap[TabPageIndex])));
            myPlot.Model = myModel;
            myPlot.Dock = DockStyle.Right;
            myPlot.Location = new Point(0, 0);
            myPlot.Size = new Size(800, 500);
            myPlot.TabIndex = 0;
            tabControl1.SelectedTab.Controls.Add(myPlot);
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TabPageIndex = this.tabControl1.SelectedIndex;
            System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Bmp;
            string name = this.tabControl1.SelectedTab.Text; 
              

        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "Images  *.png; *.bmp; *.jpg";
          
            System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Bmp;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = System.Drawing.Imaging.ImageFormat.Jpeg;
                        break;
                    case ".png":
                        format = System.Drawing.Imaging.ImageFormat.Png;
                        break;
                    case ".bmp":
                        format = System.Drawing.Imaging.ImageFormat.Bmp;
                        break;
                }


                int TabPageIndex = this.tabControl1.SelectedIndex;
                ArrayBMP = bmp.getArrayBMP(ArrayBitMap[TabPageIndex]);
                ArrayBitMap[TabPageIndex].Save(saveFileDialog1.FileName, format);
            }
        }

        private void operacjeSasiedztwaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TabPageIndex = this.tabControl1.SelectedIndex;
            using (OperacjeSasiedztwa window = new OperacjeSasiedztwa())
            {
                window.index = TabPageIndex;
                window.bitmap = ArrayBitMap[TabPageIndex];
                window.ShowDialog();
                ArrayBitMap[TabPageIndex] = window.bitmap;

            }

            tabControl1.SelectedTab.Controls.Clear();
            PictureBox newPictureBox = new PictureBox();
            tabControl1.SelectedTab.Controls.Add(newPictureBox);
            newPictureBox.Size = new Size(840, 900);

            newPictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top);
            newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            newPictureBox.Image = ArrayBitMap[TabPageIndex];


            PlotView myPlot = new PlotView();
            var myModel = new PlotModel { Title = "Histogram" };
            myModel.Series.Add(Histogram.GetFunction(bmp.getArrayBMP(ArrayBitMap[TabPageIndex])));
            myPlot.Model = myModel;
            myPlot.Dock = DockStyle.Right;
            myPlot.Location = new Point(0, 0);
            myPlot.Size = new Size(800, 500);
            myPlot.TabIndex = 0;
            tabControl1.SelectedTab.Controls.Add(myPlot);
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Przedmiot: Algorytmy Przetwarzania Obrazów" + Environment.NewLine +
                           "Prowadzący: Marek Doros, Anna Korzyńska, Łukasz Roszkowiak" + Environment.NewLine +
                           "Wykonawca: Michał Pawłowski");
        }

        private void wyjścieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}


