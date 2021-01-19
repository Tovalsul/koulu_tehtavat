using System;

namespace tiliTehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Pankkitili Tony = new Pankkitili("Tony Lehtonen", "FI59 3092 4239 313313313", 50);
            Tony.Tulosta();
            Tony.Nosta(20);
            Tony.Talleta(59);
            Tony.Nosta(200);
        }
    }
}
