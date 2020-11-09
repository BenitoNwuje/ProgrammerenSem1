using System;

namespace H5Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int num = 1;
            //De opwarmers
            //oef 8
            while (num <= 100)
            {
                Console.WriteLine(num);
                num++;
            }
            //oef 9
            num = -100;
            while (num <= 100)
            {
                Console.WriteLine(num);
                num++;
            }
            //oef 10
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
            }
            //oef 11
            for (int i = -100; i < 101; i++)
            {
                Console.WriteLine(i);
            }

            //oef 12
            num = 1;
            while (num <= 100)
            {
                if (num % 6 == 0 || num % 8 == 0 )
                {
                    Console.WriteLine(num);

                }
                num++;
            }

            //oef 13
            for (int i = 1; i < 100; i++)
            {
                if (i % 6 == 0 || i % 8 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            

            //Tafels van vermingvuldigen 
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine($"De tafel van {i}");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} X {j} = {i * j}");
                }
                Console.WriteLine("-".PadRight(20, '-'));

            }
            //RNA Transscriptie
            string input;
            string script = "";
            counter = 0;
            do
            {
                Console.WriteLine("Geef een DNA-nucleotide");
                Console.WriteLine("Gebruik een Hoofdletter");
                
                input = Console.ReadLine();

                switch (input)
                {
                    case "G":
                        script += "C";
                        break;
                    case "C":
                        script += "G";
                        break;
                    case "T":
                        script += "A";
                        break;
                    case "A":
                        script += "U";
                        break;
                    default:
                        break;
                }
                if (counter == 11)
                {
                    Console.WriteLine("Wil je stoppen Ja of Nee");
                    input = Console.ReadLine();
                    if (input == "Nee")
                    {
                        counter = 0;
                    }
                }
                counter++;

            } while (counter <= 11);
            Console.WriteLine(script);   

            //Pro Armstrong Nummer 
            Console.WriteLine("Geef mij een nummer");
            int userInput = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = userInput; i > 0; i = i / 10)
            {
                sum = sum + (int)Math.Pow(i % 10, 3.00);
            }

            if (userInput == sum)
            {
                Console.WriteLine("Armstrong Number.");

            }
            else
            {
                Console.WriteLine("Not Armstrong Number.");

            } */

            //Euler Project

            /*
            int totaal = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                    
                }
                totaal += i;
            }
            Console.WriteLine(totaal);


            int rowHeight = 5;
            for (int row = 1; row <= rowHeight; row++)
            {
                int totalSpaces = rowHeight - row;
                for (int j = 0; j < totalSpaces; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < row; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine(); 

            //PRO For doordenker 
            Console.WriteLine("Hoeveel sterren?");
            int aantal = int.Parse(Console.ReadLine());
            Console.WriteLine("For doordenker");
            for (int i = 1; i <= aantal; i++) // buitste loop lijn na lijn zorgt voor de lijnen 
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write("*"); //binneste loop print de aantal steren op een lijn 
                }
                Console.WriteLine();
            }
            for (int i = aantal - 1; i > 0; i--) // print de onderkant van de lijn 
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Oefening Deel 2
            //1 
            Console.WriteLine("Oef 1");
            Console.WriteLine("Geef een getal");
            int gebruiker = int.Parse(Console.ReadLine());
            for (int i = 1; i <= gebruiker; i++)
            {
                Console.WriteLine(i);
            }
            //2
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Oef 2");
            Console.WriteLine("Geef mij een cijfer");
            int cijfer = int.Parse(Console.ReadLine());
            for (int i = cijfer; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            Console.Clear();

            //oef 3
            Console.WriteLine("even getallen tussen 1 en 100");
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
            Console.Clear();

            //oef 4
            Console.WriteLine("oneven getallen tussen 1 en 100");
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            //oef 5
           
            Console.WriteLine("som van 1 tot n");
            Console.WriteLine("geef mij een cijfer");
            int input5 = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 1; i <= input5; i++)
            {
                total += i;
            }
            Console.WriteLine($"De som is {total}");
            
            //oef 6 
            Console.WriteLine("Toon de som van even getalen van 1 tot n");
            int input6 = int.Parse(Console.ReadLine());
            int sumEven = 0;
            for (int i = 1; i <=input6; i++)
            {
                if (i % 2 == 0)
                {
                    sumEven += i;
                }
            }
            Console.WriteLine($"De som even getallen is {sumEven} ");

            //oef 7
            Console.WriteLine("Toon de som van oneven getalen van 1 to n");
            int input7 = int.Parse(Console.ReadLine());
            int sumOneven = 0;
            for (int i = 1; i < input7; i++)
            {
                if (i % 2 == 1)
                {
                    sumOneven += 1;
                }
            }
            //oef 8

            Console.WriteLine("Geef mij een cijfer");
            int input8 = int.Parse(Console.ReadLine());
            int numHouder = input8;
            int count8 = 0;
            do
            {
                input8 = input8 / 10;
                count8++;

            } while (input8 > 1);
            Console.WriteLine($"Deze nummer {numHouder}");
            Console.WriteLine($"Bevat {count8} digits");
            */

            //oef 11 alfa 
            for (int i = 0; i < 26; i++)
            {
                char alfa = Convert.ToChar(65 + i);
                Console.WriteLine(alfa);
                
            }


        }


    }
}
