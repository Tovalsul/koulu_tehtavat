using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace celsius_fahrenheiteiksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void muunnaBT_Click(object sender, EventArgs e)
        {
            // luodaan muuttujat vastaus ja asteet doublena koska tarvitaan desimaalilukuja.
            double vastaus;
            double asteet = Convert.ToDouble(asteetTB.Text);
            // tarkistetaan if:llä kumpi radio button on valittu ja käännetään annettu arvo eri asteiksi muuttujien avulla.
            if (celsiusRB.Checked)
            {
                    vastaus = (asteet - 32) / 1.8;
                    vastausLB.Text = asteet + "Fahrenheitia on " + vastaus + " Celsius astetta";
                    vastausLB.Visible = true;
            }
            else if (fahrenheitRB.Checked)
            {
                    vastaus = asteet * 1.8 + 32;
                    vastausLB.Text = asteet + " Celsiusta on " + vastaus + " Fahrenheit astetta";
                    vastausLB.Visible = true;
            }
            // laitetaan tyhjää vastauskenttää varten vielä yksi tarkistus kertomaan käyttäjälle että siihen kenttään pitää syöttää joku luku. Samalla varmistetaan että ohjelma ei kaadu jos näin käy.
            // pelkkä else ei toimi, vaikka sen pitäisi kattaa muut syötteet... Ohjelma kaatuu jos jättää syöttämättä mitään.
            else
            {
                vastausLB.Text = "Et valinnut muunnettavaa astetta tai antanut oikeaa lukua";
                vastausLB.Visible = true;
            }
        }
    }
}
