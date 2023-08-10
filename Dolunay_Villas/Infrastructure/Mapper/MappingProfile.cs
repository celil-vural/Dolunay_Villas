using AutoMapper;
using Entity.Dtos.Log;
using Entity.Dtos.RealEstateManagement.BedTypes;
using Entity.Dtos.RealEstateManagement.HeatingOptions;
using Entity.Dtos.RealEstateManagement.ItemTypes;
using Entity.Dtos.RealEstateManagement.Region;
using Entity.Dtos.RealEstateManagement.RoomFeatures;
using Entity.Dtos.RealEstateManagement.Rooms;
using Entity.Dtos.RealEstateManagement.Rules;
using Entity.Dtos.RealEstateManagement.ValueTypes;
using Entity.Dtos.User;
using Entity.Dtos.Villa;
using Entity.Models;
using Entity.Models.RealEstateManagement;
using Microsoft.AspNetCore.Identity;
using ValueType = Entity.Models.RealEstateManagement.ValueType;
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
            CreateMap<ItemTypes, ItemTypeDto>().ReverseMap();
            CreateMap<ValueType, ValueTypeDto>().ReverseMap();
            CreateMap<BedTypes, BedTypesDto>().ReverseMap();
            CreateMap<BedTypes, BedTypesDtoForInsertion>().ReverseMap();
            CreateMap<BedTypes, BedTypesDtoForUpdate>().ReverseMap();
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<Region, RegionDtoForUpdate>().ReverseMap();
            CreateMap<Region, RegionDtoForInsertion>().ReverseMap();
            CreateMap<Log, LogDto>().ReverseMap();
            CreateMap<Log, LogDtoForInsertion>().ReverseMap();
            CreateMap<Log, LogDtoForUpdate>().ReverseMap();
        }
    }
}
