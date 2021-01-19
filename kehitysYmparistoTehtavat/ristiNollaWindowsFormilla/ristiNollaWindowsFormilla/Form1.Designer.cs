namespace ristiNollaWindowsFormilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uusiPeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palttiarallaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.xVoittoMaara = new System.Windows.Forms.Label();
            this.tasapelienMaara = new System.Windows.Forms.Label();
            this.oVoittoMaara = new System.Windows.Forms.Label();
            this.xVoittojenLaskija = new System.Windows.Forms.Label();
            this.tasapelienLaskija = new System.Windows.Forms.Label();
            this.oVoittojenLaskija = new System.Windows.Forms.Label();
            this.nollaaVoitotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(326, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uusiPeliToolStripMenuItem,
            this.nollaaVoitotToolStripMenuItem,
            this.poistuToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.fIleToolStripMenuItem.Text = "Tiedosto";
            // 
            // uusiPeliToolStripMenuItem
            // 
            this.uusiPeliToolStripMenuItem.Name = "uusiPeliToolStripMenuItem";
            this.uusiPeliToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uusiPeliToolStripMenuItem.Text = "Uusi peli";
            this.uusiPeliToolStripMenuItem.Click += new System.EventHandler(this.uusiPeliToolStripMenuItem_Click);
            // 
            // poistuToolStripMenuItem
            // 
            this.poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            this.poistuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poistuToolStripMenuItem.Text = "Sulje";
            this.poistuToolStripMenuItem.Click += new System.EventHandler(this.poistuToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.palttiarallaaToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.helpToolStripMenuItem.Text = "Apua";
            // 
            // palttiarallaaToolStripMenuItem
            // 
            this.palttiarallaaToolStripMenuItem.Name = "palttiarallaaToolStripMenuItem";
            this.palttiarallaaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.palttiarallaaToolStripMenuItem.Text = "Palttiarallaa";
            this.palttiarallaaToolStripMenuItem.Click += new System.EventHandler(this.palttiarallaaToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.SystemColors.Control;
            this.A1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(43, 78);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.nappula_click);
            this.A1.MouseEnter += new System.EventHandler(this.nappulaSisaan);
            this.A1.MouseLeave += new System.EventHandler(this.nappulaUlos);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(124, 78);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.nappula_click);
            this.A2.MouseEnter += new System.EventHandler(this.nappulaSisaan);
            this.A2.MouseLeave += new System.EventHandler(this.nappulaUlos);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(205, 78);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.nappula_click);
            this.A3.MouseEnter += new System.EventHandler(this.nappulaSisaan);
            this.A3.MouseLeave += new System.EventHandler(this.nappulaUlos);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(43, 159);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.nappula_click);
            this.B1.MouseEnter += new System.EventHandler(this.nappulaSisaan);
            this.B1.MouseLeave += new System.EventHandler(this.nappulaUlos);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(124, 159);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.nappula_click);
            this.B2.MouseEnter += new System.EventHandler(this.nappulaSisaan);
            this.B2.MouseLeave += new System.EventHandler(this.nappulaUlos);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(205, 159);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.nappula_click);
            this.B3.MouseEnter += new System.EventHandler(this.nappulaSisaan);
            this.B3.MouseLeave += new System.EventHandler(this.nappulaUlos);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(43, 240);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.nappula_click);
            this.C1.MouseEnter += new System.EventHandler(this.nappulaSisaan);
            this.C1.MouseLeave += new System.EventHandler(this.nappulaUlos);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(124, 240);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.nappula_click);
            this.C2.MouseEnter += new System.EventHandler(this.nappulaSisaan);
            this.C2.MouseLeave += new System.EventHandler(this.nappulaUlos);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(205, 240);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.nappula_click);
            this.C3.MouseEnter += new System.EventHandler(this.nappulaSisaan);
            this.C3.MouseLeave += new System.EventHandler(this.nappulaUlos);
            // 
            // xVoittoMaara
            // 
            this.xVoittoMaara.AutoSize = true;
            this.xVoittoMaara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xVoittoMaara.Location = new System.Drawing.Point(40, 342);
            this.xVoittoMaara.MaximumSize = new System.Drawing.Size(75, 20);
            this.xVoittoMaara.MinimumSize = new System.Drawing.Size(75, 20);
            this.xVoittoMaara.Name = "xVoittoMaara";
            this.xVoittoMaara.Size = new System.Drawing.Size(75, 20);
            this.xVoittoMaara.TabIndex = 10;
            this.xVoittoMaara.Text = "X:n voitot";
            // 
            // tasapelienMaara
            // 
            this.tasapelienMaara.AutoSize = true;
            this.tasapelienMaara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasapelienMaara.Location = new System.Drawing.Point(121, 342);
            this.tasapelienMaara.MaximumSize = new System.Drawing.Size(75, 20);
            this.tasapelienMaara.MinimumSize = new System.Drawing.Size(75, 20);
            this.tasapelienMaara.Name = "tasapelienMaara";
            this.tasapelienMaara.Size = new System.Drawing.Size(75, 20);
            this.tasapelienMaara.TabIndex = 11;
            this.tasapelienMaara.Text = "Tasapelit";
            // 
            // oVoittoMaara
            // 
            this.oVoittoMaara.AutoSize = true;
            this.oVoittoMaara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oVoittoMaara.Location = new System.Drawing.Point(202, 342);
            this.oVoittoMaara.MaximumSize = new System.Drawing.Size(76, 20);
            this.oVoittoMaara.MinimumSize = new System.Drawing.Size(76, 20);
            this.oVoittoMaara.Name = "oVoittoMaara";
            this.oVoittoMaara.Size = new System.Drawing.Size(76, 20);
            this.oVoittoMaara.TabIndex = 12;
            this.oVoittoMaara.Text = "O:n voitot";
            // 
            // xVoittojenLaskija
            // 
            this.xVoittojenLaskija.AutoSize = true;
            this.xVoittojenLaskija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xVoittojenLaskija.Location = new System.Drawing.Point(71, 386);
            this.xVoittojenLaskija.Name = "xVoittojenLaskija";
            this.xVoittojenLaskija.Size = new System.Drawing.Size(18, 20);
            this.xVoittojenLaskija.TabIndex = 13;
            this.xVoittojenLaskija.Text = "0";
            // 
            // tasapelienLaskija
            // 
            this.tasapelienLaskija.AutoSize = true;
            this.tasapelienLaskija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasapelienLaskija.Location = new System.Drawing.Point(152, 386);
            this.tasapelienLaskija.Name = "tasapelienLaskija";
            this.tasapelienLaskija.Size = new System.Drawing.Size(18, 20);
            this.tasapelienLaskija.TabIndex = 14;
            this.tasapelienLaskija.Text = "0";
            // 
            // oVoittojenLaskija
            // 
            this.oVoittojenLaskija.AutoSize = true;
            this.oVoittojenLaskija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oVoittojenLaskija.Location = new System.Drawing.Point(233, 386);
            this.oVoittojenLaskija.Name = "oVoittojenLaskija";
            this.oVoittojenLaskija.Size = new System.Drawing.Size(18, 20);
            this.oVoittojenLaskija.TabIndex = 15;
            this.oVoittojenLaskija.Text = "0";
            // 
            // nollaaVoitotToolStripMenuItem
            // 
            this.nollaaVoitotToolStripMenuItem.Name = "nollaaVoitotToolStripMenuItem";
            this.nollaaVoitotToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nollaaVoitotToolStripMenuItem.Text = "Nollaa voitot";
            this.nollaaVoitotToolStripMenuItem.Click += new System.EventHandler(this.nollaaVoitotToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(326, 430);
            this.Controls.Add(this.oVoittojenLaskija);
            this.Controls.Add(this.tasapelienLaskija);
            this.Controls.Add(this.xVoittojenLaskija);
            this.Controls.Add(this.oVoittoMaara);
            this.Controls.Add(this.tasapelienMaara);
            this.Controls.Add(this.xVoittoMaara);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(342, 469);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(342, 469);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ristinolla";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uusiPeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poistuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.ToolStripMenuItem palttiarallaaToolStripMenuItem;
        private System.Windows.Forms.Label xVoittoMaara;
        private System.Windows.Forms.Label tasapelienMaara;
        private System.Windows.Forms.Label oVoittoMaara;
        private System.Windows.Forms.Label xVoittojenLaskija;
        private System.Windows.Forms.Label tasapelienLaskija;
        private System.Windows.Forms.Label oVoittojenLaskija;
        private System.Windows.Forms.ToolStripMenuItem nollaaVoitotToolStripMenuItem;
    }
}

