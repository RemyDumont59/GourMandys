using backgourmandys.Enum;

namespace backgourmandys.DTOs;

public class CreatePicturePathDto
{
    public IFormFile? FormFile { get; set; }
    public string? FileName { get; set; }
    public int CakeId { get; set; }
}