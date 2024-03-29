﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Eramake;

namespace hotellinKirjautumisJarjestelma
    /*
     * 
     * ASIAKAS luokka tekee uuden asiakkaan varausjärjestelmään
     * ja muokkaa tai poistaa asiakkaan tietoja ja hakee kaikki asiakkaat
     * järjestelmän tietokannasta.
     *
     */
{
    class ASIAKAS
    {
        YHDISTA conn = new YHDISTA();

        // funktio joka syöttää uuden asikkaan tiedot
        public bool syotaAsiakas(String eNimi, String sNimi, String puhNro, String maa, String kayttajanimi, String salasana)
        {
            MySqlCommand kasky = new MySqlCommand();
            String syotaKysely = "INSERT INTO `asiakkaat`(`etu_nimi`, `suku_nimi`, `puhelin_nro`, `maa`, `kayttajanimi`, `salasana`) VALUES (@enm,@snm,@phn,@maa,@ktu,@ssa) ";
            kasky.CommandText = syotaKysely;
            kasky.Connection = conn.haeYhteys();

            // @enm ,@snm ,@phn ,@maa, @ktu, @ssa
            kasky.Parameters.Add("@enm", MySqlDbType.VarChar).Value = eNimi;
            kasky.Parameters.Add("@snm", MySqlDbType.VarChar).Value = sNimi;
            kasky.Parameters.Add("@phn", MySqlDbType.VarChar).Value = puhNro;
            kasky.Parameters.Add("@maa", MySqlDbType.VarChar).Value = maa;

            if(kayttajanimi != "")
            {
                kasky.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = kayttajanimi.ToLower();
            }
            else
            {
                kasky.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = eNimi.Substring(0, 3).ToLower() + sNimi.Substring(0, 5).ToLower();
            }
            if (salasana != "")
            {
                kasky.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = eCryptography.Encrypt(salasana);
            }
            else
            {
                kasky.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = eCryptography.Encrypt(luoSalasana());
                // MessageBox.Show(luoSalasana());
            }
            
            conn.avaaYhteys();

            if(kasky.ExecuteNonQuery() == 1)
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

        // tää aliohjelma hakee asiakkaat listan
        public DataTable haeAsiakkaat()
        {
            // kasky valitsee kaiken mitä asiakkaat listalta löytyy ja hakee yhteyden databaseen haeyhteys() metodilla.
            MySqlCommand kasky = new MySqlCommand("SELECT * FROM `asiakkaat`", conn.haeYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulukko = new DataTable();

            adapteri.SelectCommand = kasky;
            adapteri.Fill(taulukko);

            
            return taulukko;
        }

        // tällä funktiolla voi muokata asiakkaiden tietoja.
        public bool muokkaaAsiakas(int id, String eNimi, String sNimi, String puhNro, String maa, String kayttajanimi)
        {
            MySqlCommand kasky = new MySqlCommand();
            String muokkaaKysely = "UPDATE `asiakkaat` SET `etu_nimi`=@enm,`suku_nimi`=@snm,`puhelin_nro`=@phn,`maa`=@maa, `kayttajanimi`=@ktu WHERE `id`=@aid";
            kasky.CommandText = muokkaaKysely;
            kasky.Connection = conn.haeYhteys();

            // @aid, @enm ,@snm ,@phn ,@maa
            kasky.Parameters.Add("@aid", MySqlDbType.Int32).Value = id;
            kasky.Parameters.Add("@enm", MySqlDbType.VarChar).Value = eNimi;
            kasky.Parameters.Add("@snm", MySqlDbType.VarChar).Value = sNimi;
            kasky.Parameters.Add("@phn", MySqlDbType.VarChar).Value = puhNro;
            kasky.Parameters.Add("@maa", MySqlDbType.VarChar).Value = maa;
            kasky.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = kayttajanimi;

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

        // aliohjelma joka poistaa valitun asiakkaan listalta.
        public bool poistaAsiakas(int id)
        {
            MySqlCommand kasky = new MySqlCommand();
            String poistoKysely = "DELETE FROM `asiakkaat` WHERE `id`=@aid";
            kasky.CommandText = poistoKysely;
            kasky.Connection = conn.haeYhteys();

            // @aid
            kasky.Parameters.Add("@aid", MySqlDbType.Int32).Value = id;

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

        // Funktio joka tekee 12 merkkisen salasanan satunnaisesti valituista taulukon merkeistä.
        public string luoSalasana()
        {
            char[] alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#€?0123456789".ToCharArray();
            Random satunnaisluku = new Random();
            string salasana = "";
            for(int i =0; i < 12; i++)
            {
                int indeksi = satunnaisluku.Next(alpha.Length);
                salasana += alpha[indeksi];
            }
            return salasana;
        }
    }
}
