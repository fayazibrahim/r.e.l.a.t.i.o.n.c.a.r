using CarRelation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace CarRelation.Controllers
{
    public class ModelController : Controller
    {
        private readonly List<Model> _car;
        public ModelController() => _car = new List<Model>
            {
                 new Model { Id = 1, model = "530", MarkaId = 1 },
                new Model { Id = 2, model = "x6", MarkaId = 1 },
                new Model { Id = 3, model = "A180", MarkaId = 2 },
                new Model { Id = 4, model = "C220", MarkaId = 2 },
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
