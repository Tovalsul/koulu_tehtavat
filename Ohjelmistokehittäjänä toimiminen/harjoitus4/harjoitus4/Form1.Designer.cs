namespace harjoitus4
{
    partial class Ikalaskuri
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
            this.syntymapaivaDTP = new System.Windows.Forms.DateTimePicker();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.VuodetLB = new System.Windows.Forms.Label();
            this.KuukaudetLB = new System.Windows.Forms.Label();
            this.PaivatLB = new System.Windows.Forms.Label();
            this.TunnitLB = new System.Windows.Forms.Label();
            this.MinuutitLB = new System.Windows.Forms.Label();
            this.SekunnitLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // syntymapaivaDTP
            // 
            this.syntymapaivaDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syntymapaivaDTP.Location = new System.Drawing.Point(15, 15);
            this.syntymapaivaDTP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.syntymapaivaDTP.Name = "syntymapaivaDTP";
            this.syntymapaivaDTP.Size = new System.Drawing.Size(382, 31);
            this.syntymapaivaDTP.TabIndex = 0;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Location = new System.Drawing.Point(406, 15);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(111, 31);
            this.LaskeBT.TabIndex = 1;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // VuodetLB
            // 
            this.VuodetLB.AutoSize = true;
            this.VuodetLB.Location = new System.Drawing.Point(15, 56);
            this.VuodetLB.Name = "VuodetLB";
            this.VuodetLB.Size = new System.Drawing.Size(80, 25);
            this.VuodetLB.TabIndex = 2;
            this.VuodetLB.Text = "Vuodet";
            this.VuodetLB.Visible = false;
            // 
            // KuukaudetLB
            // 
            this.KuukaudetLB.AutoSize = true;
            this.KuukaudetLB.Location = new System.Drawing.Point(15, 95);
            this.KuukaudetLB.Name = "KuukaudetLB";
            this.KuukaudetLB.Size = new System.Drawing.Size(115, 25);
            this.KuukaudetLB.TabIndex = 3;
            this.KuukaudetLB.Text = "Kuukaudet";
            this.KuukaudetLB.Visible = false;
            // 
            // PaivatLB
            // 
            this.PaivatLB.AutoSize = true;
            this.PaivatLB.Location = new System.Drawing.Point(15, 133);
            this.PaivatLB.Name = "PaivatLB";
            this.PaivatLB.Size = new System.Drawing.Size(72, 25);
            this.PaivatLB.TabIndex = 4;
            this.PaivatLB.Text = "Päivät";
            this.PaivatLB.Visible = false;
            // 
            // TunnitLB
            // 
            this.TunnitLB.AutoSize = true;
            this.TunnitLB.Location = new System.Drawing.Point(244, 56);
            this.TunnitLB.Name = "TunnitLB";
            this.TunnitLB.Size = new System.Drawing.Size(72, 25);
            this.TunnitLB.TabIndex = 5;
            this.TunnitLB.Text = "Tunnit";
            this.TunnitLB.Visible = false;
            // 
            // MinuutitLB
            // 
            this.MinuutitLB.AutoSize = true;
            this.MinuutitLB.Location = new System.Drawing.Point(244, 95);
            this.MinuutitLB.Name = "MinuutitLB";
            this.MinuutitLB.Size = new System.Drawing.Size(88, 25);
            this.MinuutitLB.TabIndex = 6;
            this.MinuutitLB.Text = "Minuutit";
            this.MinuutitLB.Visible = false;
            // 
            // SekunnitLB
            // 
            this.SekunnitLB.AutoSize = true;
            this.SekunnitLB.Location = new System.Drawing.Point(244, 133);
            this.SekunnitLB.Name = "SekunnitLB";
            this.SekunnitLB.Size = new System.Drawing.Size(96, 25);
            this.SekunnitLB.TabIndex = 7;
            this.SekunnitLB.Text = "Sekunnit";
            this.SekunnitLB.Visible = false;
            // 
            // Ikalaskuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 173);
            this.Controls.Add(this.SekunnitLB);
            this.Controls.Add(this.MinuutitLB);
            this.Controls.Add(this.TunnitLB);
            this.Controls.Add(this.PaivatLB);
            this.Controls.Add(this.KuukaudetLB);
            this.Controls.Add(this.VuodetLB);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.syntymapaivaDTP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Ikalaskuri";
            this.Text = "Ikälaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker syntymapaivaDTP;
        private System.Windows.Forms.Button LaskeBT;
        private System.Windows.Forms.Label VuodetLB;
        private System.Windows.Forms.Label KuukaudetLB;
        private System.Windows.Forms.Label PaivatLB;
        private System.Windows.Forms.Label TunnitLB;
        private System.Windows.Forms.Label MinuutitLB;
        private System.Windows.Forms.Label SekunnitLB;
    }
}

