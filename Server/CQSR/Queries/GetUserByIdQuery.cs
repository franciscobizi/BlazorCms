using System;
using System.Collections.Generic;
using BlazorCms.Server.Models;
using MediatR;

namespace BlazorCms.Server.CQRS.Queries
{
    public class GetUserByIdQuery : IRequest<User>
    {
        public int userId { get; set; }

        public GetUserByIdQuery(int id)
        {
            this.userId = id;
        }
    }
}