namespace kirjautumisIkkuna
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
            this.label1 = new System.Windows.Forms.Label();
            this.kayttajanimenSyotto = new System.Windows.Forms.TextBox();
            this.salasananSyotto = new System.Windows.Forms.TextBox();
            this.kirjauduNappi = new System.Windows.Forms.Button();
            this.kayttajanimiLabel = new System.Windows.Forms.Label();
            this.salasanaLabel = new System.Windows.Forms.Label();
            this.exitNappi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kirjautumis lomake";
            // 
            // kayttajanimenSyotto
            // 
            this.kayttajanimenSyotto.Location = new System.Drawing.Point(133, 119);
            this.kayttajanimenSyotto.Name = "kayttajanimenSyotto";
            this.kayttajanimenSyotto.Size = new System.Drawing.Size(179, 20);
            this.kayttajanimenSyotto.TabIndex = 1;
            // 
            // salasananSyotto
            // 
            this.salasananSyotto.Location = new System.Drawing.Point(133, 165);
            this.salasananSyotto.Name = "salasananSyotto";
            this.salasananSyotto.Size = new System.Drawing.Size(179, 20);
            this.salasananSyotto.TabIndex = 2;
            this.salasananSyotto.UseSystemPasswordChar = true;
            // 
            // kirjauduNappi
            // 
            this.kirjauduNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kirjauduNappi.Location = new System.Drawing.Point(133, 219);
            this.kirjauduNappi.Name = "kirjauduNappi";
            this.kirjauduNappi.Size = new System.Drawing.Size(75, 44);
            this.kirjauduNappi.TabIndex = 3;
            this.kirjauduNappi.Text = "Kirjaudu";
            this.kirjauduNappi.UseVisualStyleBackColor = true;
            this.kirjauduNappi.Click += new System.EventHandler(this.kirjauduNappi_Click);
            // 
            // kayttajanimiLabel
            // 
            this.kayttajanimiLabel.AutoSize = true;
            this.kayttajanimiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayttajanimiLabel.Location = new System.Drawing.Point(29, 117);
            this.kayttajanimiLabel.Name = "kayttajanimiLabel";
            this.kayttajanimiLabel.Size = new System.Drawing.Size(98, 20);
            this.kayttajanimiLabel.TabIndex = 4;
            this.kayttajanimiLabel.Text = "Käyttäjänimi:";
            // 
            // salasanaLabel
            // 
            this.salasanaLabel.AutoSize = true;
            this.salasanaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasanaLabel.Location = new System.Drawing.Point(29, 165);
            this.salasanaLabel.Name = "salasanaLabel";
            this.salasanaLabel.Size = new System.Drawing.Size(80, 20);
            this.salasanaLabel.TabIndex = 5;
            this.salasanaLabel.Text = "Salasana:";
            // 
            // exitNappi
            // 
            this.exitNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitNappi.Location = new System.Drawing.Point(237, 219);
            this.exitNappi.Name = "exitNappi";
            this.exitNappi.Size = new System.Drawing.Size(75, 43);
            this.exitNappi.TabIndex = 6;
            this.exitNappi.Text = "Exit";
            this.exitNappi.UseVisualStyleBackColor = true;
            this.exitNappi.Click += new System.EventHandler(this.exitNappi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(427, 338);
            this.Controls.Add(this.exitNappi);
            this.Controls.Add(this.salasanaLabel);
            this.Controls.Add(this.kayttajanimiLabel);
            this.Controls.Add(this.kirjauduNappi);
            this.Controls.Add(this.salasananSyotto);
            this.Controls.Add(this.kayttajanimenSyotto);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kirjaudu sisään";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kayttajanimenSyotto;
        private System.Windows.Forms.TextBox salasananSyotto;
        private System.Windows.Forms.Button kirjauduNappi;
        private System.Windows.Forms.Label kayttajanimiLabel;
        private System.Windows.Forms.Label salasanaLabel;
        private System.Windows.Forms.Button exitNappi;
    }
}

