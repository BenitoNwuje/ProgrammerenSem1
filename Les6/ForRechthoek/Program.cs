using System;

namespace ForRechthoek
{
    class Program
    {
        static void Main(string[] args)
        {
            //For rechthoek 
            Console.WriteLine("For Rechthoek");
            Console.WriteLine("Hoeveel steren");
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                Console.Write("*");
                for (int j = 1; j <= input * 2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
