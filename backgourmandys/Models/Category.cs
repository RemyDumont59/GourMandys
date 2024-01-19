using System.Text.Json.Serialization;

namespace backgourmandys.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Cake>? Cakes { get; set; } = new List<Cake>();
    }
}
