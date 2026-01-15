using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.Model
{
    public class Kat : Dier
    {
        //Constructor
        public Kat(string naam, string geluid, int aantalPoten, bool heeftVacht, bool kanVliegen)
            : base(naam, geluid, aantalPoten, heeftVacht, kanVliegen) //Constructor van de basisklasse
        {
            
        }

        public override string MaakGeluid()
        {
            return "Miauw";
        }
    }
}
