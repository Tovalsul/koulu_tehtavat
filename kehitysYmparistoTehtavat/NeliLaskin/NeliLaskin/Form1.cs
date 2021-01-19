using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeliLaskin
{
    public partial class neliLaskin : Form
    {

        double arvo = 0;
        string operaattorit = "";
        bool operaattoriaPainettu = false;
        public neliLaskin()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            // Tämän if lauseen avulla saa sen tekstilaatikon sisältä nollan pois käyttäjän antamien numeroiden edestä.
            if (naytto.Text == "0" || (operaattoriaPainettu)){
                naytto.Clear();
            }

            operaattoriaPainettu = false;
            Button nappula = (Button)sender;
            naytto.Text = naytto.Text + nappula.Text;
        }

        private void pyyhiKaikki_Click(object sender, EventArgs e)
        {
            naytto.Text = "0";
            arvo = 0;
        }

        private void operaattorit_Click(object sender, EventArgs e)
        {
            Button nappula = (Button)sender;
            operaattorit = nappula.Text;
            arvo = double.Parse(naytto.Text);
            operaattoriaPainettu = true;
            yhtalo.Text = arvo + " " + operaattorit;
        }

        private void laskenta_Click(object sender, EventArgs e)
        {
            yhtalo.Text = "";
            switch (operaattorit)
            {
                case "+":
                    naytto.Text = (arvo + double.Parse(naytto.Text)).ToString();
                    break;
                case "-":
                    naytto.Text = (arvo - double.Parse(naytto.Text)).ToString();
                    break;
                case "*":
                    naytto.Text = (arvo * double.Parse(naytto.Text)).ToString();
                    break;
                case "/":
                    naytto.Text = (arvo / double.Parse(naytto.Text)).ToString();
                    break;
                default:
                    break;
            }// switch päättyy tähän
            
        }

        private void pyyhiPainike_Click(object sender, EventArgs e)
        {
           
            naytto.Text = "0";
        }
    }
}
