using System.Threading;
using System.Threading.Tasks;
using BlazorCms.Server.CQSR.Commands;
using BlazorCms.Server.Services;
using MediatR;

namespace BlazorCms.Server.CQSR.Handlers
{
    public class UploadOrDeleImageCommandHandler : IRequestHandler<UploadOrDeleImageCommand, string>
    {
        private readonly IBlobServices _IBlobServices;

        public UploadOrDeleImageCommandHandler(IBlobServices iBlobServices)
        {
            _IBlobServices = iBlobServices;
        }

        public async Task<string> Handle(UploadOrDeleImageCommand request, CancellationToken cancellationToken)
        {
            return await _IBlobServices.UploadOrDeleteBlobImageAsync(request.file, request._action);
        }
    }
}