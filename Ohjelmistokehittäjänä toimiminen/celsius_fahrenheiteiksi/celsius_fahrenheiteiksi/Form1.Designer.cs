namespace celsius_fahrenheiteiksi
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
            this.asteetLB = new System.Windows.Forms.Label();
            this.kysymysLB = new System.Windows.Forms.Label();
            this.vastausLB = new System.Windows.Forms.Label();
            this.asteetTB = new System.Windows.Forms.TextBox();
            this.muunnaBT = new System.Windows.Forms.Button();
            this.celsiusRB = new System.Windows.Forms.RadioButton();
            this.fahrenheitRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // asteetLB
            // 
            this.asteetLB.AutoSize = true;
            this.asteetLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asteetLB.Location = new System.Drawing.Point(12, 54);
            this.asteetLB.Name = "asteetLB";
            this.asteetLB.Size = new System.Drawing.Size(133, 25);
            this.asteetLB.TabIndex = 0;
            this.asteetLB.Text = "Anna asteet:";
            // 
            // kysymysLB
            // 
            this.kysymysLB.AutoSize = true;
            this.kysymysLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kysymysLB.Location = new System.Drawing.Point(225, 9);
            this.kysymysLB.Name = "kysymysLB";
            this.kysymysLB.Size = new System.Drawing.Size(166, 25);
            this.kysymysLB.TabIndex = 2;
            this.kysymysLB.Text = "Miten muunnat?";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vastausLB.Location = new System.Drawing.Point(12, 121);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(90, 25);
            this.vastausLB.TabIndex = 3;
            this.vastausLB.Text = "Vastaus";
            this.vastausLB.Visible = false;
            // 
            // asteetTB
            // 
            this.asteetTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asteetTB.Location = new System.Drawing.Point(151, 51);
            this.asteetTB.Name = "asteetTB";
            this.asteetTB.Size = new System.Drawing.Size(65, 31);
            this.asteetTB.TabIndex = 5;
            // 
            // muunnaBT
            // 
            this.muunnaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muunnaBT.Location = new System.Drawing.Point(424, 59);
            this.muunnaBT.Name = "muunnaBT";
            this.muunnaBT.Size = new System.Drawing.Size(100, 42);
            this.muunnaBT.TabIndex = 6;
            this.muunnaBT.Text = "Muunna";
            this.muunnaBT.UseVisualStyleBackColor = true;
            this.muunnaBT.Click += new System.EventHandler(this.muunnaBT_Click);
            // 
            // celsiusRB
            // 
            this.celsiusRB.AutoSize = true;
            this.celsiusRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celsiusRB.Location = new System.Drawing.Point(230, 37);
            this.celsiusRB.Name = "celsiusRB";
            this.celsiusRB.Size = new System.Drawing.Size(107, 29);
            this.celsiusRB.TabIndex = 7;
            this.celsiusRB.TabStop = true;
            this.celsiusRB.Text = "Celsius:";
            this.celsiusRB.UseVisualStyleBackColor = true;
            // 
            // fahrenheitRB
            // 
            this.fahrenheitRB.AutoSize = true;
            this.fahrenheitRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrenheitRB.Location = new System.Drawing.Point(230, 72);
            this.fahrenheitRB.Name = "fahrenheitRB";
            this.fahrenheitRB.Size = new System.Drawing.Size(133, 29);
            this.fahrenheitRB.TabIndex = 8;
            this.fahrenheitRB.TabStop = true;
            this.fahrenheitRB.Text = "Fahrenheit";
            this.fahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 166);
            this.Controls.Add(this.fahrenheitRB);
            this.Controls.Add(this.celsiusRB);
            this.Controls.Add(this.muunnaBT);
            this.Controls.Add(this.asteetTB);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.kysymysLB);
            this.Controls.Add(this.asteetLB);
            this.Name = "Form1";
            this.Text = "Lämpöasteiden kääntäjä";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label asteetLB;
        private System.Windows.Forms.Label kysymysLB;
        private System.Windows.Forms.Label vastausLB;
        private System.Windows.Forms.TextBox asteetTB;
        private System.Windows.Forms.Button muunnaBT;
        private System.Windows.Forms.RadioButton celsiusRB;
        private System.Windows.Forms.RadioButton fahrenheitRB;
    }
}

