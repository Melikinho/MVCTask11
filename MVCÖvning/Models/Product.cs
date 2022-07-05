using System.ComponentModel.DataAnnotations;

namespace MVCÖvning.Models
{
    public class Product
    {
        public int id { get; set; }
        [Range(3, 20)]
        [Required]
        public string name { get; set; }
        [Range(2, 8)]
        public int price { get; set; }
        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }
        [Required]
        public string Category { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }

    }
}
