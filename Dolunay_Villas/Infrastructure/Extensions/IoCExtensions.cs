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

            //Connection Repositories to Database
            //services.AddScoped<IRepositoryBase<Rules>, RepositoryBase<Rules>>();

            //Services
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IRealEstateRulesService, RealEstateRulesService>();

            //Others
        }
    }
}
