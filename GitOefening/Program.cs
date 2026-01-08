using OverervingDieren.Model;

namespace OverervingDieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Dier perry = new Vogelbekdier("Perry", "Prrrr", 4, true, true);
            Dier barry = new Vogelbekdier("Barry", "Growl", 4, true, false);
            
            Dier gerry = new Kat("Gerry", "Sjlur", 0, false);

            Console.WriteLine( perry.MaakGeluid());
            Console.WriteLine( gerry.MaakGeluid());

            string geluid = barry.MaakGeluid();
            Console.WriteLine(geluid);

            Dier vogelbekdier = new Vogelbekdier("Perry de tweede", "Prrrr", 4, true, false);

            Console.WriteLine(vogelbekdier.MaakGeluid());
            vogelbekdier.ZetHoedOp();

            Tyrannosaurus trex01 = new Tyrannosaurus("Terry", "Zeer luid gebrul", 2, false, false, false);

            Console.WriteLine(trex01.MaakGeluid());
            trex01.DinoHungry();
            trex01.DinoMad();
            trex01.DinoSated();
            trex01.DinoCalm();

        }
    }
}
