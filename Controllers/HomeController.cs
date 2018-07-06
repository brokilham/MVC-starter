using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static MVC_starter.Models.SideMenu;
namespace MVC_starter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            

            var connectionString = ConfigurationManager.ConnectionStrings["ConnStringDb1"].ConnectionString;
            var menu_webpages_list = new List<menu_webpages>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {  
                try
                {
                    string queryString = "SELECT * FROM menu_webpages";
                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                  
                    while (reader.Read())
                    {
    
                         menu_webpages_list.Add(new menu_webpages() { id = reader.GetInt32(0), name = reader.GetString(1), status = reader.GetString(2) });
                       
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return View(menu_webpages_list);
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