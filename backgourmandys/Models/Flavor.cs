using System.Text.Json.Serialization;

namespace backgourmandys.Models
{
    public class Flavor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [JsonIgnore]
        public List<CakeFlavor>? CakeFlavors { get; set; } = new List<CakeFlavor>();
        public List<Cake>? Cakes { get; set; } = new List<Cake>();
    }
}
