using Fluffy.Contracts;
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
    }
}
