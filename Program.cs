using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
internal class Program
{
    
    private static void Main(string[] args)
    {
        List<Polis> rp = new List<Polis>();
        rp.Add(new Polis("Lisa", "12345"));
        rp.Add(new Polis("Anna", "67890"));
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
                    Info.ShowInformation(ru, ra, rp);
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
*/