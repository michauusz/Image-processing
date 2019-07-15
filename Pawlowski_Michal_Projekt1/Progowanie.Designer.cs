namespace Pawlowski_Michal_Projekt1
{
    partial class Progowanie
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
            this.cancel = new System.Windows.Forms.Button();
            this.apply = new System.Windows.Forms.Button();
            this.p1Value = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.progowaniePo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progowaniePierw = new System.Windows.Forms.PictureBox();
            this.p2Value = new System.Windows.Forms.TrackBar();
            this.lbValue2 = new System.Windows.Forms.Label();
            this.lbValue1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.p1Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progowaniePo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progowaniePierw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Value)).BeginInit();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(357, 139);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(75, 23);
            this.check.TabIndex = 15;
            this.check.Text = "Sprawdź";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(456, 525);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 14;
            this.cancel.Text = "Anuluj";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click_1);
            // 
            // apply
            // 
            this.apply.Enabled = false;
            this.apply.Location = new System.Drawing.Point(248, 525);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(75, 23);
            this.apply.TabIndex = 13;
            this.apply.Text = "Zatwierdź";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click_1);
            // 
            // p1Value
            // 
            this.p1Value.Location = new System.Drawing.Point(159, 384);
            this.p1Value.Maximum = 255;
            this.p1Value.Name = "p1Value";
            this.p1Value.Size = new System.Drawing.Size(471, 45);
            this.p1Value.TabIndex = 12;
            this.p1Value.Value = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Obraz po binaryzacji";
            // 
            // progowaniePo
            // 
            this.progowaniePo.Location = new System.Drawing.Point(494, 31);
            this.progowaniePo.Name = "progowaniePo";
            this.progowaniePo.Size = new System.Drawing.Size(275, 325);
            this.progowaniePo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.progowaniePo.TabIndex = 10;
            this.progowaniePo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Obraz pierwotny";
            // 
            // progowaniePierw
            // 
            this.progowaniePierw.Location = new System.Drawing.Point(32, 31);
            this.progowaniePierw.Name = "progowaniePierw";
            this.progowaniePierw.Size = new System.Drawing.Size(265, 325);
            this.progowaniePierw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.progowaniePierw.TabIndex = 8;
            this.progowaniePierw.TabStop = false;
            // 
            // p2Value
            // 
            this.p2Value.Enabled = false;
            this.p2Value.Location = new System.Drawing.Point(159, 444);
            this.p2Value.Maximum = 255;
            this.p2Value.Name = "p2Value";
            this.p2Value.Size = new System.Drawing.Size(471, 45);
            this.p2Value.TabIndex = 16;
            this.p2Value.Value = 200;
            this.p2Value.Visible = false;
            // 
            // lbValue2
            // 
            this.lbValue2.AutoSize = true;
            this.lbValue2.Location = new System.Drawing.Point(45, 444);
            this.lbValue2.Name = "lbValue2";
            this.lbValue2.Size = new System.Drawing.Size(63, 13);
            this.lbValue2.TabIndex = 17;
            this.lbValue2.Text = "Wartość P2";
            this.lbValue2.Visible = false;
            // 
            // lbValue1
            // 
            this.lbValue1.AutoSize = true;
            this.lbValue1.Location = new System.Drawing.Point(45, 393);
            this.lbValue1.Name = "lbValue1";
            this.lbValue1.Size = new System.Drawing.Size(63, 13);
            this.lbValue1.TabIndex = 18;
            this.lbValue1.Text = "Wartość P1";
            // 
            // Progowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 591);
            this.Controls.Add(this.lbValue1);
            this.Controls.Add(this.lbValue2);
            this.Controls.Add(this.p2Value);
            this.Controls.Add(this.check);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.p1Value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progowaniePo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progowaniePierw);
            this.Name = "Progowanie";
            this.Text = "Progowanie";
            this.Load += new System.EventHandler(this.Progowanie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p1Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progowaniePo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progowaniePierw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2Value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.TrackBar p1Value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox progowaniePo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox progowaniePierw;
        private System.Windows.Forms.Label lbValue1;
        public System.Windows.Forms.TrackBar p2Value;
        public System.Windows.Forms.Label lbValue2;
    }
}