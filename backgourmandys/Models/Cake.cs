using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace backgourmandys.Models
{
    public class Cake
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? Content { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        [Required]
        public List<PicturePath>? PicturePath { get; set; } = new List<PicturePath>();
        [JsonIgnore]
        public List<CakeFlavor>? CakeFlavors { get; set; } = new List<CakeFlavor>();
        public List<Flavor>? Flavors { get; set; } = new List<Flavor>();
        [Required]
        public decimal Price { get; set; }
        public int Pieces { get; set; }
        public string? Size { get; set; }
        public int MinimalQuantity { get; set; }
        public int Lot { get; set; }
        public bool IsNumberCake { get; set; }
        public bool IsLetterCake { get; set; }
    }
}
