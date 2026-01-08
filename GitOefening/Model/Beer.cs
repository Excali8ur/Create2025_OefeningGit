using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.Model
{
    class Beer : Dier
    {
        private bool heeftHoning;
        public Beer(string naam, string geluid, int aantalPoten, bool heeftVacht, bool heeftHoning)
            : base(naam, geluid, aantalPoten, heeftVacht)
        {
            this.heeftHoning = false;
        }

        public void VindHoning()
        {
            heeftHoning = true;
        }

        public void EetHoning()
        {
            if (heeftHoning)
            {
                Console.WriteLine($"{naam} eet de honing op.");
                heeftHoning = false;
            }
            else
            {
                Console.WriteLine($"{naam} heeft geen honing om op te eten.");
            }
        }
    }
}
