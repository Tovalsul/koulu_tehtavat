namespace sekuntikello
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
            this.kelloPanel = new System.Windows.Forms.Panel();
            this.aikaLabel = new System.Windows.Forms.Label();
            this.kaynnistaButton = new System.Windows.Forms.Button();
            this.pysaytaButton = new System.Windows.Forms.Button();
            this.nollaaButton = new System.Windows.Forms.Button();
            this.ajastinTimer = new System.Windows.Forms.Timer(this.components);
            this.kelloPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kelloPanel
            // 
            this.kelloPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kelloPanel.Controls.Add(this.aikaLabel);
            this.kelloPanel.Location = new System.Drawing.Point(13, 13);
            this.kelloPanel.Name = "kelloPanel";
            this.kelloPanel.Size = new System.Drawing.Size(423, 77);
            this.kelloPanel.TabIndex = 0;
            // 
            // aikaLabel
            // 
            this.aikaLabel.AutoSize = true;
            this.aikaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aikaLabel.Location = new System.Drawing.Point(3, 0);
            this.aikaLabel.Name = "aikaLabel";
            this.aikaLabel.Size = new System.Drawing.Size(422, 73);
            this.aikaLabel.TabIndex = 0;
            this.aikaLabel.Text = "00:00:00.000";
            // 
            // kaynnistaButton
            // 
            this.kaynnistaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaynnistaButton.Location = new System.Drawing.Point(13, 128);
            this.kaynnistaButton.Name = "kaynnistaButton";
            this.kaynnistaButton.Size = new System.Drawing.Size(86, 43);
            this.kaynnistaButton.TabIndex = 1;
            this.kaynnistaButton.Text = "Start";
            this.kaynnistaButton.UseVisualStyleBackColor = true;
            this.kaynnistaButton.Click += new System.EventHandler(this.kaynnistaButton_Click);
            // 
            // pysaytaButton
            // 
            this.pysaytaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pysaytaButton.Location = new System.Drawing.Point(180, 128);
            this.pysaytaButton.Name = "pysaytaButton";
            this.pysaytaButton.Size = new System.Drawing.Size(86, 43);
            this.pysaytaButton.TabIndex = 2;
            this.pysaytaButton.Text = "Stop";
            this.pysaytaButton.UseVisualStyleBackColor = true;
            this.pysaytaButton.Click += new System.EventHandler(this.pysaytaButton_Click);
            // 
            // nollaaButton
            // 
            this.nollaaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nollaaButton.Location = new System.Drawing.Point(350, 128);
            this.nollaaButton.Name = "nollaaButton";
            this.nollaaButton.Size = new System.Drawing.Size(86, 43);
            this.nollaaButton.TabIndex = 3;
            this.nollaaButton.Text = "Reset";
            this.nollaaButton.UseVisualStyleBackColor = true;
            this.nollaaButton.Click += new System.EventHandler(this.nollaaButton_Click);
            // 
            // ajastinTimer
            // 
            this.ajastinTimer.Enabled = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 182);
            this.Controls.Add(this.nollaaButton);
            this.Controls.Add(this.pysaytaButton);
            this.Controls.Add(this.kaynnistaButton);
            this.Controls.Add(this.kelloPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.kelloPanel.ResumeLayout(false);
            this.kelloPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel kelloPanel;
        private System.Windows.Forms.Label aikaLabel;
        private System.Windows.Forms.Button kaynnistaButton;
        private System.Windows.Forms.Button pysaytaButton;
        private System.Windows.Forms.Button nollaaButton;
        private System.Windows.Forms.Timer ajastinTimer;
    }
}

