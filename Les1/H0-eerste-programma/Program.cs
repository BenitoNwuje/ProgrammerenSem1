using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H0_eerste_programma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef uw naam");
            string naam = Console.ReadLine();
            Console.WriteLine("Geef uw achternaam");
            string achterNaam = Console.ReadLine();
            Console.WriteLine($"Dus je naam is: {achterNaam} {naam}");
            Console.WriteLine($"Of: {naam} {achterNaam}");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Wat is je favoriete kleur?");
            string kleur = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Wat is je favoriete eten?");
            string eten = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Wat is je favoriete auto?");
            string auto = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Wat is je favoriete film?");
            string film = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Wat is je favoriete boek?");
            string boek = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Je favoriete kleur is {kleur}.Je eet graag {auto}.Je lievelingsfilm is {boek} en je favoriete boek is {film}.");



            Console.ReadLine();
        }
    }
}
