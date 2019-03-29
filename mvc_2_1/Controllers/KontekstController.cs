using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_2_1.Controllers
{
    public class KontekstController : Controller
    {
        // GET: Kontekst
        
        public string Index()
        {
            string poruka = "danas je: " + DateTime.Now.ToLongDateString();
            return poruka;
        }

        public string QueryPodaci(int? id)
        {
            
            {
                if (Request.QueryString["Ime"] == null || Request.QueryString["Prezime"] == null)
                {
                    return "Podaci su nepotpuni!";
                }
                else
                {
                    string ime = Request.QueryString["Ime"];
                    string prezime = Request.QueryString["Prezime"];
                    string tekstsastilom = string.Format("<label style='color:red; font-weight:bold;'>{0} {1}</label>", ime, prezime);
                    return string.Format("<p> Ime i Prezime iz query stringa su: {0}</p>", tekstsastilom);
                }
            }
        }

        public string RoutePodaci(int id=123)
        {
            try
            {
                string kontroler = RouteData.Values["controller"].ToString();
                string akcijskaMetoda = RouteData.Values["action"].ToString();
                string parametarId = RouteData.Values["id"].ToString();
                return "<h1>Route podaci:</h1>" +
                    "Kontroler: " + kontroler + "<br/>" +
                    "Parametar id: " + parametarId + "<br/>";
            }
            catch (Exception e)
            {
                return "Doslo je do pogreske: " + e.Message;
            }
        }
    }
} 