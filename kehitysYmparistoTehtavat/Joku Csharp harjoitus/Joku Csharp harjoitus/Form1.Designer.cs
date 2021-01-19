namespace Joku_Csharp_harjoitus
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
            this.painike = new System.Windows.Forms.Button();
            this.Teksti_tahan = new System.Windows.Forms.Label();
            this.tekstiLaatikko = new System.Windows.Forms.TextBox();
            this.viestiLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // painike
            // 
            this.painike.Location = new System.Drawing.Point(271, 137);
            this.painike.Name = "painike";
            this.painike.Size = new System.Drawing.Size(129, 72);
            this.painike.TabIndex = 0;
            this.painike.Text = "Paina minua";
            this.painike.UseVisualStyleBackColor = true;
            this.painike.Click += new System.EventHandler(this.painike_Click);
            // 
            // Teksti_tahan
            // 
            this.Teksti_tahan.AutoSize = true;
            this.Teksti_tahan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teksti_tahan.Location = new System.Drawing.Point(127, 44);
            this.Teksti_tahan.Name = "Teksti_tahan";
            this.Teksti_tahan.Size = new System.Drawing.Size(109, 17);
            this.Teksti_tahan.TabIndex = 1;
            this.Teksti_tahan.Text = "Anna etunimesi:";
            this.Teksti_tahan.Click += new System.EventHandler(this.Teksti_tahan_Click);
            // 
            // tekstiLaatikko
            // 
            this.tekstiLaatikko.Location = new System.Drawing.Point(254, 44);
            this.tekstiLaatikko.Name = "tekstiLaatikko";
            this.tekstiLaatikko.Size = new System.Drawing.Size(258, 20);
            this.tekstiLaatikko.TabIndex = 2;
            // 
            // viestiLabel
            // 
            this.viestiLabel.AutoSize = true;
            this.viestiLabel.Location = new System.Drawing.Point(58, 137);
            this.viestiLabel.Name = "viestiLabel";
            this.viestiLabel.Size = new System.Drawing.Size(104, 13);
            this.viestiLabel.TabIndex = 3;
            this.viestiLabel.Text = "Tähän tulee vastaus";
            this.viestiLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viestiLabel);
            this.Controls.Add(this.tekstiLaatikko);
            this.Controls.Add(this.Teksti_tahan);
            this.Controls.Add(this.painike);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button painike;
        private System.Windows.Forms.Label Teksti_tahan;
        private System.Windows.Forms.TextBox tekstiLaatikko;
        private System.Windows.Forms.Label viestiLabel;
    }
}

