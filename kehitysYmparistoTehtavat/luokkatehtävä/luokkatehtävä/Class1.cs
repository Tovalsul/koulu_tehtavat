using System;
using System.Collections.Generic;
using System.Text;

namespace luokkatehtävä
{
    class Kirjasto
    {
        private string nimi;
        private string kirjailija;
        private int sivumaara;

        public Kirjasto()
        {
            nimi = "";
            kirjailija = "";
            sivumaara = 0;
        }
        //rasitettu constructor
        public Kirjasto(string unimi, string ukirjailija, int usivumaara)
        {
            nimi = unimi;
            kirjailija = ukirjailija;
            sivumaara = usivumaara;
        }

        public string Nimi
        {
            get
            {
                return nimi;
            }
            set
            {
                nimi = value;
            }
        }
        public string Kirjailija
        {
            get
            {
                return kirjailija;
            }
            set
            {
                kirjailija = value;
            }
        }
        public int Sivumaara
        {
            get
            {
                return sivumaara;
            }
            set
            {
                sivumaara = value;
            }
        }
    }
}
