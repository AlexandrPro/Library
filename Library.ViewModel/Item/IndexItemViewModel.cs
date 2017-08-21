using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.ViewModel.Item
{
    public class IndexItemViewModel
    {
        public List<ItemViewModel> items { get; set; }
    }

    public class ItemViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string ItemType { get; set; }
    }
}
