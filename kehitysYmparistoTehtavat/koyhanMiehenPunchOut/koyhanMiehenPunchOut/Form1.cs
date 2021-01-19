using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koyhanMiehenPunchOut
{
    /// <summary>
    /// Tehnyt: Tony Valdemar Lehtonen tämän tutorialin mukaan:  https://www.mooict.com/c-tutorial-create-a-simple-punch-out-boxing-game-in-visual-studio/ 
    /// Spritet tähän on saatu täältä: https://www.mooict.com/wp-content/uploads/2018/03/mooict-punch-out-game-assets.zip
    /// </summary>
    public partial class Form1 : Form
    {
        bool torjuLyonti = false; // tällä katsotaan torjuuko pelaaja iskuja.

        List<string> vastustajanHyokkaykset = new List<string> { "vasen", "oikea", "torjunta" }; // Tämä array on lista vastustajan iskuista.
        Random satunnainenNumero = new Random();
        int vastustajanNopeus = 5; // Tällä määritetään kuinka nopeaan tahtiin vastustaja liikkuu.
        int i = 0; 
        bool vastustajaTorjui; // tällä katsotaan torjuuko vastustaja iskuja.
        int pelaajanTerveysPisteet = 100; // Näihin on määritelty kummankin ottelijan aloitus terveyspisteet.
        int vastustajanTerveysPisteet = 100;
        public Form1()
        {
            InitializeComponent();
            // Näillä saadaan terveysmittarit eri värisiksi kummallekkin ottelijalle sen jälkeen kun ne ottavat vahinkoa.
            // Ei jostain kumman syystä toimi.
            pelaajanTerveys.ForeColor = Color.Blue;
            vastustajanTerveys.ForeColor = Color.Red;
        }

        private void vastustajanLiikeEvent(object sender, EventArgs e)
        {
            vastustajaPicBox.Left += vastustajanNopeus; // liittää vastustajan nopeuden vastustajan vasempaan liikkeeseen.

            if (pelaajanTerveysPisteet > 1)
            {
                // näillä kahdella if lauseella liitetään terveyspisteet itse UI:ssa näkyvään palkkiin josta näkee sitten kuinka paljon kumpikin ukko pystyy ottamaan turpaan ennen kuin kaatuvat.
                pelaajanTerveys.Value = Convert.ToInt32(pelaajanTerveysPisteet);
            }

            if (vastustajanTerveysPisteet > 1)
            {
                vastustajanTerveys.Value = Convert.ToInt32(vastustajanTerveysPisteet);
            }

            // jos vastustajan nopeus menee 480 ja 315 välillä, niin tällä käännetään nopeus miinukselle ja siten saadaan vastustaja liikkumaan takaisin oikealle..
            if (vastustajaPicBox.Left > 480)
            {
                vastustajanNopeus = -5;
            }
            // ja tällä taas annetaan lisää vauhtia kun vastustaja menee liikaa oikealle, että se saadaan liikkumaan takaisin tuohon 480-315 välille edestakas.
            if (vastustajaPicBox.Left < 315)
            {
                vastustajanNopeus = 5;
            }

            if (vastustajanTerveysPisteet < 1)
            {
                // Voitat pelin ja vastustajan häviää. Ajastimet pysähtyy.
                vastustajaAjastin.Stop();
                vastusjaLiike.Stop();
                MessageBox.Show("Voitit ottelun! Paina OK pelaaksesi uudelleen.", "Onneksi olkoon!");
                resettaaPeli();
            }

            if (pelaajanTerveysPisteet < 1)
            {
                // Häviät pelin ja vastustaja voittaa pelin. Ajastimet pysähtyy.
                vastustajaAjastin.Stop();
                vastusjaLiike.Stop();
                MessageBox.Show("Tough Rob Voitti... Paina OK yrittääksesi uudelleen.", "Voi harmi.");
                resettaaPeli();
            }
        }

        private void vastustajaLyontiEvent(object sender, EventArgs e)
        {
            // Tällä pätkällä valitaan satunnaisesti mitä iskua vastustaja käyttää ennalta määritellystä listasta.
            i = satunnainenNumero.Next(0, vastustajanHyokkaykset.Count);

            switch (vastustajanHyokkaykset[i].ToString())
            {
                case "vasen":
                    vastustajaPicBox.Image = Properties.Resources.enemy_punch1;
                    
                    // if lause tarkistaa osuuko tämä vasemman puoleinen lyönti pelaajan ukkoon ja torjuuko pelaaja.
                    // Jos osuu ja pelaaja ei torju niin pelaaja menettää 20 terveyspistettä.

                    if (vastustajaPicBox.Bounds.IntersectsWith(pelaajaPicBox.Bounds) && !torjuLyonti)
                    {
                        // tekee vahinkoa 20 pistettä pelaajaan. 
                        pelaajanTerveysPisteet -= 20;
                    }
                    vastustajaTorjui = false; // Tällä varmistetaan että vastustaja ei voi torjua samalla kun lyö.
                    break;

                case "oikea":
                    vastustajaPicBox.Image = Properties.Resources.enemy_punch2;

                    // if lause tarkistaa osuuko tämä vasemman puoleinen lyönti pelaajan ukkoon ja torjuuko pelaaja.
                    // Jos osuu ja pelaaja ei torju niin pelaaja menettää 20 terveyspistettä.

                    if (vastustajaPicBox.Bounds.IntersectsWith(pelaajaPicBox.Bounds) && !torjuLyonti)
                    {
                        // tekee vahinkoa 20 pistettä pelaajaan.
                        pelaajanTerveysPisteet -= 20;
                    }
                    vastustajaTorjui = false; // Tällä varmistetaan että vastustaja ei voi torjua samalla kun lyö.
                    break;

                case "torjunta":
                    vastustajaPicBox.Image = Properties.Resources.enemy_block;
                    vastustajaTorjui = true; // Tämä taas on torjumista varten.
                    break;
            }
        }

        private void nappainAlhaalla(object sender, KeyEventArgs e)
        {
            // Näillä iffeillä kuunnellaan milloin pelaaja painaa mitäkin nappia ja toimii sitten annettujen ohjeiden mukaan. Toivottavasti...
            if (e.KeyCode == Keys.Down)
            {
                pelaajaPicBox.Image = Properties.Resources.boxer_block;
                torjuLyonti = true; // Varmistaa että torjunta toimii.
            }

            if (e.KeyCode == Keys.Left)
            {
                // vasenta nuolinäppäintä painettaessa pelaajan hahmo lyö vasurilla.
                pelaajaPicBox.Image = Properties.Resources.boxer_left_punch;

                if (vastustajaPicBox.Bounds.IntersectsWith(pelaajaPicBox.Bounds) && !vastustajaTorjui)
                {
                    // tekee 5 pistettä vahinkoa vastustajaan.
                    vastustajanTerveysPisteet -= 5;
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                // vasenta nuolinäppäintä painettaessa pelaajan hahmo lyö oikealla kädellä.
                pelaajaPicBox.Image = Properties.Resources.boxer_right_punch;

                if (vastustajaPicBox.Bounds.IntersectsWith(pelaajaPicBox.Bounds) && !vastustajaTorjui)
                {
                    // tekee 5 pistettä vahinkoa vastustajaan.
                    vastustajanTerveysPisteet -= 5;
                }
            }
        }

        private void nappainYlhaalla(object sender, KeyEventArgs e)
        {
            // Tämä resetoi pelaajan hahmon takaisin tavalliseen seisomisasentoon, aina kun näppäintä lakkaa painamasta.
            pelaajaPicBox.Image = Properties.Resources.boxer_stand;
            torjuLyonti = false;
        }

        private void resettaaPeli()
        {
            // Tämä metodi aloittaa pelin alusta aina kun sitä kutsutaan muualta.
            vastustajaAjastin.Start();
            vastusjaLiike.Start();

            vastustajaPicBox.Left = 385; // palauttaa vastustajan spriten takaisin keskelle ruutua topilla ja leftillä.
            vastustajaPicBox.Top = 297;

            vastustajaPicBox.Image = Properties.Resources.enemy_stand; // Palauttaa vastustajan spriten takaisin alkuasentoon.
            pelaajaPicBox.Image = Properties.Resources.boxer_stand; // Palauttaa pelaajan spriten takaisin alkuasentoon.

            pelaajanTerveysPisteet = 100; // Nämä kaksi taas palauttavat kummankin ottelijan terveyspisteet takaisin täysille.
            vastustajanTerveysPisteet = 100;
        }


    }
}
