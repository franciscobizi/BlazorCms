using AutoMapper;
using BlazorCms.Shared.Mapping;
using BlazorCms.Shared.Models;
using BlazorCms.ViewModels;

namespace Client.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup(){
            // Posts mapper
            CreateMap<PostViewModel, PostResponse>();
            CreateMap<PostResponse, PostViewModel>();

            // Posts mapper
            CreateMap<UserViewModel, User>();
            CreateMap<User, UserViewModel>();
        }
    }
}