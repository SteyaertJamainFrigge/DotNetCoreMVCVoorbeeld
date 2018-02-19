using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Oefening1.Controllers
{
    public class HomeController : Controller
    {

        private string[] groenten = { "Rode kool", "Spruiten", "Worte", "Brocoli", "Spinazie", "Bloemkool", "Chinese Kool", "" };

        public ViewResult Index(string name)
        {
            ViewBag.Groet = DateTime.Now.Hour < 12 ? "Goeimorgen" : "GoeieAvond";
            return View();
        }

        public ViewResult Groenten(string name)
        {
            ViewBag.Groenten = groenten;

            return View();
        }
    }
}