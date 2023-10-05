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
        List<RegistreringUtryck> ru = new List<RegistreringUtryck>();
        List<Rapporter> ra = new List<Rapporter>();
        

        bool isRunning = true;
        while(isRunning)
        {
            Console.WriteLine("--------Polisen 1984--------");
            Console.WriteLine("[1]: Rapportering av utryckning");  
            Console.WriteLine("[2]: Rapporter");
            Console.WriteLine("[3]: Registrera personal");
            Console.WriteLine("[4]: Hämta info");
            Console.WriteLine("[5]: Avsluta");
            Console.Write("Ditt val: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    RegistreringUtryck.RegUtryck(ru);
                    break;

                case 2:
                    Rapporter.Rapport(ra);
                    break;

                case 3:
                    Polis.RegPersonal(rp);
                    break;
                case 4:
                    //XXX.XXX(XX);
                    break;

                case 5:
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
    public string? Name { get; set; }
    public String TjanstNr { get; set; }

    public Polis(string name, string tjanstNr)
    {
        Name = name;
        TjanstNr = tjanstNr;
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
                Console.WriteLine($"Namn: {rp[i].Name}, TjänstNr: {rp[i].TjanstNr}");
                Console.WriteLine();
            }
        }    

}   
public class RegistreringUtryck
{
    public RegistreringUtryck(string regUtrInput)
    {
        RegUtrInput = regUtrInput;
    }

    public string RegUtrInput { get; }

    public static void RegUtryck(List<RegistreringUtryck> ru)
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
        Console.WriteLine("====================");

        string polisnamn = fName + " " + lName;

        string regUtrInput = $"Plats: {location} Tid: {time}  Typ: {type}  Polis på plats: {polisnamn}";
        RegistreringUtryck rut = new RegistreringUtryck(regUtrInput);
        ru.Add(rut);

    }
}

public class Rapporter
{
    public Rapporter(string rapportDocu)
    {
        RapportDocu = rapportDocu;
    }

    public string RapportDocu { get; }
    public static void Rapport(List<Rapporter> ra)
    {
        int rapportNr;
        int datum;
        string polisStation;
        string beskrivning;


        Console.WriteLine("Lämna rapport");

        Console.Write("RapportNr: ");
        int inputRapportNr = int.Parse(Console.ReadLine());
        rapportNr = inputRapportNr;
        Console.WriteLine("====================");

        Console.Write("Datum (XXMMÅÅ): ");
        int inputDatum = int.Parse(Console.ReadLine());
        datum = inputDatum;
        Console.WriteLine("====================");

        Console.Write("Polisstation: ");
        string? inputStation = Console.ReadLine();
        polisStation = inputStation;
        Console.WriteLine("====================");

        Console.Write("Beskrivning: ");
        string? inputBeskrivning = Console.ReadLine();
        beskrivning = inputBeskrivning;
        Console.WriteLine("====================");

        Console.WriteLine();
        Console.WriteLine($"RapportNr: {rapportNr}");
        Console.WriteLine($"Datum: {datum}");
        Console.WriteLine($"Polisstation: {polisStation}");
        Console.WriteLine($"Beskrivning: {beskrivning}");
        Console.WriteLine();

        string rapportDocu = $"Plats: {rapportNr} Tid: {datum}  Typ: {polisStation}  Polis på plats: {beskrivning}";
        Rapporter rap = new Rapporter(rapportDocu);
        ra.Add(rap);

    }
}

public class Info
{
    public Info(string showInfo)
    {
        ShowInfo = showinfo;
    }

    public string ShowInfo { get; }

    static void ShowInformation(List<Info> sh)
    {
        Console.WriteLine("Välj vad du vill visa:");
        Console.WriteLine("1. Utryckningar");
        Console.WriteLine("2. Rapporter");
        Console.WriteLine("3. Personal");

        int val = Convert.ToInt32(Console.ReadLine());

        switch (val)
        {
            case 1:
                Console.WriteLine("Utryckningar:");
                foreach (var rut in ru)
                {
                    Console.WriteLine(rut);
                }
                break;
            case 2:
                Console.WriteLine("Rapporter:");
                foreach (var rapport in rapporter)
                {
                    Console.WriteLine(rapport);
                }
                break;
            case 3:
                Console.WriteLine("Personal:");
                foreach (var person in personal)
                {
                    Console.WriteLine(person);
                }
                break;
            default:
                Console.WriteLine("Ogiltigt val. Försök igen.");
                break;
        }
        Info showInfo = new Info();
        sh.Add(showInfo);
    }
}