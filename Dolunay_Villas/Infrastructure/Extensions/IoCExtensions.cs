﻿using Entity.Models;
using Repository.Concrete;
using Repository.Contracts;
using Service.Concrete;
using Service.Contract;

namespace Dolunay_Villas.Infrastructure.Extensions
{
    public static class IoCExtensions
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            //Session
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //Repositories
            services.AddScoped<IRealEstateRulesRepository, RealEstateRulesRepository>();
            services.AddScoped<IRealEstateHeatingOptionsRepository, RealEstateHeatingOptionsRepository>();
            services.AddScoped<IRealEstateRoomFeaturesRepository, RealEstateRoomFeaturesRepository>();
            services.AddScoped<IRealEstateRoomsRepository, RealEstateRoomsRepository>();
            services.AddScoped<IRealEstateBedTypesRepository, RealEstateBedTypesRepository>();
            services.AddScoped<IRealEstateItemTypesRepository, RealEstateItemTypesRepository>();
            services.AddScoped<IRealEstateValueTypesRepository, RealEstateValueTypesRepository>();
            services.AddScoped<IFontAwesomeRepository, FontAwesomeRepository>();

            //Repositories Base
            services.AddScoped<IRepositoryBase<Rules>, RealEstateRulesRepository>();
            services.AddScoped<IRepositoryBase<HeatingOptions>, RealEstateHeatingOptionsRepository>();
            services.AddScoped<IRepositoryBase<RoomFeatures>, RealEstateRoomFeaturesRepository>();
            services.AddScoped<IRepositoryBase<Rooms>, RealEstateRoomsRepository>();
            services.AddScoped<IRepositoryBase<BedTypes>, RealEstateBedTypesRepository>();
            services.AddScoped<IRepositoryBase<ItemTypes>, RealEstateItemTypesRepository>();
            services.AddScoped<IRepositoryBase<Entity.Models.ValueType>, RealEstateValueTypesRepository>();

            //Services
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IRealEstateRulesService, RealEstateRulesService>();
            services.AddScoped<IRealEstateHeatingOptionsService, RealEstateHeatingOptionsService>();
            services.AddScoped<IRealEstateRoomFeaturesService, RealEstateRoomFeaturesService>();
            services.AddScoped<IRealEstateRoomsService, RealEstateRoomsService>();
            services.AddScoped<IRealEstateBedTypesService, RealEstateBedTypesService>();
            services.AddScoped<IRealEstateItemTypesService, RealEstateItemTypesService>();
            services.AddScoped<IRealEstateValueTypesService, RealEstateValueTypesService>();
            services.AddScoped<IFontAwesomeService, FontAwesomeService>();
            //Others
        }
    }
}
