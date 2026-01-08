using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.Model
{
    /// <summary>
    /// Abstracte klasse Dier, want een algemeen dier maak je niet (altijd een subklasse)
    /// </summary>
    internal abstract class Dier
    {
        //Eigenschappen
        //Protected -> Beschikbaar voor eigen klasse en alle kinderen      

        protected bool heeftVacht;
        protected string naam;
        protected string geluid;

        //Property voor aantal poten. Deze mag alleen opgevraagd worden van buitenaf
        //Aanpassen mag alleen binnen de klasse en subklassen
        public int aantalPoten { get; protected set; }

        //Constructoren
        /*public Dier()
        {
            this.naam = "naam";
            this.geluid = "geluid";
            this.aantalPoten = 0;
            this.heeftVacht = true;
        }*/

        public Dier(string naam, string geluid, int aantalPoten, bool heeftVacht)
        {
            this.naam = naam;
            this.geluid = geluid;
            this.aantalPoten = aantalPoten;
            this.heeftVacht = heeftVacht;
        }

        //Gedrag
     
        public string MaakGeluid()
        {
            return $"{naam} maakt het geluid {geluid}";
        }

        public string Eten()
        {
            return $"{naam} eet zijn voer";
        }
    }
}
