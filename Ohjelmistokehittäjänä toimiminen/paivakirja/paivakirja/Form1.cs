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

namespace paivakirja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tallennaButton_Click(object sender, EventArgs e)
        {
            // Julistetaan teksti nimisen stringin olemassa olo jonka jälkeen sanotaan että se on yhtäpaljoin kuin teksilaatikkoon annettun tekstin stringi ja sen lisäksi vielä lisätään päivämäärä siihen.
            string teksti = "";
            teksti += tekstiTextBox.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            // Tehdään uusi TextWriter classi ja kerrotaan missä on itse kirjoitettava tiedosto sille.
            TextWriter text = new StreamWriter("C:\\temp\\demo.txt");
            // Sitten kerrotaan juuri tehdylle text classille että se kirjoittaa sinne samankuin mitä löytyy teksti stringistä.
            text.Write(teksti);
            // Käsketään ohjelmaa lopettamaan kirjoittaminen.
            text.Close();
            // Lopuksi suljetaan itse ohjelma.
            Application.Exit();
        }
    }
}
