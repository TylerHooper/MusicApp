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
            ViewBag.Message = "Fill in your Key Signature here:";
            
            return View();
        }

        [HttpPost]
        public ActionResult Index(KeySignatureForm keySignature)
        {
            // declare variables based on form input
            char key = keySignature.Key;
            string accidential = keySignature.Accidential;
            string mode = keySignature.Mode;
            string customMode = keySignature.CustomMode;

            return View();
        }

    }
}