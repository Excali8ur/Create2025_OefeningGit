using OverervingDieren.Model;

namespace OverervingDieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bob, 23
            //Henk, 12
            //Casandra, 2

            List<Bezoeker> bezoekers = new List<Bezoeker>();
            Bezoeker bob = new Bezoeker("Bob", 23);
            bezoekers.Add(bob);
            bezoekers.Add(new Bezoeker("Henk", 12));
            bezoekers.Add(new Bezoeker("Casandra", 2));

            Ticket gezinsuitje = new Ticket(25, 30, bezoekers);
            int hoeveelMoetenZeBetalen = gezinsuitje.ToonPrijs();
            Console.WriteLine($"Totaalprijs = {hoeveelMoetenZeBetalen}");

            //Tante Truus, 101
            Bezoeker truus = new Bezoeker("Tante Truus", 101);
            gezinsuitje.VoegBezoekerToe(truus);
            //Embryo Erin, -3
            gezinsuitje.VoegBezoekerToe(new Bezoeker("Embryo Erin", -3));

            hoeveelMoetenZeBetalen = gezinsuitje.ToonPrijs();
            Console.WriteLine($"Totaalprijs = {hoeveelMoetenZeBetalen}");
        }
    }
}
