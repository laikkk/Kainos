using aspTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Countries and Languages";
           return View();
        }
     
        public ActionResult countries()
        {
            ViewBag.Message = "Official languages of countries";
            CountryModel cm = new CountryModel();
            return View(cm.PopulateCountriesList());
        }

        public ActionResult groupedCountries()
        {
            ViewBag.Message = "Global Language use";
            GroupedCountriesModel gcm = new GroupedCountriesModel();
            return View( gcm.PopulateGroupedCountriesList());
        }

        public ActionResult country(string id)
        {
            CountryCodeModel ccm = new CountryCodeModel();
            var ccmbList = ccm.PopulateCountryCodeList(id);
            if(ccmbList[0].Name != null)
                ViewBag.Message = "Language use in " + ccmbList[0].Name;
            return View(ccmbList);
        }
     
    }
}