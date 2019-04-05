using _7._1_Validacija.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _7._1_Validacija.Controllers
{
    public class ValidacijeController : Controller
    {
        // GET: Validacije
        public ViewResult IzdavanjeRacuna()
        {
            return View(new Racun() { Datum = DateTime.Now, BrojRacuna = "/" + DateTime.Now.Year.ToString() });
        }

        [HttpPost]
        public ViewResult IzdavanjeRacuna(Racun racun)
        {
            //obavezne vrijednosti
            if (string.IsNullOrEmpty(racun.BrojRacuna))
            {
                ModelState.AddModelError("BrojRacuna", "Broj Racuna je obavezan!");
            }
            if (string.IsNullOrEmpty(racun.Zapolsenik))
            {
                ModelState.AddModelError("Zapolsenik", "Zapolsenik je obavezan!");
            }
            if (string.IsNullOrEmpty(racun.Kupac))
            {
                ModelState.AddModelError("Kupac", "Kupac je obavezan!");
            }

            //model-level validacija
            if (ModelState.IsValidField ("Datum"))
            {
                ModelState.AddModelError("", "Datum ne smije biti manji za vise od 3 dana!");
            }

            //ukupna provjera validacije
            if (ModelState.IsValid)
            {
                return View("RacunIzdan", racun);
            }
            else
            {
                return View();
            }
        }
    }
}