using System;

namespace BottlesOfSpa
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottel = 99;
            
            for (int i = bottel; i >= 0; i++)
            {
                Console.WriteLine($"{bottel} bottles of spa on the wall,{bottel} bottles of spa.");
                bottel--;

                if (bottel == 0)
                {
                    Console.WriteLine("No more bottles of spa on the wall, no more bottles of spa.");
                    Console.WriteLine("Go to the store and buy some more, 99 bottles of spa on the wall");
                }
                else
                {
                    Console.WriteLine($"Take one down and pass it around, {bottel} bottles of spa on the wall");

                }
                System.Threading.Thread.Sleep(10000);
                if (bottel == 0)
                {

                    bottel = 99;
                }

            }





        }
    }
}
