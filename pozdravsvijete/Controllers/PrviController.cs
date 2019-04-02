using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pozdravsvijete.Controllers
{
    public class PrviController : Controller
    {
        // GET: Prvi
        public ActionResult MetodaSaParametrima(int id)
        {
            // return View();
            return Content(id.ToString());
        }

        // GET: Drugi
        public ViewResult DrugaMetodaSaParametrima(int id)
        {
            return View((object)id);
            //return Content(id.ToString());
        }
    }
}