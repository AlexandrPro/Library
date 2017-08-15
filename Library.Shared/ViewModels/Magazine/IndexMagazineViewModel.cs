﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Shared.ViewModels.Magazine
{
    public class IndexMagazineViewModel
    {
        public List<MagazineViewModel> magazines { get; set; }
    }

    public class MagazineViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public int Number { get; set; }

        [Column("YearOfPublishing", TypeName = "date")]
        public DateTime YearOfPublishing { get; set; }
    }
}