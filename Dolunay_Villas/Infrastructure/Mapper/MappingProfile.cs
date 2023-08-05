using AutoMapper;
using Entity.Dtos.Rules;
using Entity.Dtos.User;
using Entity.Dtos.Villa;
using Entity.Models;
using Microsoft.AspNetCore.Identity;

namespace StoreApp.Infrastructure.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserDtoForCreation, IdentityUser>();
            CreateMap<UserDtoForUpdate, IdentityUser>().ReverseMap();
            CreateMap<IdentityUser, UserDto>().ReverseMap();
            CreateMap<RulesDto, Rules>().ReverseMap();
            CreateMap<RulesDtoForInsertion, Rules>().ReverseMap();
            CreateMap<RulesDtoForUpdate, Rules>().ReverseMap();
            CreateMap<VillaDto, Villa>().ReverseMap();
        }
    }
}
