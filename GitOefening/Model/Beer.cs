using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.Model
{
    internal class Beer : Dier
    {
        //Eigenschappen specifiek voor Volgelbekdieren
        private bool slaapt;

        //Constructor
        public Beer(string naam, string geluid, int aantalPoten, bool heeftVacht, bool slaapt) 
            : base(naam, geluid, aantalPoten, heeftVacht) //Constructor van de basisklasse
        {
            this.slaapt = slaapt;
        }


        public void Slapen()
        {
            slaapt = true;
            //test
        }

        public void WakkerWorden()
        {
            slaapt = false;
        }
    }



}
