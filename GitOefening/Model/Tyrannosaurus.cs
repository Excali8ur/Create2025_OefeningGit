using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.Model
{
    internal class Tyrannosaurus : Dier
    {
        //Eigenschappen specifiek voor tyrannosaurus rex
        private bool isBozeDino;
        private bool heeftHonger;

        //Constructor
        public Tyrannosaurus(string naam, string geluid, int aantalPoten, bool heeftVacht, bool isBoos, bool heeftHonger)
            : base(naam, geluid, aantalPoten, heeftVacht) //Constructor van de basisklasse
        {
            this.isBozeDino = isBoos;
        }


        public void DinoMad()
        {
            isBozeDino = true;
            return $"Tyrannosaurus {naam} is aggressief, pas op dat je niet gebeten wordt!";
        }

        public void DinoCalm()
        {
            isBozeDino = false;
            return $"Tyrannosaurus {naam} is rustig op het moment. Maar pas toch maar op.";
        }

        public void DinoHungry()
        {
            heeftHonger = true;
            return $"Tyrannosaurus {naam} heeft honger.";
        }

        public void DinoSated()
        {
            heeftHonger = false;
            return $"Tyrannosaurus {naam} heeft geen honger meer.";
        }
    }
}