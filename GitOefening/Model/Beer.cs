using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.Model
{
    internal class Beer : Dier
    {
        //Constructor
        public Beer(string naam, string geluid, int aantalPoten, bool heeftVacht)
            : base(naam, geluid, aantalPoten, heeftVacht)
        {
            this.geluid = "Grom";
        }

    }
}

