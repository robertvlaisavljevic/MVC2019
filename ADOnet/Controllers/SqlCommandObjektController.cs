using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADOnet.Controllers
{
    public class SqlCommandObjektController : Controller
    {
        // GET: SqlCommandObjekt
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            //Kreiramo ConnectionString
            string connstring = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            using (SqlConnection conn=new SqlConnection(connstring))
            {
                string cmdText = "";
                cmdText += "INSERT INTO tblTecajevi ";
                cmdText += "(naziv, opis)" ;
                cmdText += "VALUES ";
                cmdText += "('Web design', 'Naucite dizajnirati web stranice') ";

                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Connection.Open();

                int brojDodanihRedaka = cmd.ExecuteNonQuery();
                if (brojDodanihRedaka > 0)
                {
                    ViewBag.Message = "zapis je upisan u bazu!";
                }
                else
                {
                    ViewBag.Message = "dogodila se greska";
                }
            }
            return View("Index");
        }

        public ActionResult Edit()
        {
            string connString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string cmdText = "";
                cmdText += "UPDATE  tblTecajevi ";
                cmdText += "SET naziv='Web programiranje' ";
                cmdText += "WHERE id=1";

                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Connection.Open();

                int brojIzmjenjenihRedaka = cmd.ExecuteNonQuery();
                ViewBag.Message = "broj izmjenjenih redaka:"
                    + brojIzmjenjenihRedaka.ToString();

            }
            return View("Index");
        }
            public ActionResult Delete()
            {
                string connString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
                {
                    string cmdText = "DELETE FROM tblTecajevi ";
                    cmdText += "WHERE id=1";

                    SqlCommand cmd = new SqlCommand(cmdText, conn);
                    cmd.Connection.Open();

                    int brojObrisanihRedaka = cmd.ExecuteNonQuery();
                    ViewBag.Message = "broj obrisanih redaka:"
                        + brojObrisanihRedaka;
                
                    return View("Index");
                }
            }
            public ActionResult Count()
            {
            string connString = ConfigurationManager.ConnectionStrings[0].ConnectionString; ;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string cmdText = "SELECT COUNT (*) from tblTecajevi ";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Connection.Open();
                int brojZapisa = (int)cmd.ExecuteScalar();
                ViewBag.Message = "broj tecajeva u bazi je: "
                        + brojZapisa.ToString();
            }
            return View("Index");
        }
    }
}