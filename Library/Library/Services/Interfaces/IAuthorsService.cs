using Library.Models;

namespace Library.Services.Interfaces
{
    public interface IAuthorsService
    {
        IList<Author> GetAuthors();

    }
}
