using ProjectAPI.Data.Entities;

namespace FinalProjectV2.Data.Entities
{
    public class ProductSpec
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public Product Product { get; set; } 
        public int ProductId { get; set; }
        public Specification Specification { get; set; }
        public int SpecificationId { get; set; }
    }
}