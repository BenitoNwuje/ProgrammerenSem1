using System;

namespace Palindroom
{
    class Program
    {
        static string TekstOmgekeerd(string input)
        {

            string reverse = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input.Substring(i, 1);
            }
            return reverse;
               
        }
        
        static void PrintstringArray(string[] print)
        {
            Console.WriteLine("Je hebt 5 palindromen ingegeven:");
            for (int i = 0; i < print.Length; i++)
            {
                Console.WriteLine(print[i]);
            }
        }
        static void PrintSystemInfo()
        {
            string pcName = Environment.MachineName;
            string userName = Environment.UserName;
            Console.WriteLine($"De naam van uw pc is: {pcName}");
            Console.WriteLine($"{userName} is uw gebruikersnaam.");
        }
        static void Main(string[] args)
        {
            string[] palindroom = new string[5];
            int count = 0;
            bool test = true;
            Console.WriteLine("De applicatie controleert of een ingegeven woord een palindrrom is of niet...");
            Console.WriteLine("Als je vijf palindromen hebt ingegeven, dan eindigt de applicatie.");
            while (test)
            {
                Console.Write("Geef een woord op om te controleren of het een palindroom is of niet: ");
                string input = Console.ReadLine();
                TekstOmgekeerd(input);

                if (TekstOmgekeerd(input) == input)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("het ingegeven woord is een palindroom");
                    palindroom[count] += input;
                    count++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("het ingegeven woord is GEEN palindroom");
                }
                Console.ForegroundColor = ConsoleColor.Gray;

                if (count == 5)
                {
                    test = false;
                }
                
            }
            PrintstringArray(palindroom);
            PrintSystemInfo();
            Console.WriteLine("Druk op een toest om scherm te sluiten");



        }
    }
}
