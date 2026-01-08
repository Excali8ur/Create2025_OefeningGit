using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.Model
{
    internal class Slak : Dier
    {
        ///Eigenschappen specifiek voor Slakken
        private bool heeftHuisje;

        ///Constructor
        public Slak(string naam, string geluid, int aantalPoten, bool heeftVacht, bool heeftHuisje)
            : base(naam, geluid, aantalPoten, heeftVacht) //Constructor van de basisklasse
        {
            this.heeftHuisje = heeftHuisje;
        }

        public void DraagHuisje()
        {
            heeftHuisje = true;
        }

        public void LegHuisjeAf()
        {
            heeftHuisje = false;
        }
    }
}
