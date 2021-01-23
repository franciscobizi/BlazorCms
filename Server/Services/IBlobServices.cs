using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BlazorCms.Server.Services
{
    public interface IBlobServices
    {
        public Task<string> UploadOrDeleteBlobImageAsync(IFormFile file, string action);
    }
}