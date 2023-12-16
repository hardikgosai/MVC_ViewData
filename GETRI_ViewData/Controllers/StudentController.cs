using GETRI_ViewData.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETRI_ViewData.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentDetails()
        {
            ViewData["Title"] = "Student Details Page";
            ViewData["Header"] = "Student Details";

            StudentModel studentModel = new StudentModel()
            {
                StudentId = "1",
                StudentName = "John Doe",
                StudentBranch = "CSE",
                StudentSection = "A",
                StudentGender = "Male"
            };

            ViewData["Student"] = studentModel;

            return View();
        }
    }
}
