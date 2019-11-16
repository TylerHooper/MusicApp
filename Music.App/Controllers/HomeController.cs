using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Music.BLL;

namespace Music.App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.DateTimeNow = DateTime.Now;
            ViewBag.Message = "This is the about page!";

            return View();
        }

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Please email all inquires to:";

        //    return View();
        //}
    }
}