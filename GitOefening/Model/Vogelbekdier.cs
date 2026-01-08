using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitOefening.Model
{
    class Vogelbekdier : Dier
    {
        // EIGENSCHAPPEN
        private bool draagtHoed;

        // CONSTRUCTOR
        public Vogelbekdier(string naam, string geluid, int aantalPoten, bool maaktGeluid, bool draagtHoed) 
            : base(naam, geluid, aantalPoten, maaktGeluid)
        {
            this.draagtHoed = draagtHoed;
        }
        public void ZetHoedOp()
        {
            draagtHoed = true;
        }

        public void ZetHoedAf()
        {
            draagtHoed = false;
        }
    }
}
