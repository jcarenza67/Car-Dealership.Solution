using System.Collections.Generic;
using CarDealership.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarDealership.Controllers
{
  public class CarController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List <Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string make, string model, string year, bool isAvailable, int price)
    {
      Car myCar = new Car(make, model, year, isAvailable, price);
      return RedirectToAction("Index");
    }
  }
}