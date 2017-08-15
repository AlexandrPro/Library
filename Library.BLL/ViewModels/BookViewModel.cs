﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Library.BLL.ViewModels
{
    public class BookViewModel
    {
        internal string ItemType;

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
