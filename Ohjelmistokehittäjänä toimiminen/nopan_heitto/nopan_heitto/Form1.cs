using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nopan_heitto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Piti laittaa tämä satunnaisluku funktion ulkopuolelle jotta se valitsi kaksi eri lukua kahden saman sijasta.
        Random satunnainen = new Random();
        private void heitaButton_Click(object sender, EventArgs e)
        {
            // Kutsutaan funktiota kummallekin nopalle ja vastaus kysymykseen on 3 koska tällä menetelmällä joudut tekemään jokaiselle pictureboxille oman funktion kutsun, eli 3 riviä on vastaus.
            piirraNoppa(noppa01PB);
            piirraNoppa(noppa02PB);
        }
        // Kerrotaan että funktio tuo noppaBox:in kuvan ja kuva riippuu satunnaisesta luvusta yhden ja kuuden välillä.
        // Kerrotaan switchillä vielä tapauskohtaisesti mistä kuva löytyy ja mikä kuva halutaan kun tulokseksi tulee n luku.
        private void piirraNoppa(PictureBox NoppaBox)
        {
            int noppa = satunnainen.Next(1, 7);
            switch (noppa)
            {
                case 1:
                    NoppaBox.Image = Properties.Resources.dice01;
                    break;
                case 2:
                    NoppaBox.Image = Properties.Resources.dice02;
                    break;
                case 3:
                    NoppaBox.Image = Properties.Resources.dice03;
                    break;
                case 4:
                    NoppaBox.Image = Properties.Resources.dice04;
                    break;
                case 5:
                    NoppaBox.Image = Properties.Resources.dice05;
                    break;
                case 6:
                    NoppaBox.Image = Properties.Resources.dice06;
                    break;
            }
        }
    }
}
