using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joku_Csharp_harjoitus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Teksti_tahan_Click(object sender, EventArgs e)
        {

        }

        private void painike_Click(object sender, EventArgs e)
        {
            string etunimi = tekstiLaatikko.Text;
            viestiLabel.Text = "Hei, " + etunimi +  "oikein hyvää päivää sinulle!";
            viestiLabel.Visible = true;
            painike.BackColor = Color.Orange;
        }
    }
}
