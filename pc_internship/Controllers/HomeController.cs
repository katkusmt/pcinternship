using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pc_internship.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Employees first. Myself second.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Nothing here will tell you much about me.";

            return View();
        }
    }
}