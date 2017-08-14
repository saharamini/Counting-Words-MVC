using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        // Get: Home/Index
        public ActionResult Index(string id)
        {
            try
            {
                var result = new Countingcs().Countwords(id);
               
                Response.Write(result);
                Response.End();
                return View();

            }
            catch (Exception ex)
            {
                return View();
            }

            
        }

        // in RouteConfig we have id
        public ActionResult About(string id)
        {
            ViewBag.Message = "Your application description page.";

            // return View();
            return Content("name="+ id);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}