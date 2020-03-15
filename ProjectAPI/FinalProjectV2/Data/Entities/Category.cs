using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Data.Entities
{
    public class Category
    {
        public Category()
        {
            SubCategories = new HashSet<SubCategory>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(30,MinimumLength = 2)]
        public string Name { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }
    }
}
