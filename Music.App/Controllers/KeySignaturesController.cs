using System;
using System.Web.Mvc;
using Music.BLL;

namespace Music.App.Controllers
{
    public class KeySignaturesController : Controller
    {
        // GET: KeySignatures
        public ActionResult Index()
        {
            char key;
            char acc;
            string mode;
            string customMode;


            ViewBag.Message = "Fill in your Key Signature here:";

            

            return View();
        }
    }
}