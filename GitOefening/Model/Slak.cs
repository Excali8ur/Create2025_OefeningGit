using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.Model
{
    internal class Slak : Dier
    {
        //Specifieke eigenschap voor alleen Slak
        private bool heeftHuisje;

        //Consctructor
        public Slak(string naam, string geluid, int aantalPoten, bool heeftVacht, bool heeftHuisje)
           : base(naam, geluid, aantalPoten, heeftVacht)
        {
            this.heeftHuisje = heeftHuisje;
        }

        public void HeeftHuisjeWel()
        {
            heeftHuisje = true;
        }

        public void HeeftHuisjeNiet()
        {
            heeftHuisje = false;
        }
    }

}
