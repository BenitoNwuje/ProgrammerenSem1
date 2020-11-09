using System;

namespace TabelMetGetallenVan1Tot100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabel met getallen van 1 tot 100");
            string nummer;
            int tabelNummer = 500;
            for (int i = 1; i <=30; i++)
            {
                for (int j = 1; j <=10; j++)
                {
                    nummer = Convert.ToString(tabelNummer);
                    Console.Write($"{nummer.PadLeft(5)}\t");
                    tabelNummer++;
                }
                Console.Write("\n");
            }
        }
    }
}
