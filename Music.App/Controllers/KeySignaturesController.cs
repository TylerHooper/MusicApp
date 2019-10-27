using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Music.BLL;
using Music.App.Models;


namespace Music.App.Controllers
{
    public class KeySignaturesController : Controller
    {
        // GET: KeySignatures
        public ActionResult Index()
        {
            ViewBag.KeyColor = "";
            return View();
        }

        //public ActionResult Result()
        //{
        //    ViewBag.Message = "Here is your Key Signature:";
        //    ViewBag.Title = "Result";

        //    return View();
        //}

        [HttpPost]
        public ActionResult Index(KeySignatureForm keySignature)
        {
            // declare variables based on form input
            char key = keySignature.Key;
            string accidential = keySignature.Accidential;
            string mode = keySignature.Mode;
            string customMode = keySignature.CustomMode;

            // pass input values from form to ModeResponse method in the BLL, assign results to string
            string[] modeResult = KeySigGenerator.ModeResponse(key, accidential, mode, customMode);

            ViewBag.Result = String.Format("The keys are: {0} {1} {2} {3} {4} {5} {6} {7}", modeResult[0], modeResult[1], modeResult[2], modeResult[3], modeResult[4], modeResult[5], modeResult[6], modeResult[7]);

            for (int i = 0; i < 7; i++)
            {
                switch (modeResult[i])
                {
                    case "C":
                        ViewBag.KeyColorC = "white-selected";
                        break;
                    case "D♭":
                        ViewBag.KeyColorCS = "black-selected";
                        break;
                    case "D":
                        ViewBag.KeyColorD = "white-selected";
                        break;
                    case "E♭":
                        ViewBag.KeyColorDS = "black-selected";
                        break;
                    case "E":
                        ViewBag.KeyColorE = "white-selected";
                        break;
                    case "F":
                        ViewBag.KeyColorF = "white-selected";
                        break;
                    case "G♭":
                        ViewBag.KeyColorFS = "black-selected";
                        break;
                    case "G":
                        ViewBag.KeyColorG = "white-selected";
                        break;
                    case "A♭":
                        ViewBag.KeyColorGS = "black-selected";
                        break;
                    case "A":
                        ViewBag.KeyColorA = "white-selected";
                        break;
                    case "B♭":
                        ViewBag.KeyColorAS = "black-selected";
                        break;
                    case "B":
                        ViewBag.KeyColorB = "white-selected";
                        break;
                    default:
                        ViewBag.KeyColorError = "The key color broke!";
                        break;
                }
            }

            return View();
        }

    }
}