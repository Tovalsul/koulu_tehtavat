namespace paivakirja
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
            this.tekstiTextBox = new System.Windows.Forms.TextBox();
            this.tallennaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tekstiTextBox
            // 
            this.tekstiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tekstiTextBox.Location = new System.Drawing.Point(13, 13);
            this.tekstiTextBox.Multiline = true;
            this.tekstiTextBox.Name = "tekstiTextBox";
            this.tekstiTextBox.Size = new System.Drawing.Size(507, 346);
            this.tekstiTextBox.TabIndex = 0;
            // 
            // tallennaButton
            // 
            this.tallennaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tallennaButton.Location = new System.Drawing.Point(13, 365);
            this.tallennaButton.Name = "tallennaButton";
            this.tallennaButton.Size = new System.Drawing.Size(507, 60);
            this.tallennaButton.TabIndex = 1;
            this.tallennaButton.Text = "Tallenna päiväkirjaan";
            this.tallennaButton.UseVisualStyleBackColor = true;
            this.tallennaButton.Click += new System.EventHandler(this.tallennaButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 437);
            this.Controls.Add(this.tallennaButton);
            this.Controls.Add(this.tekstiTextBox);
            this.Name = "Form1";
            this.Text = "Päiväkirja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tekstiTextBox;
        private System.Windows.Forms.Button tallennaButton;
    }
}

