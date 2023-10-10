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
/*
public class Name
{
    public string? NamePolice { get; set; }
    public Name(string namePolice)
    {
        NamePolice = namePolice;
    }
}*/
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
            throw new ArgumentException("Ogiltigt datum och tid format.");
        }
    }

    public void DisplayTime()
    {
        Console.WriteLine($"Du har angett datum och tid: {DateTimeValue.ToString("yyyy-MM-dd HH:mm:ss")}");
    }
}