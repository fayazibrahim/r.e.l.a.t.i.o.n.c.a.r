using CarRelation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace CarRelation.Controllers
{
    public class CarController : Controller
    {
        private readonly List<Car> _car;
        public CarController() => _car = new List<Car>
            {
                new Car {Id=1,Name="Bmw",Model="530",MarkaId=1},
                new Car {Id=2,Name="Mercedes",Model="C220",MarkaId=2}
            };

        public IActionResult Index(int? id)
        {
            if (id != null)
            {
                if (_car.Exists(m => m.Id == id)) NotFound();

                return View(_car.FindAll(m => m.MarkaId == id));
            }
            return View(_car);
        }
    }
}
