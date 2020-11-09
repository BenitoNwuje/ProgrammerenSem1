using System;

namespace H6Methoden
{
    class Program
    {
        //H6-veel-kleintjes
        static void Square(int input)
        {
            Console.WriteLine($"Het kwadraat van {input} is {input * input}");
        } // oef 1
        static void Radius(int diameter)
        {
            int berekening = diameter / 2;
            Console.WriteLine($"De straal van een cirkel is {berekening}");
        } //oef 2
        static void Circumference(int diameter)
        {
            double berekening = diameter * Math.PI;

            Console.WriteLine($"The Circumference is {berekening}");
        } //oef 3
        static void Surface(int diameter)
        {
            int r = diameter * 2;
            double berekening = Math.PI * r;
            Console.WriteLine($"The surface is {berekening}");
        }
        static int Largest(int cijfer1, int cijfer2)
        {
            if (cijfer1 > cijfer2)
            {
                return cijfer1;
            }
            else
            {
                return cijfer2;
            }
        } // oef 4
        static bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        } // oef 5

        static void ShowOdd(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if ()
                {

                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //oef 1
            Square(4);
            //oef 2 
            Radius(4);

            //oef 3
            Surface(6);
            Circumference(6);
            //oef 4
            Console.WriteLine($"{Largest(5,6)} is de grootste");
            //oef 5
            IsEven(5);
            Console.WriteLine($"is deze getal even: {IsEven(5)}");
            //oef 6
            ShowOdd(7);

            

        }

    }
}
