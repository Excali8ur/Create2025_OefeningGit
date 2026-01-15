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
    public abstract class Dier
    {
        //Eigenschappen
        //Protected -> Beschikbaar voor eigen klasse en alle subklassen
        //Dit zijn allemaal properties. Deze kunnen opgevraagd worden van buitenaf
        //Aanpassen mag alleen binnen de klasse en subklassen
        public bool heeftVacht { get; protected set; }
        public string naam { get; protected set; }
        public string geluid { get; protected set; }
        public bool kanVliegen { get; protected set; }        
        public int aantalPoten { get; protected set; }

        //Constructoren
        /*public Dier()
        {
            this.naam = "naam";
            this.geluid = "geluid";
            this.aantalPoten = 0;
            this.heeftVacht = true;
        }*/

        public Dier(string naam, string geluid, int aantalPoten, bool heeftVacht, bool kanVliegen)
        {
            this.naam = naam;
            this.geluid = geluid;
            this.aantalPoten = aantalPoten;
            this.heeftVacht = heeftVacht;
            this.kanVliegen = kanVliegen;   
        }

        //Gedrag

        //Abstracte methode -> Wordt hier niet gemaakt, alleen de header!!
        //Hiermee dwing je af dat iedere subklasse zijn eigen versie maakt
        public abstract string MaakGeluid();        
        /*
        public string MaakGeluid()
        {
            return $"{naam} maakt het geluid {geluid}";
        }
        */

        public string ToonDetails()
        {
            string details =  $"Soort: {this.GetType().Name,-15} Naam: {naam,-20} Geluid: {geluid, -10} Aantal poten: {aantalPoten}";
            
            if (heeftVacht) details += " Heeft een vacht";
            if (kanVliegen) details += " Kan vliegen";

            return details;
        }


    }
}
