namespace Pawlowski_Michal_Projekt1
{
    partial class DwuargumentoweForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.check = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Obraz2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Obraz1 = new System.Windows.Forms.PictureBox();
            this.cancel = new System.Windows.Forms.Button();
            this.apply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ObrazPo = new System.Windows.Forms.PictureBox();
            this.otworz = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Obraz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obraz1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObrazPo)).BeginInit();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.Enabled = false;
            this.check.Location = new System.Drawing.Point(747, 253);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 20;
            this.check.Text = "Sprawdź";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Drugi Obraz";
            // 
            // Obraz2
            // 
            this.Obraz2.Location = new System.Drawing.Point(405, 71);
            this.Obraz2.Name = "Obraz2";
            this.Obraz2.Size = new System.Drawing.Size(302, 383);
            this.Obraz2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Obraz2.TabIndex = 18;
            this.Obraz2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Obraz pierwotny";
            // 
            // Obraz1
            // 
            this.Obraz1.Location = new System.Drawing.Point(32, 71);
            this.Obraz1.Name = "Obraz1";
            this.Obraz1.Size = new System.Drawing.Size(306, 383);
            this.Obraz1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Obraz1.TabIndex = 16;
            this.Obraz1.TabStop = false;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(734, 521);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 22;
            this.cancel.Text = "Anuluj";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // apply
            // 
            this.apply.Enabled = false;
            this.apply.Location = new System.Drawing.Point(483, 521);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(75, 23);
            this.apply.TabIndex = 21;
            this.apply.Text = "Zatwierdź";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(855, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Wynik";
            // 
            // ObrazPo
            // 
            this.ObrazPo.Location = new System.Drawing.Point(858, 71);
            this.ObrazPo.Name = "ObrazPo";
            this.ObrazPo.Size = new System.Drawing.Size(302, 383);
            this.ObrazPo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ObrazPo.TabIndex = 23;
            this.ObrazPo.TabStop = false;
            // 
            // otworz
            // 
            this.otworz.Location = new System.Drawing.Point(506, 239);
            this.otworz.Name = "otworz";
            this.otworz.Size = new System.Drawing.Size(75, 23);
            this.otworz.TabIndex = 25;
            this.otworz.Text = "Otwórz obraz";
            this.otworz.UseVisualStyleBackColor = true;
            this.otworz.Click += new System.EventHandler(this.otworz_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DwuargumentoweForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 601);
            this.Controls.Add(this.otworz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ObrazPo);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.check);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Obraz2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Obraz1);
            this.Name = "DwuargumentoweForm";
            this.Text = "DwuargumentoweForm";
            this.Load += new System.EventHandler(this.DwuargumentoweForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Obraz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obraz1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObrazPo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Obraz2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Obraz1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ObrazPo;
        private System.Windows.Forms.Button otworz;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}