using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kymmenen_kysymystä
{
    public partial class Form1 : Form
    {
        string[] oikeatVastaukset = new string[] { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };
        string[] vastaukset = new string[10];
        int laskuri = 0;
        int oikein = 0;
        public Form1()
        {
            InitializeComponent();
            aRadioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            bRadioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            cRadioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            dRadioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
        }
        private void tyhjaaVastaus()
        {
            if(aRadioButton.Checked == true)
            {
                aRadioButton.Checked = false;
                laskuri--;
            }
            if (bRadioButton.Checked == true)
            {
                bRadioButton.Checked = false;
                laskuri--;
            }
            if (cRadioButton.Checked == true)
            {
                cRadioButton.Checked = false;
                laskuri--;
            }
            if (dRadioButton.Checked == true)
            {
                dRadioButton.Checked = false;
                laskuri--;
            }
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton && laskuri < 10)
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                laskuri++;
                ohjeLabel.Text = "Vastaus " + (laskuri) + ". kysymykseen: ";
            }
            else
            {
                vastausLabel.Text = "";
                aRadioButton.Enabled = false;
                bRadioButton.Enabled = false;
                cRadioButton.Enabled = false;
                dRadioButton.Enabled = false;
                for (int j = 0; j < 10; j++)
                {
                    if(vastaukset[j] == oikeatVastaukset[j])
                    {
                        oikein++;
                    }
                }
                vastausLabel.Text = "Oikeita vastauksia oli: " + oikein;
                vastausLabel.Visible = true;
            }
            tyhjaaVastaus();
        }
    }
}
