namespace harjoitus___crud
{
    partial class opiskelijarekisteri
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
            this.idLB = new System.Windows.Forms.Label();
            this.etunimiLB = new System.Windows.Forms.Label();
            this.sukunimiLB = new System.Windows.Forms.Label();
            this.puhelinLB = new System.Windows.Forms.Label();
            this.sahkopostiLB = new System.Windows.Forms.Label();
            this.opiskelijanroLB = new System.Windows.Forms.Label();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.tallennaBT = new System.Windows.Forms.Button();
            this.paivitaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            this.sukunimiTB = new System.Windows.Forms.TextBox();
            this.etunimiTB = new System.Windows.Forms.TextBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.opiskelijaNroTB = new System.Windows.Forms.TextBox();
            this.sahkopostiTB = new System.Windows.Forms.TextBox();
            this.puhelinTB = new System.Windows.Forms.TextBox();
            this.tietotauluDG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // idLB
            // 
            this.idLB.AutoSize = true;
            this.idLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLB.Location = new System.Drawing.Point(12, 18);
            this.idLB.Name = "idLB";
            this.idLB.Size = new System.Drawing.Size(41, 25);
            this.idLB.TabIndex = 0;
            this.idLB.Text = "ID:";
            // 
            // etunimiLB
            // 
            this.etunimiLB.AutoSize = true;
            this.etunimiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etunimiLB.Location = new System.Drawing.Point(12, 52);
            this.etunimiLB.Name = "etunimiLB";
            this.etunimiLB.Size = new System.Drawing.Size(111, 25);
            this.etunimiLB.TabIndex = 1;
            this.etunimiLB.Text = "ETUNIMI:";
            // 
            // sukunimiLB
            // 
            this.sukunimiLB.AutoSize = true;
            this.sukunimiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sukunimiLB.Location = new System.Drawing.Point(12, 91);
            this.sukunimiLB.Name = "sukunimiLB";
            this.sukunimiLB.Size = new System.Drawing.Size(128, 25);
            this.sukunimiLB.TabIndex = 2;
            this.sukunimiLB.Text = "SUKUNIMI:";
            // 
            // puhelinLB
            // 
            this.puhelinLB.AutoSize = true;
            this.puhelinLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puhelinLB.Location = new System.Drawing.Point(327, 15);
            this.puhelinLB.Name = "puhelinLB";
            this.puhelinLB.Size = new System.Drawing.Size(116, 25);
            this.puhelinLB.TabIndex = 3;
            this.puhelinLB.Text = "PUHELIN:";
            // 
            // sahkopostiLB
            // 
            this.sahkopostiLB.AutoSize = true;
            this.sahkopostiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sahkopostiLB.Location = new System.Drawing.Point(327, 52);
            this.sahkopostiLB.Name = "sahkopostiLB";
            this.sahkopostiLB.Size = new System.Drawing.Size(164, 25);
            this.sahkopostiLB.TabIndex = 4;
            this.sahkopostiLB.Text = "SÄHKÖPOSTI:";
            // 
            // opiskelijanroLB
            // 
            this.opiskelijanroLB.AutoSize = true;
            this.opiskelijanroLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opiskelijanroLB.Location = new System.Drawing.Point(327, 91);
            this.opiskelijanroLB.Name = "opiskelijanroLB";
            this.opiskelijanroLB.Size = new System.Drawing.Size(197, 25);
            this.opiskelijanroLB.TabIndex = 5;
            this.opiskelijanroLB.Text = "OPISKELIJANRO:";
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Location = new System.Drawing.Point(10, 148);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(147, 39);
            this.tyhjennaBT.TabIndex = 6;
            this.tyhjennaBT.Text = "TYHJENNÄ";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // tallennaBT
            // 
            this.tallennaBT.Location = new System.Drawing.Point(163, 148);
            this.tallennaBT.Name = "tallennaBT";
            this.tallennaBT.Size = new System.Drawing.Size(147, 39);
            this.tallennaBT.TabIndex = 7;
            this.tallennaBT.Text = "TALLENNA";
            this.tallennaBT.UseVisualStyleBackColor = true;
            this.tallennaBT.Click += new System.EventHandler(this.tallennaBT_Click);
            // 
            // paivitaBT
            // 
            this.paivitaBT.Location = new System.Drawing.Point(316, 148);
            this.paivitaBT.Name = "paivitaBT";
            this.paivitaBT.Size = new System.Drawing.Size(147, 39);
            this.paivitaBT.TabIndex = 8;
            this.paivitaBT.Text = "PÄIVITÄ";
            this.paivitaBT.UseVisualStyleBackColor = true;
            this.paivitaBT.Click += new System.EventHandler(this.paivitaBT_Click);
            // 
            // poistaBT
            // 
            this.poistaBT.Location = new System.Drawing.Point(469, 148);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(147, 39);
            this.poistaBT.TabIndex = 9;
            this.poistaBT.Text = "POISTA";
            this.poistaBT.UseVisualStyleBackColor = true;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
            // 
            // sukunimiTB
            // 
            this.sukunimiTB.Location = new System.Drawing.Point(146, 88);
            this.sukunimiTB.Name = "sukunimiTB";
            this.sukunimiTB.Size = new System.Drawing.Size(164, 31);
            this.sukunimiTB.TabIndex = 10;
            // 
            // etunimiTB
            // 
            this.etunimiTB.Location = new System.Drawing.Point(146, 49);
            this.etunimiTB.Name = "etunimiTB";
            this.etunimiTB.Size = new System.Drawing.Size(164, 31);
            this.etunimiTB.TabIndex = 11;
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(146, 12);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(164, 31);
            this.idTB.TabIndex = 12;
            // 
            // opiskelijaNroTB
            // 
            this.opiskelijaNroTB.Location = new System.Drawing.Point(530, 88);
            this.opiskelijaNroTB.Name = "opiskelijaNroTB";
            this.opiskelijaNroTB.Size = new System.Drawing.Size(164, 31);
            this.opiskelijaNroTB.TabIndex = 13;
            // 
            // sahkopostiTB
            // 
            this.sahkopostiTB.Location = new System.Drawing.Point(530, 46);
            this.sahkopostiTB.Name = "sahkopostiTB";
            this.sahkopostiTB.Size = new System.Drawing.Size(164, 31);
            this.sahkopostiTB.TabIndex = 14;
            // 
            // puhelinTB
            // 
            this.puhelinTB.Location = new System.Drawing.Point(530, 9);
            this.puhelinTB.Name = "puhelinTB";
            this.puhelinTB.Size = new System.Drawing.Size(164, 31);
            this.puhelinTB.TabIndex = 15;
            // 
            // tietotauluDG
            // 
            this.tietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tietotauluDG.Location = new System.Drawing.Point(10, 194);
            this.tietotauluDG.Name = "tietotauluDG";
            this.tietotauluDG.Size = new System.Drawing.Size(684, 216);
            this.tietotauluDG.TabIndex = 16;
            this.tietotauluDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tietotauluDG_CellClick);
            // 
            // opiskelijarekisteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 422);
            this.Controls.Add(this.tietotauluDG);
            this.Controls.Add(this.puhelinTB);
            this.Controls.Add(this.sahkopostiTB);
            this.Controls.Add(this.opiskelijaNroTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.etunimiTB);
            this.Controls.Add(this.sukunimiTB);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.paivitaBT);
            this.Controls.Add(this.tallennaBT);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.opiskelijanroLB);
            this.Controls.Add(this.sahkopostiLB);
            this.Controls.Add(this.puhelinLB);
            this.Controls.Add(this.sukunimiLB);
            this.Controls.Add(this.etunimiLB);
            this.Controls.Add(this.idLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "opiskelijarekisteri";
            this.Text = "Opiskelijarekisterin ylläpito";
            this.Load += new System.EventHandler(this.opiskelijarekisteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLB;
        private System.Windows.Forms.Label etunimiLB;
        private System.Windows.Forms.Label sukunimiLB;
        private System.Windows.Forms.Label puhelinLB;
        private System.Windows.Forms.Label sahkopostiLB;
        private System.Windows.Forms.Label opiskelijanroLB;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button tallennaBT;
        private System.Windows.Forms.Button paivitaBT;
        private System.Windows.Forms.Button poistaBT;
        private System.Windows.Forms.TextBox sukunimiTB;
        private System.Windows.Forms.TextBox etunimiTB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox opiskelijaNroTB;
        private System.Windows.Forms.TextBox sahkopostiTB;
        private System.Windows.Forms.TextBox puhelinTB;
        private System.Windows.Forms.DataGridView tietotauluDG;
    }
}

