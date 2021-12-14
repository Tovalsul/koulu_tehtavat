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
    public partial class HallitseAsiakkaitaForm : Form
    {
        ASIAKAS asiakas = new ASIAKAS();
        public HallitseAsiakkaitaForm()
        {
            InitializeComponent();
        }

        // tyhjentää tekstilaatikot
        private void tyjennaKentatNappi_Click(object sender, EventArgs e)
        {
            idHalAsiakasTextBox.Text = "";
            eNimiHalAsiakasTextBox.Text = "";
            sNimiHalAsiakasTextBox.Text = "";
            puhnroHalAsiakasTextBox.Text = "";
            maaHalAsiakasTextBox.Text = "";
            kNimiTextBox.Text = "";
            salasanaTextBox.Text = "";

            dataGridView1.DataSource = asiakas.haeAsiakkaat();
        }

        // ottaa tekstilaatikoista tiedot ja lisää ne asiakkaan tietoihin
        private void lisaaAsiakasNappi_Click(object sender, EventArgs e)
        {
            String eNimi = eNimiHalAsiakasTextBox.Text;
            String sNimi = sNimiHalAsiakasTextBox.Text;
            String puhNro = puhnroHalAsiakasTextBox.Text;
            String maa = maaHalAsiakasTextBox.Text;
            String kayttajanimi = kNimiTextBox.Text;
            String salasana = salasanaTextBox.Text;

            if (eNimi.Trim().Equals("") || sNimi.Trim().Equals("") || puhNro.Trim().Equals(""))
            {
                MessageBox.Show("Tarvittavat kentät - etu ja suku -nimet + puhelin-numero", "Infokentät ovat tyhjiä.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean syotaAsiakas = asiakas.syotaAsiakas(eNimi, sNimi, puhNro, maa, kayttajanimi, salasana);

                if (syotaAsiakas)
                {
                    dataGridView1.DataSource = asiakas.haeAsiakkaat();
                    MessageBox.Show("Uusi asiakas lisätty onnistuneesti!", "Lisää asiakas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR - asiakkaan lisäys epäonnistui!", "Lisää asiakas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            dataGridView1.DataSource = asiakas.haeAsiakkaat();
        }

        private void HallitseAsiakkaitaForm_Load(object sender, EventArgs e)
        {
            // tämä näyttää hallitseasiakkaita ikkunan datagridin sisällä kaikki tiedot mitä on haettu hotellivarausjärjestelmän databasen asiakkaat taulukosta.
            dataGridView1.DataSource = asiakas.haeAsiakkaat();
        }

        private void muokkaaNappi_Click(object sender, EventArgs e)
        {
            int id;
            String eNimi = eNimiHalAsiakasTextBox.Text;
            String sNimi = sNimiHalAsiakasTextBox.Text;
            String puhNro = puhnroHalAsiakasTextBox.Text;
            String maa = maaHalAsiakasTextBox.Text;
            String kayttajanimi = kNimiTextBox.Text;
            

            try
            {
                id = Convert.ToInt32(idHalAsiakasTextBox.Text);

                if (eNimi.Trim().Equals("") || sNimi.Trim().Equals("") || puhNro.Trim().Equals(""))
                {
                    MessageBox.Show("Tarvittavat kentät - etu ja suku -nimet + puhelin-numero", "Infokentät ovat tyhjiä.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean muokkaaAsiakas = asiakas.muokkaaAsiakas(id, eNimi, sNimi, puhNro, maa, kayttajanimi);

                    if (muokkaaAsiakas)
                    {
                        dataGridView1.DataSource = asiakas.haeAsiakkaat();
                        MessageBox.Show("Asiakkaan tietojen päivitys onnistui!", "Muokkaa asiakkan tietoja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR - tietojen päivitys epäonnistui!", "Muokkaa asiakkan tietoja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridView1.DataSource = asiakas.haeAsiakkaat();
        }


        // tällä voi valita suoraan datagridistä asiakkaan tiedot textboxeihin muokattaviksi.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idHalAsiakasTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            eNimiHalAsiakasTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            sNimiHalAsiakasTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            puhnroHalAsiakasTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maaHalAsiakasTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            kNimiTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void poistaNappi_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(idHalAsiakasTextBox.Text);

                if (asiakas.poistaAsiakas(id))
                {
                    dataGridView1.DataSource = asiakas.haeAsiakkaat();
                    MessageBox.Show("Asiakas poistettu onnistuneesti!", "Poista asiakas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tyjennaKentatNappi.PerformClick();
                }
                else
                {
                    MessageBox.Show("ERROR - Asiakkaan poisto epäonnistui!", "Poista asiakas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridView1.DataSource = asiakas.haeAsiakkaat();
        }
    }
}
