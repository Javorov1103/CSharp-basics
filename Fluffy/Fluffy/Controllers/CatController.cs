using Fluffy.Contracts;
using Fluffy.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fluffy.Controllers
{
    public class CatController : Controller
    {
        private ICatService catService;

        public CatController(ICatService catService)
        {
            this.catService = catService;
        }

        public IActionResult Index()
        {
            var cats = this.catService.GetAll();
            return View(cats);
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Create(Cat catToBeCreated)
        {
            this.catService.Create(catToBeCreated);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Cat cat = this.catService.GetCatById(id);

            return View(cat);
        }
    }
}
