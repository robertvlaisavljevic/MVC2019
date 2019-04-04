using pozdravsvijete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pozdravsvijete.Controllers
{
    public class TemplHtmlHelperiController : Controller
    {
        // GET: TemplHtmlHelperi
        public ViewResult HtmlEditorView()
        {
            return View(new OsobaTempl());
        }

        [HttpPost]
        public ViewResult HtmlEditorView(OsobaTempl osoba)
        {
            return View("HtmlLabelDisplay", osoba);
        }
    }
}