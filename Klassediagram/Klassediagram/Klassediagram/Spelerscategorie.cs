using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klassediagram
{
    public class Spelerscategorie
    {
        private string naamSpelerscategorie { get; set; } // todo: hoe mogelijke namen beperken?

        public static List<Spelerscategorie> spelerscategorieen;

        public Spelerscategorie(string naam)
        {
            naamSpelerscategorie = naam;
            spelerscategorieen.Add(this);
        }
        public void ZoekSpelerscategorie() // todo: of met argument tussen ()?
        {
            foreach (Spelerscategorie spelerscategorie in spelerscategorieen)
            {
                spelerscategorie.DrukInfo();
            }
        }

        public void DrukInfo()
        {
            Console.WriteLine($"{naamSpelerscategorie}");
        }

    }
}