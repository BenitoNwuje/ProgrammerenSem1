using System;

namespace H4_Beslissingen
{
    class Program
    {
       
        static void Main(string[] args)
        {
            /* 
            //BMI met if
            Console.Clear();
            Console.WriteLine("Hoe veel weeg je in kg?");
            Console.Write("> ");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoe groot ben je in m?");
            double meter = Convert.ToDouble(Console.ReadLine());
            double bmi = Math.Round(kilo / meter, 2);
            Console.WriteLine($"je BMI bedraag {bmi}");

            if (bmi < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ondergewicht");
            }
            else if (bmi > 18.5 && 24.9 > bmi)
            {
                Console.ForegroundColor = ConsoleColor.Green;     
                Console.WriteLine("Normaal Gewicht");
            }
            else if (bmi > 25 && 29.9 > bmi)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Overgewicht");
            }
            else if (bmi > 30 && 39.9 > bmi)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("waarlijvigheid (obesitas). Verhoogde kans op allerlei aandoeningen zoals diabetes, hartaandoeningen en rugklachten. Je zou 5 tot 10 kg moeten vermageren.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("ernstige zwaarlijvigheid. Je moet dringend vermageren want je gezondheid is in gevaar (of je hebt je lengte of gewicht in verkeerde eenheid ingevoerd)");
            }


           //Schoenverkoper

             Console.Clear();
             Console.WriteLine("U krijgt korting van een specifiek paar");
             int input1 = int.Parse(Console.ReadLine());
             Console.WriteLine("Hoeveel paar schoenen wenst te kopen");
             int input = int.Parse(Console.ReadLine());
             if (input == 10 || input1 == 5)
             {
                 input *= 10;
             }
             else
             {
                 input *= 20;
             }
             Console.WriteLine($"De totale prijs {input}");


             int stroom;
             int weerstand;
             int spanning;
             int berekening;
             //Ohm - berkenaar 
             Console.WriteLine("Wat wenst u te berekenen: Spanning is span, Weerstand is weer of Stroomsterkte is stroom");
             string berekeningInput = Console.ReadLine();
             switch (berekeningInput)
             {
                 case "span":
                     Console.WriteLine("geef mij een stroom waarde ");
                     stroom = int.Parse(Console.ReadLine());
                     Console.WriteLine("geef mij een weerstand waarde ");
                     weerstand = int.Parse(Console.ReadLine());
                     berekening = stroom * weerstand;
                     Console.WriteLine($"Jouw voltage is {berekening}");
                     break;
                 case "weer":
                     Console.WriteLine("geef mij een spanning waarde ");
                     spanning = int.Parse(Console.ReadLine());
                     Console.WriteLine("geef mij een stroom waarde ");
                     stroom = int.Parse(Console.ReadLine());
                     berekening = spanning / stroom;
                     Console.WriteLine($"Jouw voltage is {berekening}");
                     break;
                 case "stroom":
                     Console.WriteLine("geef mij een spanning waarde ");
                     spanning = int.Parse(Console.ReadLine());
                     Console.WriteLine("geef mij een weerstand waarde ");
                     weerstand = int.Parse(Console.ReadLine());
                     berekening = spanning / weerstand;
                     Console.WriteLine($"Jouw voltage is {berekening}");
                     break;
                 default:
                     Console.WriteLine("Uw keuze bestaad niet");
                     break;
             }
             //Kleurcode weerstand naar ohm
             Console.WriteLine("Geef mij de eerste 3 kleuren van jouw ring");
             int userInput = int.Parse(Console.ReadLine());


             //Orakeltje van Delphi, part deux
             Random num = new Random();
             int getal = num.Next(5, 125);
             int userAge;


             Console.WriteLine("Ben jij Man of Vrouw");
             string GenderInput = Console.ReadLine();
             if (GenderInput == "v")
             {
                 Console.WriteLine("Wat is uw leeftijd");
                 userAge = int.Parse(Console.ReadLine());
                 getal = num.Next(userAge, 150);
                 Console.WriteLine($"je zal nog {getal} jaar leven.");

             }
             else if (GenderInput == "m")
             {
                 Console.WriteLine("Wat is uw leeftijd");
                 userAge = int.Parse(Console.ReadLine());
                 getal = num.Next(userAge, 120);
                 Console.WriteLine($"je zal nog {getal} jaar leven.");
             }
             else
             {
                 Console.WriteLine("Jouw keuze bestaat niet");
             }
             //Quiz
             Console.ForegroundColor = ConsoleColor.Cyan;
             Console.WriteLine("Vraag 1: Wat is mijn naam");
             Console.WriteLine("a: Benoit");
             Console.WriteLine("b: Ben");
             Console.WriteLine("c: Benito");
             Console.WriteLine("d: Nito");
             int punt = 0;
             bool question = false;
             string quizQuestion1 = Console.ReadLine();
             switch (quizQuestion1)
             {
                 case "a":
                     Console.Clear();
                     question = false;
                     punt = -1;
                     Console.WriteLine($"Jouw antwoord was {question}");
                     break;
                 case "b":
                     Console.Clear();
                     punt = -1;
                     question = false;
                     Console.WriteLine($"Jouw antwoord was {question}");
                     break;
                 case "c":
                     punt = 2;
                     question = true;
                     Console.Clear();
                     Console.WriteLine($"Jouw antwoord was {question}");
                     break;
                 case "d":
                     Console.Clear();
                     punt = -1;
                     question = false;
                     Console.WriteLine($"Jouw antwoord was {question}");
                     break;
                 default:
                     break;
             }
             Console.ForegroundColor = ConsoleColor.Red;
             Console.BackgroundColor = ConsoleColor.White;
             Console.WriteLine("Vraag 2: Wat is mijn leeftijd");
             Console.WriteLine("a: 20");
             Console.WriteLine("b: 16");
             Console.WriteLine("c: 18");
             quizQuestion1 = Console.ReadLine();
             switch (quizQuestion1)
             {
                 case "a":
                     punt += 2;
                     question = true;
                     Console.WriteLine($"Jouw antwoord was {question}");
                     break;
                 case "b":
                     punt += -1;
                     question = false;
                     Console.WriteLine($"Jouw antwoord was {question}");
                     break;
                 case "c":
                     punt += -1;
                     question = false;
                     Console.WriteLine($"Jouw antwoord was {question}");                    
                     break;
                 default:
                     break;
             }

             Console.ForegroundColor = ConsoleColor.White;
             Console.BackgroundColor = ConsoleColor.DarkBlue;
             Console.WriteLine("Vraag 3: Wat is Mijn lievelings  kleur");
             Console.WriteLine("a: Groen");
             Console.WriteLine("b: Paars");
             Console.WriteLine("c: Blauw");
             quizQuestion1 = Console.ReadLine();
             switch (quizQuestion1)
             {
                 case "a":
                     punt += -1;
                     question = true;
                     Console.WriteLine($"Jouw antwoord was {question}");
                     break;
                 case "b":
                     punt += -1;
                     question = false;
                     Console.WriteLine($"Jouw antwoord was {question}");
                     break;
                 case "c":
                     punt += 2;
                     question = true;
                     Console.WriteLine($"Jouw antwoord was {question}");
                     break;
                 default:
                     break;
             }
             Console.WriteLine($"Jouw totale score is {punt}");
             

            //Schrikkeljaar 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Geef een jaartal in");
                int yearInput = int.Parse(Console.ReadLine());
                if ((yearInput % 400) == 0)
                {
                    Console.WriteLine($"{yearInput} is een schrikkeljaar");
                }
                else if ((yearInput % 100) == 0)
                {
                    Console.WriteLine($"{yearInput} is niet een schrikkeljaar");

                }
                else if ((yearInput % 4) == 0)
                {
                    Console.WriteLine($"{yearInput} is een schrikkeljaar");

                }
                else
                {
                    Console.WriteLine($"{yearInput} is niet een schrikkeljaar");
                }

            }
            */
            
                //GuntherD Stemwijzer
                Console.WriteLine("Werk je veel? ja of nee");
                string InputStemWijzer = Console.ReadLine();
                if (InputStemWijzer == "nee")
                {
                    Console.WriteLine("Eet je vaak Quinoa?");
                    InputStemWijzer = Console.ReadLine();
                    if (InputStemWijzer == "ja")
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Groen");
                    }
                    else if (InputStemWijzer == "nee")
                    {
                        Console.WriteLine("Krijg je vaak de schuld van alles?");
                        InputStemWijzer = Console.ReadLine();
                        if (InputStemWijzer == "ja")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.WriteLine("SP.a");
                        }
                        else if (InputStemWijzer == "nee")
                        {
                            Console.WriteLine("Geloof je nog in Sinterklaas?");
                            InputStemWijzer = Console.ReadLine();
                            if (InputStemWijzer == "ja")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.WriteLine("PVDA");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Eerst de mensen, niet de winst");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.WriteLine("Blanco");
                            }
                        }

                    }

                }
                else 
                if (InputStemWijzer == "ja")
                {
                    Console.WriteLine("Koop je soms bruin brood");
                    InputStemWijzer = Console.ReadLine();
                    if (InputStemWijzer == "ja")
                    {
                        Console.WriteLine("Ben je een seut?");
                        InputStemWijzer = Console.ReadLine();
                        if (InputStemWijzer == "ja")
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("CD&V");

                        }
                        else if (InputStemWijzer == "nee")
                        {
                            Console.WriteLine("Heb je vrienden?");
                            InputStemWijzer = Console.ReadLine();
                            if (InputStemWijzer == "ja")
                            {
                                Console.WriteLine("Staat jouw wagen, huis, ... op naam van jouw ouders?");
                                InputStemWijzer = Console.ReadLine();
                                if (InputStemWijzer == "ja")
                                {
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Write("open");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine("vld");
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.BackgroundColor = ConsoleColor.White;
                                    Console.WriteLine("Blanco");
                                }
                            }
                            else if (InputStemWijzer == "nee")
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("NV");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("*");
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("A");
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("");
                                Console.WriteLine("DENKEN.DURVEN.DOEN");
                            }
                        }
                        {

                        }
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Vlaams Belang");
                    }

                }
            
            
            











        }
    }
}
