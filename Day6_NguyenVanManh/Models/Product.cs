using System.ComponentModel.DataAnnotations;

namespace Day6_NguyenVanManh.Models
{
    public class Product
    {
        public int id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string? name { get; set; }
        [Range(0.01, 10000.00)]
        public decimal Price { get; set; }

        public string? Description { get; set; }
    }
}
