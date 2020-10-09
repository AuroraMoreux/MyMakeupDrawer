namespace MyMakeupDrawer.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using MyMakeupDrawer.Data.Models.EnumModels;
    using MyMakeupDrawer.Data.Models.Enums;

    public class Product
    {
        public Product()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(90)]
        public string Name { get; set; }

        [Required]
        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [Required]
        public int FormulationId { get; set; }

        public Formulation Formulation { get; set; }

        public int SkinTypeId { get; set; }

        public SkinType SkinType { get; set; }

        [Required]
        public int FinishId { get; set; }

        public Finish Finish { get; set; }

        public bool IsWaterproof { get; set; }

        public bool IsLongWearing { get; set; }

        public bool IsMiniSize { get; set; }

        public bool IsVegan { get; set; }

        [Required]
        public int CoulourFamilyId { get; set; }

        public ColourFamily ColourFamily { get; set; }

        public int UndertoneId { get; set; }

        public Undertone Undertone { get; set; }
    }
}
