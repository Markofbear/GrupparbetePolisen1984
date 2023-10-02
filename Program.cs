namespace GrupparbetePolisen1984;

class Program
{
    static void Main(string[] args)
    
    {
       List<string> Typ = new List<string>();
            Console.WriteLine("Ange typ av brott:");
            Typ.Add(Console.ReadLine()); 
        
        List<string> Plats = new List<string>();
            Console.WriteLine("Ange plats:");
            Plats.Add(Console.ReadLine()); 

        List<double> Tid = new List<double>();
            Console.WriteLine("Ange tid:");
            string input = Console.ReadLine();

         List<string> Poliser = new List<string>();
            Console.WriteLine("Ange vilka poliser som deltog:");
            Poliser.Add(Console.ReadLine()); 
        
    }
}
