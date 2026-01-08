using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.Model
{
    internal class Dier
    {
        //Eigenschappen
        protected int aantalPoten;
        protected bool heeftVacht;
        protected string naam;
        protected string geluid;

        //Constructoren
        /*public Dier()
        {
            this.naam = "naam";
            this.geluid = "geluid";
            this.aantalPoten = 0;
            this.heeftVacht = true;
        }*/

        public Dier(string naam, string geluid, int aantalPoten, bool heeftVacht)
        {
            this.naam = naam;
            this.geluid = geluid;
            this.aantalPoten = aantalPoten;
            this.heeftVacht = heeftVacht;
        }

        //Gedrag
        public string MaakGeluid()
        {
            return $"{naam} maakt het geluid {geluid}";
        }

        public string Eten()
        {
            return $"{naam} eet zijn voer";
        }
    }
}
