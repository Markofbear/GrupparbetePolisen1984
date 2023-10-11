using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GrupparbetePolisen1984
{
    class Program
    {
        static void Main(string[] args)
        {
            UIAnvändare UIAnvändare = new UIAnvändare();

            while (true)
            {
                int val;
                System.Console.WriteLine("-----------[Gör ett val]------------");
                System.Console.WriteLine("[1] Registrering av utryckningar");
                System.Console.WriteLine("[2] Rapporter");
                System.Console.WriteLine("[3] Registrering av personal");
                System.Console.WriteLine("[4] Information");
                System.Console.WriteLine("[0] Exit");
                System.Console.WriteLine("------------------------------------");

                if (int.TryParse(System.Console.ReadLine(), out val))
                {
                    switch (val)
                    {
                        case 1:
                            UIAnvändare.Registreringar();
                            break;

                        case 2:
                            UIAnvändare.Rapporter();
                            break;

                        case 3:
                            UIAnvändare.Personallist();
                            break;

                        case 4:
                            UIAnvändare.VisaRapporter();
                            break;

                        case 0:
                            return;

                        default:
                            System.Console.Clear();
                            System.Console.WriteLine("------------");
                            System.Console.WriteLine("|EJ ETT VAL|");
                            System.Console.WriteLine("------------");
                            break;
                    }
                }
                else
                {
                    System.Console.Clear();
                    System.Console.WriteLine("------------------");
                    System.Console.WriteLine("| ANVÄND EN SIFFRA |");
                    System.Console.WriteLine("------------------");
                }
            }
        }
    }

    class UIAnvändare
    {
        private List<string> Registrering = new List<string>();
        private List<string> Brottrapport = new List<string>();
        private List<string> Personal = new List<string>();

        public void Registreringar()
        {
            System.Console.WriteLine("Ange typ av brott:\n");
            string typ = System.Console.ReadLine();

            System.Console.WriteLine("Ange plats:\n");
            string plats = System.Console.ReadLine();

            System.Console.WriteLine("Ange tid (hh:mm):\n");
            TimeSpan tid;
            if (!TimeSpan.TryParse(System.Console.ReadLine(), out tid))
            {
                System.Console.Clear();
                System.Console.WriteLine("-------------------------------------------");
                System.Console.WriteLine("| Ej en giltig tidpunkt! Återgår till val! |");
                System.Console.WriteLine("-------------------------------------------");
                return;
            }

            System.Console.WriteLine("Ange vilka poliser som deltog:\n");
            string poliser = System.Console.ReadLine();

            string rapport = $"{typ}\n{plats}\n{tid}\n{poliser}\n";
            Registrering.Add(rapport);
        }

        public void Rapporter()
        {
            System.Console.WriteLine("Ange Rapportnummer:");
            int Rapportnr;
            if (!int.TryParse(System.Console.ReadLine(), out Rapportnr))
            {
                System.Console.Clear();
                System.Console.WriteLine("-----------------------------------------");
                System.Console.WriteLine("|Ej ett rapportnummer! Återgår till val!|");
                System.Console.WriteLine("-----------------------------------------");
                return;
            }

            System.Console.WriteLine("Ange datum(ÅÅÅÅ-MM-DD):\n");
            DateTime datum;
            if (!DateTime.TryParse(System.Console.ReadLine(), out datum))
            {
                System.Console.Clear();
                System.Console.WriteLine("--------------------------------");
                System.Console.WriteLine("|Ej ett datum! Återgår till val!|");
                System.Console.WriteLine("--------------------------------");
                return;
            }

            System.Console.WriteLine("Ange polistation:\n");
            string polisstation = System.Console.ReadLine();

            System.Console.WriteLine("Beskriv vad som hände kortfattat:\n");
            string beskrivning = System.Console.ReadLine();

            string Rapport = $"{Rapportnr}\n{datum}\n{polisstation}\n{beskrivning}";
            Brottrapport.Add(Rapport);
        }

        public void Personallist()
        {
            System.Console.WriteLine("Skriv in ditt namn:\n");
            string personalnm = System.Console.ReadLine();

            System.Console.WriteLine("Skriv in ditt önskade personalnummer:\n");
            int personalnr;
            if (!int.TryParse(System.Console.ReadLine(), out personalnr))
            {
                System.Console.Clear();
                System.Console.WriteLine("------------------------------------");
                System.Console.WriteLine("Ej ett personalnummer! Återgår till val!");
                System.Console.WriteLine("------------------------------------");
                return;
            }
            string rapport = $"{personalnm}\n{personalnr}\n";
            Personal.Add(rapport);
        }

        public void VisaRapporter()
        {
            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine("Uttryckningar:\n");
            foreach (string Rapport in Registrering)
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
}
