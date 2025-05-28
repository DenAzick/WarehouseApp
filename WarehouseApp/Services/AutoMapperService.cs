using AutoMapper;
using WarehouseApp.Models.Users;

namespace WarehouseApp.Services;

public class AutoMapperService : Profile
{
    public AutoMapperService()
    {
        CreateMap<User, UserDto>();
        CreateMap<UserDto, User>();
    }

}
