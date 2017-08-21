using System;
using System.ComponentModel.DataAnnotations;

namespace Library.ViewModel.Book
{
    public class CreateBookViewModel 
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
