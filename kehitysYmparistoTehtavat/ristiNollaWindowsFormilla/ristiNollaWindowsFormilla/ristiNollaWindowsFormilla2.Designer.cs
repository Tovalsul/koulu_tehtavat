namespace ristiNollaWindowsFormilla
{
    partial class ristiNollaWindowsFormilla2
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
            this.pelaajaYksi = new System.Windows.Forms.Label();
            this.pelaajaKaksi = new System.Windows.Forms.Label();
            this.pelaajaYksiNimi = new System.Windows.Forms.TextBox();
            this.pelaaNappi = new System.Windows.Forms.Button();
            this.pelaajaKaksiNimi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pelaajaYksi
            // 
            this.pelaajaYksi.AutoSize = true;
            this.pelaajaYksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pelaajaYksi.Location = new System.Drawing.Point(5, 14);
            this.pelaajaYksi.Name = "pelaajaYksi";
            this.pelaajaYksi.Size = new System.Drawing.Size(95, 20);
            this.pelaajaYksi.TabIndex = 0;
            this.pelaajaYksi.Text = " Pelaaja #1 :";
            // 
            // pelaajaKaksi
            // 
            this.pelaajaKaksi.AutoSize = true;
            this.pelaajaKaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pelaajaKaksi.Location = new System.Drawing.Point(8, 56);
            this.pelaajaKaksi.Name = "pelaajaKaksi";
            this.pelaajaKaksi.Size = new System.Drawing.Size(91, 20);
            this.pelaajaKaksi.TabIndex = 1;
            this.pelaajaKaksi.Text = "Pelaaja #2 :";
            // 
            // pelaajaYksiNimi
            // 
            this.pelaajaYksiNimi.Location = new System.Drawing.Point(121, 16);
            this.pelaajaYksiNimi.Name = "pelaajaYksiNimi";
            this.pelaajaYksiNimi.Size = new System.Drawing.Size(114, 20);
            this.pelaajaYksiNimi.TabIndex = 2;
            // 
            // pelaaNappi
            // 
            this.pelaaNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pelaaNappi.Location = new System.Drawing.Point(160, 89);
            this.pelaaNappi.Name = "pelaaNappi";
            this.pelaaNappi.Size = new System.Drawing.Size(75, 29);
            this.pelaaNappi.TabIndex = 3;
            this.pelaaNappi.Text = "Pelaa";
            this.pelaaNappi.UseVisualStyleBackColor = true;
            this.pelaaNappi.Click += new System.EventHandler(this.pelaaNappi_Click);
            // 
            // pelaajaKaksiNimi
            // 
            this.pelaajaKaksiNimi.Location = new System.Drawing.Point(121, 56);
            this.pelaajaKaksiNimi.Name = "pelaajaKaksiNimi";
            this.pelaajaKaksiNimi.Size = new System.Drawing.Size(114, 20);
            this.pelaajaKaksiNimi.TabIndex = 4;
            // 
            // ristiNollaWindowsFormilla2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 134);
            this.Controls.Add(this.pelaajaKaksiNimi);
            this.Controls.Add(this.pelaaNappi);
            this.Controls.Add(this.pelaajaYksiNimi);
            this.Controls.Add(this.pelaajaKaksi);
            this.Controls.Add(this.pelaajaYksi);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(264, 173);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(264, 173);
            this.Name = "ristiNollaWindowsFormilla2";
            this.ShowIcon = false;
            this.Text = "ristiNollaWindowsFormilla2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ristiNollaWindowsFormilla2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pelaajaYksi;
        private System.Windows.Forms.Label pelaajaKaksi;
        private System.Windows.Forms.TextBox pelaajaYksiNimi;
        private System.Windows.Forms.Button pelaaNappi;
        private System.Windows.Forms.TextBox pelaajaKaksiNimi;
    }
}