using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klassediagram
{
    public class Sporthal
    {
        public string naam { get; set; }
        private string straat { get; set; }
        private string huisnr { get; set; }
        private string postcode { get; set; }
        private string gemeente { get; set; }
        private string telnr { get; set; }
        private string email { get; set; }
        private DateTime[] speelmomenten { get; set; }

        public void ZoekSporthal()
        {
            foreach (Sporthal sporthal in Sporthal.sporthallen)
            {
                sporthal.DrukInfo();
            }
        }

        public string DrukInfo()
        {
            return $"{naam} - {gemeente}";
        }

        public static List<Sporthal> sporthallen;

        public Sporthal(string naam, string straat, string huisnr, string postcode, string gemeente, string telnr, string email)
        {
            this.naam = naam;
            this.straat = straat;
            this.huisnr = huisnr;
            this.postcode = postcode;
            this.gemeente = gemeente;
            this.telnr = telnr;
            this.email = email;
            sporthallen.Add(this);
        }
    }
}