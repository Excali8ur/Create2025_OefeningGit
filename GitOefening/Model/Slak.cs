namespace OverervingDieren.Model
{
    public class Slak : Dier
    {
        public bool heeftHuisje { get; private set; }

        public Slak(string naam, string geluid, int aantalPoten, bool heeftVacht, bool kanVliegen, bool heeftHuisje)
            : base(naam, geluid, aantalPoten, heeftVacht, kanVliegen)
        {
            this.naam = naam;
            this.geluid = geluid;
            this.aantalPoten = aantalPoten;
            this.heeftVacht = heeftVacht;
            this.kanVliegen = kanVliegen;
            this.heeftHuisje = heeftHuisje;
        }

        public override string MaakGeluid()
        {
            throw new NotImplementedException();
        }
    }
}