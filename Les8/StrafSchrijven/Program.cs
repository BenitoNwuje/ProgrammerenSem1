using System;

namespace StrafSchrijven
{
    class Program
    {
        static void StrafRegels()
        {
            string ste = "ste";
            string de = "de";
            bool opnieuw = true;
            do
            {
                for (int i = 1; i <= 99; i++) { 
                    if (i == 1 || i == 8 || i >= 20)
                    {
                        Console.WriteLine($"{i}{ste} Ik zal zwijgen in de klas");
                    }
                    else
                    {
                        Console.WriteLine($"{i}{de} Ik zal zwijgen in de klas");
                    }
                }

                Console.WriteLine("Wil je nog een keer de straf schrijven j of n");
                string userInput = Console.ReadLine();
                if (userInput != "j" )
                {
                    opnieuw = false;
                }
            }
            while (opnieuw);  
        
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StrafRegels();

        }
    }
}
