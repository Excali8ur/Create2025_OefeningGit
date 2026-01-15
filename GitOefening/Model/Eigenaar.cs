using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OverervingDieren.DAL;

namespace OverervingDieren.Model
{
    public class Eigenaar
    {
        public int Id { get; private set; }
        public string naam { get; private set; }
        public string adres { get; private set; }
        public string telefoonnummer { get; private set; }
        private List<Dier> dieren = new List<Dier>();

        /// <summary>
        /// Constructor van Eigenaar, waarin alle gegevens worden meegegeven
        /// Alleen de bijbehorende dieren worden opgehaald uit de database
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="naam"></param>
        /// <param name="adres"></param>
        /// <param name="telefoonnummer"></param>
        public Eigenaar(int Id, string naam, string adres, string telefoonnummer)
        {
            this.Id = Id;
            this.naam = naam;
            this.adres = adres;
            this.telefoonnummer = telefoonnummer;

            Dal dal = new Dal("Huisdieren");
            dieren = dal.GetAlleDierenVanEigenaar(this.Id);
        }

        /// <summary>
        /// Constructor van Eigenaar, waarin alleen het Id wordt meegegeven
        /// Gegevens worden opgehaald uit de database
        /// </summary>
        /// <param name="Id"></param>
        public Eigenaar(int Id)
        {
            this.Id = Id;

            Dal dal = new Dal("Huisdieren");

            List<string> eigenaarGegevens = dal.GetEigenaarGegevensViaId(this.Id);
            this.naam = eigenaarGegevens[0];
            this.adres = eigenaarGegevens[1];
            this.telefoonnummer = eigenaarGegevens[2];

            dieren = dal.GetAlleDierenVanEigenaar(this.Id);
        }

        public List<Dier> ToonDieren()
        {
            return dieren;
        }

        public void VoegDierToe(Dier dier)
        {
            if (dier == null)
            {
                throw new ArgumentNullException("Dier mag niet null zijn");
            }
            if (dieren.Contains(dier))
            {
                throw new ArgumentException("Dit dier is al aan deze eigenaar gekoppeld");
            }

            //Geen fout? Dier toevoegen aan database en aan lijst
            Dal dal = new Dal("Huisdieren");
            dal.VoegDierToeAanEigenaar(this.Id, dier);
            dieren.Add(dier);

        }

        public string ToonGegevens()
        {
            return $"Eigenaar {Id}:\nNaam: {naam}\nAdres: {adres}, Telefoonnummer: {telefoonnummer}";
        }
    }
}
