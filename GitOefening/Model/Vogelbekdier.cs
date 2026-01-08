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
        public Vogelbekdier(string naam, string geluid, int aantalPoten, bool heeftVacht, bool draagtHoed, string voedsel) 
            : base(naam, geluid, aantalPoten, heeftVacht, voedsel) //Constructor van de basisklasse
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
