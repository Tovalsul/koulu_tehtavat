namespace bmi_laskuri
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
            this.painoLabel = new System.Windows.Forms.Label();
            this.pituusLabel = new System.Windows.Forms.Label();
            this.tulosLabel = new System.Windows.Forms.Label();
            this.laskeBmiButton = new System.Windows.Forms.Button();
            this.painoTextBox = new System.Windows.Forms.TextBox();
            this.pituusTextBox = new System.Windows.Forms.TextBox();
            this.kuvausLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // painoLabel
            // 
            this.painoLabel.AutoSize = true;
            this.painoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painoLabel.Location = new System.Drawing.Point(21, 21);
            this.painoLabel.Name = "painoLabel";
            this.painoLabel.Size = new System.Drawing.Size(127, 25);
            this.painoLabel.TabIndex = 0;
            this.painoLabel.Text = "Anna paino:";
            // 
            // pituusLabel
            // 
            this.pituusLabel.AutoSize = true;
            this.pituusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pituusLabel.Location = new System.Drawing.Point(21, 73);
            this.pituusLabel.Name = "pituusLabel";
            this.pituusLabel.Size = new System.Drawing.Size(132, 25);
            this.pituusLabel.TabIndex = 1;
            this.pituusLabel.Text = "Anna pituus:";
            // 
            // tulosLabel
            // 
            this.tulosLabel.AutoSize = true;
            this.tulosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tulosLabel.Location = new System.Drawing.Point(21, 196);
            this.tulosLabel.Name = "tulosLabel";
            this.tulosLabel.Size = new System.Drawing.Size(193, 25);
            this.tulosLabel.TabIndex = 2;
            this.tulosLabel.Text = "Painoindeksisi on: ";
            // 
            // laskeBmiButton
            // 
            this.laskeBmiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laskeBmiButton.Location = new System.Drawing.Point(26, 131);
            this.laskeBmiButton.Name = "laskeBmiButton";
            this.laskeBmiButton.Size = new System.Drawing.Size(228, 43);
            this.laskeBmiButton.TabIndex = 3;
            this.laskeBmiButton.Text = "Laske painoindeksi";
            this.laskeBmiButton.UseVisualStyleBackColor = true;
            this.laskeBmiButton.Click += new System.EventHandler(this.laskeBmiButton_Click);
            // 
            // painoTextBox
            // 
            this.painoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painoTextBox.Location = new System.Drawing.Point(154, 21);
            this.painoTextBox.Name = "painoTextBox";
            this.painoTextBox.Size = new System.Drawing.Size(100, 31);
            this.painoTextBox.TabIndex = 4;
            // 
            // pituusTextBox
            // 
            this.pituusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pituusTextBox.Location = new System.Drawing.Point(154, 73);
            this.pituusTextBox.Name = "pituusTextBox";
            this.pituusTextBox.Size = new System.Drawing.Size(100, 31);
            this.pituusTextBox.TabIndex = 5;
            // 
            // kuvausLabel
            // 
            this.kuvausLabel.AutoSize = true;
            this.kuvausLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kuvausLabel.Location = new System.Drawing.Point(21, 234);
            this.kuvausLabel.Name = "kuvausLabel";
            this.kuvausLabel.Size = new System.Drawing.Size(65, 25);
            this.kuvausLabel.TabIndex = 6;
            this.kuvausLabel.Text = "paino";
            this.kuvausLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 283);
            this.Controls.Add(this.kuvausLabel);
            this.Controls.Add(this.pituusTextBox);
            this.Controls.Add(this.painoTextBox);
            this.Controls.Add(this.laskeBmiButton);
            this.Controls.Add(this.tulosLabel);
            this.Controls.Add(this.pituusLabel);
            this.Controls.Add(this.painoLabel);
            this.Name = "Form1";
            this.Text = "BMI-laskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label painoLabel;
        private System.Windows.Forms.Label pituusLabel;
        private System.Windows.Forms.Label tulosLabel;
        private System.Windows.Forms.Button laskeBmiButton;
        private System.Windows.Forms.TextBox painoTextBox;
        private System.Windows.Forms.TextBox pituusTextBox;
        private System.Windows.Forms.Label kuvausLabel;
    }
}

