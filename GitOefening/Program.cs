using OverervingDieren.Model;

namespace OverervingDieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Dier perry = new Dier("Perry", "Prrrr", 4, true);
            Dier barry = new Dier("Barry", "Growl", 4, true);
            Dier gerry = new Dier("Gerry", "Sjlur", 0, false);
            

            Console.WriteLine( perry.MaakGeluid());
            Console.WriteLine( gerry.MaakGeluid());

            string geluid = barry.MaakGeluid();
            Console.WriteLine(geluid);

            Vogelbekdier vogelbekdier = new Vogelbekdier("Perry de tweede", "Prrrr", 4, true, false);
            Hert rudolph = new Hert("Larry", "autongelukgeluiden", 4, true, true);

            Console.WriteLine(vogelbekdier.MaakGeluid());
            Console.WriteLine(rudolph.MaakGeluid());
            vogelbekdier.ZetHoedOp();
            rudolph.WordtAangereden();
        }
    }
}
