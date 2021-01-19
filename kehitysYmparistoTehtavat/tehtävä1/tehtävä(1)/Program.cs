using System;
using System.ComponentModel.DataAnnotations;

namespace tehtävä_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            laskeYhteen(7, 5);
            fahrenheiteiksi(10);
            neljaLaskuToimitusta(2, 8);
            jakojaannos(10, 3);
            vali("");
            tervehdys("EtuNimi");
            vali("");
            kayttajaLaskeeYhteen(0, 0);
            vali("");
            kayttajaFahrenheit(0);
            vali("");
            kayttajaCelsius(0);
            vali("");
            kayttajaNeljaLaskua(0, 0);
            vali("");
            kayttajaJakojaannos(0, 0);
            vali("");
            kayttajaKertotaulu(0);
            vali("");
            kayttajaIka(0);
            vali("");
            kayttajaIsompiKuin10(0);
            vali("");
            kayttajaKirjaintenVaihto("");
            vali("");
            kayttajaPosNeg(0, 0);
            vali("");
            //kayttajanPisinSana();
            vali("");
        }

        public static void vali(string tyhja)
        {
            Console.WriteLine("\n ------------------------------------------------------------------ \n");

        }

        public static void laskeYhteen(int luku1, int luku2)
        {
            int summa = luku1 + luku2;
            Console.WriteLine("Lukujen {0} ja {1} summa on {2}", luku1, luku2, summa);
        }

        public static void fahrenheiteiksi(int celsius)
        {
            double fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine(celsius + " Celsiusastetta on " + fahrenheit + " fahrenheitia");
        }

        public static void neljaLaskuToimitusta(double luku1, double luku2)
        {
            double summa = luku1 + luku2;
            Console.WriteLine("Lukujen {0} ja {1} summa on {2}", luku1, luku2, summa);
            double erotus = luku1 - luku2;
            Console.WriteLine("Lukujen {0} ja {1} erotus on {2}", luku1, luku2, erotus);
            double tulo = luku1 * luku2;
            Console.WriteLine("Lukujen {0} ja {1} tulo on {2}", luku1, luku2, tulo);
            double osamaara = luku1 / luku2;
            Console.WriteLine("Lukujen {0} ja {1} osamäärä on {2}", luku1, luku2, osamaara);
        }

        public static void jakojaannos(double luku1, double luku2)
        {
            double jaonjaama = luku1 % luku2;
            Console.WriteLine("Lukujen {0} ja {1} jakojäännös on {2}", luku1, luku2, jaonjaama);
        }

        public static void tervehdys(string nimi)
        {
            Console.WriteLine("Kerro etunimesi");
            string etuNimi = Console.ReadLine();
            Console.WriteLine("Terve " + etuNimi + "!");
        }

        public static void kayttajaLaskeeYhteen(double luku1, double luku2)
        {
            
            Console.WriteLine("Anna ensimmäinen luku");
            luku1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Anna Toinen luku");
            luku2 = double.Parse(Console.ReadLine());
            double summa = luku1 + luku2;
            Console.WriteLine("Lukujen " + luku1 +  " ja " + luku2 + " summa on " + summa, luku1, luku2, summa);
          
        }

        public static void kayttajaFahrenheit(int celsius)
        {
            Console.WriteLine("Anna käännettävä celsiusaste jonka haluat kääntää fahrenheiteiksi.");
            celsius = int.Parse(Console.ReadLine());
            double fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine(celsius + " Celsiusastetta on " + fahrenheit + " fahrenheitia");
        }

        public static void kayttajaCelsius(int fahrenheit)
        {
            Console.WriteLine("Anna käännettävä fahrenheitaste jonka haluat kääntää celsiusasteiksi.");
            fahrenheit = int.Parse(Console.ReadLine());
            double celsius = (fahrenheit -32) * 0.5559;
            Console.WriteLine(fahrenheit + " Fahrenheitastetta on " + celsius + " celsiusta");

        }

        public static void kayttajaNeljaLaskua(double luku1, double luku2)
        {
            Console.WriteLine("Anna ensimmäinen kokonaisluku jolla  haluat laskea summan, erotuksen, osamäärän ja tulon.");
            // Pitää katsoa vielä miten tää tarkistus tehdään niin että se palaa kysymään ensimmäistä lukua.
            try
            {
                luku1 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Syöttämäsi luku ei ole kokonaisluku!");
            }
            Console.WriteLine("Anna toinen kokonaisluku jolla  haluat laskea summan, erotuksen, osamäärän ja tulon.");
            luku2 = int.Parse(Console.ReadLine());
            double summa = luku1 + luku2;
            Console.WriteLine("Lukujen " + luku1 + " ja " + luku2 + " summa on " + summa, luku1, luku2, summa);
            double erotus = luku1 - luku2;
            Console.WriteLine("Lukujen " + luku1 + " ja " + luku2 + " erotus on " + erotus, luku1, luku2, erotus);
            double osamaara = luku1 / luku2;
            Console.WriteLine("Lukujen " + luku1 + " ja " + luku2 + " osamäärä on " + osamaara, luku1, luku2, osamaara);
            double tulo = luku1 * luku2;
            Console.WriteLine("Lukujen " + luku1 + " ja " + luku2 + " tulo on " + tulo, luku1, luku2, tulo);
        }

        public static void kayttajaJakojaannos(double luku1, double luku2)
        {
            Console.WriteLine("Anna ensimmäinen jaettava luku.");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen jaettava luku.");
            luku2 = int.Parse(Console.ReadLine());
            double jaonjaama = luku1 % luku2;
            Console.WriteLine("Lukujen " + luku1 + " ja " + luku2 + " jakojäännös on " + jaonjaama, luku1, luku2, jaonjaama);
        }

        public static void kayttajaKertotaulu(int luku)
        {
            int taulukko; 
            Console.WriteLine("Anna yksi kokonaisluku 1-10 väliltä.");
            luku = int.Parse(Console.ReadLine());
            for(taulukko=1; taulukko<=10; taulukko++)
            {
                Console.WriteLine("{0} luku {1} = {2}", luku, taulukko, luku*taulukko);
            }

        }
        
        public static void kayttajaIka(int ika)
        {
            Console.WriteLine("Kuinka vanha olet? \n");
            ika = int.Parse(Console.ReadLine());
            Console.WriteLine("\n" + ika + "? Näytät ikäistäsi nuoremmalta.");

        }

        public static void kayttajaIsompiKuin10(int luku)
        {
            int luvut;
            Console.WriteLine("Voisitko antaa 10 suuremma kokonaisluvun? Pyydän...");
            luku = int.Parse(Console.ReadLine());
            for(luvut=1; luvut<=luku; luvut++)
            {
                Console.WriteLine("\n" + luku, luku);
            }

        }

        public static void kayttajaKirjaintenVaihto(string sana)
        {
            Console.WriteLine("Anna jokin sana tai nimi");
            sana = (Console.ReadLine());
            Console.WriteLine(sana.Substring(sana.Length - 1) + sana.Trim(sana[0], sana[sana.Length - 1]) + sana[0]) ;


        }

        public static void kayttajaPosNeg(int luku1, int luku2)
        {
            Console.WriteLine("Anna ensimmäinen luku kahdesta luvusta joista haluat tarkistaa niiden positiivisuuden tai negatiivisuuden.");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Antaisitko vielä toisen luvun tarkistettavaksi?");
            luku2 = int.Parse(Console.ReadLine());
            if(luku1 < 0 && luku2 <0)
            {
                Console.WriteLine("Molemmat ovat negatiivisia.");
            } else if(luku1 >= 0 && luku2 >= 0)
            {
                Console.WriteLine("Molemmat ovat positiivisia.");
            } else
            {
                Console.WriteLine("Toinen on positiivinen ja toinen on negatiivinen.");
            }


        }

        /*public static void kayttajanPisinSana(string[] lause)
        {
            Console.WriteLine("Kirjoita jokin lause. Otan siitä pisimmän sanan.");
            lause = Console.ReadLine();
            var pisin = "";
            foreach (var item in strArr)
            {
                if (item.Length > pisin.Length)
                    pisin = item;
            }

        }*/
    }   
     
}
