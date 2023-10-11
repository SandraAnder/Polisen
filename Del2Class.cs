using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


public class Police
{
    public string? Name { get; set; }
    public string? ServiceNr { get; set; }

    public Police(string name, string serviceNr)
    {
        Name = name;
        ServiceNr = serviceNr;
    }
    
    public static void NameP(List<Police> rp)
    {
        for (int i = 0; i < rp.Count; i++)
        {
            Console.WriteLine($"Namn: {rp[i].Name}");
        }
    }
    public static void ServiceNrP(List<Police> rp)
    {
        for (int j = 0; j < rp.Count; j++)
        {
            Console.WriteLine($"TjänstNr: {rp[j].ServiceNr}");
        }
    }  
}


public class Dispatch
{
    public Dispatch(string regUtrInput)
    {
        RegUtrInput = regUtrInput;
    }

    public string RegUtrInput { get; }

    public static void RegUtryck(List<Dispatch> ru)
    {
        string Name = "";


        Console.WriteLine("POLIS PÅ PLATS");
        Console.Write("Namn:");
        Name = (Console.ReadLine());

        /*int antal = 0;
       

        if(antal > 1)
        {
            for(int i = 0; i < antal; i++)
            {
                Console.WriteLine("POLIS PÅ PLATS");
                Console.Write("Namn:");
                Name = (Console.ReadLine());

            }
        }
        else
        {
            Console.WriteLine("POLIS PÅ PLATS");
            Console.Write("Namn:");
            Name = (Console.ReadLine());

            
        }*/
    }
}  
class Time
{
    public DateTime DateTimeValue { get; set; }

    public Time(string input)
    {
        // Försök att konvertera användarens inmatning till ett DateTime-objekt
        if (DateTime.TryParse(input, out DateTime result))
        {
            DateTimeValue = result;
        }
        else
        {
            Console.WriteLine("Ogiltigt datum och tid format.");
        }
    }

    public void DisplayTime()
    {
        Console.WriteLine($"Du har angett datum och tid: {DateTimeValue.ToString("yyyy-MM-dd HH:mm:ss")}");
    }
}


class Timee
{
    public DateTime DateTimeValue { get; set; }

    public Timee(DateTime dateTime)
    {
        DateTimeValue = dateTime;
    }
}

class Rapporter
{
    public int RapportNr { get; set; }
    public Timee Datum { get; set; }
    public string PolisStation { get; set; }
    public string Beskrivning { get; set; }

    public Rapporter(int rapportNr, Timee datum, string polisStation, string beskrivning)
    {
        RapportNr = rapportNr;
        Datum = datum;
        PolisStation = polisStation;
        Beskrivning = beskrivning;
    }
    public static void rapportis()
}

public class Info
{
    public Info(string showInfo)
    {
        ShowInfo = showInfo;
    }

    public string ShowInfo { get; }

    public static void ShowInformation(List<Dispatch> ru, List<Rapporter> ra, List<Police> rp)
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
                    Console.WriteLine(rut.RegUtrInput);
                }
                break;
            case 2:
                Console.WriteLine("Rapporter:");
                foreach (var rapport in ra)
                {
                    Console.WriteLine(rapport.RapportNr);
                }
                break;
            case 3:
                Console.WriteLine("Personal:");
                foreach (var personal in rp)
                {
                    Console.WriteLine($"Namn: {personal.Name}, TjänstNr: {personal.ServiceNr}");
                }
                break;
            default:
                Console.WriteLine("Ogiltigt val. Försök igen.");
                break;
        }
    }
}