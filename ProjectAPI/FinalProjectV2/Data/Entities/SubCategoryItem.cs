using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectAPI.Data.Entities
{
    public class SubCategoryItem
    {
        public SubCategoryItem()
        {
            Products = new HashSet<Product>();
            Markas = new HashSet<Marka>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(80, MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [StringLength(250, MinimumLength = 2)]
        public string PhotoPath { get; set; }
        public SubCategory SubCategory { get; set; }
        public int SubCategoryId { get; set; }
        public ICollection<Product> Products { get;set;}
        public ICollection<Marka> Markas { get; set; }
    }
}