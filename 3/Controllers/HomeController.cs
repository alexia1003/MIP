using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proiect3_MIP.Controllers
{
    public class HomeController : Controller
    {
        // Pagina principala
        public ActionResult Index()
        {     
            return View();
        }

        // Pagina descriere
        public ActionResult About()
        {
            ViewBag.Message = "Magazin online.";

            return View();
        }

        // Pagina contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // Schimba limba site-ului
        public ActionResult ChangeLanguage(string lang)
        {
            Session["lang"] = lang;

            return RedirectToAction("Index", "Home",
                new { language = lang });
        }

    }
}