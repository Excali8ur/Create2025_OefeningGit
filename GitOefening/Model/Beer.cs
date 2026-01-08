using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.Model
{
    internal class Beer : Dier
    {
        //Properties
        private string type;

        //Constructor
        public Beer(string naam, string type, string geluid, int aantalPoten, bool heeftVacht, string voedsel)
         : base(naam, geluid, aantalPoten, heeftVacht, voedsel)
        {
            this.type = type;
        }

        //Methods

        public string GetInfo()
        {
            return $"{naam} de {type} houd van {voedsel} eten";
        }
    }
}
