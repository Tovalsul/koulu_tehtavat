using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace funktioLaskin
{
    public partial class funktioLaskin : Form
    {
        double arvo = 0;
        string operaattorit = "";
        bool operaattoriaPainettu = false;
        public funktioLaskin()
        {
            InitializeComponent();
        }

        private void geneerinenNappulaMetodi_Click(object sender, EventArgs e)
        {
            // Tämän if lauseen avulla saa sen tekstilaatikon sisältä nollan pois käyttäjän antamien numeroiden edestä.
            if (tulosRuutu.Text == "0" || (operaattoriaPainettu))
            {
                tulosRuutu.Clear();
            }
            // Tee pisteen tarkistus lause ettei tule monta pistettä laskimeen.
            operaattoriaPainettu = false;
            Button nappula = (Button)sender;
            tulosRuutu.Text = tulosRuutu.Text + nappula.Text;
        }

        private void pyyhiKaikki_Click(object sender, EventArgs e)
        {
            tulosRuutu.Text = "0";
            arvo = 0;
        }

        private void operaattorit_Click(object sender, EventArgs e)
        {
            Button nappula = (Button)sender;
            operaattorit = nappula.Text;
            arvo = double.Parse(tulosRuutu.Text);
            operaattoriaPainettu = true;
            yhtalo.Text = arvo + " " + operaattorit;
        }

        private void laskenta_Click(object sender, EventArgs e)
        {
            yhtalo.Text = "";
            switch (operaattorit)
            {
                case "+":
                    tulosRuutu.Text = (arvo + double.Parse(tulosRuutu.Text)).ToString();
                    break;
                case "-":
                    tulosRuutu.Text = (arvo - double.Parse(tulosRuutu.Text)).ToString();
                    break;
                case "*":
                    tulosRuutu.Text = (arvo * double.Parse(tulosRuutu.Text)).ToString();
                    break;
                case "/":
                    tulosRuutu.Text = (arvo / double.Parse(tulosRuutu.Text)).ToString();
                    break;
                case "%":
                    tulosRuutu.Text = (arvo % double.Parse(tulosRuutu.Text)).ToString();
                    break;
                case "Sqrt":
                    tulosRuutu.Text = (Math.Sqrt(double.Parse(tulosRuutu.Text)).ToString());
                    break;
                case "LOG":
                    tulosRuutu.Text = (Math.Log(double.Parse(tulosRuutu.Text)).ToString());
                    break;
                case "Sinh":
                    tulosRuutu.Text = (Math.Sinh(double.Parse(tulosRuutu.Text)).ToString());
                    break;
                case "Cosh":
                    tulosRuutu.Text = (Math.Cosh(double.Parse(tulosRuutu.Text)).ToString());
                    break;
                case "Tanh":
                    tulosRuutu.Text = (Math.Tanh(double.Parse(tulosRuutu.Text)).ToString());
                    break;
                case "EXP":
                    tulosRuutu.Text = (Math.Exp(double.Parse(tulosRuutu.Text)).ToString());
                    break;
                case "sin":
                    tulosRuutu.Text = (Math.Sin(double.Parse(tulosRuutu.Text)).ToString());
                    break;
                case "cos":
                    tulosRuutu.Text = (Math.Cos(double.Parse(tulosRuutu.Text)).ToString());
                    break;
                case "tan":
                    tulosRuutu.Text = (Math.Tan(double.Parse(tulosRuutu.Text)).ToString());
                    break;
                // Kato jos tää toimis piinä.
                case "Pi":
                    tulosRuutu.Text = (double.Parse(tulosRuutu.Text + 3.1415926535897931)).ToString();
                    break;
                case "X^2":
                    tulosRuutu.Text = (Math.Pow(double.Parse(tulosRuutu.Text, 2)).ToString());
                    break;
                case "Ceil":
                    tulosRuutu.Text = (Math.Ceiling(double.Parse(tulosRuutu.Text)).ToString());
                    break;
                case "Floor":
                    tulosRuutu.Text = (Math.Floor(double.Parse(tulosRuutu.Text)).ToString());
                    break;
                case "Ln X":
                    tulosRuutu.Text = (Math.Log(double.Parse(tulosRuutu.Text)).ToString());
                    break;
                default:
                    break;
            }// switch päättyy tähän

        }

        private void pyyhiPainike_Click(object sender, EventArgs e)
        {

            tulosRuutu.Text = "0";
        }
    }
}
