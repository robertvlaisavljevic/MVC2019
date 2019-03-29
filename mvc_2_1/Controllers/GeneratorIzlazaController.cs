using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_2_1.Controllers
{
    public class GeneratorIzlazaController : Controller
    {
        // GET: GeneratorIzlaza
        public ActionResult RedirectNaMetodu(string id)
        {
            if (id=="pozdrav")
            {
                return RedirectToAction("pozdravsvijete", "Index");
            }
            return View();
        }


    }
}