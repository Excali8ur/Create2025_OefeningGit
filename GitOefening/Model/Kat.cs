using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.Model
{
    internal class Kat : Dier
    {
        //Constructor
        public Kat(string naam, string geluid, int aantalPoten, bool heeftVacht)
            : base(naam, geluid, aantalPoten, heeftVacht) //Constructor van de basisklasse
        {
            
        }

        public override string MaakGeluid()
        {
            return "Miauw";
        }
    }
}
