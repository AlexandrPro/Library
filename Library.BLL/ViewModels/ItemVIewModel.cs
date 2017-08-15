using System.ComponentModel.DataAnnotations;

namespace Library.BLL.ViewModels
{
    public class ItemViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string ItemType {get; set;}
    }
}
