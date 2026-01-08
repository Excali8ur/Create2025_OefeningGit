using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.Model
{
    internal class Beer : Dier
    {
        private bool boos;

        public Beer(string naam, string geluid, int aantalPoten, bool heeftVacht)
            : base(naam, geluid, aantalPoten, heeftVacht)
        {
            this.boos = boos;
        }
        public void boosJa()
        {
            boos = true;
        }
        public void boosNee()
        {
            boos = false;
        }
    }
}
