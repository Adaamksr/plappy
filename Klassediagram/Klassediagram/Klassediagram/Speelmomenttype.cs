using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klassediagram
{
    public class Speelmomenttype
    {
        private string naam { get; set; } // todo: hoe mogelijke namen beperken?

        public static List<Speelmomenttype> speelmomenttypes;

        public Speelmomenttype(string naam)
        {
            this.naam = naam;
            speelmomenttypes.Add(this);
        }
        public void ZoekSpeelmomenttype()
        {
            foreach (Speelmomenttype speelmomenttype in speelmomenttypes)
            {
                speelmomenttype.DrukInfo();
            }
        }

        public void DrukInfo()
        {
            Console.WriteLine($"{naam}");
        }

    }
}