using System;

namespace ArmStrong
{
    class Program
    {
        static void Main(string[] args)
        {
            //ik heb een variable aan gemaakt 
            Console.WriteLine("Geef mij een nummer");
            int userInput = int.Parse(Console.ReadLine());

            //stap 1 mijn for loop neemt mijn userinput als inhoud en bekijkt of die grooter is dan 0 
            //stap 2 dan deelt ik die i door 10 en slaag ik die op in een sum 
            //stap 3 wat er gebeurt in sum is dat ik de rest overhoud van i en die maal 3 gaat doen en houdt die bij 
            //stap 4 loopt die opnieuw en gaat die naar de volgende cijfer tot ales geloopt is 

            int sum = 0;
            for (int i = userInput; i > 0; i = i / 10)
            {
                Console.WriteLine(i);
                 sum = sum + (int)Math.Pow(i % 10, 3.00);
            }
            Console.ReadKey();

//stap 5 bekijkt of userinput en sum gelijk zijn 
            if (userInput == sum)
            {
                Console.WriteLine("Armstrong Number.");

            }
            else
            {
                Console.WriteLine("Not Armstrong Number.");

            }
            Console.ReadLine();


        }
    }
}
