using Entity.Models;
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

            //Repositories Base
            services.AddScoped<IRepositoryBase<Rules>, RealEstateRulesRepository>();
            services.AddScoped<IRepositoryBase<HeatingOptions>, RealEstateHeatingOptionsRepository>();
            services.AddScoped<IRepositoryBase<RoomFeatures>, RealEstateRoomFeaturesRepository>();

            //Services
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IRealEstateRulesService, RealEstateRulesService>();
            services.AddScoped<IRealEstateHeatingOptionsService, RealEstateHeatingOptionsService>();
            services.AddScoped<IRealEstateRoomFeaturesService, RealEstateRoomFeaturesService>();

            //Others
        }
    }
}
