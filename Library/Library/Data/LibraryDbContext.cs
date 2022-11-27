using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext()
        {

        }
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
           : base(options)
        {
        }

        public DbSet<Book>? Books;

        public DbSet<Author>? Authors;

        public DbSet<Borrower>? Borrowers;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasMany(book => book.Borrowers)
                .WithOne(borrower => borrower.Book)
                .HasForeignKey(b => b.BookId);

            modelBuilder.Entity<Borrower>()
                .HasMany(borrower => borrower.BorrowedBooks)
                .WithOne(book => book.Borrower)
                .HasForeignKey(b => b.BorrowerId);

            modelBuilder.Entity<BorrowersBooks>()
                .HasKey(b => new { b.BookId, b.BorrowerId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
