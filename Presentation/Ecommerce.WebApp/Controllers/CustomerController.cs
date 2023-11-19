using Ecommerce.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.WebApp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(CustomerViewModel model)
        {
            return View("Index");
        }
    }
}
