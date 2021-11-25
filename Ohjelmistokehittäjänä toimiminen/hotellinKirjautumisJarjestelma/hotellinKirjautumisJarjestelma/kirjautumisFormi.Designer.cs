namespace hotellinKirjautumisJarjestelma
{
    partial class kirjautumisFormi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kirjautumisPaneeli = new System.Windows.Forms.Panel();
            this.kirjautumisLabel = new System.Windows.Forms.Label();
            this.kirjautumisRyhmaBoxi = new System.Windows.Forms.GroupBox();
            this.kirjautumisNappi = new System.Windows.Forms.Button();
            this.salasanaTekstiLaatikko = new System.Windows.Forms.TextBox();
            this.salasanaLabel = new System.Windows.Forms.Label();
            this.kayttajaNimiTekstiLaatikko = new System.Windows.Forms.TextBox();
            this.kayttajaNimiLabel = new System.Windows.Forms.Label();
            this.nimiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.kirjautumisPaneeli.SuspendLayout();
            this.kirjautumisRyhmaBoxi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hotellinKirjautumisJarjestelma.Properties.Resources.transparentLogin;
            this.pictureBox1.Location = new System.Drawing.Point(94, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kirjautumisPaneeli
            // 
            this.kirjautumisPaneeli.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.kirjautumisPaneeli.Controls.Add(this.kirjautumisLabel);
            this.kirjautumisPaneeli.Location = new System.Drawing.Point(32, 221);
            this.kirjautumisPaneeli.Name = "kirjautumisPaneeli";
            this.kirjautumisPaneeli.Size = new System.Drawing.Size(324, 44);
            this.kirjautumisPaneeli.TabIndex = 1;
            // 
            // kirjautumisLabel
            // 
            this.kirjautumisLabel.AutoSize = true;
            this.kirjautumisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kirjautumisLabel.Location = new System.Drawing.Point(23, 0);
            this.kirjautumisLabel.Name = "kirjautumisLabel";
            this.kirjautumisLabel.Size = new System.Drawing.Size(274, 42);
            this.kirjautumisLabel.TabIndex = 2;
            this.kirjautumisLabel.Text = "Kirjaudu sisään";
            // 
            // kirjautumisRyhmaBoxi
            // 
            this.kirjautumisRyhmaBoxi.Controls.Add(this.kirjautumisNappi);
            this.kirjautumisRyhmaBoxi.Controls.Add(this.salasanaTekstiLaatikko);
            this.kirjautumisRyhmaBoxi.Controls.Add(this.salasanaLabel);
            this.kirjautumisRyhmaBoxi.Controls.Add(this.kayttajaNimiTekstiLaatikko);
            this.kirjautumisRyhmaBoxi.Controls.Add(this.kayttajaNimiLabel);
            this.kirjautumisRyhmaBoxi.Location = new System.Drawing.Point(32, 271);
            this.kirjautumisRyhmaBoxi.Name = "kirjautumisRyhmaBoxi";
            this.kirjautumisRyhmaBoxi.Size = new System.Drawing.Size(324, 181);
            this.kirjautumisRyhmaBoxi.TabIndex = 2;
            this.kirjautumisRyhmaBoxi.TabStop = false;
            // 
            // kirjautumisNappi
            // 
            this.kirjautumisNappi.BackColor = System.Drawing.Color.MediumAquamarine;
            this.kirjautumisNappi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kirjautumisNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kirjautumisNappi.Location = new System.Drawing.Point(11, 126);
            this.kirjautumisNappi.Name = "kirjautumisNappi";
            this.kirjautumisNappi.Size = new System.Drawing.Size(286, 49);
            this.kirjautumisNappi.TabIndex = 4;
            this.kirjautumisNappi.Text = "Kirjaudu Sisään";
            this.kirjautumisNappi.UseVisualStyleBackColor = false;
            this.kirjautumisNappi.Click += new System.EventHandler(this.kirjautumisNappi_Click);
            // 
            // salasanaTekstiLaatikko
            // 
            this.salasanaTekstiLaatikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasanaTekstiLaatikko.Location = new System.Drawing.Point(137, 75);
            this.salasanaTekstiLaatikko.Name = "salasanaTekstiLaatikko";
            this.salasanaTekstiLaatikko.Size = new System.Drawing.Size(160, 31);
            this.salasanaTekstiLaatikko.TabIndex = 3;
            this.salasanaTekstiLaatikko.UseSystemPasswordChar = true;
            // 
            // salasanaLabel
            // 
            this.salasanaLabel.AutoSize = true;
            this.salasanaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasanaLabel.Location = new System.Drawing.Point(6, 78);
            this.salasanaLabel.Name = "salasanaLabel";
            this.salasanaLabel.Size = new System.Drawing.Size(108, 25);
            this.salasanaLabel.TabIndex = 2;
            this.salasanaLabel.Text = "Salasana:";
            // 
            // kayttajaNimiTekstiLaatikko
            // 
            this.kayttajaNimiTekstiLaatikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayttajaNimiTekstiLaatikko.Location = new System.Drawing.Point(137, 32);
            this.kayttajaNimiTekstiLaatikko.Name = "kayttajaNimiTekstiLaatikko";
            this.kayttajaNimiTekstiLaatikko.Size = new System.Drawing.Size(160, 31);
            this.kayttajaNimiTekstiLaatikko.TabIndex = 1;
            // 
            // kayttajaNimiLabel
            // 
            this.kayttajaNimiLabel.AutoSize = true;
            this.kayttajaNimiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayttajaNimiLabel.Location = new System.Drawing.Point(6, 35);
            this.kayttajaNimiLabel.Name = "kayttajaNimiLabel";
            this.kayttajaNimiLabel.Size = new System.Drawing.Size(135, 25);
            this.kayttajaNimiLabel.TabIndex = 0;
            this.kayttajaNimiLabel.Text = "Käyttäjänimi:";
            // 
            // nimiLabel
            // 
            this.nimiLabel.AutoSize = true;
            this.nimiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nimiLabel.Location = new System.Drawing.Point(28, 2);
            this.nimiLabel.Name = "nimiLabel";
            this.nimiLabel.Size = new System.Drawing.Size(336, 20);
            this.nimiLabel.TabIndex = 3;
            this.nimiLabel.Text = "Tony Lehtosen super best hotel supreme";
            // 
            // kirjautumisFormi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(382, 464);
            this.Controls.Add(this.nimiLabel);
            this.Controls.Add(this.kirjautumisRyhmaBoxi);
            this.Controls.Add(this.kirjautumisPaneeli);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kirjautumisFormi";
            this.ShowIcon = false;
            this.Text = "Teh Tony Lehtonen hotel master porgarm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.kirjautumisPaneeli.ResumeLayout(false);
            this.kirjautumisPaneeli.PerformLayout();
            this.kirjautumisRyhmaBoxi.ResumeLayout(false);
            this.kirjautumisRyhmaBoxi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel kirjautumisPaneeli;
        private System.Windows.Forms.Label kirjautumisLabel;
        private System.Windows.Forms.GroupBox kirjautumisRyhmaBoxi;
        private System.Windows.Forms.TextBox kayttajaNimiTekstiLaatikko;
        private System.Windows.Forms.Label kayttajaNimiLabel;
        private System.Windows.Forms.Label nimiLabel;
        private System.Windows.Forms.TextBox salasanaTekstiLaatikko;
        private System.Windows.Forms.Label salasanaLabel;
        private System.Windows.Forms.Button kirjautumisNappi;
    }
}