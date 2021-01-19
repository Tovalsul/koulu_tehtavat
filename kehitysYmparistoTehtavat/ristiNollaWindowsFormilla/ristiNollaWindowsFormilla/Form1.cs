using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ristiNollaWindowsFormilla
{
    public partial class Form1 : Form
    {
        bool vuoro = true; // true = ristin vuoro; false = nollan vuoro
        int vuoroMaara;
        static String pelaaja1, pelaaja2;
        public Form1()
        {
            InitializeComponent();
        }

        public static void asetaPelaajienNimet(string nimi1, string nimi2)
        {
            pelaaja1 = nimi1;
            pelaaja2 = nimi2;
        }

        private void palttiarallaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tämän pelin on tehnyt Tony Valdemar Lehtonen! Muistakin se!", "Ristinolla palttiarallaa");
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void nappula_click(object sender, EventArgs e)
        {
            Button nappi = (Button)sender;
            if (vuoro)
            {
                nappi.Text = "X";
            }
            else
            {
                nappi.Text = "O";
            }
            vuoro = !vuoro;
            nappi.Enabled = false;
            vuoroMaara++;
            tarkistaVoittaja();
        }

        private void tarkistaVoittaja()
        {
            bool jokuVoittiPelin = false;

            // Vaakatason voittoehdon tarkistajat
            if((A1.Text == A2.Text)&&(A2.Text == A3.Text) && (!A1.Enabled))
            {
                jokuVoittiPelin = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                jokuVoittiPelin = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                jokuVoittiPelin = true;
            }

            // Pystytason voittoehdon tarkistajat
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                jokuVoittiPelin = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                jokuVoittiPelin = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                jokuVoittiPelin = true;
            }

            // Vinottaisen voittoehdon tarkistajat
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                jokuVoittiPelin = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
            {
                jokuVoittiPelin = true;
            }

            if (jokuVoittiPelin)
            {
                lamautaNapit();
                String voittaja = "";
                if (vuoro)
                {
                    voittaja = pelaaja2;
                    oVoittojenLaskija.Text = (Int32.Parse(oVoittojenLaskija.Text) + 1).ToString();
                }
                else
                {
                    voittaja = pelaaja1;
                    xVoittojenLaskija.Text = (Int32.Parse(xVoittojenLaskija.Text) + 1).ToString();
                }
                MessageBox.Show(voittaja + " Voitti pelin!", "Onneksi olkoon!");
            }// if loppuu
            else
            {
                if(vuoroMaara == 9)
                {
                    tasapelienLaskija.Text = (Int32.Parse(tasapelienLaskija.Text) + 1).ToString();
                    MessageBox.Show("Tasapeli...", "Voi hitsin hitsi.");
                }
            }

        }// tarkistaVoittaja loppuu

        private void lamautaNapit()
        {

            foreach (Control c in Controls)
            {
                try
                {
                    Button nappi = (Button)c;
                    nappi.Enabled = false;
                }// try loppuu

                catch { }
            }// foreach loppuu
        }

        private void uusiPeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vuoro = true;
            vuoroMaara = 0;

           
                foreach (Control c in Controls)
                {
                try
                {
                    Button nappi = (Button)c;
                    nappi.Enabled = true;
                    nappi.Text = "";
                }// try loppuu

                catch
                { }
                }// foreach loppuu
        }

        private void nappulaSisaan(object sender, EventArgs e)
        {
            Button nappi = (Button)sender;
            if (nappi.Enabled)
            {
                if (vuoro)
                {
                    nappi.Text = "X";
                }
                else
                {
                    nappi.Text = "O";
                }
            }// if loppuu
        }

        private void nappulaUlos(object sender, EventArgs e)
        {
            Button nappi = (Button)sender;
            if (nappi.Enabled)
            {
                nappi.Text = "";
            }// if loppuu
        }

        private void nollaaVoitotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oVoittojenLaskija.Text = "0";
            xVoittojenLaskija.Text = "0";
            tasapelienLaskija.Text = "0";
        }
        // Selvitä miksi ohjelma ei lataa nimien kyselyformia.
        private void Form1_Load(object sender, EventArgs e)
        {
            ristiNollaWindowsFormilla2 nimienKysely = new ristiNollaWindowsFormilla2();
            nimienKysely.ShowDialog();
            xVoittoMaara.Text = pelaaja1;
            oVoittoMaara.Text = pelaaja2;
        }
    }   
}
