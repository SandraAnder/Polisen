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
            public int rapportNr;
            public int datum;
            public string? polisStation;
            public string? beskrivning;
        
            Console.WriteLine("Lämna rapport");

            Console.WriteLine("RapportNr: " + rapportNr);
            int inputRapportNr = int.Parse(Console.ReadLine());

            Console.WriteLine("Datum: " datum);
            int inputDatum = int.Parse(Console.ReadLine());

            Console.WriteLine("Polisstation: " + polisStation);
            string? inputStation = Console.ReadLine();

            Console.WriteLine("Beskrivning: " + beskrivning);
            string? inputBeskrivning = Console.ReadLine();
        }
    }
}