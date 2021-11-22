using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalasananTarkastus
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void tarkistaTB_Click(object sender, EventArgs e)
        {
            if(kayttajaTB.Text == "Tony" && salasanaTB.Text == "Huoll@taAuto5iNyt")
            {
                salasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                virheViestiLB.Text = "Käyttäjätunnus tai salasana virheellinen!";
                virheViestiLB.Visible = true;
            }
        }

        private void salasanaTB_TextChanged(object sender, EventArgs e)
        {
            virheViestiLB.Visible = false;
        }

        private void kayttajaTB_TextChanged(object sender, EventArgs e)
        {
            virheViestiLB.Visible = false;
        }
    }
}
