using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Shared.ViewModels.Book
{
    public class IndexBookViewModel
    {
        public List<BookViewModel> books { get; set; }

        
    }

    public class BookViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Author { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public DateTime YearOfPublishing { get; set; }
    }

}
