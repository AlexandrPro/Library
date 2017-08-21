namespace Library.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Book")]
    public partial class Book : BaseEntity
    {
        [Required]
        [StringLength(200)]
        public string Author { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Column("YearOfPublishing", TypeName = "date")]
        public DateTime YearOfPublishing { get; set; }
    }
}
