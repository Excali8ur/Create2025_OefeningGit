using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.Model
{
    internal class Slak : Dier
    {
        private bool huis;

        public Slak(string naam, string geluid, int aantalPoten, bool heeftVacht)
            : base(naam, geluid, aantalPoten, heeftVacht)
        {
            this.huis = huis;
        }
        public void HuisHeb()
        {
            huis = true;
        }
        public void HuisWeg()
        {
            huis = false;
        }
    }
}
