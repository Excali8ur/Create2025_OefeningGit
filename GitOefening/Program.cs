using OverervingDieren.DAL;
using OverervingDieren.Model;

namespace OverervingDieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom diereneigenaren!\n");
            bool doorgaan = true;
            while (doorgaan)
            {
                string keuze = ToonMenuEnKeuze();

                switch (keuze)
                {
                    case "0":
                        Console.WriteLine("Optie 0");
                        break;
                    case "1":
                        Console.WriteLine("Optie 1: Toon eigenaren met dieren");
                        ToonEigenarenMetDieren();
                        break;
                    case "s":
                    case "S":
                        Console.WriteLine("Doei");
                        doorgaan = false;
                        break;
                    default:
                        Console.WriteLine("Onbekende keuze, probeer opnieuw");
                        break;
                }

            }
        }

        private static string ToonMenuEnKeuze()
        {
            Console.WriteLine("Maak een keuze:");
            Console.WriteLine("0: Leeg");
            Console.WriteLine("1: Toon Eigenaren met hun dieren");
            Console.WriteLine("2: Voeg Dier toe aan een eigenaar");
            Console.WriteLine("3: Verander een dier van naam");
            Console.WriteLine("S: Stop het programma");

            Console.Write("Geef optie: ");
            return Console.ReadLine();
        }
        private static void ToonEigenarenMetDieren()
        {
            Dal dal = new Dal("Huisdieren");
            List<Eigenaar> eigenaren = dal.GetAlleEigenaren();

            foreach (Eigenaar eigenaar in eigenaren)
            {
                Console.WriteLine($"Eigenaar: {eigenaar.ToonGegevens()}");

                List<Dier> dieren = dal.GetAlleDierenVanEigenaar(eigenaar.Id);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Dieren:");
                foreach (Dier dier in dieren)
                {
                    Console.WriteLine($"* {dier.ToonDetails()}");
                }
                Console.WriteLine();
            }
        }
        /*
        Dier perry = new Vogelbekdier("Perry", "Prrrr", 4, true, true);
        Dier barry = new Vogelbekdier("Barry", "Growl", 4, true, false);

        Dier gerry = new Kat("Gerry", "Sjlur", 0, false);

        Console.WriteLine( perry.MaakGeluid());
        Console.WriteLine( gerry.MaakGeluid());

        string geluid = barry.MaakGeluid();
        Console.WriteLine(geluid);

        Dier vogelbekdier = new Vogelbekdier("Perry de tweede", "Prrrr", 4, true, false);

        Console.WriteLine(vogelbekdier.MaakGeluid());
        //Gebruik maken van specifieke eigenschappen of gedrag van de subklasse ->
        //Eerst aangeven welke subklasse het is (tussen () )
        ( (Vogelbekdier)vogelbekdier ).ZetHoedOp();
        */

    }
}
