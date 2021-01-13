using System;
using System.Collections.Generic;
using BlazorCms.Server.Models;
using MediatR;

namespace BlazorCms.Server.CQRS.Queries
{
    public class GetPostByParamQuery : IRequest<Post>
    {
        public string param { get; set; }

        public GetPostByParamQuery(string _param)
        {
            this.param = _param;
        }
    }
}