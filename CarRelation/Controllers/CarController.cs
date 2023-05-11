using CarRelation.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRelation.Controllers
{
    public class CarController : Controller
    {
        private readonly List<Car> _detail;

        public CarController()
        {
            _detail = new List<Car>
            {
                new Car { Id = 1, Year = "2011", Ban = "sedan", ModelId = 1 },
                new Car { Id = 2, Year = "2015", Ban = "universal", ModelId = 1 },
                new Car { Id = 3, Year = "2005", Ban = "sedan", ModelId = 1 },
                new Car { Id = 4, Year = "2003", Ban = "sedan", ModelId = 2 },
                new Car { Id = 5, Year = "2019", Ban = "sedan", ModelId = 2 },
                new Car { Id = 6, Year = "2022", Ban = "sedan", ModelId = 2 },

            };
        }
        public IActionResult Index(int? id)
        {
            if (id != null)
            {
                if (_detail.Exists(m => m.Id == id)) NotFound();

                return View(_detail.FindAll(m => m.ModelId == id));
            }
            return View(_detail);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) BadRequest();

            Car detail = _detail.Find(c => c.Id == id);

            if (detail == null) return NotFound();

            return View(detail);
        }
    }
}
