﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectV2.Data.Entities
{
    public class News
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime PublishedDate { get; set; }
        [Required]
        public string Image { get; set; }

    }
}
