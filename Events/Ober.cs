using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    class Ober
    {
        private List<Klant> klanten = new List<Klant>();
        public string Naam { get; set; }
        public BestellingsSysteem BestellingsSysteem { get; set; }
        private Bel _bel;
        public Bel Bel
        {
            get { return this._bel; }
            set
            {
                if (this._bel != null || !string.IsNullOrEmpty(product))
                {

                }
            }
        }
        public Ober (string naam)
        {
            this.Naam = naam;
        }
        public void Betaal(string product)
        {

        }
        public void Consumeer(string product)
        {
            foreach (string product in Klant)
            {

            }
        }
    }
}
