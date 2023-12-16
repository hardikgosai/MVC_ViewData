using GETRI_ViewData.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETRI_ViewData.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult CustomerDetails()
        {
            ViewData["Title"] = "Customer Details Page";
            ViewData["Header"] = "Customer Details";

            CustomerModel customerModel = new CustomerModel()
            {
                CustomerId = 1,
                CustomerName = "John Doe",
                CustomerAddress = "New York",
                CustomerEmail = "abc@xyz.com",
                CustomerContact = "1234567890",
                CustomerAge = 30,
                CustomerGender = "Male"
            };

            ViewData["Customer"] = customerModel;
            return View();
        }
    }
}
