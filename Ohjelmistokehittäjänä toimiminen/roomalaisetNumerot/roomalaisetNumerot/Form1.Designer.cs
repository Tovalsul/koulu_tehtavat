namespace roomalaisetNumerot
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
            this.otsikkoLabel = new System.Windows.Forms.Label();
            this.vastausLabel = new System.Windows.Forms.Label();
            this.ohjeLabel = new System.Windows.Forms.Label();
            this.muutaButton = new System.Windows.Forms.Button();
            this.numerotTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // otsikkoLabel
            // 
            this.otsikkoLabel.AutoSize = true;
            this.otsikkoLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otsikkoLabel.Location = new System.Drawing.Point(254, 9);
            this.otsikkoLabel.Name = "otsikkoLabel";
            this.otsikkoLabel.Size = new System.Drawing.Size(219, 27);
            this.otsikkoLabel.TabIndex = 0;
            this.otsikkoLabel.Text = "Roomalaiset numerot";
            // 
            // vastausLabel
            // 
            this.vastausLabel.AutoSize = true;
            this.vastausLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vastausLabel.Location = new System.Drawing.Point(26, 181);
            this.vastausLabel.Name = "vastausLabel";
            this.vastausLabel.Size = new System.Drawing.Size(206, 27);
            this.vastausLabel.TabIndex = 1;
            this.vastausLabel.Text = "Roomalaiset numerot";
            // 
            // ohjeLabel
            // 
            this.ohjeLabel.AutoSize = true;
            this.ohjeLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ohjeLabel.Location = new System.Drawing.Point(12, 98);
            this.ohjeLabel.Name = "ohjeLabel";
            this.ohjeLabel.Size = new System.Drawing.Size(564, 27);
            this.ohjeLabel.TabIndex = 2;
            this.ohjeLabel.Text = "Anna numero välillä 1-3999, niin muutan sen roomalaiseksi:";
            // 
            // muutaButton
            // 
            this.muutaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muutaButton.Location = new System.Drawing.Point(613, 176);
            this.muutaButton.Name = "muutaButton";
            this.muutaButton.Size = new System.Drawing.Size(119, 37);
            this.muutaButton.TabIndex = 3;
            this.muutaButton.Text = "Muuta";
            this.muutaButton.UseVisualStyleBackColor = true;
            this.muutaButton.Click += new System.EventHandler(this.muutaButton_Click);
            // 
            // numerotTextBox
            // 
            this.numerotTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerotTextBox.Location = new System.Drawing.Point(613, 96);
            this.numerotTextBox.Name = "numerotTextBox";
            this.numerotTextBox.Size = new System.Drawing.Size(107, 31);
            this.numerotTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 432);
            this.Controls.Add(this.numerotTextBox);
            this.Controls.Add(this.muutaButton);
            this.Controls.Add(this.ohjeLabel);
            this.Controls.Add(this.vastausLabel);
            this.Controls.Add(this.otsikkoLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label otsikkoLabel;
        private System.Windows.Forms.Label vastausLabel;
        private System.Windows.Forms.Label ohjeLabel;
        private System.Windows.Forms.Button muutaButton;
        private System.Windows.Forms.TextBox numerotTextBox;
    }
}

