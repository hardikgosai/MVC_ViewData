using Microsoft.AspNetCore.Mvc;

namespace GETRI_ViewData.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            List<string> lstCourses = new List<string>();
            lstCourses.Add("C#");
            lstCourses.Add("ASP.NET Core");
            lstCourses.Add("MVC");
            lstCourses.Add("SQL Server");
            lstCourses.Add("Angular");

            ViewData["Courses"] = lstCourses;
            return View();
        }
    }
}
