using System;
using System.Collections.Generic;

namespace GrupparbetePolisen1984
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> brottrapport = new List<string>(); // Startar en lista som sparar registrering
            List<string> brottrapport2 = new List<string>(); // Startar en lista för rapporter från case 2

            while (true)
            {
                int val;

                Console.WriteLine("1: Registrering av uttryckningar");
                Console.WriteLine("2: Rapporter");
                Console.WriteLine("4: Information???");
                Console.WriteLine("0: Exit");

                if (int.TryParse(Console.ReadLine(), out val)) // Om valet är en annan än siffran skicka till else
                {
                    switch (val)
                    {
                        case 1:
                            Case1.Registrering(brottrapport);
                            break;

                        case 2:
                            Case2.Rapporter(brottrapport2);
                            break;

                        case 4:
                            Case4.VisaRapporter(brottrapport, brottrapport2);
                            break;

                        case 0:
                            return;

                        default:
                            Console.WriteLine("ERRORTEST");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("ERRORTESTÄRDETENFÖRMYCKET??");
                }
            }
        }
    }

    static class Case1
    {
        public static void Registrering(List<string> brottrapport)
        {
            Console.WriteLine("Ange typ av brott:");
            string Typ = Console.ReadLine();

            Console.WriteLine("Ange plats:");
            string Plats = Console.ReadLine();

            Console.WriteLine("Ange tid:");
            double Tid;
            if (double.TryParse(Console.ReadLine(), out Tid))
            {
                Console.WriteLine("Ange vilka poliser som deltog:");
                string Poliser = Console.ReadLine();

                string rapport = $"{Typ}\n{Plats}\n{Tid}\n{Poliser}\n"; // Skapar en rapport 
                brottrapport.Add(rapport); // Sparar rapport i listan
            }
            else
            {
                Console.WriteLine("Ej en tidpunkt! Try again.");
            }
        }
    }

    static class Case2
    {
        public static void Rapporter(List<string> brottrapport2)
        {
            Console.WriteLine("Ange Rapportnummer:");
            double rapportnr;
            if (!double.TryParse(Console.ReadLine(), out rapportnr))
            {
                Console.WriteLine("Ej ett rapportnummer försök igen!");
                return;
            }

            Console.WriteLine("Ange datum:");
            double datum;
            if (!double.TryParse(Console.ReadLine(), out datum))
            {
                Console.WriteLine("Ej ett datum försök igen!");
                return;
            }

            Console.WriteLine("Ange polistation:");
            string polisstation = Console.ReadLine();

            Console.WriteLine("Beskriv vad som hände kortfattat:");
            string beskrivning = Console.ReadLine();

            string rapport2 = $"{rapportnr}\n{datum}\n{polisstation}\n{beskrivning}"; // Skapar en rapport 
            brottrapport2.Add(rapport2); // Sparar rapport i den andra listan
        }
    }

    static class Case4
    {
        public static void VisaRapporter(List<string> brottrapport, List<string> brottrapport2)
        {
            Console.WriteLine("Rapporter från case 1:");
            foreach (string rapport in brottrapport)
            {
                Console.WriteLine(rapport);
            }

            Console.WriteLine("Rapporter från case 2:");
            foreach (string rapport in brottrapport2)
            {
                Console.WriteLine(rapport);
            }
        }
    }
}

