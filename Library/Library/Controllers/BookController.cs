﻿using Library.Models;
using Library.Services;
using Library.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

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
            IList<Book> books = this.booksService.GetBooks();

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
            this.booksService.Add(book);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            //Take the book with the current id from the DB, and pass it 
            // To the VIEW
            var book = this.booksService.GetBook(id);

            return View(book);
        }

        public IActionResult Delete(int id)
        {
            //Delete the book with the passed id

            this.booksService.DeleteBook(id);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Book book = this.booksService.GetBook(id);
            var authors = this.authorsService.GetAuthors();
            ViewBag.Authors = authors;

            return View(book);
        }

        public IActionResult EditBook(Book book)
        {
            this.booksService.UpdateBook(book);

            return RedirectToAction("Index");
        }
    }
}
