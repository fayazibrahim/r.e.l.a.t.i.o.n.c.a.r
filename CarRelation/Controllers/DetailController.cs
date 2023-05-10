using CarRelation.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRelation.Controllers
{
    public class DetailController : Controller
    {
        private readonly List<Detail> _detail;

        public DetailController()
        {
            _detail = new List<Detail>
            {
                new Detail {Id=1,Name="Bmw",color="Black",ban="sedan",detail="detail",MarkaId=1},
                new Detail {Id=2,Name="Mercedes",color="Red",ban="hatchback",detail="detail", MarkaId=2}

            };
        }
        public IActionResult Index(int? id)
        {
            if (id != null)
            {
                if (_detail.Exists(m => m.Id == id)) NotFound();

                return View(_detail.FindAll(m => m.MarkaId == id));
            }
            return View(_detail);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) BadRequest();

            Detail detail = _detail.Find(c => c.Id == id);

            if (detail == null) return NotFound();

            return View(detail);
        }
    }
}
