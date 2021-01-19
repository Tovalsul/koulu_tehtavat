namespace kirjautumisIkkuna
{
    partial class Main
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
            this.oletKirjautunutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oletKirjautunutLabel
            // 
            this.oletKirjautunutLabel.AutoSize = true;
            this.oletKirjautunutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oletKirjautunutLabel.Location = new System.Drawing.Point(227, 190);
            this.oletKirjautunutLabel.Name = "oletKirjautunutLabel";
            this.oletKirjautunutLabel.Size = new System.Drawing.Size(291, 31);
            this.oletKirjautunutLabel.TabIndex = 0;
            this.oletKirjautunutLabel.Text = "Olet kirjautunut sisään!";
            this.oletKirjautunutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.oletKirjautunutLabel);
            this.Name = "Main";
            this.Text = "Tää ite sivu mihin kirjauduit on täs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oletKirjautunutLabel;
    }
}