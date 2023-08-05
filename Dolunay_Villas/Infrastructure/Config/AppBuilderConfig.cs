using Dolunay_Villas.Infrastructure.Extensions;
namespace Dolunay_Villas.Infrastructure.Config
{
    public static class AppBuilderConfig
    {
        public static void ConfigureBuilder(this WebApplicationBuilder builder)
        {
            //builder.Services.AddControllers().AddApplicationPart(typeof(Controllers.AssemblyReferance).Assembly);
            builder.Services.AddControllersWithViews();
            builder.Services.ConfigureIdentity();
            builder.Services.AddRazorPages();
            builder.Services.ConfigureDb(builder.Configuration);
            builder.Services.ConfigureSession();
            builder.Services.AddDependencies();
            builder.Services.ConfigureCors();
            builder.Services.ConfigurePolicy();
            builder.Services.ConfigureApplicationCookie();
            builder.Services.AddAutoMapper(typeof(Program));
            builder.Services.ConfigureRouting();
        }
    }
}
