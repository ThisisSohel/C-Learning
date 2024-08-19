using MVCFrameWorkProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFrameWorkProject.Controllers
{
    public class CountryController : Controller
    {

        static List<Country> countries = new List<Country>()
        {
            new Country() {Id = 111, Name = "Bangladesh", PassWord = ""},
            new Country() {Id = 112, Name = "UK", PassWord = ""},
            new Country() {Id = 113, Name = "USA", PassWord = ""},
        };
        public ActionResult Index()
        {
            ViewBag.CountriesList = new List<string>()
            {
                "BD",
                "UK",
                "USA"
            };

            ViewData["CountriesList"] = new List<string>()
            {
                "BD",
                "UK",
                "USA"
            };

            TempData["tempData"] = "This message from temp data!";

            ViewBag.UnderLine = "..................";
            ViewBag.VB = "dgf";
            ViewData["VD"] = "Data from ViewData";
            ViewBag.DropDownListOfCountry = new SelectList(countries, "Id", "Name");


            TempData["myData"] = "Temp Data from Country Controller";
 
            return View(countries);
            //return RedirectToAction("Index", "Home2");



        }


    }
}