namespace backgourmandys.Models
{
    public class PicturePath
    {
        public int Id { get; set; }
        public string? Path { get; set; }
        public int CakeId { get; set; }
        public Cake? Cake {  get; set; }
    }
}
