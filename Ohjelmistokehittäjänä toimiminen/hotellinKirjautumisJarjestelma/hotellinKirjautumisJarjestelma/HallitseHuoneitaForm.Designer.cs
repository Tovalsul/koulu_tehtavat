namespace hotellinKirjautumisJarjestelma
{
    partial class HallitseHuoneitaForm
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
            this.halHuoneAlaPaneeli = new System.Windows.Forms.Panel();
            this.vapaaHuonePaneeli = new System.Windows.Forms.Panel();
            this.vapaaEiRadioButton = new System.Windows.Forms.RadioButton();
            this.vapaaKyllaRadioButton = new System.Windows.Forms.RadioButton();
            this.huoneVapaaHalHuone = new System.Windows.Forms.Label();
            this.halHuoneComboBox = new System.Windows.Forms.ComboBox();
            this.tyjennaKentatNappi = new System.Windows.Forms.Button();
            this.poistaHuoneNappi = new System.Windows.Forms.Button();
            this.muokkaaHuoneNappi = new System.Windows.Forms.Button();
            this.lisaaHuoneNappi = new System.Windows.Forms.Button();
            this.halHuonedataGridView1 = new System.Windows.Forms.DataGridView();
            this.puhnroHalHuoneTextBox = new System.Windows.Forms.TextBox();
            this.puhHalHuoneLabel = new System.Windows.Forms.Label();
            this.huoneTyyppiLabel = new System.Windows.Forms.Label();
            this.huoneNroTextBox = new System.Windows.Forms.TextBox();
            this.huoneNroLabel = new System.Windows.Forms.Label();
            this.halHuoneYlaPaneeli = new System.Windows.Forms.Panel();
            this.halHuoneLabel = new System.Windows.Forms.Label();
            this.halHuoneAlaPaneeli.SuspendLayout();
            this.vapaaHuonePaneeli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.halHuonedataGridView1)).BeginInit();
            this.halHuoneYlaPaneeli.SuspendLayout();
            this.SuspendLayout();
            // 
            // halHuoneAlaPaneeli
            // 
            this.halHuoneAlaPaneeli.BackColor = System.Drawing.Color.SlateGray;
            this.halHuoneAlaPaneeli.Controls.Add(this.vapaaHuonePaneeli);
            this.halHuoneAlaPaneeli.Controls.Add(this.huoneVapaaHalHuone);
            this.halHuoneAlaPaneeli.Controls.Add(this.halHuoneComboBox);
            this.halHuoneAlaPaneeli.Controls.Add(this.tyjennaKentatNappi);
            this.halHuoneAlaPaneeli.Controls.Add(this.poistaHuoneNappi);
            this.halHuoneAlaPaneeli.Controls.Add(this.muokkaaHuoneNappi);
            this.halHuoneAlaPaneeli.Controls.Add(this.lisaaHuoneNappi);
            this.halHuoneAlaPaneeli.Controls.Add(this.halHuonedataGridView1);
            this.halHuoneAlaPaneeli.Controls.Add(this.puhnroHalHuoneTextBox);
            this.halHuoneAlaPaneeli.Controls.Add(this.puhHalHuoneLabel);
            this.halHuoneAlaPaneeli.Controls.Add(this.huoneTyyppiLabel);
            this.halHuoneAlaPaneeli.Controls.Add(this.huoneNroTextBox);
            this.halHuoneAlaPaneeli.Controls.Add(this.huoneNroLabel);
            this.halHuoneAlaPaneeli.Controls.Add(this.halHuoneYlaPaneeli);
            this.halHuoneAlaPaneeli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.halHuoneAlaPaneeli.Location = new System.Drawing.Point(0, 0);
            this.halHuoneAlaPaneeli.Name = "halHuoneAlaPaneeli";
            this.halHuoneAlaPaneeli.Size = new System.Drawing.Size(921, 452);
            this.halHuoneAlaPaneeli.TabIndex = 1;
            // 
            // vapaaHuonePaneeli
            // 
            this.vapaaHuonePaneeli.BackColor = System.Drawing.SystemColors.Window;
            this.vapaaHuonePaneeli.Controls.Add(this.vapaaEiRadioButton);
            this.vapaaHuonePaneeli.Controls.Add(this.vapaaKyllaRadioButton);
            this.vapaaHuonePaneeli.Location = new System.Drawing.Point(116, 207);
            this.vapaaHuonePaneeli.Name = "vapaaHuonePaneeli";
            this.vapaaHuonePaneeli.Size = new System.Drawing.Size(137, 34);
            this.vapaaHuonePaneeli.TabIndex = 19;
            // 
            // vapaaEiRadioButton
            // 
            this.vapaaEiRadioButton.AutoSize = true;
            this.vapaaEiRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vapaaEiRadioButton.ForeColor = System.Drawing.Color.Red;
            this.vapaaEiRadioButton.Location = new System.Drawing.Point(94, 3);
            this.vapaaEiRadioButton.Name = "vapaaEiRadioButton";
            this.vapaaEiRadioButton.Size = new System.Drawing.Size(45, 28);
            this.vapaaEiRadioButton.TabIndex = 1;
            this.vapaaEiRadioButton.TabStop = true;
            this.vapaaEiRadioButton.Text = "EI";
            this.vapaaEiRadioButton.UseVisualStyleBackColor = true;
            // 
            // vapaaKyllaRadioButton
            // 
            this.vapaaKyllaRadioButton.AutoSize = true;
            this.vapaaKyllaRadioButton.Checked = true;
            this.vapaaKyllaRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vapaaKyllaRadioButton.ForeColor = System.Drawing.Color.Green;
            this.vapaaKyllaRadioButton.Location = new System.Drawing.Point(3, 3);
            this.vapaaKyllaRadioButton.Name = "vapaaKyllaRadioButton";
            this.vapaaKyllaRadioButton.Size = new System.Drawing.Size(85, 28);
            this.vapaaKyllaRadioButton.TabIndex = 0;
            this.vapaaKyllaRadioButton.TabStop = true;
            this.vapaaKyllaRadioButton.Text = "KYLLÄ";
            this.vapaaKyllaRadioButton.UseVisualStyleBackColor = true;
            // 
            // huoneVapaaHalHuone
            // 
            this.huoneVapaaHalHuone.AutoSize = true;
            this.huoneVapaaHalHuone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huoneVapaaHalHuone.Location = new System.Drawing.Point(31, 212);
            this.huoneVapaaHalHuone.Name = "huoneVapaaHalHuone";
            this.huoneVapaaHalHuone.Size = new System.Drawing.Size(79, 24);
            this.huoneVapaaHalHuone.TabIndex = 17;
            this.huoneVapaaHalHuone.Text = "Vapaa?:";
            // 
            // halHuoneComboBox
            // 
            this.halHuoneComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halHuoneComboBox.FormattingEnabled = true;
            this.halHuoneComboBox.Location = new System.Drawing.Point(116, 136);
            this.halHuoneComboBox.Name = "halHuoneComboBox";
            this.halHuoneComboBox.Size = new System.Drawing.Size(200, 32);
            this.halHuoneComboBox.TabIndex = 16;
            // 
            // tyjennaKentatNappi
            // 
            this.tyjennaKentatNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyjennaKentatNappi.Location = new System.Drawing.Point(8, 381);
            this.tyjennaKentatNappi.Name = "tyjennaKentatNappi";
            this.tyjennaKentatNappi.Size = new System.Drawing.Size(332, 40);
            this.tyjennaKentatNappi.TabIndex = 15;
            this.tyjennaKentatNappi.Text = "Tyhjennä kentät";
            this.tyjennaKentatNappi.UseVisualStyleBackColor = true;
            this.tyjennaKentatNappi.Click += new System.EventHandler(this.tyjennaKentatNappi_Click);
            // 
            // poistaHuoneNappi
            // 
            this.poistaHuoneNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poistaHuoneNappi.Location = new System.Drawing.Point(255, 316);
            this.poistaHuoneNappi.Name = "poistaHuoneNappi";
            this.poistaHuoneNappi.Size = new System.Drawing.Size(85, 40);
            this.poistaHuoneNappi.TabIndex = 14;
            this.poistaHuoneNappi.Text = "Poista";
            this.poistaHuoneNappi.UseVisualStyleBackColor = true;
            this.poistaHuoneNappi.Click += new System.EventHandler(this.poistaHuoneNappi_Click);
            // 
            // muokkaaHuoneNappi
            // 
            this.muokkaaHuoneNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muokkaaHuoneNappi.Location = new System.Drawing.Point(164, 316);
            this.muokkaaHuoneNappi.Name = "muokkaaHuoneNappi";
            this.muokkaaHuoneNappi.Size = new System.Drawing.Size(85, 40);
            this.muokkaaHuoneNappi.TabIndex = 13;
            this.muokkaaHuoneNappi.Text = "Muokkaa";
            this.muokkaaHuoneNappi.UseVisualStyleBackColor = true;
            this.muokkaaHuoneNappi.Click += new System.EventHandler(this.muokkaaHuoneNappi_Click);
            // 
            // lisaaHuoneNappi
            // 
            this.lisaaHuoneNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisaaHuoneNappi.Location = new System.Drawing.Point(8, 316);
            this.lisaaHuoneNappi.Name = "lisaaHuoneNappi";
            this.lisaaHuoneNappi.Size = new System.Drawing.Size(150, 40);
            this.lisaaHuoneNappi.TabIndex = 12;
            this.lisaaHuoneNappi.Text = "Lisää uusi huone";
            this.lisaaHuoneNappi.UseVisualStyleBackColor = true;
            this.lisaaHuoneNappi.Click += new System.EventHandler(this.lisaaHuoneNappi_Click);
            // 
            // halHuonedataGridView1
            // 
            this.halHuonedataGridView1.AllowUserToAddRows = false;
            this.halHuonedataGridView1.AllowUserToDeleteRows = false;
            this.halHuonedataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.halHuonedataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.halHuonedataGridView1.Location = new System.Drawing.Point(358, 102);
            this.halHuonedataGridView1.Name = "halHuonedataGridView1";
            this.halHuonedataGridView1.ReadOnly = true;
            this.halHuonedataGridView1.Size = new System.Drawing.Size(540, 319);
            this.halHuonedataGridView1.TabIndex = 11;
            this.halHuonedataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.halHuonedataGridView1_CellClick);
            // 
            // puhnroHalHuoneTextBox
            // 
            this.puhnroHalHuoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puhnroHalHuoneTextBox.Location = new System.Drawing.Point(116, 172);
            this.puhnroHalHuoneTextBox.Name = "puhnroHalHuoneTextBox";
            this.puhnroHalHuoneTextBox.Size = new System.Drawing.Size(200, 29);
            this.puhnroHalHuoneTextBox.TabIndex = 8;
            // 
            // puhHalHuoneLabel
            // 
            this.puhHalHuoneLabel.AutoSize = true;
            this.puhHalHuoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puhHalHuoneLabel.Location = new System.Drawing.Point(21, 174);
            this.puhHalHuoneLabel.Name = "puhHalHuoneLabel";
            this.puhHalHuoneLabel.Size = new System.Drawing.Size(89, 24);
            this.puhHalHuoneLabel.TabIndex = 7;
            this.puhHalHuoneLabel.Text = "Puhelin#:";
            // 
            // huoneTyyppiLabel
            // 
            this.huoneTyyppiLabel.AutoSize = true;
            this.huoneTyyppiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huoneTyyppiLabel.Location = new System.Drawing.Point(37, 140);
            this.huoneTyyppiLabel.Name = "huoneTyyppiLabel";
            this.huoneTyyppiLabel.Size = new System.Drawing.Size(73, 24);
            this.huoneTyyppiLabel.TabIndex = 3;
            this.huoneTyyppiLabel.Text = "Huone:";
            // 
            // huoneNroTextBox
            // 
            this.huoneNroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huoneNroTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.huoneNroTextBox.Location = new System.Drawing.Point(116, 102);
            this.huoneNroTextBox.Name = "huoneNroTextBox";
            this.huoneNroTextBox.Size = new System.Drawing.Size(128, 29);
            this.huoneNroTextBox.TabIndex = 2;
            // 
            // huoneNroLabel
            // 
            this.huoneNroLabel.AutoSize = true;
            this.huoneNroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huoneNroLabel.Location = new System.Drawing.Point(4, 104);
            this.huoneNroLabel.Name = "huoneNroLabel";
            this.huoneNroLabel.Size = new System.Drawing.Size(106, 24);
            this.huoneNroLabel.TabIndex = 1;
            this.huoneNroLabel.Text = "Huone nro:";
            // 
            // halHuoneYlaPaneeli
            // 
            this.halHuoneYlaPaneeli.BackColor = System.Drawing.Color.Tan;
            this.halHuoneYlaPaneeli.Controls.Add(this.halHuoneLabel);
            this.halHuoneYlaPaneeli.Location = new System.Drawing.Point(0, 0);
            this.halHuoneYlaPaneeli.Name = "halHuoneYlaPaneeli";
            this.halHuoneYlaPaneeli.Size = new System.Drawing.Size(937, 64);
            this.halHuoneYlaPaneeli.TabIndex = 0;
            // 
            // halHuoneLabel
            // 
            this.halHuoneLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.halHuoneLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halHuoneLabel.Location = new System.Drawing.Point(0, 0);
            this.halHuoneLabel.Name = "halHuoneLabel";
            this.halHuoneLabel.Size = new System.Drawing.Size(937, 64);
            this.halHuoneLabel.TabIndex = 0;
            this.halHuoneLabel.Text = "Hallitse Huoneita";
            this.halHuoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HallitseHuoneitaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 452);
            this.Controls.Add(this.halHuoneAlaPaneeli);
            this.Name = "HallitseHuoneitaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HallitseHuoneitaForm";
            this.Load += new System.EventHandler(this.HallitseHuoneitaForm_Load);
            this.halHuoneAlaPaneeli.ResumeLayout(false);
            this.halHuoneAlaPaneeli.PerformLayout();
            this.vapaaHuonePaneeli.ResumeLayout(false);
            this.vapaaHuonePaneeli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.halHuonedataGridView1)).EndInit();
            this.halHuoneYlaPaneeli.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel halHuoneAlaPaneeli;
        private System.Windows.Forms.Button tyjennaKentatNappi;
        private System.Windows.Forms.Button poistaHuoneNappi;
        private System.Windows.Forms.Button muokkaaHuoneNappi;
        private System.Windows.Forms.Button lisaaHuoneNappi;
        private System.Windows.Forms.DataGridView halHuonedataGridView1;
        private System.Windows.Forms.TextBox puhnroHalHuoneTextBox;
        private System.Windows.Forms.Label puhHalHuoneLabel;
        private System.Windows.Forms.Label huoneTyyppiLabel;
        private System.Windows.Forms.TextBox huoneNroTextBox;
        private System.Windows.Forms.Label huoneNroLabel;
        private System.Windows.Forms.Panel halHuoneYlaPaneeli;
        private System.Windows.Forms.Label halHuoneLabel;
        private System.Windows.Forms.ComboBox halHuoneComboBox;
        private System.Windows.Forms.Label huoneVapaaHalHuone;
        private System.Windows.Forms.Panel vapaaHuonePaneeli;
        private System.Windows.Forms.RadioButton vapaaEiRadioButton;
        private System.Windows.Forms.RadioButton vapaaKyllaRadioButton;
    }
}