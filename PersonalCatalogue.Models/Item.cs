using System;
using System.ComponentModel.DataAnnotations;

namespace PersonalCatalogue.Data

{
    public class Item
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string ImageLocation { get; set; }
        public double Price { get; set; }

    }
}
