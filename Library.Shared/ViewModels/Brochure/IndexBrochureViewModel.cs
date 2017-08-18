using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Shared.ViewModels.Brochure
{
    public class IndexBrochureViewModel
    {
        public List<BrochureViewModel> brochures { get; set; }
    }

    public class BrochureViewModel
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
