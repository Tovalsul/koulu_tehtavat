namespace SalasananTarkastus
{
    partial class SalasanaForm
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
            this.salasanaPanel = new System.Windows.Forms.Panel();
            this.kayttajaTunnusLB = new System.Windows.Forms.Label();
            this.salasanaLB = new System.Windows.Forms.Label();
            this.kayttajaTB = new System.Windows.Forms.TextBox();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.tarkistaTB = new System.Windows.Forms.Button();
            this.virheViestiLB = new System.Windows.Forms.Label();
            this.SalasanaOikeinPanel = new System.Windows.Forms.Panel();
            this.tervetuloaLB = new System.Windows.Forms.Label();
            this.salasanaPanel.SuspendLayout();
            this.SalasanaOikeinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // salasanaPanel
            // 
            this.salasanaPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.salasanaPanel.Controls.Add(this.virheViestiLB);
            this.salasanaPanel.Controls.Add(this.tarkistaTB);
            this.salasanaPanel.Controls.Add(this.salasanaTB);
            this.salasanaPanel.Controls.Add(this.kayttajaTB);
            this.salasanaPanel.Controls.Add(this.salasanaLB);
            this.salasanaPanel.Controls.Add(this.kayttajaTunnusLB);
            this.salasanaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salasanaPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasanaPanel.ForeColor = System.Drawing.Color.Gold;
            this.salasanaPanel.Location = new System.Drawing.Point(0, 0);
            this.salasanaPanel.Name = "salasanaPanel";
            this.salasanaPanel.Size = new System.Drawing.Size(610, 162);
            this.salasanaPanel.TabIndex = 0;
            // 
            // kayttajaTunnusLB
            // 
            this.kayttajaTunnusLB.AutoSize = true;
            this.kayttajaTunnusLB.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayttajaTunnusLB.Location = new System.Drawing.Point(69, 12);
            this.kayttajaTunnusLB.Name = "kayttajaTunnusLB";
            this.kayttajaTunnusLB.Size = new System.Drawing.Size(220, 38);
            this.kayttajaTunnusLB.TabIndex = 0;
            this.kayttajaTunnusLB.Text = "Käyttäjätunnus:";
            // 
            // salasanaLB
            // 
            this.salasanaLB.AutoSize = true;
            this.salasanaLB.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasanaLB.Location = new System.Drawing.Point(151, 53);
            this.salasanaLB.Name = "salasanaLB";
            this.salasanaLB.Size = new System.Drawing.Size(138, 38);
            this.salasanaLB.TabIndex = 1;
            this.salasanaLB.Text = "Salasana:";
            // 
            // kayttajaTB
            // 
            this.kayttajaTB.Location = new System.Drawing.Point(295, 12);
            this.kayttajaTB.Name = "kayttajaTB";
            this.kayttajaTB.Size = new System.Drawing.Size(270, 35);
            this.kayttajaTB.TabIndex = 2;
            this.kayttajaTB.TextChanged += new System.EventHandler(this.kayttajaTB_TextChanged);
            // 
            // salasanaTB
            // 
            this.salasanaTB.Location = new System.Drawing.Point(295, 53);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.Size = new System.Drawing.Size(270, 35);
            this.salasanaTB.TabIndex = 3;
            this.salasanaTB.UseSystemPasswordChar = true;
            this.salasanaTB.TextChanged += new System.EventHandler(this.salasanaTB_TextChanged);
            // 
            // tarkistaTB
            // 
            this.tarkistaTB.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarkistaTB.ForeColor = System.Drawing.Color.Black;
            this.tarkistaTB.Location = new System.Drawing.Point(12, 53);
            this.tarkistaTB.Name = "tarkistaTB";
            this.tarkistaTB.Size = new System.Drawing.Size(130, 41);
            this.tarkistaTB.TabIndex = 4;
            this.tarkistaTB.Text = "Tarkista";
            this.tarkistaTB.UseVisualStyleBackColor = true;
            this.tarkistaTB.Click += new System.EventHandler(this.tarkistaTB_Click);
            // 
            // virheViestiLB
            // 
            this.virheViestiLB.AutoSize = true;
            this.virheViestiLB.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virheViestiLB.Location = new System.Drawing.Point(13, 111);
            this.virheViestiLB.Name = "virheViestiLB";
            this.virheViestiLB.Size = new System.Drawing.Size(86, 38);
            this.virheViestiLB.TabIndex = 5;
            this.virheViestiLB.Text = "Virhe";
            this.virheViestiLB.Visible = false;
            // 
            // SalasanaOikeinPanel
            // 
            this.SalasanaOikeinPanel.BackColor = System.Drawing.Color.DarkRed;
            this.SalasanaOikeinPanel.Controls.Add(this.tervetuloaLB);
            this.SalasanaOikeinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaOikeinPanel.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaOikeinPanel.ForeColor = System.Drawing.Color.Snow;
            this.SalasanaOikeinPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            this.SalasanaOikeinPanel.Size = new System.Drawing.Size(610, 162);
            this.SalasanaOikeinPanel.TabIndex = 1;
            this.SalasanaOikeinPanel.Visible = false;
            // 
            // tervetuloaLB
            // 
            this.tervetuloaLB.AutoSize = true;
            this.tervetuloaLB.Location = new System.Drawing.Point(-2, 0);
            this.tervetuloaLB.Name = "tervetuloaLB";
            this.tervetuloaLB.Size = new System.Drawing.Size(582, 80);
            this.tervetuloaLB.TabIndex = 0;
            this.tervetuloaLB.Text = "Tervetuloa Sivuilleni";
            // 
            // SalasanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 162);
            this.Controls.Add(this.SalasanaOikeinPanel);
            this.Controls.Add(this.salasanaPanel);
            this.Name = "SalasanaForm";
            this.Text = "Salasanan tarkastus";
            this.salasanaPanel.ResumeLayout(false);
            this.salasanaPanel.PerformLayout();
            this.SalasanaOikeinPanel.ResumeLayout(false);
            this.SalasanaOikeinPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel salasanaPanel;
        private System.Windows.Forms.Label virheViestiLB;
        private System.Windows.Forms.Button tarkistaTB;
        private System.Windows.Forms.TextBox salasanaTB;
        private System.Windows.Forms.TextBox kayttajaTB;
        private System.Windows.Forms.Label salasanaLB;
        private System.Windows.Forms.Label kayttajaTunnusLB;
        private System.Windows.Forms.Panel SalasanaOikeinPanel;
        private System.Windows.Forms.Label tervetuloaLB;
    }
}

