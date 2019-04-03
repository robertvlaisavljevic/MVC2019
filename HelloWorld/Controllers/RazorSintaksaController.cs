using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class RazorSintaksaController : Controller
    {
        // GET: RazorSintaksa
        public ViewResult SwitchView()
        {
            return View();
        }
        public ViewResult ViewZaForPetlju()
        {
<<<<<<< HEAD
            string[] voce = new string[]
            {
                "Jabuka",
                "Kruska",
                "Banana",
                "Grožđe",
                "Šljiva"
            };
            return View(voce);
=======
            return View();
>>>>>>> c17e13165121a0512bd4c3280084a58eced5935f
        }
    }
    
}