using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pozdravsvijete.Controllers
{
    public class pozdravsvijeteController : Controller
    {
        // GET: pozdravsvijete
        public ActionResult Index()
        {
            string model = "Pozdrav svijete";
            return View((object(model);
        }
    }
}