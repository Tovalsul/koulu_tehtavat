using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmi_laskuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void laskeBmiButton_Click(object sender, EventArgs e)
        {
            // Luodaan tarvittavat muuttujat
            double paino = 0, pituus = 0;
            // Käännetään pituus ja paino doubleiksi jotta niillä voidaan laskea.
            paino = Convert.ToDouble(painoTextBox.Text);
            pituus = Convert.ToDouble(pituusTextBox.Text);
            // Tehdään painoindeksikaava
            double bmi = Math.Round(paino / (pituus * pituus), 2);
            // Muistutetaan käyttäjää pilkusta ettei BMI ole 0.
            if (bmi == 0)
            {
                tulosLabel.Text = "Muista pituutta laittaessa ";
                kuvausLabel.Text = "pilkku!";
                tulosLabel.ForeColor = Color.Orange;
                kuvausLabel.ForeColor = Color.Orange;
                kuvausLabel.Visible = true;
            }
            // Alla on sitten loput laskut painoindeksiä laskettaessa.
            else if(bmi < 18.5)
            {
                tulosLabel.Text = "Painoindeksisi on: " + bmi;
                tulosLabel.ForeColor = Color.Aqua;
                kuvausLabel.ForeColor = Color.Aqua;
                kuvausLabel.Text = "Alipaino";
                kuvausLabel.Visible = true;

            }
            else if (bmi < 25)
            {
                tulosLabel.Text = "Painoindeksisi on: " + bmi;
                tulosLabel.ForeColor = Color.Green;
                kuvausLabel.ForeColor = Color.Green;
                kuvausLabel.Text = "Normaalipaino";
                kuvausLabel.Visible = true;
            }
            else if (bmi < 40)
            {
                tulosLabel.Text = "Painoindeksisi on: " + bmi;
                tulosLabel.ForeColor = Color.Gold;
                kuvausLabel.ForeColor = Color.Gold;
                kuvausLabel.Text = "Ylipaino";
                kuvausLabel.Visible = true;
            }
            else
            {
                tulosLabel.Text = "Painoindeksisi on: " + bmi;
                tulosLabel.ForeColor = Color.Red;
                kuvausLabel.ForeColor = Color.Red;
                kuvausLabel.Text = "Huomattava ylipaino";
                kuvausLabel.Visible = true;
            }
        }
    }
}
