namespace OverervingDieren.Model
{
    public class Vlinder : Dier
    {
        public Vlinder(string naam, string geluid, int aantalPoten, bool heeftVacht, bool kanVliegen) : base(naam, geluid, aantalPoten, heeftVacht, kanVliegen)
        {
        }
        public override string MaakGeluid()
        {
            throw new NotImplementedException();
        }
    }
}