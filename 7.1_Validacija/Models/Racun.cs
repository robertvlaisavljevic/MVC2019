using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _7._1_Validacija.Models
{
    public class Racun
    {
        public string BrojRacuna { get; set; }
        public DateTime Datum { get; set; }
        public string Zapolsenik { get; set; }
        public string Kupac { get; set; }
        public decimal Cijena { get; set; }
    }
}