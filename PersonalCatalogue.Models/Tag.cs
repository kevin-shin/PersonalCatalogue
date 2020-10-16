using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalCatalogue.Models
{
    [Table("tags")]
    public class Tag
    {
        [Key]
        [Required]
        [Column("tagid")]
        public int TagId;

        [Column("name")]
        public string Name;

        [Column("color")]
        public string Color;
    }
}
