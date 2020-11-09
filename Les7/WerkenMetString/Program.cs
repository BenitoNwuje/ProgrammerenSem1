using System;

namespace WerkenMetString
{
    class Program
    {
        static void Main(string[] args)
        {
            string familienaam = "Nwuje";
            string voornaam = "Benito";
            string stad = "Deurne";
            Console.WriteLine("Werken met string");
            Console.WriteLine($"Mijn naam is {voornaam} {familienaam} en ik woon in {stad}");
            Console.WriteLine($"Aantal karakters in voornaam is: {voornaam.Length}");
            Console.WriteLine($"Aantal karakters in familienaam is: {familienaam.Length}");
            Console.WriteLine($"Eerste karakter in familienaam is {familienaam.Substring(0,1)}");
            Console.WriteLine($"Tweede karakter in familienaam is {voornaam.Substring(1,1)}");
            Console.WriteLine($"Derde en vierde karakter in familienaam is {familienaam.Substring(2,2)}");
            Console.WriteLine($"Mijn initialen zijn {voornaam.Substring(0,1)+familienaam.Substring(0,1)}");

            string volledigeNaam = $"{voornaam} {familienaam}";
            Console.WriteLine($"Mijn volledige naam bestaat uit de volgende karkaters:");
            for (int i = 0; i < volledigeNaam.Length; i++)
            {
                Console.WriteLine($"\t de letter {volledigeNaam.Substring(i,1)}");
            }
            string naamOmgekeerd = "";
            for (int i = volledigeNaam.Length -1; i >= 0; i--)
            {
                naamOmgekeerd += volledigeNaam.Substring(i, 1);
            }
            Console.WriteLine($"Mijn volledige naam omgekeerd: {naamOmgekeerd}");
        }
    }
}
