using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ajastin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int kokonaisaika;
        private void Form1_Load(object sender, EventArgs e)
        {
            pysaytaButton.Enabled = false; // Otetaan pysaytanappi pois käytöstä
            // Lisätään for loopilla minuutti ja sekunti comboboxeihin kumpaankin 60 numerovaihtoehtoa. For loopilla sen takia että muuten menisi ikuisuus lisätä niitä itse käsin.
            for(int i=0; i < 60; i++)
            {
                minuutitComboBox.Items.Add(i.ToString());
                sekunnitComboBox.Items.Add(i.ToString());
            }
            // Määritellään oletus ajaksi tasan 30 minuuttia ja 0 sekuntia
            minuutitComboBox.SelectedIndex = 30;
            sekunnitComboBox.SelectedIndex = 0;
        }

        private void kaynnistaButton_Click(object sender, EventArgs e)
        {
            kaynnistaButton.Enabled = false; // Otetaan käynnistysnappi pois käytöstä siksi aikaa ettei vahingossa pääse painamaan sitä päällekkäin.
            pysaytaButton.Enabled = true; // Laitetaan pysäytysnappi päälle.
            int minuutit = int.Parse(minuutitComboBox.SelectedItem.ToString()); // Haetaan comboboxista valitut minuutit.
            int sekunnit = int.Parse(sekunnitComboBox.SelectedItem.ToString()); // Haetaan comboboxista valitut sekunnit.
            // Kerrotaan että kokonaisaika on yhteensä minuutit + sekunnit ja kerrotaan vielä siihen päälle että yhdessä minuutissa on 60 sekuntia.
            kokonaisaika = (minuutit * 60) + sekunnit;
            ajastin.Enabled = true;
        }

        private void pysaytaButton_Click(object sender, EventArgs e)
        {
            kaynnistaButton.Enabled = true; // Otetaan käynnistysnappi takaisin käyttöön, niin ei tarvitse käynnistää uudelleen koko ohjelmaa jos haluaa ajastaa uudestaan jotain.
            pysaytaButton.Enabled = false; // Otetaan pysäytysnappi pois käytöstä.
            // Resetoidaan ajastin asettamalla kokonaisaika takaisin nollaan ja ottamalla ajastimen ajastin pois käytöstä. Samalla kirjoitetaan labeliin ajaksi 00:00.
            kokonaisaika = 0;
            ajastin.Enabled = false; 
            aikaLabel.Text = "00:00";
        }

        private void ajastin_Tick(object sender, EventArgs e)
        {
            // Niinkauan kuin kokonais aika on enemmän kuin 0 tämä vähentää siitä yhden sekunnin pois joka tikillä.
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                // Tehdään aika labelia varten minuutit ja sekunnit aiemmin määritellystä kokonaisajasta.
                int minuutit = kokonaisaika / 60; 
                int sekunnit = kokonaisaika - (minuutit * 60);
                // Kirjoitetaan labeliin jäljellä oleva aika joka tickin välein.
                aikaLabel.Text = minuutit.ToString() + ":" + sekunnit.ToString();
            }
            else
            {
                // Kokonaisajan arvon päädyttyä nollaan pysäytetään ajastin ja ilmoitetaan käyttäjälle ajan päättymisestä.
                ajastin.Stop();
                MessageBox.Show("Aikasi loppui!");
            }
        }
    }
}
