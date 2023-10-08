using System;
using System.Collections.Generic;

namespace GrupparbetePolisen1984
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Registrering = new List<string>(); // Startar en lista som sparar registrering
            List<string> Brottrapport = new List<string>(); // Startar en lista för Rapporter från case 2

            while (true)
            {
                int val;

                Console.WriteLine("1: Registrering av uttryckningar");
                Console.WriteLine("2: Rapporter");
                Console.WriteLine("4: InformationMEDSORT???");
                Console.WriteLine("0: Exit");

                if (int.TryParse(Console.ReadLine(), out val)) // Om valet är en annan än siffran skicka till else
                {
                    switch (val)
                    {
                        case 1:
                            Case1.Registrering(Registrering);
                            break;

                        case 2:
                            Case2.Rapporter(Brottrapport);
                            break;

                        case 4:
                            Case4.VisaRapporter(Registrering, Brottrapport);
                            break;

                        case 0:
                            return;

                        default:
                            Console.WriteLine("ERRORTEST"); //FIX *********
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("ERRORTESTÄRDETENFÖRMYCKET??"); //FIXIT ********
                }
            }
        }
    }

    static class Case1
    {
        public static void Registrering(List<string> Registrering)
        {
            Console.WriteLine("Ange typ av brott:");
            string Typ = Console.ReadLine();

            Console.WriteLine("Ange plats:");
            string Plats = Console.ReadLine();

            Console.WriteLine("Ange tid (hh:mm)");
                TimeSpan Tid; // TimeSpan nytt och fräscht (TM) 
                if (!TimeSpan.TryParse(Console.ReadLine(), out Tid))
                    {
                        Console.WriteLine("Ej en giltig tidpunkt! Återgår till val!");
                        return;
                    }
                    
                       Console.WriteLine("Ange vilka poliser som deltog:");
                        string Poliser = Console.ReadLine();

                        string Rapport = $"{Typ}\n{Plats}\n{Tid}\n{Poliser}\n"; // Skapar en Rapport 
                        Registrering.Add(Rapport); // Sparar Rapport i listan
            }
        }
    }

    static class Case2
    {
        public static void Rapporter(List<string> Brottrapport)
        {
            Console.WriteLine("Ange Rapportnummer:");
            int Rapportnr; // sätta in max 4a siffror?
            if (!int.TryParse(Console.ReadLine(), out Rapportnr)) // ! igen ***LÄS*** ! ifall double failar?? VARFÖR INTE TIDIGARE??
            {
                Console.WriteLine("Ej ett Rapportnummer försök igen!");
                return;
            }

            Console.WriteLine("Ange datum:");
            double datum; // ÄNDRA TILL DATUM TIMESPAN *************
            if (!double.TryParse(Console.ReadLine(), out datum))
            {
                Console.WriteLine("Ej ett datum! Återgår till val!");
                return;
            }

            Console.WriteLine("Ange polistation:");
            string polisstation = Console.ReadLine();

            Console.WriteLine("Beskriv vad som hände kortfattat:");
            string beskrivning = Console.ReadLine();

            string Rapport2 = $"{Rapportnr}\n{datum}\n{polisstation}\n{beskrivning}"; // Skapar en Rapport 
            Brottrapport.Add(Rapport2); // Sparar Rapport i den andra listan ****VARFÖRRAPPORT2INTERAPPORT?****
        }
    }

    static class Case4
    {
        public static void VisaRapporter(List<string> Registrering, List<string> Brottrapport)
        {
            Console.WriteLine("Rapporter från case 1:"); // SORT här??
            foreach (string Rapport in Registrering) // in commando som jag hittat online, ****LÄSPÅLÄSPÅ*****
            {
                Console.WriteLine(Rapport);
            }

            Console.WriteLine("Rapporter från case 2:");
            foreach (string Rapport in Brottrapport)
            {
                Console.WriteLine(Rapport);
            }
        }
    }


