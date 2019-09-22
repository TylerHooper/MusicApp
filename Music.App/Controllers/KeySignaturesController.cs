using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Music.App.Controllers
{
    public class KeySignaturesController : Controller
    {
        // GET: KeySignatures
        public ActionResult Index()
        {
            ViewBag.Message = "Fill in your Key Signature here:";
            return View();
        }
    }
}