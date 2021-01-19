using System;
using System.Collections.Generic;
using System.Text;

namespace tiliTehtävä
{
    public class Pankkitili
    {
        private string omistaja;
        private string tilinumero;
        private double saldo;

        public Pankkitili()
        {
            omistaja = "";
            tilinumero = "";
            saldo = 0;
        }

        public Pankkitili(string uusiOmistaja, string uusiTilinumero, double uusiSaldo)
        {
            omistaja = uusiOmistaja;
            tilinumero = uusiTilinumero;
            saldo = uusiSaldo;
        }

        public void Tulosta()
        {
            Console.WriteLine("Tilin omistaja: " + omistaja);
            Console.WriteLine("Tilinumero: " + tilinumero);
            Console.WriteLine("Saldo: " + saldo);
        }

        public string Omistaja
        {
            get
            {
                return omistaja;
            }
            set
            {
                omistaja = value;
            }
        }
        public string Tilinumero
        {
            get
            {
                return tilinumero;
            }
            set
            {
                tilinumero = value;
            }
        }
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
            }
        }

        public void Talleta(double summa)
        {
            saldo += summa;
            Console.WriteLine("Uusi saldo on: " + saldo);
        }

        public void Nosta(double summa)
        {
            if(summa <= saldo)
            {
                saldo -= summa;
                Console.WriteLine("Uusi saldo on: " + saldo);
            }
            else
            {
                Console.WriteLine("Saldosi ei riitä nostoon.");
            }
        }
    }
}
