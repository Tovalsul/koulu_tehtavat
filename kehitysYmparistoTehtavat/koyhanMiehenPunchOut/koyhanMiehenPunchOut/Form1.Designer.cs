namespace koyhanMiehenPunchOut
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
            this.vastustajanTerveys = new System.Windows.Forms.ProgressBar();
            this.pelaajanTerveys = new System.Windows.Forms.ProgressBar();
            this.vastustajaPicBox = new System.Windows.Forms.PictureBox();
            this.pelaajaPicBox = new System.Windows.Forms.PictureBox();
            this.vastustajaAjastin = new System.Windows.Forms.Timer(this.components);
            this.vastusjaLiike = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vastustajaPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelaajaPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // vastustajanTerveys
            // 
            this.vastustajanTerveys.Location = new System.Drawing.Point(12, 44);
            this.vastustajanTerveys.Name = "vastustajanTerveys";
            this.vastustajanTerveys.Size = new System.Drawing.Size(300, 25);
            this.vastustajanTerveys.TabIndex = 0;
            // 
            // pelaajanTerveys
            // 
            this.pelaajanTerveys.Location = new System.Drawing.Point(521, 44);
            this.pelaajanTerveys.Name = "pelaajanTerveys";
            this.pelaajanTerveys.Size = new System.Drawing.Size(300, 25);
            this.pelaajanTerveys.TabIndex = 1;
            // 
            // vastustajaPicBox
            // 
            this.vastustajaPicBox.BackColor = System.Drawing.Color.Transparent;
            this.vastustajaPicBox.Image = global::koyhanMiehenPunchOut.Properties.Resources.enemy_stand;
            this.vastustajaPicBox.Location = new System.Drawing.Point(385, 297);
            this.vastustajaPicBox.Name = "vastustajaPicBox";
            this.vastustajaPicBox.Size = new System.Drawing.Size(77, 185);
            this.vastustajaPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.vastustajaPicBox.TabIndex = 2;
            this.vastustajaPicBox.TabStop = false;
            // 
            // pelaajaPicBox
            // 
            this.pelaajaPicBox.BackColor = System.Drawing.Color.Transparent;
            this.pelaajaPicBox.Image = global::koyhanMiehenPunchOut.Properties.Resources.boxer_stand;
            this.pelaajaPicBox.Location = new System.Drawing.Point(401, 367);
            this.pelaajaPicBox.Name = "pelaajaPicBox";
            this.pelaajaPicBox.Size = new System.Drawing.Size(61, 153);
            this.pelaajaPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pelaajaPicBox.TabIndex = 3;
            this.pelaajaPicBox.TabStop = false;
            // 
            // vastustajaAjastin
            // 
            this.vastustajaAjastin.Enabled = true;
            this.vastustajaAjastin.Interval = 1000;
            this.vastustajaAjastin.Tick += new System.EventHandler(this.vastustajaLyontiEvent);
            // 
            // vastusjaLiike
            // 
            this.vastusjaLiike.Enabled = true;
            this.vastusjaLiike.Interval = 20;
            this.vastusjaLiike.Tick += new System.EventHandler(this.vastustajanLiikeEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::koyhanMiehenPunchOut.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(825, 565);
            this.Controls.Add(this.pelaajaPicBox);
            this.Controls.Add(this.vastustajaPicBox);
            this.Controls.Add(this.pelaajanTerveys);
            this.Controls.Add(this.vastustajanTerveys);
            this.Name = "Form1";
            this.Text = "Punch Out Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nappainAlhaalla);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nappainYlhaalla);
            ((System.ComponentModel.ISupportInitialize)(this.vastustajaPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelaajaPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar vastustajanTerveys;
        private System.Windows.Forms.ProgressBar pelaajanTerveys;
        private System.Windows.Forms.PictureBox vastustajaPicBox;
        private System.Windows.Forms.PictureBox pelaajaPicBox;
        private System.Windows.Forms.Timer vastustajaAjastin;
        private System.Windows.Forms.Timer vastusjaLiike;
    }
}

