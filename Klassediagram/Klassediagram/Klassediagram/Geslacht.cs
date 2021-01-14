using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klassediagram
{
    public class Geslacht
    {
        private char naam { get; set; } // todo: hoe mogelijke namen beperken met getter en setter?
        public static List<Geslacht> geslachten;
        public Geslacht(char naam)
        {
            this.naam = naam;
            geslachten.Add(this);
        }
        public void ZoekGeslacht()
        {
            foreach (Geslacht geslacht in geslachten)
            {
                geslacht.DrukInfo();
            }
        }

        public void DrukInfo()
        {
            Console.WriteLine($"{naam}");
        }
    }

}