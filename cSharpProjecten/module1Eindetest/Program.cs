using System;

namespace module1Eindetest
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int counter = 1;
                bool bitchBye = false;

            
            

            Console.WriteLine("Welke bij Menu kies een item");
            Console.WriteLine("Menuitem 1 - Rekenmachine.");
            Console.WriteLine("Menuitem 2 - Password tester");
            Console.WriteLine("Menuitem 3 -  Recyclage");
            Console.WriteLine("Menuitem 4  - Computersolver");
            int menuChoice = int.Parse(Console.ReadLine());
            switch (menuChoice)
            {
                case 1:
                    //menuItem 1 - rekenmachine 
                    int total = 0;
                    Console.WriteLine("Welcome bij MenuItem 1-Rekenmachine");
                    Console.WriteLine("Geef mijn een getal");
                    int userNum = int.Parse(Console.ReadLine());
                    Console.WriteLine("Geef mij een tweede getal");
                    int userNumTwo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Welke operator kiest u");
                    Console.WriteLine("+, -, *, /, %");
                    string userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "+":
                            total = userNum + userNumTwo;
                            if (total <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            Console.WriteLine(total);
                            break;
                        case "-":
                            total = userNum - userNumTwo;
                            if (total <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            Console.WriteLine(total);
                            break;
                        case "*":
                            total = userNum * userNumTwo;
                            if (total <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            Console.WriteLine(total);
                            break;
                        case "/":
                            total = userNum / userNumTwo;
                            if (total <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            Console.WriteLine(total);
                            break;
                        case "%":
                            total = userNum % userNumTwo;
                            if (total <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            Console.WriteLine(total);
                            break;
                        default:
                            Console.WriteLine("Jouw input bestaat niet");
                            break;
                    }
                    break;
                case 2:
                    //menuitem 2 - passwoord tester 
                    Console.WriteLine("Welkome bij MenuItem 2 - Password tester");
                    Console.WriteLine("Geef mij jouw paswoord ");
                    string userPas = Console.ReadLine();
                    if (userPas != "TrumpSux")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Verboden");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Toegelaten");
                    }
                    break;
                case 3:
                    Console.WriteLine("Welkome bij MenuItem 3 - Recyclage ");

                    Console.WriteLine("Ain't nobody got time for that");
                    break;
                case 4:
                    Console.WriteLine("Welkome bij MenuItem 4 - Computersolver");
                    Console.WriteLine("Does the computer turn on? j or n");
                    string userAnswer = Console.ReadLine();
                    if (userAnswer != "j")
                    {
                        Console.WriteLine("Is the computer power light on?");
                        userAnswer = Console.ReadLine();
                        if (userAnswer != "j")
                        {
                            Console.WriteLine("Check the computer power cord");
                        }
                        else
                        {
                            Console.WriteLine("Turn the computer monitor on");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Are there any error messages?");
                        userAnswer = Console.ReadLine();
                        if (userAnswer != "j")
                        {
                            Console.WriteLine("Computer is fine");

                        }
                        else
                        {
                            Console.WriteLine("Perform a search for the error message");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Jouw keuze bestaat niet, opnieuw dan");
                    break;
            }
                Console.WriteLine("No een keer ja of nee bitch??");
                if (counter == 2)
                {
                    Console.WriteLine("Sorry bitch opnieuw");
                    Console.ReadLine();

                }
                else if (counter == 3)
                {
                    Console.WriteLine("Bitch jij hou van deze spelletje bye bitch");
                    Console.ReadLine();
                    bitchBye = false;

                }
            } while (bi);

        }
    }
}
