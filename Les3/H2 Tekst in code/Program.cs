using System;
using System.IO;

namespace H2_Tekst_in_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Oefening: H2-systeem-informatie
            /*
             bool is64bit = Environment.Is64BitOperatingSystem;
             string pcName = Environment.MachineName;
             int proCount = Environment.ProcessorCount;
             string userName = Environment.UserName;
             long memory = Environment.WorkingSet;

             Console.WriteLine($"Uw computer heeft een 64-bit besturingssysteem: {is64bit}");
             Console.WriteLine($"De naam van uw pc is: {pcName}");
             Console.WriteLine($"Uw pc heeft {proCount} processorkernen.");
             Console.WriteLine($"{userName} is uw gebruikersnaam.");
             Console.WriteLine($"Je gebruikt {memory} bytes aan geheugen");

             //Oefening: H2-systeem-informatie-pro
             long cDriveInBytes = DriveInfo.GetDrives()[0].AvailableFreeSpace;
             long totalSize = DriveInfo.GetDrives()[0].TotalSize;

             Console.WriteLine($"Vrije ruimte op jouw c-schijf: {cDriveInBytes}");
             Console.WriteLine($"Totale ruimte van jouw c-schijf:{totalSize}");
             Console.Write("Geef met nummer 1 t/m ... aan over welke harde schijf van jouw pc je info wenst:");
             int input = Convert.ToInt32(Console.ReadLine()) - 1;
             long totalSize2 = DriveInfo.GetDrives()[input].TotalSize;
             Console.WriteLine($"De vrije ruimte van C:\\ is {totalSize2} Gb");
            
            //Oefening: H2-weerstandberekenaar-deel1
            Console.Write("Geef de waarde (uitgedrukt in een getal van 0 tot 9) van de eerste ring: ");
            string ring1 = Console.ReadLine();
            Console.Write("Geef de waarde (uitgedrukt in een getal van 0 tot 9) van de tweede ring: ");
            string ring2 = Console.ReadLine();
            Console.Write("Geef de waarde (uitgedrukt in een getal van 0 tot 9) van de derde ring (exponent): ");
            int ring3 = Convert.ToInt32(Console.ReadLine());
            string ring = ring1 + ring2;
            int totaal = Convert.ToInt32(ring);
            double resulaat = totaal * Math.Pow(10, ring3);
            Console.WriteLine($"Resultaat is {resulaat} Ohm, ofwel {totaal}x{Math.Pow(10, ring3)}.");
            
            //Oefening: H2-weerstandberekenaar-deel2

            Console.WriteLine("╔══════╦══════╦══════╦══════════════╗");
            Console.WriteLine("║ring1 \tring2\tring3\tTotaal(Ohm)");
            Console.WriteLine("╟──────╫──────╫──────╫──────────────╢ ");
            Console.WriteLine($"║ {ring1}\t{ring2}\t{ring3}\t{resulaat} Ohm");
            Console.WriteLine("╚══════╩══════╩══════╩══════════════╝");
             
            //Oefening: H2-shell-starter
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "ipconfig";
            process.StartInfo.Arguments = "/all";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start(); //start process

            // Read the output (or the error)
            string output = process.StandardOutput.ReadToEnd();
            Console.WriteLine(output);
            string err = process.StandardError.ReadToEnd();
            Console.WriteLine(err);
            //Continue
            Console.WriteLine("Klaar");
            Console.ReadLine();
            Console.Clear();
            //hostname
            process.StartInfo.FileName = "hostname";
            process.StartInfo.Arguments = "";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start(); //start process
            output = process.StandardOutput.ReadToEnd();
            Console.WriteLine(output);
            err = process.StandardError.ReadToEnd();
            Console.WriteLine(err);
            //Continue
            Console.WriteLine("Klaar");
            Console.ReadLine();
            Console.Clear();
            //arp -a
            process.StartInfo.FileName = "arp";
            process.StartInfo.Arguments = " -a";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start(); //start process
            output = process.StandardOutput.ReadToEnd();
            Console.WriteLine(output);
            err = process.StandardError.ReadToEnd();
            Console.WriteLine(err);
            //Continue
            Console.WriteLine("Klaar");
            Console.ReadLine();
            Console.Clear();
            //getmac
            process.StartInfo.FileName = "getmac";
            process.StartInfo.Arguments = "";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start(); //start process
            output = process.StandardOutput.ReadToEnd();
            Console.WriteLine(output);
            err = process.StandardError.ReadToEnd();
            Console.WriteLine(err);
            //Continue
            Console.WriteLine("Klaar");
            Console.ReadLine();
            Console.Clear();
            //nslookup
            process.StartInfo.FileName = "nslookup";
            process.StartInfo.Arguments = "google.com";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start(); //start process
            output = process.StandardOutput.ReadToEnd();
            Console.WriteLine(output);
            err = process.StandardError.ReadToEnd();
            Console.WriteLine(err);
            //Continue
            Console.WriteLine("Klaar");
            Console.ReadLine();
            Console.Clear();

            //netstat
            process.StartInfo.FileName = "netstat";
            process.StartInfo.Arguments = "";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start(); //start process
            output = process.StandardOutput.ReadToEnd();
            Console.WriteLine(output);
            err = process.StandardError.ReadToEnd();
            Console.WriteLine(err);
            //Continue
            Console.WriteLine("Klaar");
            Console.ReadLine();
            Console.Clear();

            */

           
            //Oefening: H2-weerstandsberekendaar-deel3
            Console.Write("Geef de waarde (uitgedrukt in een getal van 0 tot 9) van de eerste ring: ");
            string ring1 = Console.ReadLine();
            Console.Write("Geef de waarde (uitgedrukt in een getal van 0 tot 9) van de tweede ring: ");
            string ring2 = Console.ReadLine();
            Console.Write("Geef de waarde (uitgedrukt in een getal van 0 tot 9) van de derde ring (exponent): ");
            int ring3 = Convert.ToInt32(Console.ReadLine());
            int totaal = Convert.ToInt32(ring1 + ring2);
            double resulaat = totaal * Math.Pow(10, ring3);

            if (ring1 == "0")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (ring1 == "1")
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkRed;
            }
            else if (ring1 == "2")
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Red;
            }
            

            Console.WriteLine($"Resultaat is {resulaat} Ohm, ofwel {totaal}x{Math.Pow(10, ring3)}.");
            
            Console.WriteLine("╔══════╦══════╦══════╦══════════════╗");
            Console.WriteLine("║ring1 \tring2\tring3\tTotaal(Ohm)");
            Console.WriteLine("╟──────╫──────╫──────╫──────────────╢ ");
            Console.WriteLine($"║ {ring1}\t{ring2}\t{ring3}\t{resulaat} Ohm");
            Console.WriteLine("╚══════╩══════╩══════╩══════════════╝");

           






        }
    }
}
