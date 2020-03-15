using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectAPI.Data.Entities
{
    public class SubCategory
    {
        public SubCategory()
        {
            SubCategoryItems = new HashSet<SubCategoryItem>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }
        public ICollection<SubCategoryItem> SubCategoryItems { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}