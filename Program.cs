using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GrupparbetePolisen1984
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Registrering = new List<string>(); // Startar en lista som sparar registrering
            List<string> Brottrapport = new List<string>(); // Startar en lista för Rapporter från case 2
            List<string> Personal = new List<string>();
            while (true)
            {
                int val;
                System.Console.WriteLine("------------------------------------");
                System.Console.WriteLine("1: Registrering av uttryckningar");
                System.Console.WriteLine("2: Rapporter");
                System.Console.WriteLine("3: Registrering av personal");
                System.Console.WriteLine("4: InformationMEDSORT???");
                System.Console.WriteLine("0: Exit");
                System.Console.WriteLine("------------------------------------");

                if (int.TryParse(System.Console.ReadLine(), out val)) // Om valet är en annan än siffran skicka till else
                {
                    switch (val)
                    {
                        case 1:
                            Case1.Registrering(Registrering);
                            break;

                        case 2:
                            Case2.Rapporter(Brottrapport);
                            break;

                        case 3:
                            Case3.Personallist(Personal);
                            break;

                        case 4:
                            Case4.VisaRapporter(Registrering, Brottrapport, Personal);
                            break;

                        case 0:
                            return;

                        default:
                            System.Console.Clear();
                            System.Console.WriteLine("------------------------------------");
                            System.Console.WriteLine("EJ ETT VAL");
                            System.Console.WriteLine("------------------------------------");
                            break;
                    }
                }
                else
                {
                    System.Console.Clear();
                    System.Console.WriteLine("------------------------------------");
                    System.Console.WriteLine("ANVÄND EN SIFFRA"); 
                    System.Console.WriteLine("------------------------------------");

                }
            }
        }
    }

    static class Case1
    {
        public static void Registrering(List<string> Registrering)
        {
            System.Console.WriteLine("Ange typ av brott:\n");
            string Typ = System.Console.ReadLine();

            System.Console.WriteLine("Ange plats:\n");
            string Plats = System.Console.ReadLine();

            System.Console.WriteLine("Ange tid (hh:mm):\n");
                TimeSpan Tid; // TimeSpan nytt och fräscht (TM) 
                if (!TimeSpan.TryParse(System.Console.ReadLine(), out Tid))
                    {   
                        System.Console.Clear();
                        System.Console.WriteLine("------------------------------------");
                        System.Console.WriteLine("Ej en giltig tidpunkt! Återgår till val!");
                        System.Console.WriteLine("------------------------------------");
                        return;
                    }
                    
                       System.Console.WriteLine("Ange vilka poliser som deltog:\n");
                        string Poliser = System.Console.ReadLine();

                        string Rapport = $"{Typ}\n{Plats}\n{Tid}\n{Poliser}\n"; // Skapar en Rapport 
                        Registrering.Add(Rapport); // Sparar Rapport i listan
            }
        }
    }

    static class Case2
    {
        public static void Rapporter(List<string> Brottrapport)
        {
            System.Console.WriteLine("Ange Rapportnummer:");
            int Rapportnr; 
            if (!int.TryParse(System.Console.ReadLine(), out Rapportnr))
            {   
                System.Console.Clear();
                System.Console.WriteLine("------------------------------------");
                System.Console.WriteLine("Ej ett rapportnummer! Återgår till val!");
                System.Console.WriteLine("------------------------------------");
                return;
            }

            System.Console.WriteLine("Ange datum(ÅÅÅÅ-MM-DD):\n"); 
            DateTime datum; // DateTime Fresher than fresh (TM)
            if (!DateTime.TryParse(System.Console.ReadLine(), out datum))
            {   System.Console.Clear();
                System.Console.WriteLine("------------------------------------");
                System.Console.WriteLine("Ej ett datum! Återgår till val!");
                System.Console.WriteLine("------------------------------------");
                return;
            }

            System.Console.WriteLine("Ange polistation:\n");
            string polisstation = System.Console.ReadLine();

            System.Console.WriteLine("Beskriv vad som hände kortfattat:\n");
            string beskrivning = System.Console.ReadLine();

            string Rapport = $"{Rapportnr}\n{datum}\n{polisstation}\n{beskrivning}"; // Skapar en Rapport 
            Brottrapport.Add(Rapport); // Sparar Rapport i den andra listan 
        }
    }


static class Case3
    {

        public static void Personallist(List<string> Personal)
    {

        System.Console.WriteLine("Skriv in ditt namn:\n");
        string Personalnm = System.Console.ReadLine();


        System.Console.WriteLine("Skriv in ditt ösnakde personalnummer:\n");
        int Personalnr;
         if (!int.TryParse(System.Console.ReadLine(), out Personalnr))
            {   
                System.Console.Clear();
                System.Console.WriteLine("------------------------------------");
                System.Console.WriteLine("Ej ett personal nummer! Återgår till val!");
                System.Console.WriteLine("------------------------------------");
                return;
            }
        string Rapport = $"{Personalnm}\n{Personalnr}";
        Personal.Add(Rapport);
    }


    }
    static class Case4
    {
        public static void VisaRapporter(List<string> Registrering, List<string> Brottrapport, List<string> Personal)
        {   
            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine("Uttryckningar:\n"); // SORT här??
            foreach (string Rapport in Registrering) // in commando som jag hittat online, ****LÄSPÅLÄSPÅ*****
            {
                System.Console.WriteLine(Rapport);
            }
            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine("Rapporter:\n");
            foreach (string Rapport in Brottrapport)
            {
                System.Console.WriteLine(Rapport);
            }
            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine("Personal:\n");
            foreach (string Rapport in Personal)
            {
                System.Console.WriteLine(Rapport);
            }
        }
    }


