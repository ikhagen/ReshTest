using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReshTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Homeboy";

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Title = "About time";

            return View();
        }
        public ActionResult Isengard()
        {
            ViewBag.Title = "They're taking the hobbits";

            return View();
        }
    }
}
