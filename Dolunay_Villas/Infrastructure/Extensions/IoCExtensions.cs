﻿using Repository.Concrete;
using Repository.Concrete.RealEstateManagement;
using Repository.Contracts;
using Repository.Contracts.RealEstateManagement;
using Service.Concrete;
using Service.Concrete.RealEstateManagement;
using Service.Contract;
using Service.Contract.RealEstateManagement;

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
            services.AddSingleton<IFontAwesomeRepository, FontAwesomeRepository>();
            services.AddScoped<IRealEstateHighlightsRepository, RealEstateHighlightsRepository>();
            services.AddScoped<IRealEstateRegionRepository, RealEstateRegionRepository>();
            services.AddScoped<ILoggerRepository, LoggerRepository>();
            services.AddScoped<IPhotoRepository, PhotoRepository>();
            services.AddScoped<IIconRepository, IconRepository>();
            services.AddScoped<IRealEstateFeaturesRepository, RealEstateFeaturesRepository>();
            services.AddScoped<IRealEstateTypesRepository, RealEstateTypesRepository>();
            services.AddScoped<IRealEstateDistancesRepository, RealEstateDistancesRepository>();
            services.AddScoped<IRealEstateDistanceRulerRepository, RealEstateDistanceRulerRepository>();
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
            services.AddSingleton<IFontAwesomeService, FontAwesomeService>();
            services.AddScoped<IRealEstateHighlightsService, RealEstateHighlightsService>();
            services.AddScoped<IRealEstateRegionService, RealEstateRegionService>();
            services.AddScoped<ILoggerService, LoggerService>();
            services.AddScoped<IPhotoService, PhotoService>();
            services.AddScoped<IIconService, IconService>();
            services.AddScoped<IRealEstateFeaturesService, RealEstateFeaturesService>();
            services.AddScoped<IRealEstateTypesService, RealEstateTypesService>();
            services.AddScoped<IRealEstateDistancesService, RealEstateDistancesService>();
            services.AddScoped<IRealEstateDistanceRulerService, RealEstateDistanceRulerService>();

            //Others
        }
    }
}
