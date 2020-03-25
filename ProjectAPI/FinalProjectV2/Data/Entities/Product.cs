using FinalProjectV2.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectAPI.Data.Entities
{
    public class Product
    {
        public Product()
        {
            Photos = new HashSet<Photo>();
            ProductSpecs = new HashSet<ProductSpec>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(80, MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [StringLength(250, MinimumLength = 2)]
        public string MainPhoto { get; set; }
        [Required]
        public decimal Price { get; set; }
        public byte SalePercent { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public byte GuaranteeDate { get; set; }
        public byte GuaranteePrice { get; set; }
        public string Condition { get; set; }
        public string ShipDate { get; set; }
        public byte ShipPrice { get; set; }
        public byte TestDate { get; set; }
        public string Specification { get; set; }
        public SubCategoryItem SubCategoryItems { get; set; }
        public int SubCategoryItemsId { get; set; }
        public bool IsInBasket { get; set; }
        public ICollection<ProductSpec> ProductSpecs { get; set; }
    }
}