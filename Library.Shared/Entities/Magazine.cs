using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Library.Shared.Entities
{
    [Table("Magazine")]
    public class Magazine : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public int Number { get; set; }

        [Column("YearOfPublishing", TypeName = "date")]
        public DateTime YearOfPublishing { get; set; }
    }
}
