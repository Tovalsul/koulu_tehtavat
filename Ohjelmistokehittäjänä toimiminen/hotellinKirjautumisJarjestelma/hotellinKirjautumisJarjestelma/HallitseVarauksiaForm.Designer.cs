namespace hotellinKirjautumisJarjestelma
{
    partial class HallitseVarauksiaForm
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
            this.halVarausLabel = new System.Windows.Forms.Label();
            this.huoneTyyppiComboBox = new System.Windows.Forms.ComboBox();
            this.tyjennaKentatNappi = new System.Windows.Forms.Button();
            this.poistaVarausNappi = new System.Windows.Forms.Button();
            this.muokkaaVarausNappi = new System.Windows.Forms.Button();
            this.lisaaVarausNappi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.huoneTyyppiLabel = new System.Windows.Forms.Label();
            this.halHuoneYlaPaneeli = new System.Windows.Forms.Panel();
            this.halVarausAlaPaneeli = new System.Windows.Forms.Panel();
            this.varausPaattyyDate = new System.Windows.Forms.DateTimePicker();
            this.varausAlkaaDate = new System.Windows.Forms.DateTimePicker();
            this.varausPaattyyLabel = new System.Windows.Forms.Label();
            this.varausAlkaaLabel = new System.Windows.Forms.Label();
            this.huoneNroComboBox = new System.Windows.Forms.ComboBox();
            this.huoneNroLabel = new System.Windows.Forms.Label();
            this.asiakasIdTextBox = new System.Windows.Forms.TextBox();
            this.asiakasIdLabel = new System.Windows.Forms.Label();
            this.varausIdTextBox = new System.Windows.Forms.TextBox();
            this.varausIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.halHuoneYlaPaneeli.SuspendLayout();
            this.halVarausAlaPaneeli.SuspendLayout();
            this.SuspendLayout();
            // 
            // halVarausLabel
            // 
            this.halVarausLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.halVarausLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halVarausLabel.Location = new System.Drawing.Point(0, 0);
            this.halVarausLabel.Name = "halVarausLabel";
            this.halVarausLabel.Size = new System.Drawing.Size(937, 64);
            this.halVarausLabel.TabIndex = 0;
            this.halVarausLabel.Text = "Hallitse Varauksia";
            this.halVarausLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // huoneTyyppiComboBox
            // 
            this.huoneTyyppiComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huoneTyyppiComboBox.FormattingEnabled = true;
            this.huoneTyyppiComboBox.Location = new System.Drawing.Point(140, 149);
            this.huoneTyyppiComboBox.Name = "huoneTyyppiComboBox";
            this.huoneTyyppiComboBox.Size = new System.Drawing.Size(200, 32);
            this.huoneTyyppiComboBox.TabIndex = 16;
            this.huoneTyyppiComboBox.SelectedIndexChanged += new System.EventHandler(this.huoneTyyppiComboBox_SelectedIndexChanged);
            // 
            // tyjennaKentatNappi
            // 
            this.tyjennaKentatNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyjennaKentatNappi.Location = new System.Drawing.Point(8, 362);
            this.tyjennaKentatNappi.Name = "tyjennaKentatNappi";
            this.tyjennaKentatNappi.Size = new System.Drawing.Size(332, 40);
            this.tyjennaKentatNappi.TabIndex = 15;
            this.tyjennaKentatNappi.Text = "Tyhjennä kentät";
            this.tyjennaKentatNappi.UseVisualStyleBackColor = true;
            this.tyjennaKentatNappi.Click += new System.EventHandler(this.tyjennaKentatNappi_Click);
            // 
            // poistaVarausNappi
            // 
            this.poistaVarausNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poistaVarausNappi.Location = new System.Drawing.Point(255, 316);
            this.poistaVarausNappi.Name = "poistaVarausNappi";
            this.poistaVarausNappi.Size = new System.Drawing.Size(85, 40);
            this.poistaVarausNappi.TabIndex = 14;
            this.poistaVarausNappi.Text = "Poista";
            this.poistaVarausNappi.UseVisualStyleBackColor = true;
            this.poistaVarausNappi.Click += new System.EventHandler(this.poistaVarausNappi_Click);
            // 
            // muokkaaVarausNappi
            // 
            this.muokkaaVarausNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muokkaaVarausNappi.Location = new System.Drawing.Point(164, 316);
            this.muokkaaVarausNappi.Name = "muokkaaVarausNappi";
            this.muokkaaVarausNappi.Size = new System.Drawing.Size(85, 40);
            this.muokkaaVarausNappi.TabIndex = 13;
            this.muokkaaVarausNappi.Text = "Muokkaa";
            this.muokkaaVarausNappi.UseVisualStyleBackColor = true;
            this.muokkaaVarausNappi.Click += new System.EventHandler(this.muokkaaVarausNappi_Click);
            // 
            // lisaaVarausNappi
            // 
            this.lisaaVarausNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisaaVarausNappi.Location = new System.Drawing.Point(8, 316);
            this.lisaaVarausNappi.Name = "lisaaVarausNappi";
            this.lisaaVarausNappi.Size = new System.Drawing.Size(150, 40);
            this.lisaaVarausNappi.TabIndex = 12;
            this.lisaaVarausNappi.Text = "Lisää varaus";
            this.lisaaVarausNappi.UseVisualStyleBackColor = true;
            this.lisaaVarausNappi.Click += new System.EventHandler(this.lisaaVarausNappi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(358, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(540, 300);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // huoneTyyppiLabel
            // 
            this.huoneTyyppiLabel.AutoSize = true;
            this.huoneTyyppiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huoneTyyppiLabel.Location = new System.Drawing.Point(69, 153);
            this.huoneTyyppiLabel.Name = "huoneTyyppiLabel";
            this.huoneTyyppiLabel.Size = new System.Drawing.Size(73, 24);
            this.huoneTyyppiLabel.TabIndex = 3;
            this.huoneTyyppiLabel.Text = "Huone:";
            // 
            // halHuoneYlaPaneeli
            // 
            this.halHuoneYlaPaneeli.BackColor = System.Drawing.Color.Tan;
            this.halHuoneYlaPaneeli.Controls.Add(this.halVarausLabel);
            this.halHuoneYlaPaneeli.Location = new System.Drawing.Point(0, 0);
            this.halHuoneYlaPaneeli.Name = "halHuoneYlaPaneeli";
            this.halHuoneYlaPaneeli.Size = new System.Drawing.Size(937, 64);
            this.halHuoneYlaPaneeli.TabIndex = 0;
            // 
            // halVarausAlaPaneeli
            // 
            this.halVarausAlaPaneeli.BackColor = System.Drawing.Color.SlateGray;
            this.halVarausAlaPaneeli.Controls.Add(this.varausIdTextBox);
            this.halVarausAlaPaneeli.Controls.Add(this.varausIdLabel);
            this.halVarausAlaPaneeli.Controls.Add(this.varausPaattyyDate);
            this.halVarausAlaPaneeli.Controls.Add(this.varausAlkaaDate);
            this.halVarausAlaPaneeli.Controls.Add(this.varausPaattyyLabel);
            this.halVarausAlaPaneeli.Controls.Add(this.varausAlkaaLabel);
            this.halVarausAlaPaneeli.Controls.Add(this.huoneNroComboBox);
            this.halVarausAlaPaneeli.Controls.Add(this.huoneNroLabel);
            this.halVarausAlaPaneeli.Controls.Add(this.asiakasIdTextBox);
            this.halVarausAlaPaneeli.Controls.Add(this.asiakasIdLabel);
            this.halVarausAlaPaneeli.Controls.Add(this.huoneTyyppiComboBox);
            this.halVarausAlaPaneeli.Controls.Add(this.tyjennaKentatNappi);
            this.halVarausAlaPaneeli.Controls.Add(this.poistaVarausNappi);
            this.halVarausAlaPaneeli.Controls.Add(this.muokkaaVarausNappi);
            this.halVarausAlaPaneeli.Controls.Add(this.lisaaVarausNappi);
            this.halVarausAlaPaneeli.Controls.Add(this.dataGridView1);
            this.halVarausAlaPaneeli.Controls.Add(this.huoneTyyppiLabel);
            this.halVarausAlaPaneeli.Controls.Add(this.halHuoneYlaPaneeli);
            this.halVarausAlaPaneeli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.halVarausAlaPaneeli.Location = new System.Drawing.Point(0, 0);
            this.halVarausAlaPaneeli.Name = "halVarausAlaPaneeli";
            this.halVarausAlaPaneeli.Size = new System.Drawing.Size(905, 413);
            this.halVarausAlaPaneeli.TabIndex = 2;
            // 
            // varausPaattyyDate
            // 
            this.varausPaattyyDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varausPaattyyDate.CustomFormat = "dd-MM-yyyy";
            this.varausPaattyyDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varausPaattyyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.varausPaattyyDate.Location = new System.Drawing.Point(140, 260);
            this.varausPaattyyDate.Name = "varausPaattyyDate";
            this.varausPaattyyDate.Size = new System.Drawing.Size(200, 29);
            this.varausPaattyyDate.TabIndex = 24;
            this.varausPaattyyDate.Value = new System.DateTime(2020, 12, 12, 0, 0, 0, 0);
            // 
            // varausAlkaaDate
            // 
            this.varausAlkaaDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varausAlkaaDate.CustomFormat = "dd-MM-yyyy";
            this.varausAlkaaDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varausAlkaaDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.varausAlkaaDate.Location = new System.Drawing.Point(140, 225);
            this.varausAlkaaDate.Name = "varausAlkaaDate";
            this.varausAlkaaDate.Size = new System.Drawing.Size(200, 29);
            this.varausAlkaaDate.TabIndex = 23;
            this.varausAlkaaDate.Value = new System.DateTime(2020, 12, 12, 0, 0, 0, 0);
            // 
            // varausPaattyyLabel
            // 
            this.varausPaattyyLabel.AutoSize = true;
            this.varausPaattyyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varausPaattyyLabel.Location = new System.Drawing.Point(6, 262);
            this.varausPaattyyLabel.Name = "varausPaattyyLabel";
            this.varausPaattyyLabel.Size = new System.Drawing.Size(136, 24);
            this.varausPaattyyLabel.TabIndex = 22;
            this.varausPaattyyLabel.Text = "Varaus päättyy:";
            // 
            // varausAlkaaLabel
            // 
            this.varausAlkaaLabel.AutoSize = true;
            this.varausAlkaaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varausAlkaaLabel.Location = new System.Drawing.Point(20, 227);
            this.varausAlkaaLabel.Name = "varausAlkaaLabel";
            this.varausAlkaaLabel.Size = new System.Drawing.Size(122, 24);
            this.varausAlkaaLabel.TabIndex = 21;
            this.varausAlkaaLabel.Text = "Varaus alkaa:";
            // 
            // huoneNroComboBox
            // 
            this.huoneNroComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huoneNroComboBox.FormattingEnabled = true;
            this.huoneNroComboBox.Location = new System.Drawing.Point(140, 187);
            this.huoneNroComboBox.Name = "huoneNroComboBox";
            this.huoneNroComboBox.Size = new System.Drawing.Size(200, 32);
            this.huoneNroComboBox.TabIndex = 20;
            // 
            // huoneNroLabel
            // 
            this.huoneNroLabel.AutoSize = true;
            this.huoneNroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huoneNroLabel.Location = new System.Drawing.Point(54, 191);
            this.huoneNroLabel.Name = "huoneNroLabel";
            this.huoneNroLabel.Size = new System.Drawing.Size(88, 24);
            this.huoneNroLabel.TabIndex = 19;
            this.huoneNroLabel.Text = "Huone #:";
            // 
            // asiakasIdTextBox
            // 
            this.asiakasIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asiakasIdTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.asiakasIdTextBox.Location = new System.Drawing.Point(140, 114);
            this.asiakasIdTextBox.Name = "asiakasIdTextBox";
            this.asiakasIdTextBox.Size = new System.Drawing.Size(128, 29);
            this.asiakasIdTextBox.TabIndex = 18;
            // 
            // asiakasIdLabel
            // 
            this.asiakasIdLabel.AutoSize = true;
            this.asiakasIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asiakasIdLabel.Location = new System.Drawing.Point(41, 116);
            this.asiakasIdLabel.Name = "asiakasIdLabel";
            this.asiakasIdLabel.Size = new System.Drawing.Size(101, 24);
            this.asiakasIdLabel.TabIndex = 17;
            this.asiakasIdLabel.Text = "Asiakas ID:";
            // 
            // varausIdTextBox
            // 
            this.varausIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varausIdTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.varausIdTextBox.Location = new System.Drawing.Point(140, 79);
            this.varausIdTextBox.Name = "varausIdTextBox";
            this.varausIdTextBox.Size = new System.Drawing.Size(128, 29);
            this.varausIdTextBox.TabIndex = 26;
            // 
            // varausIdLabel
            // 
            this.varausIdLabel.AutoSize = true;
            this.varausIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varausIdLabel.Location = new System.Drawing.Point(41, 81);
            this.varausIdLabel.Name = "varausIdLabel";
            this.varausIdLabel.Size = new System.Drawing.Size(96, 24);
            this.varausIdLabel.TabIndex = 25;
            this.varausIdLabel.Text = "Varaus ID:";
            // 
            // HallitseVarauksiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 413);
            this.Controls.Add(this.halVarausAlaPaneeli);
            this.Name = "HallitseVarauksiaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.HallitseVarauksiaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.halHuoneYlaPaneeli.ResumeLayout(false);
            this.halVarausAlaPaneeli.ResumeLayout(false);
            this.halVarausAlaPaneeli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label halVarausLabel;
        private System.Windows.Forms.ComboBox huoneTyyppiComboBox;
        private System.Windows.Forms.Button tyjennaKentatNappi;
        private System.Windows.Forms.Button poistaVarausNappi;
        private System.Windows.Forms.Button muokkaaVarausNappi;
        private System.Windows.Forms.Button lisaaVarausNappi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label huoneTyyppiLabel;
        private System.Windows.Forms.Panel halHuoneYlaPaneeli;
        private System.Windows.Forms.Panel halVarausAlaPaneeli;
        private System.Windows.Forms.TextBox asiakasIdTextBox;
        private System.Windows.Forms.Label asiakasIdLabel;
        private System.Windows.Forms.ComboBox huoneNroComboBox;
        private System.Windows.Forms.Label huoneNroLabel;
        private System.Windows.Forms.DateTimePicker varausPaattyyDate;
        private System.Windows.Forms.DateTimePicker varausAlkaaDate;
        private System.Windows.Forms.Label varausPaattyyLabel;
        private System.Windows.Forms.Label varausAlkaaLabel;
        private System.Windows.Forms.TextBox varausIdTextBox;
        private System.Windows.Forms.Label varausIdLabel;
    }
}