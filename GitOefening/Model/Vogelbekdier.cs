using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.Model
{
    public class Vogelbekdier : Dier
    {
        //Eigenschappen specifiek voor Volgelbekdieren
        public bool draagtHoed { get; private set; }

        //Constructor
        public Vogelbekdier(string naam, string geluid, int aantalPoten, bool heeftVacht, bool kanVliegen, bool draagtHoed) 
            : base(naam, geluid, aantalPoten, heeftVacht, kanVliegen) //Constructor van de basisklasse
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
