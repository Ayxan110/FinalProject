using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectAPI.Data.Entities
{
    public class Model
    {
        public int Id { get; set; }
        [Required]
        [StringLength(80, MinimumLength = 2)]
        public string Name { get; set; }
        public Marka Marka { get; set; }
        public int MarkaId { get; set; }
    }
}