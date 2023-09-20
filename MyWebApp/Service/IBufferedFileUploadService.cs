namespace MyWebApp.Service
{
    public interface IBufferedFileUploadService
    {
        Task<string> UploadFile(IFormFile file);
    }
}
