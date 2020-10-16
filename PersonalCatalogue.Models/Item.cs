using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalCatalogue.Data

{
    [Table("items")]
    public class Item
    {
        [Key]
        [Required]
        [Column("itemid")]
        public int ItemId { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("tagid")]
        public int TagId { get; set; }

        [Column("purchased")]
        public DateTime Purchased { get; set; }

        [Column("imagepath")]
        public string ImagePath { get; set; }

        [Column("price")]
        public double Price { get; set; }

    }
}
