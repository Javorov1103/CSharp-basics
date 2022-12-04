using Library.Models;

namespace Library.Services.Interfaces
{
    public interface IBooksService
    {
        IList<Book> GetBooks();

        Book GetBook(int id);

        IList<Book> GetBooksByAuthor(int authorId);

        void DeleteBook(int id);

        void UpdateBook(Book book);

        void Add(Book book);
    }
}
