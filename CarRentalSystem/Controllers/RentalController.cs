using Microsoft.AspNetCore.Mvc;

namespace CarRentalSystem.Controllers
{
    public class RentalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
