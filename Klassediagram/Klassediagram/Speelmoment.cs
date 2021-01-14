using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klassediagram
{
    public class Speelmoment
    {
        public DateTime datumTijd { get; set; }
        private int maxCapaciteit { get; set; } // todo: naar sporthal verhuizen?
        public Person[] spelerslijst { get; set; }
        public Speelmomenttype speelmomenttype { get; set; }
        public Sporthal sporthal { get; set; }

        public void ZoekSpeelmoment() // todo: uitbreiden naar zoeken op sporthal/datumTijd/...?
        {
            foreach (Speelmoment speelmoment in Speelmoment.speelmomenten)
            {
                speelmoment.DrukInfo(); // datum + tijd + sporthal
            }
        }

        public void DrukInfo()
        {
            Console.WriteLine($"{datumTijd.Date}\t{datumTijd.TimeOfDay}\t{sporthal.naam}"); // checken of datum en tijd juist worden weergegeven
        }

        public static List<Speelmoment> speelmomenten;
        public Speelmoment(DateTime datumTijd, int maxCapaciteit)
        {
            this.datumTijd = datumTijd;
            this.maxCapaciteit = maxCapaciteit;
            speelmomenten.Add(this); // todo: hoe checken of deze al bestaat in database?
        }
        
    }
}