using OverervingDieren.Model;

namespace OverervingDieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Beer henk = new Beer("Henk", "Hendig dikke Ijsbeer", "Growl", 4, true, "pengweng");
            Console.WriteLine(henk.GetInfo());
        }
    }
}
