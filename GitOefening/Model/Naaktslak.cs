using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.Model
{
    internal class Naaktslak
    {
		public Naaktslak(string naam, string geluid, int aantalPoten, bool heeftVacht, bool draagtHoed)
			: base(naam, geluid, aantalPoten, heeftVacht);
	}
}
