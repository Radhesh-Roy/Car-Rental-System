using Microsoft.AspNetCore.Mvc;

namespace CarRentalSystem.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
