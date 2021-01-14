using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassediagram
{
    class Inschrijving // leden_speelmomenten_combo uit datamodel
    {
        public Person persoon;
        public Speelmoment speelmoment;
        public List<Inschrijving> inschrijvingen;

        public Inschrijving(Person p, Speelmoment s)
        {
            persoon = p;
            speelmoment = s;
            inschrijvingen.Add(this);
        }

        public void ZoekInschrijving()
        {
            foreach (Inschrijving inschrijving in inschrijvingen)
            {
                inschrijving.DrukInfoPersoon();
            }
        }

        public void ZoekPersonen(Person p, DateTime datum)
        {
            foreach (Sporthal sporthal in Sporthal.sporthallen)
            {
                sporthal.DrukInfo(); // naam + gemeente
                Console.WriteLine("----------------------------------"); // todo: verbeteren
                foreach (Inschrijving inschrijving in inschrijvingen)
                {
                    inschrijving.DrukInfoSpeelmoment(); // datum + speelmomenttype
                    if (inschrijving.persoon.voornaam == p.voornaam && inschrijving.persoon.familienaam == p.familienaam && inschrijving.speelmoment.datumTijd >= datum.AddDays(-14) && inschrijving.speelmoment.datumTijd <= datum)
                    {
                        foreach (Person persoon in inschrijving.speelmoment.spelerslijst)
                        {
                            persoon.DrukInfo(); // familienaam + voornaam
                        }
                    }
                }
            }
        }

        public void DrukInfoSpeelmoment()
        {
            Console.WriteLine($"{speelmoment.datumTijd} {speelmoment.speelmomenttype}:");
        }
    }
}
