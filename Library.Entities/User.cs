using System.ComponentModel.DataAnnotations;

namespace Library.Entities
{
    public class User : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }
    }
}
