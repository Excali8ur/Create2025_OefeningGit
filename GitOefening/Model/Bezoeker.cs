using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.Model
{
    public class Bezoeker
    {
        //Eigenschappen

        //Property
        //Public get en private set
        public string Naam { get; private set; }        
        private int leeftijd;

        //Constructor
        //Zelfde naam als de klasse; GEEN returntype
        //Wordt aangeroepen als een nieuwe bezoeker aangemaakt wordt
        public Bezoeker(string naam, int leeftijd)
        {
            this.Naam = naam;
            this.leeftijd = leeftijd;
        }

        //Gedrag
        public bool IsVolwassen()
        {
            bool resultaat;
            //Als leeftijd groter of gelijk aan 18,
            //Dan is iemand volwassen anders niet
            if (leeftijd >= 18)
            {
                resultaat = true;
            }
            else
            {
                resultaat = false;
            }
            return resultaat;
            //1 regel variant, komt hij nooit
            return (leeftijd >= 18);
        }
    }
}
