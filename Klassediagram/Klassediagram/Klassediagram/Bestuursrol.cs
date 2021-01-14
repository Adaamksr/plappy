using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klassediagram
{
    public class Bestuursrol
    {
        private string naamBestuursrol { get; set; }
        private string omschrijving { get; set; }

        public static List<Bestuursrol> bestuursrollen;

        public Bestuursrol(string naam, string omschrijving)
        {
            naamBestuursrol = naam;
            this.omschrijving = omschrijving;
            bestuursrollen.Add(this);
        }
        public void ZoekBestuursrol()
        {
            foreach (Bestuursrol bestuursrol in bestuursrollen)
            {
                bestuursrol.DrukInfo();
            }
        }

        public void DrukInfo()
        {
            Console.WriteLine($"{naamBestuursrol}");
        }

    }
}