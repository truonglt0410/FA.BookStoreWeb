using FA.BookStoreWeb.Models.BaseEntities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FA.BookStoreWeb.Models.Common
{
    [Table("Categories", Schema = "common")]
    public class Category : BaseEntity
    {
        [Required(ErrorMessage = "The {0} is required")]
        [StringLength(255, ErrorMessage = "The {0} must between {2} and {1} characters", MinimumLength = 3)]
        [Display(Name = "Category Name")]
        public string Name { get; set; }

        [MaxLength(500, ErrorMessage = "The {0} must less than {1} characters")]
        public string Description { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
