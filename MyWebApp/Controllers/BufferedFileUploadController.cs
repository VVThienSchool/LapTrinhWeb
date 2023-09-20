using Microsoft.AspNetCore.Mvc;
using MyWebApp.Service;

namespace MyWebApp.Controllers
{
    public class BufferedFileUploadController : Controller
    {
        readonly IBufferedFileUploadService _bufferedFileUploadService;
        public BufferedFileUploadController(IBufferedFileUploadService bufferedFileUploadService)
        {
            this._bufferedFileUploadService = bufferedFileUploadService;
        }

        [HttpGet]
        [Route("upload")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("upload")]
        public async Task<ActionResult> Index(IFormFile file)
        {
            try
            {
                string path = await _bufferedFileUploadService.UploadFile(file);
                if (path != null)
                {
                    ViewBag.Message = "File Upload Successful";
                    ViewBag.path = "/images/" + file.FileName;
                }
                else
                {
                    ViewBag.Message = "File Upload Failed";
                    ViewBag.path = null;
                }
            }
            catch (Exception ex)
            {
                //Log ex
                ViewBag.Message = "File Upload Failed";
            }
            return View();
        }
    }
}
