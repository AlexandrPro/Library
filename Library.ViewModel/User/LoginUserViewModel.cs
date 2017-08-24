using System.ComponentModel.DataAnnotations;

namespace Library.ViewModel.User
{
    public class LoginUserViewModel
    {
        [Required]
        [StringLength(100)]
        [Display(Name = "Login")]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "RememberMe?")]
        public bool RememberMe { get; set; }
    }
}
