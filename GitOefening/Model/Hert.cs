using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.Model
{
    internal class Hert : Dier
    {
        //Eigenschappen specifiek voor Volgelbekdieren
        private bool zietkoplampen;

        //constructor
        public Hert(string naam, string geluid, int aantalPoten, bool heeftVacht, bool zietkoplampen)
    : base(naam, geluid, aantalPoten, heeftVacht) //Constructor van de basisklasse
        {
            this.zietkoplampen = zietkoplampen;
        }

        public void WordtAangereden()
        {
            zietkoplampen = true;
        }

        public void LooptVerder()
        {
            zietkoplampen = false;
        }
    }
}
