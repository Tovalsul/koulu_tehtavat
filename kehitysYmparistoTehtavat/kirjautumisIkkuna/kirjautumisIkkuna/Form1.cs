using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kirjautumisIkkuna
{
    /// <summary>
    /// Tekijä: Tony Lehtonen
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void kirjauduNappi_Click(object sender, EventArgs e)
        {
            string kayttaja = kayttajanimenSyotto.Text;
            string salasana = salasananSyotto.Text;  
            if(kayttaja == "tonylehtonen" && salasana == "test")
            {
                this.Hide();
                Main paaIkkuna = new Main();
                paaIkkuna.Show();
            }
            else
            {
                MessageBox.Show("Käyttäjätunnus tai salasana väärin", "Olen Eero R!");

            }
        }

        private void exitNappi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
