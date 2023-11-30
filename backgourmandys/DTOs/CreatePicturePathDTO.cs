using backgourmandys.Enum;

namespace backgourmandys.DTOs;

public class CreatePicturePathDto
{
    public int Id { get; set; }
    public IFormFile? Path { get; set; }
    public int CakeId { get; set; }
}