using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace childaction1.Controllers
{
    public class ChildActionViewController : Controller
    {
        // GET: ChildActionView
        public ActionResult ChildActionView()
        {
            string[] proizvodi = new string[]
            {
                "Banana", "Krumpir", "Brokula", "Mandarina", "Limun", "Mrkva"
            };
            return View(proizvodi);
        }
        [ChildActionOnly]
        public string OdrediGrupuProizvoda(string proizvod)
        {
            switch (proizvod)
            {
                case "Banana":
                case "Limun":
                    return "voce";
                case "Mrkva":
                case "Krumpir":
                    return "povrce";
                default:
                    return "Nepoznato";
                    
            }
        }
    }
}