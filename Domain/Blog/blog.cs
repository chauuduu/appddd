using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Blog
{
    [Table("blogs")]
    public class Blogs
    {
        [MaxLength(50)]
        [Required]
        public string Name { get; set; } // nvarchar(50), not null
        [MaxLength]
        [Required]
        public string content { get; set; } // nvarchar(max), not null
        [Required]
        public Guid id { get; set; } // uniqueidentifier, not null
        [MaxLength(50)]
        public string author { get; set; } // varchar(50), null
    }
}
