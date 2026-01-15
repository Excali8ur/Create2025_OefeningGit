namespace OverervingDieren.Model
{
    public class Kangoeroe : Dier
    {
        public Kangoeroe(string naam, string geluid, int aantalPoten, bool heeftVacht, bool kanVliegen) : base(naam, geluid, aantalPoten, heeftVacht, kanVliegen)
        {
        }
        public override string MaakGeluid()
        {
            throw new NotImplementedException();
        }
    }
}