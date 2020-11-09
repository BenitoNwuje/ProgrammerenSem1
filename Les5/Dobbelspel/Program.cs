using System;

namespace Dobbelspel
{
    class Program
    {
        static void DoppelSteen()
        {
            //1
            Console.WriteLine("╔═══════╗");
            Console.WriteLine("║       ║");
            Console.WriteLine("║   *   ║");
            Console.WriteLine("║       ║");
            Console.WriteLine("╚═══════╝");
            Console.WriteLine("╔═══════╗");
            Console.WriteLine("║*      ║");
            Console.WriteLine("║       ║");
            Console.WriteLine("║      *║");
            Console.WriteLine("╚═══════╝");
            //2
            Console.WriteLine("╔═══════╗");
            Console.WriteLine("║*      ║");
            Console.WriteLine("║   *   ║");
            Console.WriteLine("║      *║");
            Console.WriteLine("╚═══════╝");
            //3
            Console.WriteLine("╔═══════╗");
            Console.WriteLine("║*      ║");
            Console.WriteLine("║   *   ║");
            Console.WriteLine("║      *║");
            Console.WriteLine("╚═══════╝");
            //4
            Console.WriteLine("╔═══════╗");
            Console.WriteLine("║*     *║");
            Console.WriteLine("║       ║");
            Console.WriteLine("║*     *║");
            Console.WriteLine("╚═══════╝");
            //5
            Console.WriteLine("╔═══════╗");
            Console.WriteLine("║*     *║");
            Console.WriteLine("║   *   ║");
            Console.WriteLine("║*     *║");
            Console.WriteLine("╚═══════╝");
            //5
            Console.WriteLine("╔═══════╗");
            Console.WriteLine("║*     *║");
            Console.WriteLine("║*     *║");
            Console.WriteLine("║*     *║");
            Console.WriteLine("╚═══════╝");
        }

        static void Main(string[] args)
        {
            //Deel 1

            string doppele1 = @"
            ╔═══════╗
            ║       ║
            ║   *   ║
            ║       ║
            ╚═══════╝";
            string doppele2 = @"
            ╔═══════╗
            ║*      ║
            ║       ║
            ║      *║
            ╚═══════╝";
            string doppele3 = @"
            ╔═══════╗
            ║*      ║
            ║   *   ║
            ║      *║
            ╚═══════╝";
            string doppele4 = @"
            ╔═══════╗
            ║*     *║
            ║       ║
            ║*     *║
            ╚═══════╝";
            string doppele5 = @"
            ╔═══════╗
            ║*     *║
            ║   *   ║
            ║*     *║
            ╚═══════╝";
            string doppele6 = @"
            ╔═══════╗
            ║*     *║
            ║*     *║
            ║*     *║
            ╚═══════╝";


            //deel 1
            DoppelSteen();

            //deel 2
            Random r = new Random();
            int num = r.Next(1, 7);
            int num2 = r.Next(1, 7);
            Console.WriteLine("Je hebt de volgende ogen gegooid");
            switch (num)
            {
                case 1:
                    Console.WriteLine(doppele1);
                    break;
                case 2:
                    Console.WriteLine(doppele2);
                    break;
                case 3:
                    Console.WriteLine(doppele3);
                    break;
                case 4:
                    Console.WriteLine(doppele4);
                    break;
                case 5:
                    Console.WriteLine(doppele5);
                    break;
                case 6:
                    Console.WriteLine(doppele6);
                    break;
                default:
                    break;
            }
            switch (num2)
            {
                case 1:
                    Console.WriteLine(doppele1);
                    break;
                case 2:
                    Console.WriteLine(doppele2);
                    break;
                case 3:
                    Console.WriteLine(doppele3);
                    break;
                case 4:
                    Console.WriteLine(doppele4);
                    break;
                case 5:
                    Console.WriteLine(doppele5);
                    break;
                case 6:
                    Console.WriteLine(doppele6);
                    break;
                default:
                    break;
            }



            Console.WriteLine();
        }
    }
}
