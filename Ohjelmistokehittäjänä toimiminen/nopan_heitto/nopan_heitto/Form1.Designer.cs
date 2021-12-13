namespace nopan_heitto
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
            this.heitaButton = new System.Windows.Forms.Button();
            this.noppa02PB = new System.Windows.Forms.PictureBox();
            this.noppa01PB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).BeginInit();
            this.SuspendLayout();
            // 
            // otsikkoLabel
            // 
            this.otsikkoLabel.AutoSize = true;
            this.otsikkoLabel.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otsikkoLabel.Location = new System.Drawing.Point(13, 13);
            this.otsikkoLabel.Name = "otsikkoLabel";
            this.otsikkoLabel.Size = new System.Drawing.Size(144, 28);
            this.otsikkoLabel.TabIndex = 0;
            this.otsikkoLabel.Text = "Nopan heitto";
            // 
            // heitaButton
            // 
            this.heitaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heitaButton.Location = new System.Drawing.Point(18, 239);
            this.heitaButton.Name = "heitaButton";
            this.heitaButton.Size = new System.Drawing.Size(233, 44);
            this.heitaButton.TabIndex = 3;
            this.heitaButton.Text = "Heitä";
            this.heitaButton.UseVisualStyleBackColor = true;
            this.heitaButton.Click += new System.EventHandler(this.heitaButton_Click);
            // 
            // noppa02PB
            // 
            this.noppa02PB.Image = global::nopan_heitto.Properties.Resources.rollingDice;
            this.noppa02PB.Location = new System.Drawing.Point(151, 44);
            this.noppa02PB.Name = "noppa02PB";
            this.noppa02PB.Size = new System.Drawing.Size(100, 145);
            this.noppa02PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppa02PB.TabIndex = 2;
            this.noppa02PB.TabStop = false;
            // 
            // noppa01PB
            // 
            this.noppa01PB.Image = global::nopan_heitto.Properties.Resources.rollingDice;
            this.noppa01PB.Location = new System.Drawing.Point(18, 44);
            this.noppa01PB.Name = "noppa01PB";
            this.noppa01PB.Size = new System.Drawing.Size(100, 145);
            this.noppa01PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppa01PB.TabIndex = 1;
            this.noppa01PB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 312);
            this.Controls.Add(this.heitaButton);
            this.Controls.Add(this.noppa02PB);
            this.Controls.Add(this.noppa01PB);
            this.Controls.Add(this.otsikkoLabel);
            this.Name = "Form1";
            this.Text = "Heitä noppaa";
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label otsikkoLabel;
        private System.Windows.Forms.PictureBox noppa01PB;
        private System.Windows.Forms.PictureBox noppa02PB;
        private System.Windows.Forms.Button heitaButton;
    }
}

