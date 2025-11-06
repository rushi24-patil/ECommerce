using AutoMapper;
using UserServer.DAL.Models;
using UserServer.BLL.DTOs;

namespace UserServer.BLL.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<User, CreateUserDto>().ReverseMap();
            CreateMap<User, UpdateUserDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, GetUserDto>().ReverseMap();
            CreateMap<GetAllUserDto, User>().ReverseMap();
        }
    }
}
