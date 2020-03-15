using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectAPI.Data.Entities
{
    public class Product
    {
        public Product()
        {
            Photos = new HashSet<Photo>();
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
        [Required]
        public byte GuaranteeDate { get; set; }
        [Required]
        public byte GuaranteePrice { get; set; }
        [Required]
        [StringLength(30,MinimumLength = 2)]
        public string Condition { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 1)]
        public string ShipDate { get; set; }
        [Required]
        public byte ShipPrice { get; set; }
        [Required]
        public byte TestDate { get; set; }
        [Required]
        [StringLength(800,MinimumLength = 5)]
        public string Specification { get; set; }
        public SubCategoryItem SubCategoryItems { get; set; }
        public int SubCategoryItemsId { get; set; }
        [Required]
        public bool IsInBasket { get; set; }
    }
}