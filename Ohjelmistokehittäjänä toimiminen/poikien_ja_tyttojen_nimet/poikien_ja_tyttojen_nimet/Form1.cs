using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace poikien_ja_tyttojen_nimet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tarkistusButton_Click(object sender, EventArgs e)
        {
            // Laitetaan vastauksen teksti tyhjäksi ja piilotetaan se sillä muuten teksti ei vaihdu ollenkaan jos syötettyä nimeä ei löydy listalta.
            vastausLabel.Text = "";
            vastausLabel.Visible = false;
            // Luodaan pojille ja tytöille omat string taulukot ja haetaan niille sisältö tekstitiedostoista.
            string[] pojat = File.ReadAllLines("C:/Users/tonyl/source/repos/koulu_tehtavat/Ohjelmistokehittäjänä toimiminen/poikien_ja_tyttojen_nimet/poikien_ja_tyttojen_nimet/taulukot/pojat.txt");
            string[] tytot = File.ReadAllLines("C:/Users/tonyl/source/repos/koulu_tehtavat/Ohjelmistokehittäjänä toimiminen/poikien_ja_tyttojen_nimet/poikien_ja_tyttojen_nimet/taulukot/tytot.txt");
            string nimi = nimiTextBox.Text;
            int laskuriPojat = 1;
            int laskuriTytot = 1;
            // Käydään kaikki stringit juuri luoduusta taulukoista läpi foreachilla ja tarkistetaan löytyykö niistä syötettyä nimeä.
            foreach(string poika in pojat)
            {
                if (nimi == poika)
                {
                    vastausLabel.Text = "Nimesi on " + laskuriPojat + ". suosituin poikien nimi vuonna 2020";
                    vastausLabel.Visible = true;
                }
                // Ilman laskurin arvon nostoa ohjelma väittäisi jokaisen nimen olevan ensimmäiseksi suosituin. Kai se sitten ottaa sen taulukosta haetun nimen paikasta sen luvun ja lisää vaan yhden ettei 25:ksi suosituin nimi palauttaisi 24 kun kone alkaa laskemaan nollasta.
                // Sitä en vielä tiedä palauttaako ohjelma numeron 1 vain siksi että se oli viimeisin annettu arvo laskurille ennen tuota laskurin arvon nostamista yhdellä ja se jotenkin sen jälkeen ottaa sieltä taulukosta sen valitun nimen paikka-arvon ja lisää siihen yhden. 
                laskuriPojat++;
            }
            // Tyttöjen nimille tehdään aivan sama homma kuin pojillekkin tuossa aikaisemmin.
            foreach(string tytto in tytot)
            {
                if (nimi == tytto)
                {
                    vastausLabel.Text = "Nimesi on " + laskuriTytot + ". suosituin tyttöjen nimi vuonna 2020";
                    vastausLabel.Visible = true;
                }
                laskuriTytot++;
            }
            // Ilmoitetaan käyttäjälle että nimeä ei löytynyt listoilta.
            if (vastausLabel.Visible == false)
            {
                vastausLabel.Text = "Nimesi ei löytynyt suosituimpien nimien joukosta! :´-(";
                vastausLabel.Visible = true;
            }
        }
    }
}
