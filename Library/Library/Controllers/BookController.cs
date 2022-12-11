﻿using Library.Models;
using Library.Services;
using Library.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BookController : Controller
    {
        private readonly IBooksService booksService;
        private readonly IAuthorsService authorsService;

        public BookController(IBooksService booksService, IAuthorsService authorsService)
        {
            this.booksService = booksService;
            this.authorsService = authorsService;
        }
        public IActionResult Index()
        {
            var books = this.booksService.GetBooks();

            return View(books);
        }

        public IActionResult Add()
        {
            var authors = this.authorsService.GetAuthors();
            ViewBag.Authors = authors;

            return View();
        }

        public IActionResult AddBook(Book book)
        {
            //Adding a book into the DB

            return RedirectToAction("Index");
        }
    }
}
