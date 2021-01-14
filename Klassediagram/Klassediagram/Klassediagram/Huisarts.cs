using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klassediagram
{
    public class Huisarts
    {
        private int rizivnr { get; set; }
        private string voornaam { get; set; }
        private string familienaam { get; set; }
        private string straat { get; set; }
        private string huisnr { get; set; }
        private string postcode { get; set; }
        private string gemeente { get; set; }
        private string telnr { get; set; }
        private string email { get; set; }


        public static List<Huisarts> huisartsen;
        public Huisarts(int rizivnr, string voornaam, string familienaam, string straat, string huisnr, string postcode, string gemeente, string telnr, string email)
        {
            this.rizivnr = rizivnr;
            this.voornaam = voornaam;
            this.familienaam = familienaam;
            this.straat = straat;
            this.huisnr = huisnr;
            this.postcode = postcode;
            this.gemeente = gemeente;
            this.telnr = telnr;
            this.email = email;
        }
        public void ZoekHuisarts()
        {
            foreach (Huisarts huisarts in huisartsen)
            {
                huisarts.DrukInfo();
            }
        }

        public void DrukInfo()
        {
            Console.WriteLine($"{familienaam} {voornaam} - {straat} {huisnr}, {postcode} {gemeente}");
        }
    }
}