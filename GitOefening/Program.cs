using OverervingDieren.Model;

namespace OverervingDieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Dier perry = new("Perry", "Prrrr", 4, true);
            Dier barry = new("Barry", "Growl", 4, true);
            Dier gerry = new("Gerry", "Sjlur", 0, false);
            Dier pipi = new("pipi", "oe-oe-oe", 2, true);

            Console.WriteLine(perry.MaakGeluid());
            Console.WriteLine(gerry.MaakGeluid());

            string geluid = barry.MaakGeluid();
            Console.WriteLine(geluid);

                Vogelbekdier vogelbekdier = new("Perry de tweede", "Prrrr", 4, true, false);
                Aap aap = new("pipi", "oe - oe - oe", 2, true, false);

            Console.WriteLine(vogelbekdier.MaakGeluid());
            vogelbekdier.ZetHoedOp();
            
            Console.WriteLine(aap.MaakGeluid());
            aap.TrektKlerenAan();
        }
    }
}
