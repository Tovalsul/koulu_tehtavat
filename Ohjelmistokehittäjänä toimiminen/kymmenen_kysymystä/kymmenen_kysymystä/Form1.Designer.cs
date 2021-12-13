namespace kymmenen_kysymystä
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
            this.kayttajanVastausLabel = new System.Windows.Forms.Label();
            this.vastauksetPanel = new System.Windows.Forms.Panel();
            this.aRadioButton = new System.Windows.Forms.RadioButton();
            this.bRadioButton = new System.Windows.Forms.RadioButton();
            this.cRadioButton = new System.Windows.Forms.RadioButton();
            this.dRadioButton = new System.Windows.Forms.RadioButton();
            this.piilotettuRadioButton = new System.Windows.Forms.RadioButton();
            this.vastauksetPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ohjeLabel
            // 
            this.ohjeLabel.AutoSize = true;
            this.ohjeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ohjeLabel.Location = new System.Drawing.Point(13, 13);
            this.ohjeLabel.Name = "ohjeLabel";
            this.ohjeLabel.Size = new System.Drawing.Size(256, 25);
            this.ohjeLabel.TabIndex = 9;
            this.ohjeLabel.Text = "Vastaus 1. kysymykseen:";
            // 
            // vastausLabel
            // 
            this.vastausLabel.AutoSize = true;
            this.vastausLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vastausLabel.Location = new System.Drawing.Point(12, 139);
            this.vastausLabel.Name = "vastausLabel";
            this.vastausLabel.Size = new System.Drawing.Size(90, 25);
            this.vastausLabel.TabIndex = 8;
            this.vastausLabel.Text = "Vastaus";
            // 
            // kayttajanVastausLabel
            // 
            this.kayttajanVastausLabel.AutoSize = true;
            this.kayttajanVastausLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayttajanVastausLabel.Location = new System.Drawing.Point(3, 0);
            this.kayttajanVastausLabel.Name = "kayttajanVastausLabel";
            this.kayttajanVastausLabel.Size = new System.Drawing.Size(68, 20);
            this.kayttajanVastausLabel.TabIndex = 7;
            this.kayttajanVastausLabel.Text = "Vastaus";
            // 
            // vastauksetPanel
            // 
            this.vastauksetPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vastauksetPanel.Controls.Add(this.dRadioButton);
            this.vastauksetPanel.Controls.Add(this.cRadioButton);
            this.vastauksetPanel.Controls.Add(this.bRadioButton);
            this.vastauksetPanel.Controls.Add(this.aRadioButton);
            this.vastauksetPanel.Controls.Add(this.kayttajanVastausLabel);
            this.vastauksetPanel.Location = new System.Drawing.Point(295, 13);
            this.vastauksetPanel.Name = "vastauksetPanel";
            this.vastauksetPanel.Size = new System.Drawing.Size(136, 142);
            this.vastauksetPanel.TabIndex = 6;
            // 
            // aRadioButton
            // 
            this.aRadioButton.AutoSize = true;
            this.aRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aRadioButton.Location = new System.Drawing.Point(7, 23);
            this.aRadioButton.Name = "aRadioButton";
            this.aRadioButton.Size = new System.Drawing.Size(38, 24);
            this.aRadioButton.TabIndex = 1;
            this.aRadioButton.TabStop = true;
            this.aRadioButton.Text = "A";
            this.aRadioButton.UseVisualStyleBackColor = true;
            // 
            // bRadioButton
            // 
            this.bRadioButton.AutoSize = true;
            this.bRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRadioButton.Location = new System.Drawing.Point(7, 53);
            this.bRadioButton.Name = "bRadioButton";
            this.bRadioButton.Size = new System.Drawing.Size(38, 24);
            this.bRadioButton.TabIndex = 2;
            this.bRadioButton.TabStop = true;
            this.bRadioButton.Text = "B";
            this.bRadioButton.UseVisualStyleBackColor = true;
            // 
            // cRadioButton
            // 
            this.cRadioButton.AutoSize = true;
            this.cRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cRadioButton.Location = new System.Drawing.Point(7, 83);
            this.cRadioButton.Name = "cRadioButton";
            this.cRadioButton.Size = new System.Drawing.Size(38, 24);
            this.cRadioButton.TabIndex = 3;
            this.cRadioButton.TabStop = true;
            this.cRadioButton.Text = "C";
            this.cRadioButton.UseVisualStyleBackColor = true;
            // 
            // dRadioButton
            // 
            this.dRadioButton.AutoSize = true;
            this.dRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dRadioButton.Location = new System.Drawing.Point(7, 113);
            this.dRadioButton.Name = "dRadioButton";
            this.dRadioButton.Size = new System.Drawing.Size(39, 24);
            this.dRadioButton.TabIndex = 4;
            this.dRadioButton.TabStop = true;
            this.dRadioButton.Text = "D";
            this.dRadioButton.UseVisualStyleBackColor = true;
            // 
            // piilotettuRadioButton
            // 
            this.piilotettuRadioButton.AutoCheck = false;
            this.piilotettuRadioButton.AutoSize = true;
            this.piilotettuRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piilotettuRadioButton.Location = new System.Drawing.Point(472, 14);
            this.piilotettuRadioButton.Name = "piilotettuRadioButton";
            this.piilotettuRadioButton.Size = new System.Drawing.Size(87, 24);
            this.piilotettuRadioButton.TabIndex = 0;
            this.piilotettuRadioButton.TabStop = true;
            this.piilotettuRadioButton.Text = "piilotettu";
            this.piilotettuRadioButton.UseVisualStyleBackColor = true;
            this.piilotettuRadioButton.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 175);
            this.Controls.Add(this.piilotettuRadioButton);
            this.Controls.Add(this.vastauksetPanel);
            this.Controls.Add(this.vastausLabel);
            this.Controls.Add(this.ohjeLabel);
            this.Name = "Form1";
            this.Text = "10 kysymystä";
            this.vastauksetPanel.ResumeLayout(false);
            this.vastauksetPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ohjeLabel;
        private System.Windows.Forms.Label vastausLabel;
        private System.Windows.Forms.Label kayttajanVastausLabel;
        private System.Windows.Forms.Panel vastauksetPanel;
        private System.Windows.Forms.RadioButton dRadioButton;
        private System.Windows.Forms.RadioButton cRadioButton;
        private System.Windows.Forms.RadioButton bRadioButton;
        private System.Windows.Forms.RadioButton aRadioButton;
        private System.Windows.Forms.RadioButton piilotettuRadioButton;
    }
}

