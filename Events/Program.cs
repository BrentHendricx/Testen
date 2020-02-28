using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Klant klant1 = new Klant("Tafel 1");
            Klant klant2 = new Klant("Tafel 2");
            BestellingsSysteem bestellingsSysteem = new BestellingsSysteem();
            //var bel = new bel()
            Ober Jan = new Ober("Jan")
            {
                BestellingsSysteem = bestellingsSysteem,
            };
        }
    }
}
