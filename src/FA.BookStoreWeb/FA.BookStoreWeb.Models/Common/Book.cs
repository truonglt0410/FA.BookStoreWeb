using FA.BookStoreWeb.Models.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStoreWeb.Models.Common
{
    [Table("Books", Schema = "common")]
    public class Book : BaseEntity
    {

        [Required(ErrorMessage = "The {0} is required")]
        [StringLength(255, ErrorMessage = "The {0} must between {2} and {1} characters ", MinimumLength = 3)]
        public string Title { get; set; }

        [MaxLength(500, ErrorMessage = "The {0} must less than {1} characters")]
        public string Summary { get; set; }

        [Required(ErrorMessage = "The {0} is required")]
        [Display(Name = "Image Thumbnail")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "The {0} is required")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "The {0} is required")]
        public int Quantity { get; set; }

        [Display(Name = "Created Date")]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Modified Date")]
        public DateTimeOffset ModifiedDate { get; set; }

        [Display(Name = "Is Active?")]
        [DefaultValue(false)]
        public bool IsActive { get; set; }


        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }



        [ForeignKey("Publisher")]
        public Guid PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
