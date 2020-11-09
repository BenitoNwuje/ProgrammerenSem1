using System;

namespace ForDoordenkerExtra
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("For doordenker extra");
            int aantal = 3;
            for (int i = 1; i <= aantal ; i++)
            {
                for (int j = 1; j < aantal - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }






        }
    }
}
