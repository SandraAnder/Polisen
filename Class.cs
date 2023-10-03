using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Polisen
{
    public class Polis
    {
        public string? namn { get; set; }
        public int tjanstNr { get; set; }

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

            Console.Write("Datum (XXMMÅÅ): ");
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
            Console.WriteLine();

        }
        public static void RegPersonal()
        {
            List<Polis> rp = new List<Polis>();

            Console.Write("Namn: ");
            string? inputNamn = Console.ReadLine();

            Console.Write("Tjänstnummer: ");
            int inputTjanstNr = int.Parse(Console.ReadLine());

            // Skapa ett Polis-objekt och lägg till det i listan
            Polis polis = new Polis
            {
                namn = inputNamn,
                tjanstNr = inputTjanstNr
            };

            rp.Add(polis);

            Console.WriteLine($"Ny personal registrerad: {inputNamn}, {inputTjanstNr}");
            Console.WriteLine();
            
        }
    }
}













