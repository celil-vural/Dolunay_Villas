using Repository.Concrete;
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
            //Others
        }
    }
}
