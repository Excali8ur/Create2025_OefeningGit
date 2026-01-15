using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverervingDieren.Model
{
    public class Ticket
    {
        //Allemaal private eigenschappen, geen proprties
        private int totaalPrijs;
        private int prijsVolwassene;
        private int prijsKind;
        private List<Bezoeker> bezoekers;

        //Constructor
        public Ticket(int prijsVolwassene, int prijsKind)
        {
            this.prijsVolwassene = prijsVolwassene;
            this.prijsKind = prijsKind;
            totaalPrijs = 0;
            bezoekers = new List<Bezoeker>();
        }

        public Ticket(int prijsVolwassene, int prijsKind, List<Bezoeker> bezoekers)
        {
            this.prijsVolwassene = prijsVolwassene;
            this.prijsKind = prijsKind;
            this.bezoekers = bezoekers;

            totaalPrijs = berekenTotaalprijs();            
        }

        private int berekenTotaalprijs()
        {
            //Totaalprijs = (aantalvolwassen * prijsVol) + (aantalkinderen * prijsKind)
            int aantalKinderen = 0;
            int aantalVolwassene = 0;

            foreach (Bezoeker bezoeker in bezoekers)
            {
                bool isVolwassene = bezoeker.IsVolwassen();
                if (isVolwassene)
                {
                    aantalVolwassene++;
                }
                else
                {
                    aantalKinderen++;
                }
            }
            totaalPrijs = (aantalKinderen * prijsKind) + (aantalVolwassene * prijsVolwassene);
            return totaalPrijs;
        }

        public int ToonPrijs()
        {
            berekenTotaalprijs();
            return totaalPrijs;
        }

        public void VoegBezoekerToe(Bezoeker bezoeker)
        {
            bezoekers.Add(bezoeker);
            berekenTotaalprijs();
        }

    }
}
