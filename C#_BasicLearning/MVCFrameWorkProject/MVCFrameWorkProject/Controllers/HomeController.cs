using MVCFrameWorkProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFrameWorkProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TempData["Message"] = "Hello from home controller!";

            ViewData["data"] = 123;

            //return RedirectToAction("Index", "Country");
            return View();
        }

        [ChildActionOnly]
        public ActionResult RenderMenu()
        {
            return PartialView("_MenuBar");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}