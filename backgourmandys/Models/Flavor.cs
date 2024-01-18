namespace backgourmandys.Models
{
    public class Flavor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<CakeFlavor>? CakeFlavors { get; set; } = new List<CakeFlavor>();
    }
}
