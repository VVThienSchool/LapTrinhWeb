using MyWebApp.Service;

namespace MyWebApp.ServiceImpl
{
    public class BufferedFileUploadLocalService : IBufferedFileUploadService
    {
        public async Task<string> UploadFile(IFormFile file)
        {
            string path = "D:/LtWeb/MyWebApp/wwwroot/images/";
            try
            {
                if (file.Length > 0)
                {
                    //path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "UploadedFiles"));
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (var fileStream = new FileStream(Path.Combine(path, file.FileName), FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                    return Path.Combine(path, file.FileName);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("File Copy Failed", ex);
            }
        }
    }
}
