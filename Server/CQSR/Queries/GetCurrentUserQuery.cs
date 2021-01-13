using BlazorCms.Server.Models;
using MediatR;

namespace BlazorCms.Server.CQSR.Queries
{
    public class GetCurrentUserQuery : IRequest<User>
    {
        public bool _IsAuthenticated { get; set; }
        public string _UserEmail { get; set; }
        public GetCurrentUserQuery(bool IsAuthenticated, string UserEmail)
        {
            _IsAuthenticated = IsAuthenticated;
            _UserEmail = UserEmail;
        }
    }
}