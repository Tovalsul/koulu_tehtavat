using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Eramake;

namespace hotellinKirjautumisJarjestelma
{
    public partial class kirjautumisFormi : Form
    {
        public kirjautumisFormi()
        {
            InitializeComponent();
        }

        private void kirjautumisNappi_Click(object sender, EventArgs e)
        {
            // tähän on tehty uusia luokkia joita sitten kirjautumisnappi käyttää paikallisesti?
            YHDISTA conn = new YHDISTA();
            DataTable taulukko = new DataTable();
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            MySqlCommand kasky = new MySqlCommand();
            String kysely = "SELECT * FROM `asiakkaat` WHERE `kayttajanimi` = @ktu AND `salasana` =@ssana";

            kasky.CommandText = kysely;
            kasky.Connection = conn.haeYhteys();

            kasky.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = kayttajaNimiTekstiLaatikko.Text;
            kasky.Parameters.Add("@ssana", MySqlDbType.VarChar).Value = eCryptography.Encrypt(salasanaTekstiLaatikko.Text);

            adapteri.SelectCommand = kasky;
            adapteri.Fill(taulukko);

            //jos käyttäjänimi ja salasana ovat olemassa niin
            if(taulukko.Rows.Count > 0)
            {
                // Tarkistetaan että ei käyttäjänimi ja salasana ettei pääse sisään ilman mitään tunnuksia.
                if (kayttajaNimiTekstiLaatikko.Text.Trim().Equals("") && salasanaTekstiLaatikko.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Kirjoita käyttäjänimesi ja salasanasi kirjautuaksesi sisään", "Kirjautumistiedot puuttuu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // piilottaa logini ikkunan ja näyttää pääikkunan
                    this.Hide();
                    paaIkkunaForm paaForm = new paaIkkunaForm();
                    paaForm.Show();
                }
            }
            else
            {
                if (kayttajaNimiTekstiLaatikko.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Kirjoita käyttäjänimesi kirjautuaksesi sisään.","Käyttäjänimi puuttuu.", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else if (salasanaTekstiLaatikko.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Kirjoita salasanasi kirjautuaksesi sisään.", "Salasana puuttuu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Tätä käyttäjänimeä tai salasanaa ei ole olemassa", "Väärä käyttäjänimi tai salasana", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
    }
}
