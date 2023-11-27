using backgourmandys.Enum;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

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
        public Category Category { get; set; }
        public Flavour Flavour { get; set; }
        [Required]
        public List<PicturePath>? PicturePath { get; set; } = new List<PicturePath>();
        [Required]
        public decimal Price { get; set; }
        public int Pieces { get; set; }
        public string? Size { get; set; }
        public int MinimalQuantity { get; set; }
        public int Lot { get; set; }
        public bool IsNumberOrLetterCake { get; set; }
    }
}
