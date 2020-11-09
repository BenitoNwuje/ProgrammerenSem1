using System;

namespace H4_ruimte_specifiek
{
    class Program
    {
        enum Planeet {Mercurius = 1, Venus, Aarde, Mars, Jupiter, Saturnus, Uranus, Neptunus, Pluto}
        static void Main(string[] args)
        {
        



            Console.WriteLine("Wat is jouw gewicht");
            Console.Write("> ");
            double userWeigth = double.Parse(Console.ReadLine());
            Console.WriteLine("Voor welke planeet wil je je gewicht kennen?");
            Console.WriteLine($"1. {Planeet.Mercurius}");
            Console.WriteLine($"2. {Planeet.Venus}");
            Console.WriteLine($"3. {Planeet.Aarde}");
            Console.WriteLine($"4. {Planeet.Mars}");
            Console.WriteLine($"5. {Planeet.Jupiter}");
            Console.WriteLine($"6. {Planeet.Saturnus}");
            Console.WriteLine($"7. {Planeet.Uranus}");
            Console.WriteLine($"8. {Planeet.Neptunus}"); 
            Console.WriteLine($"9. {Planeet.Pluto}");

            Console.Write("> ");
            int userChoice = int.Parse(Console.ReadLine());

            double totaal;
            switch (userChoice)
            {
                case (int)Planeet.Mercurius:
                    totaal = 0.38 * userWeigth;
                    Console.WriteLine($"Daar weeg je {totaal}kg.");
                    break;
                case (int)Planeet.Venus:
                    totaal = 0.91 * userWeigth;
                    Console.WriteLine($"Daar weeg je {totaal}kg.");
                    break;
                case (int)Planeet.Aarde:
                    totaal = 1.00 * userWeigth;
                    Console.WriteLine($"Daar weeg je {totaal}kg.");
                    break;
                case (int)Planeet.Mars:
                    totaal = 0.38 * userWeigth;
                    Console.WriteLine($"Daar weeg je {totaal}kg."); 
                    break;
                case (int)Planeet.Jupiter:
                    totaal = 2.34 * userWeigth;
                    Console.WriteLine($"Daar weeg je {totaal}kg."); 
                    break;
                case (int)Planeet.Saturnus:
                    totaal = 1.06 * userWeigth;
                    Console.WriteLine($"Daar weeg je {totaal}kg."); 
                    break;
                case (int)Planeet.Uranus:
                    totaal = 0.92 * userWeigth;
                    Console.WriteLine($"Daar weeg je {totaal}kg.");
                    break;
                case (int)Planeet.Neptunus:
                    totaal = 1.19 * userWeigth;
                    Console.WriteLine($"Daar weeg je {totaal}kg."); 
                    break;
                case (int)Planeet.Pluto:
                    totaal = 0.06* userWeigth;
                    Console.WriteLine($"Daar weeg je {totaal}kg.");
                    break;

                default:
                    Console.WriteLine("Jouw keuze bestaat niet");
                    break;
            }

        }
    }
}
