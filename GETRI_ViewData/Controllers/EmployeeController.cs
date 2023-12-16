using GETRI_ViewData.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETRI_ViewData.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            EmployeeModel employee = new EmployeeModel()
            {
                EmpId = 1,
                EmpName = "John Doe",
                EmpSal = 10000
            };

            ViewData["EmpId"] = employee.EmpId;
            ViewData["EmpName"] = employee.EmpName;
            ViewData["EmpSal"] = employee.EmpSal;
            return View();
        }
    }
}
