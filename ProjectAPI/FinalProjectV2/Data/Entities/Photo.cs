using System.ComponentModel.DataAnnotations;

namespace ProjectAPI.Data.Entities
{
    public class Photo
    {
        public int Id { get; set; }
        [Required]
        [StringLength(300,MinimumLength = 2)]
        public string Path { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}