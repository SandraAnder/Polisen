using Polisen;

internal class Program
{
    private static void Main(string[] args)
    {
        bool isRunning = true;
        while(isRunning)
        {
            Console.WriteLine("[1]: Rapportering av uttryckning");  
            Console.WriteLine("[2]: Rapporter");
            Console.WriteLine("[3]: Registrera personal");
            Console.WriteLine("[4]: Avsluta");
            Console.Write("Ditt val: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    break;

                case 2:
                    Polis.Rapport();
                    break;

                case 3:
                    Polis.RegPersonal();
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