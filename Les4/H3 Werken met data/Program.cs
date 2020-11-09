using System;

namespace H3_Werken_met_data
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oefening H3 geometric-fun
            Console.WriteLine("Geef een hoek, uitgedrukt in graden.");
            Console.Write("> ");
            int input = Convert.ToInt32(Console.ReadLine());

            double rad = Math.Round(input * (Math.PI / 180), 2);

            Console.WriteLine(value: $"{input} graden is {rad} radialen.");
            double sin = Math.Round(Math.Sin(rad),2);
            double cos = Math.Round(Math.Cos(rad),2);
            double tan = Math.Round(Math.Tan(rad),2);

            Console.WriteLine($"De sinus is {sin}.");
            Console.WriteLine($"De cosinus is {cos}.");
            Console.WriteLine($"De tangens is {tan}.");  

            //oefening h3 BMI berekenaar
            Console.Clear();
            Console.WriteLine("Hoe veel weeg je in kg?");
            Console.Write("> ");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoe groot ben je in m?");
            double meter = Convert.ToDouble(Console.ReadLine());
            double bmi = Math.Round(kilo/meter, 2);
            Console.WriteLine($"je BMI bedraag {bmi}");




            
            //H3-binaire-god 
            Console.WriteLine("Geef een getal.");
            Console.Write("> ");
            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze%2 != 0)
            {
                keuze--;
            }
            Console.WriteLine($"Het getal is nu {keuze}.");
            Console.WriteLine($"Het getal is nu {keuze*=8}.");

            Console.WriteLine("Geef een binaire String.");
            Console.Write("> ");
            string binairInput = Console.ReadLine();
            int binairNum = Convert.ToInt32(binairInput, 2);
            if (binairNum%2 != 0)
            {
                binairNum--;
            }
            string binary = Convert.ToString(binairNum, 2);
            Console.WriteLine($"Het getal is nu {binary}.");
            binairNum *= 8;
            binary = Convert.ToString(binairNum, 2);
            Console.WriteLine($"Het getal is nu {binary}.");

            //H3-op-de-poef 
            Console.WriteLine("Voer bedrag in?");
            Console.Write("> ");
            int poef = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"De pef staat op {poef} euro");
            Console.WriteLine("Voer bedrag in?");
            Console.Write("> ");
            poef += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"De pef staat op {poef} euro");
            Console.WriteLine("Voer bedrag in?");
            Console.Write("> ");
            poef += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"De pef staat op {poef} euro");
            Console.WriteLine("Voer bedrag in?");
            Console.Write("> ");
            poef += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"De pef staat op {poef} euro");
            Console.WriteLine("Voer bedrag in?");
            Console.Write("> ");
            poef += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"De pef staat op {poef} euro");
            Console.WriteLine("********************");
            Console.WriteLine($"Het totaal van de poef is {poef} euro.");
            Console.WriteLine("Dit zal 4 afbetalingen vragen"); //WAAROM 4
            
            //oefening h3 feestkassa 
            Console.WriteLine("Frietjes?");
            Console.Write("> ");
            int frietjes = 20 * Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Koninginnenhapjes?");
            Console.Write("> ");
            int koninginnenhapjes = 10 * Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ijsjes?");
            Console.Write("> ");
            int ijsjes = 3 * Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dranken?");
            Console.Write("> ");
            int dranken =2 * Convert.ToInt32(Console.ReadLine());
            int totaal = frietjes + koninginnenhapjes + ijsjes + dranken;
            Console.WriteLine($"Het totaal te betalen bedrag is {totaal} EURO");
            
            //H3 orakeltje
            Random num = new Random();
            int getal = num.Next(5, 125);
            Console.WriteLine($"je zal nog {getal} jaar leven.");
            //H3 random invoer
            
            Random r = new Random();
            int randomTotal = 0;
            for (int i = 0; i < 5; i++)
            {
                int poefRandom = r.Next(1, 50);
                Console.WriteLine("Voer bedrag in?");
                Console.WriteLine($"Automatisch gegenereerd: {poefRandom}");
                randomTotal += poefRandom;
                Console.WriteLine($"De poef staat op {randomTotal} euro");
            }
            //H3 random invoer
            Console.WriteLine("********************");
            Console.WriteLine($"Het totaal van de poef is {randomTotal} euro.");
            Console.WriteLine("Dit zal 4 afbetalingen vragen"); //WAAROM 4 

            //Oefening: H3-maaltafels-binair
            string bit1 = "1";
            string bit2 = "1001";
            int binair1 = Convert.ToInt32(bit1,2);
            int binair2 = Convert.ToInt32(bit2,2);
            int totaal2 = binair1 * binair2;
            string binaireTotaal = Convert.ToString(totaal2, 2);
            Console.WriteLine($"{bit1} * {bit2} is {binaireTotaal}");
            bit1 = "10";
            bit2 = "110";
            binair1 = Convert.ToInt32(bit1, 2);
            binair2 = Convert.ToInt32(bit2, 2);
            totaal2 = binair1 * binair2;
            binaireTotaal = Convert.ToString(totaal2, 2);
            Console.WriteLine($"{bit1} * {bit2} is {binaireTotaal}");
            bit1 = "11";
            bit2 = "1";
            binair1 = Convert.ToInt32(bit1, 2);
            binair2 = Convert.ToInt32(bit2, 2);
            totaal2 = binair1 * binair2;
            binaireTotaal = Convert.ToString(totaal2, 2);
            Console.WriteLine($"{bit1} * {bit2} is {binaireTotaal}");
            bit1 = "100";
            bit2 = "11";
            binair1 = Convert.ToInt32(bit1, 2);
            binair2 = Convert.ToInt32(bit2, 2);
            totaal2 = binair1 * binair2;
            binaireTotaal = Convert.ToString(totaal2, 2);
            Console.WriteLine($"{bit1} * {bit2} is {binaireTotaal}");
            bit1 = "101";
            bit2 = "111";
            binair1 = Convert.ToInt32(bit1, 2);
            binair2 = Convert.ToInt32(bit2, 2);
            totaal2 = binair1 * binair2;
            binaireTotaal = Convert.ToString(totaal2, 2);
            Console.WriteLine($"{bit1} * {bit2} is {binaireTotaal}");
            bit1 = "110";
            bit2 = "10";
            binair1 = Convert.ToInt32(bit1, 2);
            binair2 = Convert.ToInt32(bit2, 2);
            totaal2 = binair1 * binair2;
            binaireTotaal = Convert.ToString(totaal2, 2);
            Console.WriteLine($"{bit1} * {bit2} is {binaireTotaal}");
            bit1 = "111";
            bit2 = "10";
            binair1 = Convert.ToInt32(bit1, 2);
            binair2 = Convert.ToInt32(bit2, 2);
            totaal2 = binair1 * binair2;
            binaireTotaal = Convert.ToString(totaal2, 2);
            Console.WriteLine($"{bit1} * {bit2} is {binaireTotaal}");
            bit1 = "1000";
            bit2 = "1";
            binair1 = Convert.ToInt32(bit1, 2);
            binair2 = Convert.ToInt32(bit2, 2);
            totaal2 = binair1 * binair2;
            binaireTotaal = Convert.ToString(totaal2, 2);
            Console.WriteLine($"{bit1} * {bit2} is {binaireTotaal}");
            bit1 = "1001";
            bit2 = "110";
            binair1 = Convert.ToInt32(bit1, 2);
            binair2 = Convert.ToInt32(bit2, 2);
            totaal2 = binair1 * binair2;
            binaireTotaal = Convert.ToString(totaal2, 2);
            Console.WriteLine($"{bit1} * {bit2} is {binaireTotaal}");
            bit1 = "1010";
            bit2 = "1000";
            binair1 = Convert.ToInt32(bit1, 2);
            binair2 = Convert.ToInt32(bit2, 2);
            totaal2 = binair1 * binair2;
            binaireTotaal = Convert.ToString(totaal2, 2);
            Console.WriteLine($"{bit1} * {bit2} is {binaireTotaal}");







        }
    }
}
