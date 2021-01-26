using AutoMapper;
using BlazorCms.Server.Models;
using BlazorCms.Shared.Mapping;

namespace BlazorCms.Server.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            #region PostToPostResponse
            CreateMap<Post, PostResponse>();/* .ForMember(dest => dest.PostAuthorNavigation, opt => opt.MapFrom(src => src.PostAuthorNavigation)) */
            #endregion

            #region PostResponseToPost
            CreateMap<PostResponse, Post>();/* .ForMember(dest => dest.PostAuthorNavigation, opt => opt.MapFrom(src => src.PostAuthorNavigation)) */
            #endregion
        }

    }
}