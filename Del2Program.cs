using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    
    private static void Main(string[] args)
    {
        List<Police> rp = new List<Police>();
        rp.Add(new Police("Kalle", "46345"));
        rp.Add(new Police("Björn", "89890"));
        List<Dispatch> ru = new List<Dispatch>();
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
                    Console.WriteLine("Gör en registrering");

                    Console.WriteLine("PLATS");
                    string? location = Console.ReadLine();
                    Console.WriteLine("====================");

                    Console.WriteLine("TID");
                    string? inputTime = Console.ReadLine();
                    Console.WriteLine("====================");
                    if (DateTime.TryParse(inputTime, out DateTime datum))
                    {

                        Console.WriteLine("TYP");
                        string? type = Console.ReadLine();
                        Console.WriteLine("====================");

                        Console.WriteLine("Polis på plats"); 
                        Console.Write("Namn: ");
                        
                        string? nmPolice = Console.ReadLine();
                        
                        string regUtrInput = $"Plats: {location} Tid: {datum}  Typ: {type}  Polis på plats: {nmPolice}";
                        Dispatch rut = new Dispatch(regUtrInput);
                        ru.Add(rut);

                        Console.WriteLine($"Din rapport är registrerad");
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt datumformat.");
                    }
                    break;

                case 2:
                    Console.WriteLine("Lämna rapport");

                    Console.Write("RapportNr: ");
                    int inputRapportNr = int.Parse(Console.ReadLine());
                    Console.WriteLine("====================");

                    Console.Write("Datum (ÅÅÅÅ-MM-DD HH:mm:ss): ");
                    string? inputDatum = Console.ReadLine();
                    Console.WriteLine("====================");
                    if (DateTime.TryParse(inputDatum, out DateTime datum1))
                    {
                        Console.Write("Polisstation: ");
                        string? inputStation = Console.ReadLine();
                        Console.WriteLine("====================");

                        Console.Write("Beskrivning: ");
                        string? inputBeskrivning = Console.ReadLine();
                        Console.WriteLine("====================");

                        string rapportOutput = $"Rapportnummer: {inputRapportNr} Tid: {datum1} Polisstation: {inputStation} Beskrivning: {inputBeskrivning}";
                        Rapporter rapport = new Rapporter(rapportOutput, datum1);
                        ra.Add(rapport);
                       
                        Console.WriteLine($"Rapporten har lagts till: RapportNr: {inputRapportNr}, Datum: {datum1.ToString("yyyy-MM-dd HH:mm:ss")}, Polisstation: {inputStation}, Beskrivning: {inputBeskrivning}");
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt datumformat.");
                        
                    }
                    break;

                case 3:
                    Console.Write("Namn: ");
                    string? namePolice = Console.ReadLine();
                    Console.Write("Tjänstnummer: ");
                    string? inputServiceNr = Console.ReadLine();
                    Console.WriteLine();
                    Police personal = new Police(namePolice, inputServiceNr);
                    rp.Add(personal);
                    Console.WriteLine("Alla namn i listan:");
                    for (int i = 0; i < rp.Count; i++)
                    {
                        Console.WriteLine($"Namn: {rp[i].Name} tjänstenummer: {rp[i].ServiceNr}");
                    }
                    Console.WriteLine();
                    
                    break;
                case 4:
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
                                Console.WriteLine(rapport.RapportOutput);
                            }
                            break;
                        case 3:
                            Console.WriteLine("Personal:");
                            foreach (var p in rp)
                            {
                                Console.WriteLine($"Namn: {p.Name}, TjänstNr: {p.ServiceNr}");
                            }
                            break;
                        default:
                            Console.WriteLine("Ogiltigt val. Försök igen.");
                            break;
                    }
                    break;

                case 5:
                    Console.WriteLine("Tack för idag");
                    isRunning = false;
                    break;
                
                default:
                    Console.WriteLine("Välj rätt");
                    break;       
            }
        }
    }
}
