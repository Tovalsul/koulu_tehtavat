using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotellinKirjautumisJarjestelma
{
    public partial class HallitseHuoneitaForm : Form
    {
        public HallitseHuoneitaForm()
        {
            InitializeComponent();
        }

        HUONE huone = new HUONE();
        private void HallitseHuoneitaForm_Load(object sender, EventArgs e)
        {
            halHuoneComboBox.DataSource = huone.huoneTyyppiLista();
            halHuoneComboBox.DisplayMember = "leima";
            halHuoneComboBox.ValueMember = "kategoria_id";
            halHuonedataGridView1.DataSource = huone.haeHuoneet();
        }

        private void lisaaHuoneNappi_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(huoneNroTextBox.Text);
            int tyyppi = Convert.ToInt32(halHuoneComboBox.SelectedValue.ToString());
            String puhelin = puhnroHalHuoneTextBox.Text;
            String vapaa = "";

            try
            {
                if (vapaaKyllaRadioButton.Checked)
                {
                    vapaa = "Kyllä";
                }
                else if (vapaaEiRadioButton.Checked)
                {
                    vapaa = "Ei";
                }

                if (huone.syotaHuone(numero, tyyppi, puhelin, vapaa))
                {
                    MessageBox.Show("Huoneen lisäys onnistui.", "Lisää huone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huoneen lisäys ei onnistunut.", "Lisää huone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Huone numero Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            halHuonedataGridView1.DataSource = huone.haeHuoneet();
        }

        private void muokkaaHuoneNappi_Click(object sender, EventArgs e)
        {
            int tyyppi = Convert.ToInt32(halHuoneComboBox.SelectedValue.ToString());
            String puhelin = puhnroHalHuoneTextBox.Text;
            String vapaa = "";

            try
            {
                int numero = Convert.ToInt32(huoneNroTextBox.Text);

                if (vapaaKyllaRadioButton.Checked)
                {
                    vapaa = "Kyllä";
                }
                else if (vapaaEiRadioButton.Checked)
                {
                    vapaa = "Ei";
                }

                if (huone.muokkaaHuone(numero, tyyppi, puhelin, vapaa))
                {
                    MessageBox.Show("Huoneen tiedot on päivitetty!", "Muokkaa huone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tietojen päivitys epäonnistui!", "Muokkaa huone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Huone numero Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            halHuonedataGridView1.DataSource = huone.haeHuoneet();
        }

        private void poistaHuoneNappi_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(huoneNroTextBox.Text);

                if (huone.poistaHuone(numero))
                {
                    MessageBox.Show("Huone on poistettu tietokannasta!", "Poista huone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huoneen Poisto epäonnistui!", "Poista huone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Huone numero Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            halHuonedataGridView1.DataSource = huone.haeHuoneet();
        }

        private void tyjennaKentatNappi_Click(object sender, EventArgs e)
        {

            huoneNroTextBox.Text = "";
            halHuoneComboBox.SelectedIndex = 0;
            puhnroHalHuoneTextBox.Text = "";
            vapaaKyllaRadioButton.Checked = true;

            halHuonedataGridView1.DataSource = huone.haeHuoneet();
        }
        // tällä saa valittua listalta olevan huoneen tiedot tekstilaatikoihin
        private void halHuonedataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            huoneNroTextBox.Text = halHuonedataGridView1.CurrentRow.Cells[0].Value.ToString();
            halHuoneComboBox.SelectedValue = halHuonedataGridView1.CurrentRow.Cells[1].Value;
            puhnroHalHuoneTextBox.Text = halHuonedataGridView1.CurrentRow.Cells[2].Value.ToString();

            String vapaa = halHuonedataGridView1.CurrentRow.Cells[3].Value.ToString();

            if (vapaa.Equals("Kyllä"))
            {
                vapaaKyllaRadioButton.Checked = true;
            }
            else if (vapaa.Equals("Ei"))
            {
                vapaaEiRadioButton.Checked = true;
            }
        }
    }
}
