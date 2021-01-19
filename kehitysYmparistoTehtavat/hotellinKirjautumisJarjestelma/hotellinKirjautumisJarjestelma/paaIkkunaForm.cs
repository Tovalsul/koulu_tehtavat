using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotellinKirjautumisJarjestelma
{
    public partial class paaIkkunaForm : Form
    {
        public paaIkkunaForm()
        {
            InitializeComponent();
        }

        private void paaIkkunaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void hallitseAsiakkaitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HallitseAsiakkaitaForm hallitseAF = new HallitseAsiakkaitaForm();
            hallitseAF.ShowDialog();
        }

        private void hallitseVarauksiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HallitseVarauksiaForm hallitseVF = new HallitseVarauksiaForm();
            hallitseVF.ShowDialog();
        }

        private void hallitseHuoneitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HallitseHuoneitaForm hallitseHF = new HallitseHuoneitaForm();
            hallitseHF.ShowDialog();
        }
    }
}
