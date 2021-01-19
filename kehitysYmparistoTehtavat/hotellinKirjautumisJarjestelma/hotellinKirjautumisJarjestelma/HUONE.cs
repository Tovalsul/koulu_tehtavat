using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace hotellinKirjautumisJarjestelma
{
    /*
     * Tämä luokka hallitsee huoneita
     */
    class HUONE
    {
        YHDISTA conn = new YHDISTA();
        
        // hakee eri_huone_tyypit listalta huoneen tyypin.
        public DataTable huoneTyyppiLista()
        {
            MySqlCommand kasky = new MySqlCommand("SELECT * FROM `eri_huone_tyypit`", conn.haeYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulukko = new DataTable();

            adapteri.SelectCommand = kasky;
            adapteri.Fill(taulukko);


            return taulukko;
        }

        // hakee eri_huone_tyypit listalta huoneen tyypin mukaan ja vain vapaana olevat huoneet.
        public DataTable huoneTyypilla(int huoneTyyppi)
        {
            MySqlCommand kasky = new MySqlCommand("SELECT * FROM `huoneet` WHERE `huoneTyyppi`=@htp and vapaana='Kyllä'", conn.haeYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulukko = new DataTable();

            kasky.Parameters.Add("@htp", MySqlDbType.Int32).Value = huoneTyyppi;

            adapteri.SelectCommand = kasky;
            adapteri.Fill(taulukko);


            return taulukko;
        }

        // haeHuoneTyyppi hakee huoneen tyypin id numeron.
        public int haeHuoneTyyppi(int huone_numero)
        {
            MySqlCommand kasky = new MySqlCommand("SELECT `huoneTyyppi` FROM `huoneet` WHERE `huone_numero`=@hnm", conn.haeYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulukko = new DataTable();

            // @hnum
            kasky.Parameters.Add("@hnm", MySqlDbType.Int32).Value = huone_numero;

            adapteri.SelectCommand = kasky;
            adapteri.Fill(taulukko);


            return Convert.ToInt32(taulukko.Rows[0][0].ToString());
        }

        // päivittää varatun huoneen tilan vapaasta varatuksi ja toisinpäin. 
        public bool huoneVarattu(int huone_numero, String kylla_vai_ei)
        {
            MySqlCommand kasky = new MySqlCommand("UPDATE `huoneet` SET `vapaana`=@kylla_ei WHERE `huone_numero` = @hnm", conn.haeYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulukko = new DataTable();

            //@hnm, @kylla_vai_ei
            kasky.Parameters.Add("@hnm", MySqlDbType.Int32).Value = huone_numero;
            kasky.Parameters.Add("@kylla_ei", MySqlDbType.VarChar).Value = kylla_vai_ei;

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

        // tämä funktio lisää huoneen tietokantaan.
        public bool syotaHuone(int huone_numero, int huoneTyyppi, String puhelin, String vapaana)
        {
            MySqlCommand kasky = new MySqlCommand();
            String syotaKysely = "INSERT INTO `huoneet`(`huone_numero`, `huoneTyyppi`, `puhelin`, `vapaana`) VALUES (@hnm,@htp,@phn,@vap) ";
            kasky.CommandText = syotaKysely;
            kasky.Connection = conn.haeYhteys();

            // @hnm ,@htp ,@phn ,@vap
            kasky.Parameters.Add("@hnm", MySqlDbType.Int32).Value = huone_numero;
            kasky.Parameters.Add("@htp", MySqlDbType.Int32).Value = huoneTyyppi;
            kasky.Parameters.Add("@phn", MySqlDbType.VarChar).Value = puhelin;
            kasky.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaana;

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

        // tämä hakee listan kaikista huoneista.
        public DataTable haeHuoneet()
        {
             MySqlCommand kasky = new MySqlCommand("SELECT * FROM `huoneet`", conn.haeYhteys());
             MySqlDataAdapter adapteri = new MySqlDataAdapter();
             DataTable taulukko = new DataTable();

             adapteri.SelectCommand = kasky;
             adapteri.Fill(taulukko);
    
             return taulukko;
        }

        // tällä funktiolla muokataan valittua huonetta.
        public bool muokkaaHuone(int huone_numero, int huoneTyyppi, String puhelin, String vapaana)
        {
            MySqlCommand kasky = new MySqlCommand();
            String muokkaaKysely = "UPDATE `huoneet` SET `huoneTyyppi`=@htp,`puhelin`=@phn,`vapaana`=@vap WHERE `huone_numero`=@hnm";
            kasky.CommandText = muokkaaKysely;
            kasky.Connection = conn.haeYhteys();

            // @hnm ,@htp ,@phn ,@vap
            kasky.Parameters.Add("@hnm", MySqlDbType.Int32).Value = huone_numero;
            kasky.Parameters.Add("@htp", MySqlDbType.Int32).Value = huoneTyyppi;
            kasky.Parameters.Add("@phn", MySqlDbType.VarChar).Value = puhelin;
            kasky.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaana;

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

        // tällä poistetaan huone tietokannasta.
        public bool poistaHuone(int huone_numero)
        {
            MySqlCommand kasky = new MySqlCommand();
            String poistoKysely = "DELETE FROM `huoneet` WHERE `huone_numero`=@hnm";
            kasky.CommandText = poistoKysely;
            kasky.Connection = conn.haeYhteys();

            // @hnm
            kasky.Parameters.Add("@hnm", MySqlDbType.Int32).Value = huone_numero;

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
