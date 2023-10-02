using System.Security.Cryptography.X509Certificates;

namespace GrupparbetePolisen1984;

public class Uttryckingar
{
    static void Main(string[] args)
    { 
        int val;
        switch(val)
        {

        System.Console.WriteLine("1: Registrering av uttryckningar \n 2: Rapporter \n 3:");

        case 1:

        System.Console.WriteLine("Ange typ av brott:");
        string Typ = Console.ReadLine(); 

        System.Console.WriteLine("Ange plats:");
        string Plats = Console.ReadLine(); 

        System.Console.WriteLine("Ange tid:");
        double Tid = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Ange vilka poliser som deltog:");
        string Poliser = Console.ReadLine(); 
        
        System.Console.WriteLine(Typ + "\n" + Plats + "\n" + Tid + "\n" + Poliser);
        break;

        case 2:

    
        }
    }
}
