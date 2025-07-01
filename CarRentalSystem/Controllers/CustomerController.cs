using Microsoft.AspNetCore.Mvc;

namespace CarRentalSystem.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
