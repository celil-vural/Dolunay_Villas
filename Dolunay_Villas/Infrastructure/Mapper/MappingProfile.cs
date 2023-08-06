using AutoMapper;
using Entity.Dtos.HeatingOptions;
using Entity.Dtos.RoomFeatures;
using Entity.Dtos.Rooms;
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
            CreateMap<HeatingOptions, HeatingOptionsDto>().ReverseMap();
            CreateMap<HeatingOptions, HeatingOptionsDtoForInsertions>().ReverseMap();
            CreateMap<HeatingOptions, HeatingOptionsDtoForUpdate>().ReverseMap();
            CreateMap<RoomFeatures, RoomFeaturesDto>().ReverseMap();
            CreateMap<RoomFeatures, RoomFeaturesDtoForUpdate>().ReverseMap();
            CreateMap<RoomFeatures, RoomFeaturesDtoForInsertions>().ReverseMap();
            CreateMap<Rooms, RoomsDto>().ReverseMap();
            CreateMap<Rooms, RoomsDtoForInsertions>().ReverseMap();
            CreateMap<Rooms, RoomsDtoForUpdate>().ReverseMap();
        }
    }
}
