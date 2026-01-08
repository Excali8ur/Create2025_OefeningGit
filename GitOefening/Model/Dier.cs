using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.Model
{
    internal abstract class Dier
    {
        //Eigenschappen
        protected int aantalPoten;
        protected bool heeftVacht;
        protected string naam;
        protected string geluid;

        public Dier(string naam, string geluid, int aantalPoten, bool heeftVacht)
        {
            this.naam = naam;
            this.geluid = geluid;
            this.aantalPoten = aantalPoten;
            this.heeftVacht = heeftVacht;
        }

        //Gedrag
        public abstract string MaakGeluid();
    }
}
