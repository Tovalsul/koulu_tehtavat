using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roomalaisetNumerot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Luodaan funktiot jotka kutsuttaessa tarkistavat textboxista sataset, kympit ja ykköset ja palauttavat sitten vastaavat roomalaiset numerot.
        private string sataset(int luku2, string vastaus)
        {
            // Tarkistetaan taas jakojäännöksellä. Logiikkana on jos se jaetaan n luvulla ja yli ei jää mitään JA jos n luku ei ole 0 niin sitten se on todennäköisesti n luku ja palauttaa sitten vastaavan roomalaisen numerosarjan.
            if(luku2 % 9 == 0 && luku2 != 0)
            {
                return "CM";
            }
            // Samalla logiikalla tarkistetaan sitten loputkin 800, 700, 600... ja palautetaan niitä arvoja vastaavat roomalaiset numerot.
            else if(luku2 % 8 == 0 && luku2 != 0)
            {
                return "DCCC";
            }
            else if(luku2 % 7 == 0 && luku2 != 0)
            {
                return "DCC";
            }
            else if (luku2 % 6 == 0 && luku2 != 0)
            {
                return "DC";
            }
            else if (luku2 % 5 == 0 && luku2 != 0)
            {
                return "D";
            }
            else if (luku2 % 4 == 0 && luku2 != 0)
            {
                return "CD";
            }
            else if (luku2 % 3 == 0 && luku2 != 0)
            {
                return "CCC";
            }
            else if (luku2 % 2 == 0 && luku2 != 0)
            {
                return "CC";
            }
            else if (luku2 % 1 == 0 && luku2 != 0)
            {
                return "C";
            }
            // Jos satasia ei ollu niin sitten palautetaan tyhjää stringiä.
            else
            {
                return "";
            }

        }
        private string kympit(int luku3, string vastaus)
        {
            // Sama homma kuin satasissa mutta nyt on eri kohta substringissä luku3:n kohdalla, niin siitä ei tarvitse murehtia.
            if(luku3 % 9 == 0 && luku3 != 0)
            {
                return "XC";
            }
            else if(luku3 % 8 == 0 && luku3 != 0)
            {
                return "LCCC";
            }
            else if (luku3 % 7 == 0 && luku3 != 0)
            {
                return "LCC";
            }
            else if (luku3 % 6 == 0 && luku3 != 0)
            {
                return "LC";
            }
            else if (luku3 % 5 == 0 && luku3 != 0)
            {
                return "L";
            }
            else if (luku3 % 4 == 0 && luku3 != 0)
            {
                return "LX";
            }
            else if (luku3 % 3 == 0 && luku3 != 0)
            {
                return "XXX";
            }
            else if (luku3 % 2 == 0 && luku3 != 0)
            {
                return "XX";
            }
            else if (luku3 % 1 == 0 && luku3 != 0)
            {
                return "X";
            }
            // Jos kymppejä ei ollu niin sitten palautetaan tyhjää stringiä.
            else
            {
                return "";
            }
        }
        private string ykkoset(int luku4, string vastaus)
        {
            // numerotTextBox.Text.Substring(3, 1) menossa nyt
            if (luku4 % 9 == 0 && luku4 != 0)
            {
                return "IX";
            }
            else if(luku4 % 8 == 0 && luku4 != 0)
            {
                return "VIII";
            }
            else if (luku4 % 7 == 0 && luku4 != 0)
            {
                return "VII";
            }
            else if (luku4 % 6 == 0 && luku4 != 0)
            {
                return "VI";
            }
            else if (luku4 % 5 == 0 && luku4 != 0)
            {
                return "V";
            }
            else if (luku4 % 4 == 0 && luku4 != 0)
            {
                return "IV";
            }
            else if (luku4 % 3 == 0 && luku4 != 0)
            {
                return "III";
            }
            else if (luku4 % 2 == 0 && luku4 != 0)
            {
                return "II";
            }
            else if (luku4 % 1 == 0 && luku4 != 0)
            {
                return "I";
            }
            // Jos numeroita ei ollut ollenkaan niin sitten palautetaan tyhjää stringiä ja mitään ei näy.
            else
            {
                return "";
            }
        }
        private void muutaButton_Click(object sender, EventArgs e)
        {
            // Luodaan käsiteltävät muuttujat ja tyhjä string johon luodaan myohemmin vastaus joka haetaan siitä sitten.
            int luku1, luku2, luku3, luku4;
            string vastaus = "";
            // Tarkistetaan syötetyn numerosarjan pituus helposti katsomalla onko se pitempi kuin 3 numeroa jolloin se on ainakin tuhatluku.
            if (numerotTextBox.Text.Length > 3) // Kyseessä on tuhatluku
            {
                // Käännetään textboxin string kokonaisluvuiksi ja sitten haetaan stringin osat substringillä joista saadaan tuhannet, sadat, kympit ja ykkoset.
                luku1 = Convert.ToInt32(numerotTextBox.Text.Substring(0, 1)); // Tuhannet
                luku2 = Convert.ToInt32(numerotTextBox.Text.Substring(1, 1)); // Sadat
                luku3 = Convert.ToInt32(numerotTextBox.Text.Substring(2, 1)); // Kympit
                luku4 = Convert.ToInt32(numerotTextBox.Text.Substring(3, 1)); // Ykköset
                // Tarkistetaan tuhannet jakojäännöksen avulla jos mitään ei jää yli vaikka jaettaessa kahdella niin vastaus on kaksituhatta eli MM. Kuitenkin logiikka jää hieman puutteelliseksi sillä laskettaessa yli 3999 esim. 6000 saa vastaukseksi silti vain MMM eli 3000 koska sekin luku on kolmella jaollinen. 
                if(luku1 % 3 == 0)
                {
                    vastaus += "MMM";
                }
                else if(luku1 % 2 == 0)
                {
                    vastaus += "MM";
                }
                else if (luku1 % 1 == 0)
                {
                    vastaus += "M";
                }
                else
                {
                    vastaus += "";
                }
                // Lisätään saadut mahdolliset tuhannet satasiin, sitten kymppeihin ja yykösiin jos niitä on. Samalla kutsutaan erikseen luotuja funktioita jotka tarkistavat textboxin stringin osat ja antavat loppuosan.
                vastaus += sataset(luku2, vastaus);
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            // Tarkistetaan samalla logiikalla kuin aiemminkin. Nyt vain katsotaan että onko numerosarja pitempi kuin 2 numeroa joilloin ainakin liikutaan vähintään satasissa.
            else if(numerotTextBox.Text.Length > 2) // Kyseessä on sataluku
            {
                luku2 = Convert.ToInt32(numerotTextBox.Text.Substring(0, 1)); // Sadat
                luku3 = Convert.ToInt32(numerotTextBox.Text.Substring(1, 1)); // Kympit
                luku4 = Convert.ToInt32(numerotTextBox.Text.Substring(2, 1)); // Ykköset
                vastaus += sataset(luku2, vastaus);
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            // Nyt katsotaan onko numerosarja pidempi yksi numero jolloin kyseessä on ainakin kymmenluku.
            else if (numerotTextBox.Text.Length > 1) // Kyseessä on kymmenluku
            {
                luku3 = Convert.ToInt32(numerotTextBox.Text.Substring(0, 1)); // Kympit
                luku4 = Convert.ToInt32(numerotTextBox.Text.Substring(1, 1)); // Ykköset
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            // Katsotaan onko numerosarja pidempi kuin 0. Tämän ehdon täyttyessä tekstilaatikossa on vähintään yksinumeroinen luku.
            else if (numerotTextBox.Text.Length > 0) // Kyseessä on ykkösluku
            {
                luku4 = Convert.ToInt32(numerotTextBox.Text.Substring(0, 1)); // Ykköset
                vastaus += ykkoset(luku4, vastaus);
            }
            vastausLabel.Text = vastaus;
            vastausLabel.Visible = true;
        }
    }
}
