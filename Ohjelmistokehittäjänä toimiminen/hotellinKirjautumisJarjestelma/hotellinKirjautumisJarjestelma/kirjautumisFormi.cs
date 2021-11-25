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
            String kysely = "SELECT * FROM `kayttajat` WHERE `kayttajanimi` = @usn AND `salasana` =@pass";

            kasky.CommandText = kysely;
            kasky.Connection = conn.haeYhteys();

            kasky.Parameters.Add("@usn", MySqlDbType.VarChar).Value = kayttajaNimiTekstiLaatikko.Text;
            kasky.Parameters.Add("@pass", MySqlDbType.VarChar).Value = salasanaTekstiLaatikko.Text;

            adapteri.SelectCommand = kasky;
            adapteri.Fill(taulukko);

            //jos käyttäjänimi ja salasana ovat olemassa niin
            if(taulukko.Rows.Count > 0)
            {
                // piilottaa logini ikkunan ja näyttää pääikkunan
                this.Hide();
                paaIkkunaForm paaForm = new paaIkkunaForm();
                paaForm.Show();
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
