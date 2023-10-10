using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    
    private static void Main(string[] args)
    {
        List<Police> rp = new List<Police>();
        rp.Add(new Police("Kalle", "46345"));
        rp.Add(new Police("Björn", "89890"));
        //List<Police> nm = new List<Police>();
        //nm.Add(new Police("Lisa", "12345"));
        //nm.Add(new Police("Anna", "67890"));
        List<Dispatch> ru = new List<Dispatch>();
        //List<Rapporter> ra = new List<Rapporter>();
        

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
                    //RegistreringUtryck.RegUtryck(ru);
                    Console.WriteLine("Gör en registrering");

                    Console.WriteLine("PLATS");
                    string? location = Console.ReadLine();
                    Console.WriteLine("====================");

                    Console.WriteLine("Ange ett datum och tid (YYYY-MM-DD HH:mm:ss): ");
                    string? dateT = Console.ReadLine();
                    try
                    {
                        Time time = new Time(dateT);
                        time.DisplayTime();
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.WriteLine("====================");

                    Console.WriteLine("TYP");
                    string? type = Console.ReadLine();
                    Console.WriteLine("====================");

                    Console.WriteLine("Polis på plats"); 
                    Console.Write("Namn: ");
                    string? nmPolice = Console.ReadLine();
                    //Console.WriteLine($"Namn: {Police.NameP}");
                    
                    //int antal = int.Parse(Console.ReadLine()); 

                    //string polisnamn = fName + " " + lName;
                    string regUtrInput = $"Plats: {location} Tid: {dateT}  Typ: {type}  Polis på plats: {nmPolice}";
                    Dispatch rut = new Dispatch(regUtrInput);
                    ru.Add(rut);
                    
                    
                    
                    break;

                case 2:
                    //Rapporter.Rapport(ra);
                    Console.WriteLine("Ange ett datum och tid (YYYY-MM-DD HH:mm:ss): ");
                    string input = Console.ReadLine();
                    try
                    {
                        Time time = new Time(input);
                        time.DisplayTime();
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
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
                    Console.WriteLine();
                    Police.NameP(rp);
                    Police.ServiceNrP(rp);
                    break;
                case 4:
                    //Info.ShowInformation(ru, ra, rp);
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
