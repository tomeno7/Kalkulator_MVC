using Microsoft.AspNetCore.Mvc;
using Kalkulator_MVC.Models;

namespace Kalkulator_MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Oblicz(string shapeType, double width, double height, double radius)
        {
            Shape shape = null;

            switch (shapeType)
            {
                case "Prostokąt":
                    shape = new Rectangle(width, height);
                    break;
                case "Koło":
                    shape = new Circle(radius);
                    break;
            }

            if (shape != null)
            {
                ViewBag.Area = shape.CalculateArea();
                ViewBag.Perimeter = shape.CalculatePerimeter();
            }

            return View("Wynik");
        }
    }
}