using System;

namespace ControleVanDeInvoer
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = true;
            int juistGetal = 0;
            double totaalJuist = 0;
            int foutieveGetal = 0;
            double totaalFout = 0;

            do
            {
                Console.WriteLine("Controle van de invoer");
                Console.Write("Voer een getal in tussen 100.0 tot en met 120.0: ");
                double userInput = double.Parse(Console.ReadLine());
                if (userInput >= 100 && userInput <= 120)
                {
                    juistGetal++;
                    totaalJuist += userInput;
                }
                else
                {
                    foutieveGetal++;
                    totaalFout += userInput;
                }
                Console.Write("Meer getallen invoerenn ? (j of n): ");
                string input = Console.ReadLine();
                if (input == "n")
                {
                    stop = false;
                }

            } while (stop);
            Console.WriteLine($"Er zijn {juistGetal} geldig(e) en {foutieveGetal} getallen ingevoerd.");
            Console.WriteLine($"De totale som van geldige getallen is {totaalJuist} en van ongeldige getallen is {totaalFout} ");
        }
    }
}
