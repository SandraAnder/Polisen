/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 public class Polis
{
    public string? Namn { get; set; }
    public int TjanstNr { get; set; }

    public static void RegUtryck()
    {
        List<string> regUtryck = new List<string>();

        Console.WriteLine("Gör en registrering");

        Console.WriteLine("PLATS");
        string? location = (Console.ReadLine());
        Console.WriteLine("====================");

        Console.WriteLine("TID");
        double time = double.Parse(Console.ReadLine());
        Console.WriteLine("====================");

        Console.WriteLine("TYP");
        string? type = (Console.ReadLine());
        Console.WriteLine("====================");

        Console.WriteLine("POLIS PÅ PLATS");
        Console.Write("Förnamn:");
        string? fName = (Console.ReadLine());

        Console.Write("Efternamn: ");
        string? lName = (Console.ReadLine());

        string polisnamn = fName + " " + lName;

        string regUtrInput = $"Plats: {location} Tid: {time}  Typ: {type}  Polis på plats: {polisnamn}";

        //Polis rg = new Polis
        // rg.Add(regUtrInput);
        // Console.WriteLine(RegUtryck);
        
        // Console.WriteLine($"{regUtrInput}");

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
        
        Console.Write("Namn: ");
        string? inputNamn = Console.ReadLine();

        Console.Write("Tjänstnummer: ");
        int inputTjanstNr = int.Parse(Console.ReadLine());

        // Skapa ett Polis-objekt och lägg till det i listan
        Polis personal = new Polis
        {
            Namn = inputNamn,
            TjanstNr = inputTjanstNr
        };

        string cops = inputNamn + " " + inputTjanstNr;

        List<Polis> rp = new List<Polis>();
        Polis p = new Polis(cops);
        rp.Add(p);

    }
}
*/













