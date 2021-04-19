using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;

namespace BlazorCms.Server.Services
{
    public class BlobServices : IBlobServices
    {
        protected string blobUrl { get; set ;}
        private readonly BlobServiceClient _BlobServiceClient;

        public BlobServices(BlobServiceClient blobServiceClient)
        {
            _BlobServiceClient = blobServiceClient;
        }

        public async Task<string> UploadOrDeleteBlobImageAsync(IFormFile UploadFiles, string action)
        {
            if (UploadFiles == null || UploadFiles.Length == 0) return "";
            
            var fileName = UploadFiles.FileName;

            var containerClient = _BlobServiceClient.GetBlobContainerClient("blazorcmsimages");
            var blob = containerClient.GetBlobClient(fileName);

            if (action == "Upload")
            {
                var fileStream = UploadFiles.OpenReadStream();
                fileStream.Position = 0;
                await blob.UploadAsync(fileStream, new BlobHttpHeaders { ContentType = UploadFiles.ContentType.ToString() });
                fileName = blob.Uri.ToString();
            }
            else
            {
                await blob.DeleteIfExistsAsync();
                fileName = "Deleted";
            }

            return fileName;
        }

    }
}