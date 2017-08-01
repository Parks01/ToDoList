using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
    {
      [Route("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/car/list")]
        public ActionResult CarList()
        {
          List<Car> allCars = Car.GetAll();
          return View(allCars);
        }

        [HttpPost("/car/create")]
        public ActionResult CreateCar()
        {
          Car newCar = new Car(Request.Form["car-brand"], Request.Form["car-model"], int.Parse(Request.Form["car-price"]), int.Parse(Request.Form["car-mileage"]));
          newCar.Save();
          return View(newCar);
        }
        [HttpPost("/car/list/clear")]
         public ActionResult CarListClear()
         {
             Car.ClearAll();
             return View();
         }

    }
}
