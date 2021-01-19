namespace kaksiLukua
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
            this.components = new System.ComponentModel.Container();
            this.laskuNappi = new System.Windows.Forms.Button();
            this.lukuTeksti1 = new System.Windows.Forms.Label();
            this.lukuTeksti2 = new System.Windows.Forms.Label();
            this.lukuLaatikko1 = new System.Windows.Forms.TextBox();
            this.lukuLaatikko2 = new System.Windows.Forms.TextBox();
            this.vastausLabel = new System.Windows.Forms.Label();
            this.ohje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // laskuNappi
            // 
            this.laskuNappi.Location = new System.Drawing.Point(179, 231);
            this.laskuNappi.Name = "laskuNappi";
            this.laskuNappi.Size = new System.Drawing.Size(75, 23);
            this.laskuNappi.TabIndex = 0;
            this.laskuNappi.Text = "Laske yhteen";
            this.laskuNappi.UseVisualStyleBackColor = true;
            this.laskuNappi.Click += new System.EventHandler(this.laskuNappi_Click);
            // 
            // lukuTeksti1
            // 
            this.lukuTeksti1.AutoSize = true;
            this.lukuTeksti1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lukuTeksti1.Location = new System.Drawing.Point(114, 76);
            this.lukuTeksti1.Name = "lukuTeksti1";
            this.lukuTeksti1.Size = new System.Drawing.Size(61, 20);
            this.lukuTeksti1.TabIndex = 1;
            this.lukuTeksti1.Text = "Luku 1:";
            // 
            // lukuTeksti2
            // 
            this.lukuTeksti2.AutoSize = true;
            this.lukuTeksti2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lukuTeksti2.Location = new System.Drawing.Point(114, 158);
            this.lukuTeksti2.Name = "lukuTeksti2";
            this.lukuTeksti2.Size = new System.Drawing.Size(61, 20);
            this.lukuTeksti2.TabIndex = 2;
            this.lukuTeksti2.Text = "Luku 2:";
            // 
            // lukuLaatikko1
            // 
            this.lukuLaatikko1.Location = new System.Drawing.Point(179, 76);
            this.lukuLaatikko1.Name = "lukuLaatikko1";
            this.lukuLaatikko1.Size = new System.Drawing.Size(115, 20);
            this.lukuLaatikko1.TabIndex = 3;
            // 
            // lukuLaatikko2
            // 
            this.lukuLaatikko2.Location = new System.Drawing.Point(181, 158);
            this.lukuLaatikko2.Name = "lukuLaatikko2";
            this.lukuLaatikko2.Size = new System.Drawing.Size(115, 20);
            this.lukuLaatikko2.TabIndex = 4;
            // 
            // vastausLabel
            // 
            this.vastausLabel.AutoSize = true;
            this.vastausLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vastausLabel.Location = new System.Drawing.Point(124, 300);
            this.vastausLabel.Name = "vastausLabel";
            this.vastausLabel.Size = new System.Drawing.Size(152, 20);
            this.vastausLabel.TabIndex = 5;
            this.vastausLabel.Text = "Tähän tulee vastaus";
            this.vastausLabel.Visible = false;
            // 
            // ohje
            // 
            this.ohje.AutoSize = true;
            this.ohje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ohje.Location = new System.Drawing.Point(118, 13);
            this.ohje.Name = "ohje";
            this.ohje.Size = new System.Drawing.Size(133, 20);
            this.ohje.TabIndex = 6;
            this.ohje.Text = "Anna kaksi lukua.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "+";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ohje);
            this.Controls.Add(this.vastausLabel);
            this.Controls.Add(this.lukuLaatikko2);
            this.Controls.Add(this.lukuLaatikko1);
            this.Controls.Add(this.lukuTeksti2);
            this.Controls.Add(this.lukuTeksti1);
            this.Controls.Add(this.laskuNappi);
            this.Name = "Form1";
            this.Text = "vastaus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button laskuNappi;
        private System.Windows.Forms.Label lukuTeksti1;
        private System.Windows.Forms.Label lukuTeksti2;
        private System.Windows.Forms.TextBox lukuLaatikko1;
        private System.Windows.Forms.TextBox lukuLaatikko2;
        private System.Windows.Forms.Label vastausLabel;
        private System.Windows.Forms.Label ohje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

