using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


public class Polis
{
    public string? Name { get; set; }
    public string? TjanstNr { get; set; }

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

        Console.WriteLine("Alla namn i listan:");
        Console.WriteLine();

        for (int i = 0; i < rp.Count; i++)
        {
            Console.WriteLine($"Namn: {rp[i].Name}, TjänstNr: {rp[i].TjanstNr}");
        }
    }    

}