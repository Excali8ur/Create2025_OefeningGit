using OverervingDieren.DAL;
using OverervingDieren.Model;

namespace OverervingDieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom diereneigenaren!\n");

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
}
