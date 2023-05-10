using CarRelation.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRelation.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Marka> _marka;

        public HomeController() //ilk run olanda bir basha ishlesin
        {
            _marka = new List<Marka>
            {
                new Marka {Id=1, Name="Bmw"},
                new Marka {Id=2, Name="Mercedes"}
            };
        }
        public IActionResult Index()
        {
            return View(_marka);
        }
    }
}
