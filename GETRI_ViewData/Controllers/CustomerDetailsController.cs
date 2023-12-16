using GETRI_ViewData.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETRI_ViewData.Controllers
{
    public class CustomerDetailsController : Controller
    {
        public IActionResult Index()
        {
            List<CustomerDetails> lstCustomerDetails = new List<CustomerDetails>();
            
            CustomerDetails customerDetails = new CustomerDetails();
            customerDetails.CustomerId = 1;
            customerDetails.CustomerName = "John Doe";
            customerDetails.CustomerAddress = "Street 1";
            customerDetails.CustomerCity = "New York";
            lstCustomerDetails.Add(customerDetails);

            customerDetails = new CustomerDetails();
            customerDetails.CustomerId = 2;
            customerDetails.CustomerName = "Jane Jhonson";
            customerDetails.CustomerAddress = "Street 2";
            customerDetails.CustomerCity = "London";
            lstCustomerDetails.Add(customerDetails);

            customerDetails = new CustomerDetails();
            customerDetails.CustomerId = 3;
            customerDetails.CustomerName = "Mark Smith";
            customerDetails.CustomerAddress = "Street 3";
            customerDetails.CustomerCity = "Sydney";
            lstCustomerDetails.Add(customerDetails);

            customerDetails = new CustomerDetails();
            customerDetails.CustomerId = 4;
            customerDetails.CustomerName = "David Miller";
            customerDetails.CustomerAddress = "Street 4";
            customerDetails.CustomerCity = "Toronto";
            lstCustomerDetails.Add(customerDetails);

            ViewData["CustomerDetails"] = lstCustomerDetails;
            return View();
        }
    }
}
