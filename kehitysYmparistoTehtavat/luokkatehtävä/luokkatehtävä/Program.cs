using System;

namespace luokkatehtävä
{
    class Program
    {
        
        static void Main(string[] args)
        {
        Kirjasto ikiyo = new Kirjasto();
        Console.WriteLine(ikiyo.Nimi);
        ikiyo.Nimi = "ikiyö";
        Console.WriteLine(ikiyo.Nimi);
            //rasitettu constructor
        Kirjasto csharp = new Kirjasto("C#:n perusteet", "M.Smith", 488);
        Console.WriteLine(csharp.Nimi);
        Console.WriteLine(csharp.Nimi + " " + csharp.Kirjailija + " " + csharp.Sivumaara);
        csharp.Sivumaara = 498;
        Console.WriteLine(csharp.Nimi + " " + csharp.Kirjailija + " " + csharp.Sivumaara);
        }
    }
}
