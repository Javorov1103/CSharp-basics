using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? ShortDescription { get; set; }

        [Required]
        public int AuthorId { get; set; }

        public Author? Author { get; set; }

        public string? CoverImageURL { get; set; }

        public IList<BorrowersBooks>? Borrowers { get; set; }
    }
}
