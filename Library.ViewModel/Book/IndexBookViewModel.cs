﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.ViewModel.Book
{
    public class IndexBookViewModel
    {
        public List<BookViewModel> books { get; set; }

        
    }

    public class BookViewModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Author { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public DateTime YearOfPublishing { get; set; }
    }

}
