using System;

namespace ForVierkant
{
    class Program
    {
        static void Main(string[] args)
        {
            //For Vierkant 
            Console.WriteLine("For Vierkant");
            Console.WriteLine("Hoeveel steren");
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= input; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
