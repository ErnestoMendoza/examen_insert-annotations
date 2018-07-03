using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Examen.Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Examen_Planet_1._0v.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {      
            return View();
        }



        [HttpPost]
        public ActionResult Index(DatosPersonas model)
        {
            if (ModelState.IsValid)
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    string query = "INSERT INTO Personas(Nombre, Apellido_Paterno, Apellido_Materno, CURP) VALUES(@Nombre, @Apellido_Paterno, @Apellido_Materno, @CURP)";
                    query += " SELECT SCOPE_IDENTITY()";
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Connection = con;
                        con.Open();
                        cmd.Parameters.AddWithValue("@Nombre", model.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido_Paterno", model.aPaterno);
                        cmd.Parameters.AddWithValue("@Apellido_Materno", model.aMaterno);
                        cmd.Parameters.AddWithValue("@CURP", model.curp);
                        model.ID = Convert.ToInt32(cmd.ExecuteScalar());
                        con.Close();
                    }
                }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
      
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}