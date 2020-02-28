using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    class Kok
    {
        public string Naam { get; set; }
        private BestellingsSysteem _bestellingsSysteem;
        public BestellingsSysteem BestellingsSysteem
        {
            get { return _bestellingsSysteem }
            set
            {
                if (_bestellingsSysteem != null) _bestellingsSysteem.BestellingsEvent -= BestellingOntvangen;
                _bestellingsSysteem = value;
                _bestellingsSysteem.BestellingEvent += BestellingOntvangen;
            }
        }
        public Kok (string naam)
        {
            Naam = naam;
        }
        public void BestellingOntvangen (object sender, BestelEventArgs args)
        {
            if (args == null || string.IsNullOrEmpty(product)) return; //Preconditie
            System.Console.WriteLine(args.Product + " in voorbereiding");
            System.Threading.Thread.Sleep(5000);
            /*
            Bel.Ring(args);
            */
        }
    }
}
