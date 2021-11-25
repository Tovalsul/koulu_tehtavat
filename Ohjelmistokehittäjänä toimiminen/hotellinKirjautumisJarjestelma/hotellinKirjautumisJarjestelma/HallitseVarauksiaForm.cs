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
    public partial class HallitseVarauksiaForm : Form
    {
        public HallitseVarauksiaForm()
        {
            InitializeComponent();
        }

        HUONE huone = new HUONE();
        VARAUKSET varaukset = new VARAUKSET();

        private void HallitseVarauksiaForm_Load(object sender, EventArgs e)
        {
            // Nämä näyttävät huoneen tyypin hallitse varauksia ikkunan huonetyyppi comboboxissa.
            huoneTyyppiComboBox.DataSource = huone.huoneTyyppiLista();
            huoneTyyppiComboBox.DisplayMember = "leima";
            huoneTyyppiComboBox.ValueMember = "kategoria_id";

            // Näyttää vapaan valitun huonetyypin huonenumeron.
            int huoneTyyppi = Convert.ToInt32(huoneTyyppiComboBox.SelectedValue.ToString());
            huoneNroComboBox.DataSource = huone.huoneTyypilla(huoneTyyppi);
            huoneNroComboBox.DisplayMember = "huone_numero";
            huoneNroComboBox.ValueMember = "huone_numero";

            // Näyttää kaikki varaukset hallintaikkunassa
            dataGridView1.DataSource = varaukset.haeKaikkiVaraukset();
        }

        private void tyjennaKentatNappi_Click(object sender, EventArgs e)
        {
            varausIdTextBox.Text = "";
            asiakasIdTextBox.Text = "";
            huoneTyyppiComboBox.SelectedIndex = 0;
            huoneNroComboBox.SelectedIndex = 0;
            varausAlkaaDate.Value = DateTime.Now;
            varausPaattyyDate.Value = DateTime.Now;

            // tätä samaa pätkää voi käyttää myös päivittämään hallintaikkunassa nähdyn varauslistan hakemalla se uudestaan tietokannasta.
            dataGridView1.DataSource = varaukset.haeKaikkiVaraukset();
        }

        private void huoneTyyppiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // alla oleva pätkä näyttää valitun huone tyypin huone numeron
                int tyyppi = Convert.ToInt32(huoneTyyppiComboBox.SelectedValue.ToString());
                huoneNroComboBox.DataSource = huone.huoneTyypilla(tyyppi);
                huoneNroComboBox.DisplayMember = "huone_numero";
                huoneNroComboBox.ValueMember = "huone_numero";
            }
            catch (Exception)
            {
                // ei tee mitään jos tulee virhe
            }
        }

        private void lisaaVarausNappi_Click(object sender, EventArgs e)
        {
            try
            {
                int asiakasId = Convert.ToInt32(asiakasIdTextBox.Text);
                int huoneNro = Convert.ToInt32(huoneNroComboBox.Text);
                DateTime Alkaa = varausAlkaaDate.Value;
                DateTime Paattyy = varausPaattyyDate.Value;

                if(DateTime.Compare(Alkaa.Date, DateTime.Now.Date) > 0)
                {
                    MessageBox.Show("Eipä varailla menneessä ajassa siellä! Vaan tämän päiväisä tai tuleville päiville voi varata ajan.", "Väärä päivämäärä!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (DateTime.Compare(Paattyy.Date, Alkaa.Date) < 0)
                {
                    MessageBox.Show(Paattyy.Day + " " + Alkaa.Day);
                    MessageBox.Show("Varaus ei voi alkaa ennen päättymisajankohtaa!", "Varauksen alku ja päättymis -päivät meni ristiin!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (varaukset.syotaVaraus(huoneNro, asiakasId, Alkaa, Paattyy))
                    {
                        // Muuttaa huoneen tilan varatuksi kun lisää varauksen tietokantaan.
                        huone.huoneVarattu(huoneNro, "Ei");
                        MessageBox.Show("Varaus lisätty", "Lisää varaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Varauksen lisäys epäonnistui", "Lisää varaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lisää varaus error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridView1.DataSource = varaukset.haeKaikkiVaraukset();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            varausIdTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
            // hakee huoneen id numeron.
            int huoneId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            
            // valitsee huoneen tyypin comboboksista.
            huoneTyyppiComboBox.SelectedValue = huone.haeHuoneTyyppi(huoneId);
            
            // valitsee huoneen numeron comboboksista.
            huoneNroComboBox.SelectedValue = huoneId;
            
            asiakasIdTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            // Ottaa klikatun varauksen päivämäärät ja syöttää ne kenttiin muokattaviksi.
            varausAlkaaDate.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
            varausPaattyyDate.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
        }

        private void muokkaaVarausNappi_Click(object sender, EventArgs e)
        {
            try
            {
                int varausId = Convert.ToInt32(varausIdTextBox.Text);
                int asiakasId = Convert.ToInt32(asiakasIdTextBox.Text);
                int huoneNro = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                DateTime Alkaa = varausAlkaaDate.Value;
                DateTime Paattyy = varausPaattyyDate.Value;

                if (Alkaa < DateTime.Now)
                {
                    MessageBox.Show("Eipä varailla menneessä ajassa siellä! Vaan tämän päiväisä tai tuleville päiville voi varata ajan.", "Väärä päivämäärä!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Paattyy < Alkaa)
                {
                    MessageBox.Show("Varaus ei voi alkaa ennen päättymisajankohtaa!", "Varauksen alku ja päättymis -päivät meni ristiin!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (varaukset.muokkaaVaraus(varausId, huoneNro, asiakasId, Alkaa, Paattyy))
                    {
                        // Muuttaa huoneen tilan varatuksi kun lisää varauksen tietokantaan.
                        huone.huoneVarattu(huoneNro, "Ei");
                        MessageBox.Show("Varauksen päivitys onnistui!", "Päivitä varaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Varauksen päivitys epäonnistui", "Päivitä varaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Päivitä varaus error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridView1.DataSource = varaukset.haeKaikkiVaraukset();
        }

        private void poistaVarausNappi_Click(object sender, EventArgs e)
        {
            try
            {
                int varausId = Convert.ToInt32(varausIdTextBox.Text);
                int huone_numero = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                if (varaukset.poistaVaraus(varausId))
                {
                    huone.huoneVarattu(huone_numero, "Kyllä");

                    MessageBox.Show("Varaus poistettu!", "Poista varaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Poista varaus error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridView1.DataSource = varaukset.haeKaikkiVaraukset();
        }
    }
} 



  /* Nämä käskyt laitettiin xampin kautta taulukoihin rajoittamaan varausten tekoa niin ettei 
    olemattomia asiakkaita voida lisätä tietokantaan tai tehdä päällekäisiä varauksia. 
  */

  // ALTER TABLE huoneet ADD CONSTRAINT fk_tyyppi_id FOREIGN KEY (huoneTyyppi) REFERENCES eri_huone_tyypit(kategoria_id) ON UPDATE CASCADE ON DELETE CASCADE;
  // ALTER TABLE varaukset ADD CONSTRAINT fk_huone_nro FOREIGN KEY (huoneNro) REFERENCES huoneet(huone_numero) ON UPDATE CASCADE ON DELETE CASCADE;
  // ALTER TABLE varaukset ADD CONSTRAINT fk_asiakas_id FOREIGN KEY (asiakasId) REFERENCES asiakkaat(id) ON UPDATE CASCADE ON DELETE CASCADE;