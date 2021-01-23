using MediatR;
using Microsoft.AspNetCore.Http;

namespace BlazorCms.Server.CQSR.Commands
{
    public class UploadOrDeleImageCommand : IRequest<string>
    {
        public IFormFile file { get; set ;}
        public string _action { get; set; }
    }
}