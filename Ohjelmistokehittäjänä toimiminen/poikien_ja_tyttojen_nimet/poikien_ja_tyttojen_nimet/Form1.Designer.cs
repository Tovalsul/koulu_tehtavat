namespace poikien_ja_tyttojen_nimet
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
            this.ohjeLabel = new System.Windows.Forms.Label();
            this.vastausLabel = new System.Windows.Forms.Label();
            this.nimiTextBox = new System.Windows.Forms.TextBox();
            this.tarkistusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ohjeLabel
            // 
            this.ohjeLabel.AutoSize = true;
            this.ohjeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ohjeLabel.Location = new System.Drawing.Point(13, 13);
            this.ohjeLabel.Name = "ohjeLabel";
            this.ohjeLabel.Size = new System.Drawing.Size(462, 20);
            this.ohjeLabel.TabIndex = 0;
            this.ohjeLabel.Text = "Anna nimesi, niin tarkastan, onko se 50 suosituimman joukossa: ";
            // 
            // vastausLabel
            // 
            this.vastausLabel.AutoSize = true;
            this.vastausLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vastausLabel.Location = new System.Drawing.Point(12, 45);
            this.vastausLabel.Name = "vastausLabel";
            this.vastausLabel.Size = new System.Drawing.Size(290, 20);
            this.vastausLabel.TabIndex = 1;
            this.vastausLabel.Text = "Nimesi on n. suosituin nimi vuonna 2020";
            // 
            // nimiTextBox
            // 
            this.nimiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nimiTextBox.Location = new System.Drawing.Point(481, 13);
            this.nimiTextBox.Name = "nimiTextBox";
            this.nimiTextBox.Size = new System.Drawing.Size(100, 26);
            this.nimiTextBox.TabIndex = 2;
            // 
            // tarkistusButton
            // 
            this.tarkistusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarkistusButton.Location = new System.Drawing.Point(481, 45);
            this.tarkistusButton.Name = "tarkistusButton";
            this.tarkistusButton.Size = new System.Drawing.Size(88, 34);
            this.tarkistusButton.TabIndex = 3;
            this.tarkistusButton.Text = "Tarkasta";
            this.tarkistusButton.UseVisualStyleBackColor = true;
            this.tarkistusButton.Click += new System.EventHandler(this.tarkistusButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 89);
            this.Controls.Add(this.tarkistusButton);
            this.Controls.Add(this.nimiTextBox);
            this.Controls.Add(this.vastausLabel);
            this.Controls.Add(this.ohjeLabel);
            this.Name = "Form1";
            this.Text = "Onko sinulla yksi suosituista nimistä?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ohjeLabel;
        private System.Windows.Forms.Label vastausLabel;
        private System.Windows.Forms.TextBox nimiTextBox;
        private System.Windows.Forms.Button tarkistusButton;
    }
}

