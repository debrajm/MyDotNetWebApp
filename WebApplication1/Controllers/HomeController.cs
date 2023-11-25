using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            // ViewBag.Message = "Your application description page. This is for testing.";

            return View();
        }

        public ActionResult Contact()
        {
            // ViewBag.Message = "Your contact page. This is test purpose";

            return View();
        }

        public ActionResult Career()
        {
            // ViewBag.Message = "This is your career page";
            return View();
        }

        public ActionResult Product()
        {
            //ViewBag.Message = "This is your Product page";
            return View();
        }
    }
}