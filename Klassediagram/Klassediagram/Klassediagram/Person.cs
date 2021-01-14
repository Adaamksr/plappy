using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klassediagram
{
    public class Person
    {
        private int lidnr { get; set; }
        public string voornaam { get; set; }
        public string familienaam { get; set; }
        private string straat { get; set; }
        private string huisnr { get; set; }
        private string postcode { get; set; }
        private string gemeente { get; set; }
        private string land { get; set; }
        private string telnr { get; set; }
        private string gsmnr { get; set; }
        private string email { get; set; }
        private DateTime geboortedatum { get; set; }
        private int klassement { get; set; }
        private string emergencyFamilienaam { get; set; }
        private string emergencyVoornaam { get; set; }
        private string emergencyTelnr { get; set; }
        private bool actiefLid { get; set; }
        private DateTime lidSinds { get; set; }
        private bool hasAppToegang { get; set; }
        private bool isPloegkapitein { get; set; }
        private bool isWedstrijdleider { get; set; }
        public static List<Person> personen;
        private Huisarts huisarts { get; set; }
        private Inloggegevens inloggegevens { get; set; }
        private Spelerscategorie spelerscategorie { get; set; }
        private Bestuursrol bestuursrol { get; set; }
        private Geslacht geslacht { get; set; }

        // optionele parameters achteraan:
        public Person(int lidnr, string voornaam, string familienaam, string straat, string huisnr, string postcode, string gemeente, string land, string telnr, string gsmnr, string email, DateTime geboortedatum, string emergencyFamilienaam, string emergencyVoornaam, string emergencyTelnr, DateTime lidSinds, bool actiefLid = true, bool hasAppToegang = false, bool isPloegkapitein = false, bool isWedstrijdleider = false)
        {
            this.lidnr = lidnr;
            this.voornaam = voornaam;
            this.familienaam = familienaam;
            this.straat = straat;
            this.huisnr = huisnr;
            this.postcode = postcode;
            this.gemeente = gemeente;
            this.land = land;
            this.telnr = telnr;
            this.gsmnr = gsmnr;
            this.email = email;
            this.geboortedatum = geboortedatum.Date; // todo: Date ok?
            this.emergencyFamilienaam = emergencyFamilienaam;
            this.emergencyVoornaam = emergencyVoornaam;
            this.emergencyTelnr = emergencyTelnr;
            this.lidSinds = lidSinds.Date; // todo: Date ok?
            this.actiefLid = actiefLid;
            this.hasAppToegang = hasAppToegang;
            this.isPloegkapitein = isPloegkapitein;
            this.isWedstrijdleider = isWedstrijdleider;

            // checken of persoon al in database staat
            foreach (Person persoon in personen)
            {
                if (persoon.voornaam == voornaam && persoon.familienaam == familienaam && persoon.geboortedatum == geboortedatum)
                {
                    continue;
                }
                else
                {
                    personen.Add(this);
                }
            }
        }

        public void ZoekPersoon() // eenvoudige opzoekfunctie om speler te koppelen aan speelmoment
        {
            foreach (Person persoon in personen)
            {
                persoon.DrukInfo();
            }
        }

        public void DrukInfo()
        {
            Console.WriteLine($"{familienaam} {voornaam}");
        }
    }
}