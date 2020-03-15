using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Data.Entities
{
    public class AdvertisementSlider
    {
        public int Id { get; set; }
        [Required]
        [StringLength(300,MinimumLength = 2)]
        public string Photo { get; set; }
    }
}
