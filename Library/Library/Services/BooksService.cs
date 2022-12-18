using Library.Data;
using Library.Models;
using Library.Services.Interfaces;

namespace Library.Services
{
    public class BooksService : IBooksService
    {
        private LibraryDbContext _dbContext;

        public BooksService(LibraryDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void DeleteBook(int id)
        {
            var book = _dbContext.Books.Find(id);

            if (book != null)
            {
                this._dbContext.Books.Remove(book);
                this._dbContext.SaveChanges();
            }
        }

        public Book GetBook(int id)
        {
            Book? book = this._dbContext.Books.Join(
                _dbContext.Authors,
                b => b.AuthorId,
                a => a.Id,
                (b, a) => new Book()
                {
                    Id = b.Id,
                    AuthorId = b.AuthorId,
                    Title = b.Title,
                    ShortDescription = b.ShortDescription,
                    CoverImageURL = b.CoverImageURL,
                    Author = a
                }
                )?.FirstOrDefault(x => x.Id == id);


            if (book == null)
            {
                throw new ArgumentException($"There is no book with id: {id}");
            }

            return book;
        }

        public IList<Book> GetBooks()
        {
            var books = _dbContext.Books.Join(
                _dbContext.Authors,
                b => b.AuthorId,
                a => a.Id,
                (b, a) => new Book()
                {
                    Id = b.Id,
                    AuthorId = b.AuthorId,
                    Title = b.Title,
                    ShortDescription = b.ShortDescription,
                    CoverImageURL = b.CoverImageURL,
                    Author = a
                }
                );

            return books.ToList();
        }

        public IList<Book> GetBooksByAuthor(int authorId)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            this._dbContext.Books.Update(book);

            this._dbContext.SaveChanges();
        }


        public void Add(Book book)
        {

            this._dbContext.Books.Add(book);

            this._dbContext.SaveChanges();
        }
    }
}
