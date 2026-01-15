namespace OverervingDieren.Model
{
    internal class Vogel : Dier
    {
        public Vogel(string naam, string geluid, int aantalPoten, bool heeftVacht, bool kanVliegen) : base(naam, geluid, aantalPoten, heeftVacht, kanVliegen)
        {

        }

        public override string MaakGeluid()
        {
            throw new NotImplementedException();
        }
    }
}