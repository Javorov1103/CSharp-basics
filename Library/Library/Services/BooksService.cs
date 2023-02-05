using Library.Data;
using Library.Models;
using Library.Services.Interfaces;
using Microsoft.Data.SqlClient;

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
            string query = @"

                    UPDATE Books SET
                    Title = @Title,
                    ShortDescription = @ShortDescription,
                    CoverImageURL = @CoverImageURL,
                    Price = @Price
                    WHERE Id = @Id
                    ";

            using (SqlConnection connection = new SqlConnection(@"Server=DESKTOP-OSKT1GA\SQLEXPRESS;Database=BookLibrary;Trusted_Connection=True;TrustServerCertificate=True"))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = query;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@Title",book.Title);
                    command.Parameters.AddWithValue("@ShortDescription",book.ShortDescription);
                    command.Parameters.AddWithValue("@CoverImageURL", book.CoverImageURL ?? "");
                    command.Parameters.AddWithValue("@Price", book.Price);
                    command.Parameters.AddWithValue("@Id", book.Id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            //this._dbContext.Books.Update(book);

            //this._dbContext.SaveChanges();
        }


        public void Add(Book book)
        {
            string query = $@"
                INSERT INTO [dbo].[Books]
                           ([Title]
                           ,[ShortDescription]
                           ,[AuthorId]
                           ,[CoverImageURL]
                           ,[Price])
                     VALUES
                           (@Title
                           ,@ShortDescr
                           ,@AuthorId
                           ,@URL
                           ,@Price)
            ";

            using (var connection = new SqlConnection(@"Server=DESKTOP-OSKT1GA\SQLEXPRESS;Database=BookLibrary;Trusted_Connection=True;TrustServerCertificate=True"))
            {
                using (var commmand = new SqlCommand())
                {
                    commmand.CommandText = query;
                    commmand.Connection = connection;
                    commmand.Parameters.Add(new SqlParameter("@Title", book.Title));
                    commmand.Parameters.Add(new SqlParameter("@ShortDescr", book.ShortDescription));
                    commmand.Parameters.Add(new SqlParameter("@AuthorId", book.AuthorId));
                    commmand.Parameters.Add(new SqlParameter("@URL", book.CoverImageURL ?? ""));
                    commmand.Parameters.Add(new SqlParameter("@Price", book.Price ));

                    connection.Open();
                    commmand.ExecuteScalar();

                    connection.Close();

                }
                //connection.Execute(query, book);
            }

            //this._dbContext.Books.Add(book);

            //this._dbContext.SaveChanges();
        }
    }
}
