using System.Collections.Generic;
using System.Web.Mvc;
using Vidly2.Models;

namespace Vidly2.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>()
            {
                new Customer(){Id = 0, Name = "John Smith"},
                new Customer(){Id = 1, Name = "Mary Williams"}
            };
            return View(customers);
        }
        
        public ActionResult Detail(int id)
        {
            var customers = new List<Customer>()
            {
                new Customer(){Id = 0, Name = "John Smith"},
                new Customer(){Id = 1, Name = "Mary Williams"}
            };

            if (id < customers.Count)
            {
                return View(customers[id]);
            }
            else
            {
                return HttpNotFound();
            }
        }
    }
}