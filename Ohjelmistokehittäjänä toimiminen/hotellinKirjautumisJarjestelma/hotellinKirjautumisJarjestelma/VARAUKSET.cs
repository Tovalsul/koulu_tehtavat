using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace hotellinKirjautumisJarjestelma
{
    class VARAUKSET
    {
        // yhdistä luokka muodostaa yhteyden tietokantaan.
        YHDISTA conn = new YHDISTA();

        // hae kaikki varaukset
        public DataTable haeKaikkiVaraukset()
        {
            MySqlCommand kasky = new MySqlCommand("SELECT * FROM `varaukset`", conn.haeYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulukko = new DataTable();

            adapteri.SelectCommand = kasky;
            adapteri.Fill(taulukko);

            return taulukko;
        }

        // tämä funktio lisää varauksen tietokantaan.
        public bool syotaVaraus(int huoneNro, int asiakasId, DateTime varausAlkaa, DateTime varausPaattyy)
        {
            MySqlCommand kasky = new MySqlCommand();
            String syotaKysely = "INSERT INTO `varaukset`(`huoneNro`, `asiakasId`, `varausAlkaa`, `varausPaattyy`) VALUES(@hnm, @aid, @vra, @vrp)";
            kasky.CommandText = syotaKysely;
            kasky.Connection = conn.haeYhteys();

            // @hnm ,@aid ,@vra ,@vrp
            kasky.Parameters.Add("@hnm", MySqlDbType.Int32).Value = huoneNro;
            kasky.Parameters.Add("@aid", MySqlDbType.Int32).Value = asiakasId;
            kasky.Parameters.Add("@vra", MySqlDbType.VarChar).Value = varausAlkaa;
            kasky.Parameters.Add("@vrp", MySqlDbType.VarChar).Value = varausPaattyy;

            conn.avaaYhteys();

            if (kasky.ExecuteNonQuery() == 1)
            {
                conn.suljeYhteys();
                return true;
            }
            else
            {
                conn.suljeYhteys();
                return false;
            }
        }

        // tällä funktiolla muokataan valittua varausta.
        public bool muokkaaVaraus(int varausId, int huoneNro, int asiakasId, DateTime varausAlkaa, DateTime varausPaattyy)
        {
            MySqlCommand kasky = new MySqlCommand();
            String muokkaaKysely = "UPDATE `varaukset` SET `huoneNro`=@hnm,`asiakasId`=@aid,`varausAlkaa`=@vra,`varausPaattyy`=@vrp WHERE `varausId`=@vid";
            kasky.CommandText = muokkaaKysely;
            kasky.Connection = conn.haeYhteys();

            // @hnm ,@aid ,@vra ,@vrp, @vid
            kasky.Parameters.Add("@vid", MySqlDbType.Int32).Value = varausId;
            kasky.Parameters.Add("@hnm", MySqlDbType.Int32).Value = huoneNro;
            kasky.Parameters.Add("@aid", MySqlDbType.Int32).Value = asiakasId;
            kasky.Parameters.Add("@vra", MySqlDbType.VarChar).Value = varausAlkaa;
            kasky.Parameters.Add("@vrp", MySqlDbType.VarChar).Value = varausPaattyy;

            conn.avaaYhteys();

            if (kasky.ExecuteNonQuery() == 1)
            {
                conn.suljeYhteys();
                return true;
            }
            else
            {
                conn.suljeYhteys();
                return false;
            }
        }

        // tällä poistetaan varaus tietokannasta.
        public bool poistaVaraus(int varausId)
        {
            MySqlCommand kasky = new MySqlCommand();
            String poistoKysely = "DELETE FROM `varaukset` WHERE `varausId`=@vid";
            kasky.CommandText = poistoKysely;
            kasky.Connection = conn.haeYhteys();

            // @hnm
            kasky.Parameters.Add("@vid", MySqlDbType.Int32).Value = varausId;

            conn.avaaYhteys();

            if (kasky.ExecuteNonQuery() == 1)
            {
                conn.suljeYhteys();
                return true;
            }
            else
            {
                conn.suljeYhteys();
                return false;
            }
        }
    }
}
