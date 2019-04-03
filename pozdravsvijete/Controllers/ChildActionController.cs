using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pozdravsvijete.Controllers
{
    public class ChildActionController : Controller
    {
        // GET: ChildAction
        public ActionResult ChildActionView()
        {
            string[] proizvodi = new string[]
            {
                "Banana", "Jabuka", "Kivi", "Mrkva", "Kupus"
            };
            return View(proizvodi);
        }
        
        [ChildActionOnly]
        public string OdrediGrupuProizvoda(string proizvod)
        {
            switch (proizvod)
            {
                case "Kivi":
                case "Jabuka":
                case "Banana": return "voce";
                default:
                    return "Povrce";
                   
            }
        }
    }
}