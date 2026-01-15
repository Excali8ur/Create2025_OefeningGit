namespace OverervingDieren.Model
{
    public class Beer : Dier
    {
        public Beer(string naam, string geluid, int aantalPoten, bool heeftVacht, bool kanVliegen) 
            : base(naam, geluid, aantalPoten, heeftVacht, kanVliegen)
        {
        }
        public override string MaakGeluid()
        {
            throw new NotImplementedException();
        }
    }
}