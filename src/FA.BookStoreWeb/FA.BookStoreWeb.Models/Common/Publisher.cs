﻿using FA.BookStoreWeb.Models.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.BookStoreWeb.Models.Common
{
    [Table("Publishers", Schema = "common")]
    public class Publisher : BaseEntity
    {
        [Required(ErrorMessage = "The {0} is required")]
        [StringLength(255, ErrorMessage = "The {0} must between {2} and {1} characters ", MinimumLength = 3)]
        [Display(Name = "Publisher Name")]
        public string Name { get; set; }

        [MaxLength(500, ErrorMessage = "The {0} must less than {1} characters")]
        public string Description { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
