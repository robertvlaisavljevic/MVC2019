using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlHelperi.Models;

namespace HtmlHelperi.Controllers
{
    public class MetaDataHtmlHelperiController : Controller
    {
        // GET: TemplHtmlHelperi
        public ViewResult MetaDataView()
        {
            return View(new OsobaMeta());
        }

        [HttpPost]
        public ViewResult MetaDataView(OsobaMeta osoba)
        {
            return View("HtmlLabelDisplay", osoba);
        }
    }
}