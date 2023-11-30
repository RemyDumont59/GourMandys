using CloudinaryDotNet.Actions;

namespace backgourmandys.Interfaces;

public interface IPictureService
{
    Task<ImageUploadResult> AddPhotoAsync(IFormFile file);
    Task<DeletionResult> DeletePhotoAsync(string publicId);
}