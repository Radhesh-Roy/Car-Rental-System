using CarRentalSystem.DatabaseContext;
using CarRentalSystem.Models;
using CarRentalSystem.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalSystem.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarRepository Context;

        public CarsController(ICarRepository context)
        {
            Context = context;
        }

        public IActionResult Index()
        {
            var data = Context.GetAllData();
            return View(data);

        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Create(Cars cars)
        {


            Context.Add(cars);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = Context.GetId(id);
           
            return View(data);

        }


        [HttpPost]

        public IActionResult Edit(Cars cars)
        {
            var data = Context.GetId(cars.Id);
            if (data == null)
            {

                return View(null);

            }

            data.Brand = cars.Brand;
            data.Model = cars.Model;
            data.NumberPlate = cars.NumberPlate;
            data.RentPerDay = cars.RentPerDay;
            data.IsAvailable = cars.IsAvailable;

            Context.Update(data);
            return RedirectToAction("Index");

        }

        [HttpPost]

        public IActionResult Delete(int id)
        {
          var data= Context.Delete(id);
            return RedirectToAction("Index");
        }


    }
}