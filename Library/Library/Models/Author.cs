﻿using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public IList<Book>? Books { get; set; }
    }
}
