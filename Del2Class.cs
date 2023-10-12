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

    public Police(string? name, string? serviceNr)
    {
        Name = name;
        ServiceNr = serviceNr;
    }
}


public class Dispatch
{
    public Dispatch(string regUtrInput)
    {
        RegUtrInput = regUtrInput;
    }

    public string RegUtrInput { get; }
}  

public class Time
{
    public DateTime DateTimeValue { get; set; }

    public Time(string? input)
    {
        // Försök att konvertera användarens inmatning till ett DateTime-objekt
        if (DateTime.TryParse(input, out DateTime result))
        {
            DateTimeValue = result;
        }
    }
}

public class Rapporter
{
    public string? RapportOutput { get; set; }

    public DateTime Datum { get; set; }

    public Rapporter(string rapportOutput, DateTime datum)
    {
        RapportOutput = rapportOutput;
        Datum = datum;
    }
}
public class RapportInfo
{
     public int RapportNr { get; set; }
     public string? PolisStation { get; set; }
    public string? Beskrivning { get; set; }

    public RapportInfo(int rapportNr, string polisStation, string beskrivning)
    {
        RapportNr = rapportNr;
        PolisStation = polisStation;
        Beskrivning = beskrivning;
    }
}