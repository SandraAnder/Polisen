using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    
    private static void Main(string[] args)
    {
        List<Polis> rp = new List<Polis>();
        List<Polis> ru = new List<Polis>();
        

        bool isRunning = true;
        while(isRunning)
        {
            Console.WriteLine("[1]: Rapportering av utryckning");  
            Console.WriteLine("[2]: Rapporter");
            Console.WriteLine("[3]: Registrera personal");
            Console.WriteLine("[4]: Avsluta");
            Console.Write("Ditt val: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Polis.RegUtryck();
                    break;

                case 2:
                    Polis.Rapport();
                    break;

                case 3:
                    Polis.RegPersonal(rp);
                    break;

                case 4:
                    isRunning = false;
                    break;
                
                default:
                    Console.WriteLine("Välj rätt");
                    break;       
            }
        }
    }
}




public class Polis
{
    public string? Namn { get; set; }
    public String TjanstNr { get; set; }

    public Polis(string name, string tjanstNr)
    {
        Namn = name;
        TjanstNr = tjanstNr;
    }
    

   

    public static void RegUtryck(List<Polis> ru)
    {

      
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
        Polis newPolis = new Polis(regUtrInput);
        ru.Add(newPolis);

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
    
    public static void RegPersonal(List<Polis> rp)
    {
        
        Console.Write("Namn: ");
        string? inputNamn = Console.ReadLine();

        Console.Write("Tjänstnummer: ");
        string? inputTjanstNr = Console.ReadLine();
        Console.WriteLine();

        Polis personal = new Polis(inputNamn, inputTjanstNr);
        rp.Add(personal);

        for (int i = 0; i < rp.Count; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Namn: {rp[i].Namn}, TjänstNr: {rp[i].TjanstNr}");
        }
    }
}