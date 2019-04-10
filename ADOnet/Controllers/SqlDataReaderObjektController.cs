using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ADOnet.Controllers
{
    public class SqlDataReaderObjektController : Controller
    {
        // GET: SqlDataReaderObjekt
        public ActionResult Index()
        {
            string connstring = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                string cmdText = "";
                cmdText += "INSERT INTO tblTecajevi ";
                cmdText += "(naziv, opis)";
                cmdText += "VALUES ";
                cmdText += "('Web design', 'Naucite dizajnirati web stranice') ";

                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Tecaj t1 = new Tecaj();
                        t1.Id = int.Parse(reader["id"].ToString());
                        t1.naziv = reader["naziv"].ToString();
                        t1.opis = reader["opis"].ToString();

                        lstTecajevi.Add(t1);
                    }

                } 

            }
            return View("Index", lstTecajevi);
        }
        
    }
    } 