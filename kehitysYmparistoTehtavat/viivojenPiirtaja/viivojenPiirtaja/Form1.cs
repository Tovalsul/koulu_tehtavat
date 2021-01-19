using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viivojenPiirtaja
{
    /// <summary>
    /// Tämä ohjelma piirtää erilaisia kuvioita viivoilla. 
    /// Viivojen määrää, kulmaa, pituutta ja kasvua muuttamalla saa aikaan erilaisia kuvioita. 
    /// Tehnyt Tony Lehtonen
    /// </summary>
    public partial class Form1 : Form
    {
        // Tässä on määritelty kynalla itse piirtäjä ja tehty pisteet x,y akselille.
        Pen kyna = new Pen(Color.Black);
        Graphics grafiikat = null;

        static int origoX, origoY;
        static int alkuX, alkuY;
        static int loppuX, loppuY;

        static int kulma = 0;
        static int pituus = 0;
        static int kasvu = 0;
        static int viivat = 0;

        public Form1()
        {
            InitializeComponent();
            // tähän kohtaan on myös määritelty viivojen alkupiste
            alkuX = viivojenPiirtoAlue.Width / 2;
            alkuY = viivojenPiirtoAlue.Height / 2;
        }

        private void viivojenPiirtoAlue_Paint(object sender, PaintEventArgs e)
        {
            kyna.Width = 1;
            pituus = Int32.Parse(viivojenPituus.Text);
            grafiikat = viivojenPiirtoAlue.CreateGraphics();
            // for looppi kutsuu piirraViiva metodia niin kauan kuin se on yhtäsuuri kuin käyttäjän syöttämä viivojen määrä.
            for (int i = 0; i < Int32.Parse(viivojenMaara.Text); i++)
            {
                piirraViiva();
            }
        }

        private void piirraViiva()
        {
            // tämä piirraViiva metodi piirtelee viivoja paneelille ja ottaa jokaiselle viivalle oman satunnaisen värin.
            Random satunnainenLukuGeneraattori = new Random();
            kyna.Color = Color.FromArgb(satunnainenLukuGeneraattori.Next(255), satunnainenLukuGeneraattori.Next(255), satunnainenLukuGeneraattori.Next(255));
            kulma = kulma + Int32.Parse(viivojenKulma.Text);
            pituus = pituus + Int32.Parse(viivojenKasvu.Text);

            loppuX = (int)(alkuX + Math.Cos(kulma * .017453292519) * pituus);
            loppuY = (int)(alkuY + Math.Sin(kulma * .017453292519) * pituus);

           // Point taulukkoon on määritelty viivojen alku ja loppu pisteet.
            Point[] pisteet =
            {
                new Point(alkuX, alkuY),
                new Point(loppuX, loppuY)
            };

            // tällä alla olevalla pätkällä ohjelma piirtää siitä mihin edellien viiva päättyi.
            alkuX = loppuX;
            alkuY = loppuY;

            grafiikat.DrawLines(kyna, pisteet);
        }

        private void piirraPainike_Click(object sender, EventArgs e)
        {
            // tämä pätkä määrittelee viivojen ominaisuuksia ja niiden alku pisteen näytön keskelle vaikka ikkunan koko muuttuisikin. Samalla nappia painaessa se päivittää piirtopaneelin ja piirtää viivat uudestaan.
            pituus = Int32.Parse(viivojenPituus.Text);
            kasvu = Int32.Parse(viivojenKasvu.Text);
            kulma = Int32.Parse(viivojenKulma.Text);

            alkuX = viivojenPiirtoAlue.Width / 2;
            alkuY = viivojenPiirtoAlue.Height / 2;

            viivojenPiirtoAlue.Refresh();
        }
    }
}
