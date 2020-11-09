using System;

namespace DobbelSteenDeel2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string LB = "╔";
            const string RB = "╗";
            const string LO = "╚";
            const string RO = "╝";
            const string HL = "═";
            const string VL = "║";
            const string TEKEN = "*";
            const string SPATIE = " ";

            Random rnd = new Random();

            string eersteSteen = $"{LB}{HL}{HL}{HL}{HL}{HL}{RB}\n" +
            $"{VL}{SPATIE}{SPATIE}{SPATIE}{SPATIE}{SPATIE}{VL}\n" +
            $"{VL}{SPATIE}{SPATIE}{TEKEN}{SPATIE}{SPATIE}{VL}\n" +
            $"{VL}{SPATIE}{SPATIE}{SPATIE}{SPATIE}{SPATIE}{VL}\n" +
            $"{LO}{HL}{HL}{HL}{HL}{HL}{RO}";

            string tweedeSteen = $"{LB}{HL}{HL}{HL}{HL}{HL}{RB}\n" +
            $"{VL}{TEKEN}{SPATIE}{SPATIE}{SPATIE}{SPATIE}{VL}\n" +
            $"{VL}{SPATIE}{SPATIE}{SPATIE}{SPATIE}{SPATIE}{VL}\n" +
            $"{VL}{SPATIE}{SPATIE}{SPATIE}{SPATIE}{TEKEN}{VL}\n" +
            $"{LO}{HL}{HL}{HL}{HL}{HL}{RO}";

            string derdeSteen = $"{LB}{HL}{HL}{HL}{HL}{HL}{RB}\n" +
            $"{VL}{TEKEN}{SPATIE}{SPATIE}{SPATIE}{SPATIE}{VL}\n" +
            $"{VL}{SPATIE}{SPATIE}{TEKEN}{SPATIE}{SPATIE}{VL}\n" +
            $"{VL}{SPATIE}{SPATIE}{SPATIE}{SPATIE}{TEKEN}{VL}\n" +
            $"{LO}{HL}{HL}{HL}{HL}{HL}{RO}";

            string vierdeSteen = $"{LB}{HL}{HL}{HL}{HL}{HL}{RB}\n" +
           $"{VL}{TEKEN}{SPATIE}{SPATIE}{SPATIE}{TEKEN}{VL}\n" +
           $"{VL}{SPATIE}{SPATIE}{SPATIE}{SPATIE}{SPATIE}{VL}\n" +
           $"{VL}{TEKEN}{SPATIE}{SPATIE}{SPATIE}{TEKEN}{VL}\n" +
           $"{LO}{HL}{HL}{HL}{HL}{HL}{RO}";

            string vijfdeSteen = $"{LB}{HL}{HL}{HL}{HL}{HL}{RB}\n" +
           $"{VL}{TEKEN}{SPATIE}{SPATIE}{SPATIE}{TEKEN}{VL}\n" +
           $"{VL}{SPATIE}{SPATIE}{TEKEN}{SPATIE}{SPATIE}{VL}\n" +
           $"{VL}{TEKEN}{SPATIE}{SPATIE}{SPATIE}{TEKEN}{VL}\n" +
           $"{LO}{HL}{HL}{HL}{HL}{HL}{RO}";

            string zesdeSteen = $"{LB}{HL}{HL}{HL}{HL}{HL}{RB}\n" +
          $"{VL}{TEKEN}{SPATIE}{SPATIE}{SPATIE}{TEKEN}{VL}\n" +
          $"{VL}{TEKEN}{SPATIE}{SPATIE}{SPATIE}{TEKEN}{VL}\n" +
          $"{VL}{TEKEN}{SPATIE}{SPATIE}{SPATIE}{TEKEN}{VL}\n" +
          $"{LO}{HL}{HL}{HL}{HL}{HL}{RO}";

            string[] stenen = { eersteSteen, tweedeSteen, derdeSteen, vierdeSteen, vijfdeSteen, zesdeSteen };

            for (int i = 0; i < 2; i++)
            {
                int result = rnd.Next(stenen.Length);

                Console.WriteLine($"{stenen[result]}");
            }
          
   
        }
    }
}
