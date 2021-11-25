using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace hotellinKirjautumisJarjestelma
{
    /*
     * YHDISTA-luokka luo yhteyden tämän ohjelman ja mysql tietokannan vällille.
     * 
     */
    class YHDISTA
    {
        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=csharp_hotellinvarausjarjestelmadb;");

        // funktio joka palauttaa yhteyden
        public MySqlConnection haeYhteys()
        {
            return yhteys;
        }

        // funktio joka avaa yhteyden
        public void avaaYhteys()
        {
            if(yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }

        // funktio joka sulkee yhteyden
        public void suljeYhteys()
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
