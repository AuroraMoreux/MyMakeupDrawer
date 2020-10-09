namespace MyMakeupDrawer.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using MyMakeupDrawer.Data.Models.Enums;

    public class Brand
    {
        public Brand()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Products = new HashSet<Product>();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(50)]
        public int Name { get; set; }

        public bool IsCrueltyFree { get; set; }

        [Required]
        public int PriceRangeId { get; set; }

        public PriceRange PriceRange { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
