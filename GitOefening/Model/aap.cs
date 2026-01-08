using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.Model
{
    internal class Aap : Dier 
    {
        //Eigenschappen specifiek voor Volgelbekdieren
        private bool draagtkleren;

        //Constructor
        public Aap(string naam, string geluid, int aantalPoten, bool heeftVacht, bool draagtkleren)
            : base(naam, geluid, aantalPoten, heeftVacht) //Constructor van de basisklasse
        {
            this.draagtkleren = draagtkleren;
        }


        public void TrektKlerenAan()
        {
            draagtkleren = true;
        }

        public void TrektKlerenUit()
        {
            draagtkleren = false;
        }
    }
}
