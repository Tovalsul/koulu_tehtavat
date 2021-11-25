using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autokululaskuri
{
    public partial class autokululaskuri : Form
    {
        public autokululaskuri()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, pesut, huollot, renkaat, muut, kilometrit, polttoneste, kustannukset;
            laina = Convert.ToDouble(lainaLyhennysTB.Text);
            nesteet = Convert.ToDouble(nesteetTB.Text);
            vakuutus = Convert.ToDouble(vakuutusmaksutTB.Text);
            pesut = Convert.ToDouble(pesutTB.Text);
            huollot = Convert.ToDouble(huolllotTB.Text);
            renkaat = Convert.ToDouble(renkaatTB.Text);
            muut = Convert.ToDouble(muutKulutTB.Text);
            polttoneste = Convert.ToDouble(polttonesteTB.Text);
            kilometrit = Convert.ToDouble(kmPerVuosiCB.Text);
            kustannukset = (laina + nesteet + vakuutus + pesut + +huollot + renkaat + polttoneste + muut) / (kilometrit / 12);
            vastausLabel.Text = "Kustannukset kilometriä kohti ovat: " + kustannukset;
        }
    }
}
