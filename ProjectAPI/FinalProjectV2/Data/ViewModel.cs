using ProjectAPI.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectV2.Data
{
    public class ViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<SubCategory> SubCategories { get; set; }
        public IEnumerable<SubCategoryItem> SubCategoryItems { get; set; }
        public IEnumerable<Social> Socials { get; set; }
        public IEnumerable<Contact> Contacts { get; set; }
    }
}
