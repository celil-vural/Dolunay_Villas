using AutoMapper;
using Entity.Dtos.Icon;
using Entity.Dtos.Log;
using Entity.Dtos.Photo;
using Entity.Dtos.RealEstateManagement.BedTypes;
using Entity.Dtos.RealEstateManagement.DistanceRuler;
using Entity.Dtos.RealEstateManagement.Distances;
using Entity.Dtos.RealEstateManagement.EstateTypes;
using Entity.Dtos.RealEstateManagement.HeatingOptions;
using Entity.Dtos.RealEstateManagement.ItemTypes;
using Entity.Dtos.RealEstateManagement.RealEstateFeatures;
using Entity.Dtos.RealEstateManagement.Region;
using Entity.Dtos.RealEstateManagement.RoomFeatures;
using Entity.Dtos.RealEstateManagement.Rooms;
using Entity.Dtos.RealEstateManagement.Rule;
using Entity.Dtos.RealEstateManagement.ValueTypes;
using Entity.Dtos.User;
using Entity.Dtos.Villas;
using Entity.Models;
using Entity.Models.RealEstateManagement.BedTypes;
using Entity.Models.RealEstateManagement.Distance;
using Entity.Models.RealEstateManagement.DistanceRuler;
using Entity.Models.RealEstateManagement.EstateType;
using Entity.Models.RealEstateManagement.HeatingOptions;
using Entity.Models.RealEstateManagement.ItemType;
using Entity.Models.RealEstateManagement.RealEstateFeatures;
using Entity.Models.RealEstateManagement.Regions;
using Entity.Models.RealEstateManagement.Room;
using Entity.Models.RealEstateManagement.RoomFeatures;
using Entity.Models.RealEstateManagement.Rule;
using Microsoft.AspNetCore.Identity;
using ValueType = Entity.Models.RealEstateManagement.ValueType.ValueType;
namespace StoreApp.Infrastructure.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Dtos
            CreateMap<UserDtoForCreation, IdentityUser>();
            CreateMap<UserDtoForUpdate, IdentityUser>().ReverseMap();
            CreateMap<IdentityUser, UserDto>().ReverseMap();
            CreateMap<RulesDto, Rules>().ReverseMap();
            CreateMap<RulesDtoForInsertion, Rules>().ReverseMap();
            CreateMap<RulesDtoForUpdate, Rules>().ReverseMap();
            CreateMap<VillaDto, Villa>().ReverseMap();
            CreateMap<HeatingOption, HeatingOptionsDto>().ReverseMap();
            CreateMap<HeatingOption, HeatingOptionsDtoForInsertions>().ReverseMap();
            CreateMap<HeatingOption, HeatingOptionsDtoForUpdate>().ReverseMap();
            CreateMap<RoomFeature, RoomFeaturesDto>().ReverseMap();
            CreateMap<RoomFeature, RoomFeaturesDtoForUpdate>().ReverseMap();
            CreateMap<RoomFeature, RoomFeaturesDtoForInsertions>().ReverseMap();
            CreateMap<Rooms, RoomsDto>().ReverseMap();
            CreateMap<Rooms, RoomsDtoForInsertions>().ReverseMap();
            CreateMap<Rooms, RoomsDtoForUpdate>().ReverseMap();
            CreateMap<ItemType, ItemTypeDto>().ReverseMap();
            CreateMap<ValueType, ValueTypeDto>().ReverseMap();
            CreateMap<BedType, BedTypesDto>().ReverseMap();
            CreateMap<BedType, BedTypesDtoForInsertion>().ReverseMap();
            CreateMap<BedType, BedTypesDtoForUpdate>().ReverseMap();
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<Region, RegionDtoForUpdate>().ReverseMap();
            CreateMap<Region, RegionDtoForInsertion>().ReverseMap();
            CreateMap<Log, LogDto>().ReverseMap();
            CreateMap<Log, LogDtoForInsertion>().ReverseMap();
            CreateMap<Log, LogDtoForUpdate>().ReverseMap();
            CreateMap<Photo, PhotoDto>().ReverseMap();
            CreateMap<Photo, PhotoDtoInsertion>().ReverseMap();
            CreateMap<Photo, PhotoDtoUpdate>().ReverseMap();
            CreateMap<Icon, IconDto>().ReverseMap();
            CreateMap<Icon, IconDtoForUpdate>().ReverseMap();
            CreateMap<Icon, IconDtoForInsertion>().ReverseMap();
            CreateMap<RealEstateFeatures, RealEstateFeaturesDto>().ReverseMap();
            CreateMap<RealEstateFeatures, RealEstateFeaturesDtoForInsertion>().ReverseMap();
            CreateMap<RealEstateFeatures, RealEstateFeaturesDtoForUpdate>().ReverseMap();
            CreateMap<EstateTypes, EstateTypesDto>().ReverseMap();
            CreateMap<EstateTypes, EstateTypesDtoForInsertion>().ReverseMap();
            CreateMap<EstateTypes, EstateTypesDtoForUpdate>().ReverseMap();
            CreateMap<Distances, DistancesDto>().ReverseMap();
            CreateMap<Distances, DistancesDtoForInsertion>().ReverseMap();
            CreateMap<Distances, DistancesDtoForUpdate>().ReverseMap();
            CreateMap<DistanceRuler, DistanceRulerDto>().ReverseMap();
            CreateMap<DistanceRuler, DistanceRulerDtoForUpdate>().ReverseMap();
            CreateMap<DistanceRuler, DistanceRulerDtoForInsertion>().ReverseMap();
            CreateMap<Villa, VillaDto>().ReverseMap();
            CreateMap<Villa, VillaDtoForInsertion>().ReverseMap();
            CreateMap<Villa, VillaDtoForUpdate>().ReverseMap();
            #endregion
        }
    }
}
