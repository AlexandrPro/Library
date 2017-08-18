﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Shared.ViewModels.Brochure
{
    public class CreateBrochureViewModel
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string TypeOfCover { get; set; }

        public int NumberOfPages { get; set; }
    }
}