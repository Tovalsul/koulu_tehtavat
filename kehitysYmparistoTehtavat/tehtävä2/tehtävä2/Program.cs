using System;

namespace tehtävä2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            vali();
            onkoLukuTosiVaiEi(0, 0);
            vali();
            tosiVaiEiReturn(0, 0);
            vali();
            palautaJakoJaannos(0, 0);
            vali();
            onkoLukujenValissa(0, 0, 0);
            vali();
            tuumatSenteiksi(0);
            vali();
            elukoidenJalkojenMaara();
            vali();
            tunnitMinuutitSekunnit();
            
        }

        public static void vali()
        {
            Console.WriteLine("\n ------------------------------------------------------------------ \n");

        }

        public static void onkoLukuTosiVaiEi(int luku1, int luku2)
        {
            Console.WriteLine("Anna kaksi lukua verrattavaksi. Katsotaan ovatka ne samoja.");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Toinenkin luku.");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine(luku1 == luku2);
        
        }// Kai tähän on joku lyhyempikin tapa. Teen vielä returnilla kun sitä vissiin haluttiin käytettävän.
   

        public static bool tosiVaiEiReturn(int luku1, int luku2)
        {
            Console.WriteLine("Anna kaksi lukua verrattavaksi. Katsotaan ovatka ne samoja.");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Toinen luku.");
            luku2 = int.Parse(Console.ReadLine());
            bool vertaa = luku1 == luku2;
            Console.WriteLine(vertaa);
            return vertaa;
        }

        public static int palautaJakoJaannos(int luku1, int luku2)
        {

            Console.WriteLine("Tarvitsen kaksi lukua. Tarkistetaan niistä jakojäännös.");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Toinen luku kiitos.");
            luku2 = int.Parse(Console.ReadLine());
            int jakoJaannosMuuttuja = luku1 % luku2;
            Console.WriteLine(jakoJaannosMuuttuja);
            return jakoJaannosMuuttuja;
        }

        public static bool onkoLukujenValissa(int luku1, int luku2, int luku3)
        {
            Console.WriteLine("Anna kolme lukua. Katsotaan onko kolmas niistä kahden ensimmäisen välissä.");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Toinenkin.");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ja kolmas sieltä väliin noin!");
            luku3 = int.Parse(Console.ReadLine());
            bool valissa = true;
            // Tämä välillä palauttaa false, vaikka itse kolmas luku olisikin lukujanalla kahden ensimmäisen annetun luvun välissä. Eli on tullut kai looginen virhe.
            if (luku3 > luku1 && luku3 < luku2)
            {
                Console.WriteLine(valissa);
                return valissa;
            } else
            {
                Console.WriteLine(!valissa);
                return !valissa;
            }
           
        }

        public static double tuumatSenteiksi(double tuumat)
        {
            Console.WriteLine("Tuumat tähän. Käännän tuumat senteiksi.");
            tuumat = double.Parse(Console.ReadLine());
            double sentit = tuumat * 2.54;
            Console.WriteLine(sentit);
            return sentit;
        }

        public static int elukoidenJalkojenMaara()
        {
            // Tässä kysytään eläinten jalkojen määrää. Tossa alla noin.
            Console.WriteLine("Kuinka monta kanaa?");
            int kana = int.Parse(Console.ReadLine());
            Console.WriteLine("Kuinka monta lehmää?");
            int lehma = int.Parse(Console.ReadLine());
            Console.WriteLine("Kuinka monta sikaa?");
            int sika = int.Parse(Console.ReadLine());
            // Tähän on määritelty etukäteen eri elukoiden jalkojen määrää ja ne kerrotaan valmiiksi samalla, jotta saadaan helposti jokaisen käyttäjän antaman elukan jalat laskettua.
            int kananJalat = kana * 2;
            int lehmanJalat = lehma * 4;
            int sianJalat = sika * 4;
            int kaikkienElaintenJalat = kananJalat + lehmanJalat + sianJalat;
            Console.WriteLine("Yhteensä eläimillä on " + kaikkienElaintenJalat + " jalkaa.");
            return kaikkienElaintenJalat;
        }

        public static string tunnitMinuutitSekunnit()
        {
            // ota tästä paivaMaara stringista nykyinen aika ja käännä se matematiikalla minuuteiksi ja sekunneiksi noihin muihin.
            // nyt sellasenaan aika palauttaa pelkät tunnit.
            // muista vielä tarkistaa toimiiko lukujenvälissä metodi oikein.
            // Katso vielä uudestaan mitä kaikkea TimeSpanilla voi tehdä ja DateTime uudestaan.
            string paivaMaara = DateTime.Now.ToShortTimeString();
            Console.WriteLine("Haluatko ajan tunteina, minuutteina vai sekunteina?");
            string ajanMuotoilu = (Console.ReadLine());
            // Tässä alapuolella olevat on vielä kesken. Katso millä tavalla saat ne toimimaan halutulla tavalla ja korjaa ne.
            if (ajanMuotoilu == "tunnit")
            {
                
                Console.WriteLine("Kello on " + paivaMaara + " tunteina.);
                return tunnit;
            }
            else if (ajanMuotoilu == "minuutit")
            {

                string minuutit = paivaMaara;
                Console.WriteLine("Aika on " + minuutit + " sekunneissa.");
                return minuutit;
                /*
                string minuutit = DateTime.Now.Minute.ToString();
                Console.WriteLine("Kello on " + minuutit + " minuutteina.");
                return minuutit;
                */
            }
            else
            {
                string sekunnit = DateTime.Now.Second.ToString();
                Console.WriteLine("Kello on " + sekunnit + " sekunteina.");
                return sekunnit;
            }
        }

    }
   

    
}

