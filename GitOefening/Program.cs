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

            Console.WriteLine("Perry het vogelbekdier????");
            
            Beer boory = new Beer("boory","ik HOu van ZALM",3, true, true);
            Console.WriteLine(boory.houIkVanZalm());
            Console.WriteLine(boory.MaakGeluid());
            
            Beer baary = new Beer("baary","IK HAAT ZALM",5, true, false);
            Console.WriteLine(boory.houIkVanZalm());
            Console.WriteLine(boory.MaakGeluid());
        }
    }
}
