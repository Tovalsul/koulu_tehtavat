namespace Ajastin
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
            this.components = new System.ComponentModel.Container();
            this.minuutitLabel = new System.Windows.Forms.Label();
            this.sekunnitLabel = new System.Windows.Forms.Label();
            this.aikaLabel = new System.Windows.Forms.Label();
            this.kaynnistaButton = new System.Windows.Forms.Button();
            this.pysaytaButton = new System.Windows.Forms.Button();
            this.minuutitComboBox = new System.Windows.Forms.ComboBox();
            this.sekunnitComboBox = new System.Windows.Forms.ComboBox();
            this.ajastin = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // minuutitLabel
            // 
            this.minuutitLabel.AutoSize = true;
            this.minuutitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuutitLabel.Location = new System.Drawing.Point(12, 9);
            this.minuutitLabel.Name = "minuutitLabel";
            this.minuutitLabel.Size = new System.Drawing.Size(94, 25);
            this.minuutitLabel.TabIndex = 0;
            this.minuutitLabel.Text = "Minuutit:";
            // 
            // sekunnitLabel
            // 
            this.sekunnitLabel.AutoSize = true;
            this.sekunnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sekunnitLabel.Location = new System.Drawing.Point(143, 9);
            this.sekunnitLabel.Name = "sekunnitLabel";
            this.sekunnitLabel.Size = new System.Drawing.Size(102, 25);
            this.sekunnitLabel.TabIndex = 1;
            this.sekunnitLabel.Text = "Sekunnit:";
            // 
            // aikaLabel
            // 
            this.aikaLabel.AutoSize = true;
            this.aikaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aikaLabel.Location = new System.Drawing.Point(20, 73);
            this.aikaLabel.Name = "aikaLabel";
            this.aikaLabel.Size = new System.Drawing.Size(194, 73);
            this.aikaLabel.TabIndex = 2;
            this.aikaLabel.Text = "00:00";
            // 
            // kaynnistaButton
            // 
            this.kaynnistaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaynnistaButton.Location = new System.Drawing.Point(12, 149);
            this.kaynnistaButton.Name = "kaynnistaButton";
            this.kaynnistaButton.Size = new System.Drawing.Size(115, 57);
            this.kaynnistaButton.TabIndex = 3;
            this.kaynnistaButton.Text = "Käynnistä";
            this.kaynnistaButton.UseVisualStyleBackColor = true;
            this.kaynnistaButton.Click += new System.EventHandler(this.kaynnistaButton_Click);
            // 
            // pysaytaButton
            // 
            this.pysaytaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pysaytaButton.Location = new System.Drawing.Point(133, 149);
            this.pysaytaButton.Name = "pysaytaButton";
            this.pysaytaButton.Size = new System.Drawing.Size(114, 57);
            this.pysaytaButton.TabIndex = 4;
            this.pysaytaButton.Text = "Pysäytä";
            this.pysaytaButton.UseVisualStyleBackColor = true;
            this.pysaytaButton.Click += new System.EventHandler(this.pysaytaButton_Click);
            // 
            // minuutitComboBox
            // 
            this.minuutitComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuutitComboBox.FormattingEnabled = true;
            this.minuutitComboBox.Location = new System.Drawing.Point(17, 37);
            this.minuutitComboBox.Name = "minuutitComboBox";
            this.minuutitComboBox.Size = new System.Drawing.Size(89, 33);
            this.minuutitComboBox.TabIndex = 5;
            // 
            // sekunnitComboBox
            // 
            this.sekunnitComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sekunnitComboBox.FormattingEnabled = true;
            this.sekunnitComboBox.Location = new System.Drawing.Point(148, 37);
            this.sekunnitComboBox.Name = "sekunnitComboBox";
            this.sekunnitComboBox.Size = new System.Drawing.Size(89, 33);
            this.sekunnitComboBox.TabIndex = 6;
            // 
            // ajastin
            // 
            this.ajastin.Enabled = true;
            this.ajastin.Interval = 1000;
            this.ajastin.Tick += new System.EventHandler(this.ajastin_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 222);
            this.Controls.Add(this.sekunnitComboBox);
            this.Controls.Add(this.minuutitComboBox);
            this.Controls.Add(this.pysaytaButton);
            this.Controls.Add(this.kaynnistaButton);
            this.Controls.Add(this.aikaLabel);
            this.Controls.Add(this.sekunnitLabel);
            this.Controls.Add(this.minuutitLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minuutitLabel;
        private System.Windows.Forms.Label sekunnitLabel;
        private System.Windows.Forms.Label aikaLabel;
        private System.Windows.Forms.Button kaynnistaButton;
        private System.Windows.Forms.Button pysaytaButton;
        private System.Windows.Forms.ComboBox minuutitComboBox;
        private System.Windows.Forms.ComboBox sekunnitComboBox;
        private System.Windows.Forms.Timer ajastin;
    }
}

