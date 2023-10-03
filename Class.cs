using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Polisen
{
    public class Polis
    {
        public static void RegUtryck()
        {

        }










        public static void Rapport()
        {
            int rapportNr;
            int datum;
            string polisStation;
            string beskrivning;

            Console.WriteLine("Lämna rapport");

            Console.Write("RapportNr: ");
            int inputRapportNr = int.Parse(Console.ReadLine());
            rapportNr = inputRapportNr;

            Console.Write("Datum: ");
            int inputDatum = int.Parse(Console.ReadLine());
            datum = inputDatum;

            Console.Write("Polisstation: ");
            string? inputStation = Console.ReadLine();
            polisStation = inputStation;

            Console.Write("Beskrivning: ");
            string? inputBeskrivning = Console.ReadLine();
            beskrivning = inputBeskrivning;

            Console.WriteLine($"RapportNr: {rapportNr}");
            Console.WriteLine($"Datum: {datum}");
            Console.WriteLine($"Polisstation: {polisStation}");
            Console.WriteLine($"Beskrivning: {beskrivning}");

            
        }
    }
}













