namespace backgourmandys.Models
{
    public class CakeFlavor
    {
        public int CakeId { get; set; }
        public Cake? Cake { get; set; }

        public int FlavorId { get; set; }
        public Flavor? Flavor { get; set; }
    }
}
