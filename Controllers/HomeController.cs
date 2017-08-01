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
          List<string> allCars = Car.GetAll();
          return View(allCars);
        }

        [HttpPost("/car/create")]
        public ActionResult CreateCar()
        {
          Car newCar = new Car(Request.Form["new-car"]);
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
