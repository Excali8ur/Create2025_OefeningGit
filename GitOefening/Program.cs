using OverervingDieren.Model;

namespace OverervingDieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dier perry = new Vogelbekdier("Perry", "Prrrr", 4, true, true);
            Dier Berry = new Beer("Berry", "Grom", 4, true, false);

            Console.WriteLine(perry.MaakGeluid());
            Console.WriteLine(Berry.MaakGeluid());

            ((Beer)Berry).VindHoning();

        }
    }
}
