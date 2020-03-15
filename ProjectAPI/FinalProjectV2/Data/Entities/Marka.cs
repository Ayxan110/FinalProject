using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Data.Entities
{
    public class Marka
    {
        public Marka()
        {
            Models = new HashSet<Model>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(50,MinimumLength = 2)]
        public string Name { get; set; }
        public SubCategoryItem SubCategoryItems { get; set; }
        public int SubCategoryItemsId { get; set; }
        public ICollection<Model> Models { get; set; }
    }
}
