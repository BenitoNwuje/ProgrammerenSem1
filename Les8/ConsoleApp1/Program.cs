using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string voornaam = "Farah";
            string familienaam = "Rahou";
            string lievelingsmuziek = "Hiphop";
            Console.WriteLine($"Mijn voornaam is {voornaam}.\nmijn familienaam is {familienaam}.\nMijn lievelingsmuziek is {lievelingsmuziek}.");
            Console.WriteLine();
            Console.WriteLine($"er zitten {voornaam.Length} letters in mijn voornaam en {familienaam.Length} in mijn familienaam. Totaal er van is = {voornaam.Length + familienaam.Length} ");
            Console.WriteLine($"Eerste karakter in familienaam: {familienaam.Substring(0, 1)}");
            Console.WriteLine($"tweede karakter in familienaam: {familienaam.Substring(1, 1)}");
            Console.WriteLine($"Eerste karakter in voornaam: {voornaam.Substring(0, 1)}");
            Console.WriteLine($"tweede en derde karakter in familienaam: {familienaam.Substring(1, 2)}");
            Console.WriteLine($"laatste karakter in familienaam: {familienaam.Substring(5)}");
            Console.WriteLine($"Initialen : {voornaam.Substring(0, 1)}{familienaam.Substring(0, 1)}");
            Console.WriteLine();
            /* for (int i = 0; i < 6; i++)
             {
                 Console.WriteLine($"\tde letter {familienaam.Substring(i, 1)}");
             }
             Console.WriteLine("");
             int a = 6;
             string samenvoegen = "";
             do
             {

                 a--;

                 samenvoegen += familienaam.Substring(a, 1);
             } while (a != 0);
             Console.WriteLine($"Mijn familienaam omgekeerd: {samenvoegen}");
             Console.ReadKey();
            string reverse = "";

            for (int i = 4; i >= 0; i--)
            {
                reverse += familienaam.Substring(i, 1);
            }

            Console.WriteLine($"Naam omgekeerd is {reverse}"); */

            int getal = 1;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("getal");
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{getal}\t");
                    getal++;
                }
                Console.Write("\n");
            }

        }
    }
}
