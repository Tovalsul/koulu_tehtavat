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

namespace harjoitus___crud
{
    public partial class opiskelijarekisteri : Form
    {
        public opiskelijarekisteri()
        {
            InitializeComponent();
        }

        private void opiskelijarekisteri_Load(object sender, EventArgs e)
        {
            tietotauluDG.DataSource = OPISKELIJA.haeOpiskelijat();
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            idTB.Text = "";
            etunimiTB.Text = "";
            sukunimiTB.Text = "";
            puhelinTB.Text = "";
            sahkopostiTB.Text = "";
            opiskelijaNroTB.Text = "";
        }

        private void tallennaBT_Click(object sender, EventArgs e)
        {
            String enimi = etunimiTB.Text;
            String snimi = sukunimiTB.Text;
            String puhelin = puhelinTB.Text;
            String email = sahkopostiTB.Text;
            int onro = Int32.Parse(opiskelijaNroTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || onro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, puhelin, sähköposti ja opisklijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = OPISKELIJA.lisaaOpiskelija(enimi, snimi, puhelin, email, onro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opiskelija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisäämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            tietotauluDG.DataSource = OPISKELIJA.haeOpiskelijat();
        }

        private void paivitaBT_Click(object sender, EventArgs e)
        {
            String enimi = etunimiTB.Text;
            String snimi = sukunimiTB.Text;
            String puhelin = puhelinTB.Text;
            String email = sahkopostiTB.Text;
            int onro = Int32.Parse(opiskelijaNroTB.Text);
            int oid = Int32.Parse(idTB.Text);

            if (oid.Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || onro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - ID, Etu- ja sukunimi, puhelin, sähköposti ja opisklijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = OPISKELIJA.muokkaaOpiskelijaa(oid, enimi, snimi, puhelin, email, onro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Opiskelija päivitetty onnistuneesti", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Opiskelijaa ei pystytty päivittämään", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            tietotauluDG.DataSource = OPISKELIJA.haeOpiskelijat();
            }

        private void tietotauluDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTB.Text = tietotauluDG.CurrentRow.Cells[0].Value.ToString();
            etunimiTB.Text = tietotauluDG.CurrentRow.Cells[1].Value.ToString();
            sukunimiTB.Text = tietotauluDG.CurrentRow.Cells[2].Value.ToString();
            puhelinTB.Text = tietotauluDG.CurrentRow.Cells[3].Value.ToString();
            sahkopostiTB.Text = tietotauluDG.CurrentRow.Cells[4].Value.ToString();
            opiskelijaNroTB.Text = tietotauluDG.CurrentRow.Cells[5].Value.ToString();
        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            String ktunnus = idTB.Text;
            if (OPISKELIJA.poistaOpiskelija(ktunnus))
            {
                tietotauluDG.DataSource = OPISKELIJA.haeOpiskelijat();
                MessageBox.Show("Opiskelijat poistettu onnistuneesti", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opiskelijaa ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaBT.PerformClick();
        }
    }
}
