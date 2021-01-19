using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kaksiLukua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void laskuNappi_Click(object sender, EventArgs e)
        {
            int luku1, luku2, summa;
            try
            {
                luku1 = int.Parse(lukuLaatikko1.Text);
            }
            catch
            {
                
                vastausLabel.Text = ("Anna arvoja vain kokonaislukuina.");
                vastausLabel.Visible = true;
                lukuLaatikko1.Text = ("");
                lukuLaatikko1.Focus();
                luku1 = int.Parse(lukuLaatikko1.Text);
                /* Toimii muuten paitsi jos laittaa murtolukuja ja ei suorita jostain syystä catch osaa ollenkaan
                vaan tulee System.FormatException: 'Input string was not in a correct format.' sen sijaan. */
            }
            try
            {
                luku2 = int.Parse(lukuLaatikko2.Text);
            }
            catch
            {
                
                vastausLabel.Text = ("Anna arvoja vain kokonaislukuina.");
                vastausLabel.Visible = true;
                lukuLaatikko2.Text = ("");
                lukuLaatikko2.Focus();
                luku2 = int.Parse(lukuLaatikko2.Text);
            }
            
            summa = luku1 + luku2;
            vastausLabel.Text = ("" + summa);
            vastausLabel.Visible = true;

        }
    }
}
