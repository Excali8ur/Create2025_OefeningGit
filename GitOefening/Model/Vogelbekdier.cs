using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.Model
{
    internal class Vogelbekdier : Dier
    {
        //Eigenschappen specifiek voor Volgelbekdieren
        private bool draagtHoed;

        //Constructor
        public Vogelbekdier(string naam, string geluid, int aantalPoten, bool heeftVacht, bool draagtHoed) 
            : base(naam, geluid, aantalPoten, heeftVacht) //Constructor van de basisklasse
        {
            this.draagtHoed = draagtHoed;
        }

        public override string MaakGeluid()
        {
            return $"{naam} maakt het geluid {geluid}";
        }

        public void ZetHoedOp()
        {
            draagtHoed = true;
        }

        public void ZetHoedAf()
        {
            draagtHoed = false;
        }

        /// <summary>
        /// Deze methode overschrijft (override) de abstracte methode uit de hoofdklasse Dier
        /// Iedere subklasse moet dit zelf doen.
        /// </summary>
        /// <returns></returns>
        public override string MaakGeluid()
        {
            return $"{naam} maakt het geluid {geluid}";
        }
    }



}
