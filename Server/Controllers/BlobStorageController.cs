using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using BlazorCms.Server.CQSR.Commands;
using Microsoft.AspNetCore.Http;

namespace BlazorCms.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlobStorageController : ControllerBase
    {
        private readonly IMediator _imediator;

        public BlobStorageController(IMediator imediator)
        {
            _imediator = imediator;
        }

        [HttpPost("uploadimage")]
        public async Task<IActionResult> UploadImage(IFormFile UploadFiles)
        {
            UploadOrDeleImageCommand command = new UploadOrDeleImageCommand()
            {
                file = UploadFiles,
                _action = "Upload"
            };

            var result = await _imediator.Send(command);
            Response.Headers.Add("fileName", result);
            return result != null ? (IActionResult) Ok(result) : NotFound();
            
        }

        [HttpPost("removeimage")]
        public async Task<IActionResult> DeleteImage(IFormFile UploadFiles)
        {
            UploadOrDeleImageCommand command = new UploadOrDeleImageCommand()
            {
                file = UploadFiles,
                _action = "Delete"
            };

            var result = await _imediator.Send(command);
            Response.Headers.Add("fileName", result);
            return result != null ? (IActionResult) Ok(result) : NotFound();
            
        }
    }
}
