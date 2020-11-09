using System;

namespace H7_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //oef1
            //int[] num = new int[11];
            // for (int i = 0; i <=10; i++)
            //{
            //num[i] = i;
            //Console.WriteLine(num[i]);
            //}

            int[] box = new int[101];
            for (int i = 100; i >= 1 ; i--)
            {
                box[i] = i;
                Console.WriteLine(box[i]);
            }

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();


            

            string star = "*";
            for (int i = 0; i <= 30; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{star.PadLeft(5)}\t");
                }
                
            }


        }
    }
}
