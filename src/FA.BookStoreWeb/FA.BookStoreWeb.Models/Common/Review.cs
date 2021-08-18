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
    [Table("Reviews", Schema = "common")]
    public class Review : BaseEntity
    {
        [Required(ErrorMessage = "The {0} is required")]
        [StringLength(255, ErrorMessage = "The {0} must between {2} and {1} characters ", MinimumLength = 3)]
        [Display(Name = "Review")]
        public string Comment { get; set; }

        [Display(Name = "Created Date")]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Modified Date")]
        public DateTimeOffset ModifiedDate { get; set; }

        [Display(Name = "Is Active?")]
        [DefaultValue(false)]
        public bool IsActive { get; set; }

        [ForeignKey("Book")]
        public Guid BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}
