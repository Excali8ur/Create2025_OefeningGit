using GitOefening.Model;

namespace GitOefening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dier perry = new Dier("Perry", "prrr", 4, true);
            Dier gerry = new Dier("Perry", "prrr", 4, true);
            Dier harry = new Dier("Perry", "prrr", 4, false);

            Vogelbekdier vogelbekdier = new Vogelbekdier("Perry de tweede", "prrr2", 4, true, false);

            Console.WriteLine(vogelbekdier.MaakGeluid());
            
        }
    }
}
