using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitOefening.Model
{
    class Dier
    {
        protected string naam;
        protected string geluid;
        protected int aantalPoten;
        protected bool maaktGeluid;

        public Dier(string naam, string geluid, int aantalPoten, bool maaktGeluid)
        {
            this.naam = naam;
            this.geluid = geluid;
            this.aantalPoten = aantalPoten;
            this.maaktGeluid = maaktGeluid;
        }

        public string MaakGeluid()
        {
            return geluid;
        }
    }
}
