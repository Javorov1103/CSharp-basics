using Library.Data;
using Library.Models;
using Library.Services.Interfaces;

namespace Library.Services
{
    public class BooksService : IBooksService
    {
        private readonly LibraryDbContext dbContext;

        public BooksService(LibraryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public Book GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Book> GetBooks()
        {
            return this.dbContext.Books.ToList();
        }

        public IList<Book> GetBooksByAuthor(int authorId)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
