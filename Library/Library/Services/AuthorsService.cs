using Library.Data;
using Library.Models;
using Library.Services.Interfaces;

namespace Library.Services
{
    public class AuthorsService : IAuthorsService
    {
        private readonly LibraryDbContext dbContext;

        public AuthorsService(LibraryDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IList<Author> GetAuthors()
        {
            var authors = this.dbContext.Authors.ToList();

            return authors;
        }
    }
}
