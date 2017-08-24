using System.ComponentModel.DataAnnotations;

namespace Library.ViewModel.User
{
    public class CreateUserViewModel
    {
        [Required]
        [StringLength(100)]
        [Display(Name = "Login")]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }
    }
}
