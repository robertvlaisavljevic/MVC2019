using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADOnet.Controllers
{
    public class SqlConnectionObjektController : Controller
    {
        // GET: SqlConnectionObjekt direktno
        
         // GET: SqlConnectionObjekt
        public ActionResult Spoj()
        {
            //Prvo kreiramo konn string
            //string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=algebra;Integrated Security=True";
            string connString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            //Nakon toga instanca Sqqlconnection
            SqlConnection conn = new SqlConnection(connString);

            //otvaramo vezu s bazom
            try
            {
                conn.Open();
                if (conn.State==System.Data.ConnectionState.Open)
                {
                    Response.Write("Konekcija je uspjela");
                }
            }
            catch(Exception ex)
            {
                Response.Write("Konekcija nije uspjela"+ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return View();
        }


    }
}