using Library.Services;
using Library.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BookController : Controller
    {
        private readonly IBooksService booksService;

        public BookController(IBooksService booksService)
        {
            this.booksService = booksService;
        }
        public IActionResult Index()
        {
            var books = this.booksService.GetBooks();

            return View(books);
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
