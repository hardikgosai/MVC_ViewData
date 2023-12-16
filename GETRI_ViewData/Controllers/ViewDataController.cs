using Microsoft.AspNetCore.Mvc;

namespace GETRI_ViewData.Controllers
{
    public class ViewDataController : Controller
    {
        public IActionResult Index()
        {
            string val = "Learning ASP.NET Core MVC";
            ViewData["Name"] = val;
            ViewData["Addition"] = Addition(10,10);
            ViewData["Subtraction"] = Subtraction(10, 10);
            ViewData["Multiplication"] = Multiplication(10, 10);
            ViewData["Division"] = Division(10, 10);
            ViewData["FullName"] = GetFullName("John", "Doe");

            return View();
        }

        public int Addition(int a, int b)
        {
            return a + b;
        }
        
        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }

        public string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}
