namespace viivojenPiirtaja
{
    partial class Form1
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
            this.viivojenOminaisuusValikko = new System.Windows.Forms.Panel();
            this.piirraPainike = new System.Windows.Forms.Button();
            this.viivojenKasvu = new System.Windows.Forms.TextBox();
            this.viivojenPituus = new System.Windows.Forms.TextBox();
            this.viivojenKulma = new System.Windows.Forms.TextBox();
            this.viivojenMaara = new System.Windows.Forms.TextBox();
            this.kasvuLabel = new System.Windows.Forms.Label();
            this.pituusLabel = new System.Windows.Forms.Label();
            this.kulmaLabel = new System.Windows.Forms.Label();
            this.viivaLabel = new System.Windows.Forms.Label();
            this.viivojenPiirtoAlue = new System.Windows.Forms.Panel();
            this.viivojenOminaisuusValikko.SuspendLayout();
            this.SuspendLayout();
            // 
            // viivojenOminaisuusValikko
            // 
            this.viivojenOminaisuusValikko.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.viivojenOminaisuusValikko.Controls.Add(this.piirraPainike);
            this.viivojenOminaisuusValikko.Controls.Add(this.viivojenKasvu);
            this.viivojenOminaisuusValikko.Controls.Add(this.viivojenPituus);
            this.viivojenOminaisuusValikko.Controls.Add(this.viivojenKulma);
            this.viivojenOminaisuusValikko.Controls.Add(this.viivojenMaara);
            this.viivojenOminaisuusValikko.Controls.Add(this.kasvuLabel);
            this.viivojenOminaisuusValikko.Controls.Add(this.pituusLabel);
            this.viivojenOminaisuusValikko.Controls.Add(this.kulmaLabel);
            this.viivojenOminaisuusValikko.Controls.Add(this.viivaLabel);
            this.viivojenOminaisuusValikko.Dock = System.Windows.Forms.DockStyle.Top;
            this.viivojenOminaisuusValikko.Location = new System.Drawing.Point(0, 0);
            this.viivojenOminaisuusValikko.Name = "viivojenOminaisuusValikko";
            this.viivojenOminaisuusValikko.Size = new System.Drawing.Size(469, 49);
            this.viivojenOminaisuusValikko.TabIndex = 0;
            // 
            // piirraPainike
            // 
            this.piirraPainike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piirraPainike.Location = new System.Drawing.Point(394, 9);
            this.piirraPainike.Name = "piirraPainike";
            this.piirraPainike.Size = new System.Drawing.Size(60, 29);
            this.piirraPainike.TabIndex = 0;
            this.piirraPainike.Text = "Piirrä!";
            this.piirraPainike.UseVisualStyleBackColor = true;
            this.piirraPainike.Click += new System.EventHandler(this.piirraPainike_Click);
            // 
            // viivojenKasvu
            // 
            this.viivojenKasvu.Location = new System.Drawing.Point(362, 13);
            this.viivojenKasvu.Name = "viivojenKasvu";
            this.viivojenKasvu.Size = new System.Drawing.Size(23, 20);
            this.viivojenKasvu.TabIndex = 5;
            this.viivojenKasvu.Text = "1";
            // 
            // viivojenPituus
            // 
            this.viivojenPituus.Location = new System.Drawing.Point(269, 13);
            this.viivojenPituus.Name = "viivojenPituus";
            this.viivojenPituus.Size = new System.Drawing.Size(23, 20);
            this.viivojenPituus.TabIndex = 6;
            this.viivojenPituus.Text = "100";
            // 
            // viivojenKulma
            // 
            this.viivojenKulma.Location = new System.Drawing.Point(175, 13);
            this.viivojenKulma.Name = "viivojenKulma";
            this.viivojenKulma.Size = new System.Drawing.Size(23, 20);
            this.viivojenKulma.TabIndex = 5;
            this.viivojenKulma.Text = "5";
            // 
            // viivojenMaara
            // 
            this.viivojenMaara.Location = new System.Drawing.Point(81, 13);
            this.viivojenMaara.Name = "viivojenMaara";
            this.viivojenMaara.Size = new System.Drawing.Size(23, 20);
            this.viivojenMaara.TabIndex = 4;
            this.viivojenMaara.Text = "1";
            // 
            // kasvuLabel
            // 
            this.kasvuLabel.AutoSize = true;
            this.kasvuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kasvuLabel.ForeColor = System.Drawing.Color.White;
            this.kasvuLabel.Location = new System.Drawing.Point(301, 13);
            this.kasvuLabel.Name = "kasvuLabel";
            this.kasvuLabel.Size = new System.Drawing.Size(52, 20);
            this.kasvuLabel.TabIndex = 3;
            this.kasvuLabel.Text = "Kasvu";
            // 
            // pituusLabel
            // 
            this.pituusLabel.AutoSize = true;
            this.pituusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pituusLabel.ForeColor = System.Drawing.Color.White;
            this.pituusLabel.Location = new System.Drawing.Point(207, 13);
            this.pituusLabel.Name = "pituusLabel";
            this.pituusLabel.Size = new System.Drawing.Size(53, 20);
            this.pituusLabel.TabIndex = 2;
            this.pituusLabel.Text = "Pituus";
            // 
            // kulmaLabel
            // 
            this.kulmaLabel.AutoSize = true;
            this.kulmaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kulmaLabel.ForeColor = System.Drawing.Color.White;
            this.kulmaLabel.Location = new System.Drawing.Point(113, 13);
            this.kulmaLabel.Name = "kulmaLabel";
            this.kulmaLabel.Size = new System.Drawing.Size(53, 20);
            this.kulmaLabel.TabIndex = 1;
            this.kulmaLabel.Text = "Kulma";
            // 
            // viivaLabel
            // 
            this.viivaLabel.AutoSize = true;
            this.viivaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viivaLabel.ForeColor = System.Drawing.Color.White;
            this.viivaLabel.Location = new System.Drawing.Point(12, 13);
            this.viivaLabel.Name = "viivaLabel";
            this.viivaLabel.Size = new System.Drawing.Size(60, 20);
            this.viivaLabel.TabIndex = 0;
            this.viivaLabel.Text = "# Viivat";
            // 
            // viivojenPiirtoAlue
            // 
            this.viivojenPiirtoAlue.BackColor = System.Drawing.SystemColors.Info;
            this.viivojenPiirtoAlue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viivojenPiirtoAlue.Location = new System.Drawing.Point(0, 49);
            this.viivojenPiirtoAlue.Name = "viivojenPiirtoAlue";
            this.viivojenPiirtoAlue.Size = new System.Drawing.Size(469, 401);
            this.viivojenPiirtoAlue.TabIndex = 1;
            this.viivojenPiirtoAlue.Paint += new System.Windows.Forms.PaintEventHandler(this.viivojenPiirtoAlue_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.viivojenPiirtoAlue);
            this.Controls.Add(this.viivojenOminaisuusValikko);
            this.Name = "Form1";
            this.Text = "Viivojen piirto ohjelma";
            this.viivojenOminaisuusValikko.ResumeLayout(false);
            this.viivojenOminaisuusValikko.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viivojenOminaisuusValikko;
        private System.Windows.Forms.Button piirraPainike;
        private System.Windows.Forms.TextBox viivojenKasvu;
        private System.Windows.Forms.TextBox viivojenPituus;
        private System.Windows.Forms.TextBox viivojenKulma;
        private System.Windows.Forms.TextBox viivojenMaara;
        private System.Windows.Forms.Label kasvuLabel;
        private System.Windows.Forms.Label pituusLabel;
        private System.Windows.Forms.Label kulmaLabel;
        private System.Windows.Forms.Label viivaLabel;
        private System.Windows.Forms.Panel viivojenPiirtoAlue;
    }
}

