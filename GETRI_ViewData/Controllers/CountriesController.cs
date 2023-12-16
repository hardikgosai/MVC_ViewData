using Microsoft.AspNetCore.Mvc;

namespace GETRI_ViewData.Controllers
{
    public class CountriesController : Controller
    {
        public IActionResult Index()
        {
            List<string> lstCountries = new List<string>();
            lstCountries.Add("India");
            lstCountries.Add("USA");
            lstCountries.Add("UK");
            lstCountries.Add("Australia");
            lstCountries.Add("Canada");

            ViewData["Countries"] = lstCountries;
            return View();
        }
    }
}
