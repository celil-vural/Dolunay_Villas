﻿using Entity.Enums;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Repository.Concrete.EntityFramework;
using System.Security.Claims;

namespace Dolunay_Villas.Infrastructure.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
            });
        }
        public static void ConfigurePolicy(this IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                foreach (var power in Enum.GetNames(typeof(Powers)))
                {
                    options.AddPolicy(power, policy =>
                        policy.RequireClaim(power, "true"));
                }
            });
        }
        public static void ConfigureDb(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<RepositoryContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("sqlconnection"),
                    b => b.MigrationsAssembly("Dolunay_Villas"));
                options.EnableSensitiveDataLogging(true);
            });
        }

        public static void ConfigureApplicationCookie(this IServiceCollection services)
        {
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.Cookie.Name = "Dolunay_Villas.Cookie";
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                options.SlidingExpiration = true;
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.Cookie.SameSite = SameSiteMode.Strict;
                options.Cookie.SecurePolicy = CookieSecurePolicy.Always;

            });
        }
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.User.RequireUniqueEmail = true; //aynı mail adresiyle birden fazla kayıt olamaz
                                                        // Kullanıcıların e-posta doğrulaması yapmasını gerektir
                options.Password.RequiredLength = 6;
                options.Password.RequireDigit = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
            }).AddEntityFrameworkStores<RepositoryContext>()
            .AddDefaultTokenProviders();
        }

        public static void ConfigureSession(this IServiceCollection service)
        {
            service.AddDistributedMemoryCache();
            service.AddSession(options =>
            {
                options.Cookie.Name = "Dolunay_Villas.Session";
                options.IdleTimeout = TimeSpan.FromMinutes(10);
            });
        }

        public static void ConfigureAndCheckMigration(this IApplicationBuilder app)
        {
            RepositoryContext context = app
                .ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<RepositoryContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
        }

        public static async void ConfigureDefaultAdminUser(this IApplicationBuilder app)
        {
            const string adminUser = "FurkanDolunay";
            const string adminPassword = "zDbRA29VsAPSnD";
            UserManager<IdentityUser> userManager = app.ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<UserManager<IdentityUser>>();
            RoleManager<IdentityRole> roleManager = app.ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<RoleManager<IdentityRole>>();
            IdentityUser user = await userManager.FindByNameAsync(adminUser);
            if (user == null)
            {
                var role = await roleManager.FindByNameAsync("Admin");
                foreach (var power in Enum.GetValues(typeof(Powers)).Cast<Powers>())
                {
                    var claimName = PowersDictionary.claimNames[power];
                    var claimResult = await roleManager.AddClaimAsync(role, new Claim(claimName, "true"));
                    if (!claimResult.Succeeded)
                        throw new Exception($"System have problems with claim definition for {claimName}.");
                }
                user = new IdentityUser()
                {
                    Email = "mfdesign@gmail.com",
                    PhoneNumber = "5511342381",
                    UserName = adminUser,
                    EmailConfirmed = true,
                };
                var result = await userManager.CreateAsync(user, adminPassword);
                if (!result.Succeeded)
                    throw new Exception("Admin user could not created.");
                var roleResult = await userManager.AddToRolesAsync(user,
                    roleManager
                        .Roles
                        .Select(r => r.Name)
                        .ToList()
                );
                if (!roleResult.Succeeded)
                    throw new Exception("System have problems with role defination for admin.");
            }
        }
        public static void ConfigureLocalization(this WebApplication application)
        {
            application.UseRequestLocalization(options =>
            {
                options.AddSupportedCultures("en-US", "tr-TR").AddSupportedUICultures("en-US", "tr-TR").SetDefaultCulture("tr-TR");
            });
        }

        /*public static void ConfigureSwagger(this WebApplication application)
        {
            application.UseSwagger();
            application.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "StoreApp API V1");
            });
        }*/
        public static void ConfigureRouting(this IServiceCollection services)
        {
            services.AddRouting(options =>
            {
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = false;
            });
        }
        public static void ConfigureEndPoints(this WebApplication application)
        {
            application.UseEndpoints(endpoint =>
            {
                endpoint.MapAreaControllerRoute(
                    name: "Admin", areaName: "Admin", pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}");
                endpoint.MapAreaControllerRoute(
                        name: "RealEstateManagement",
                        areaName: "RealEstateManagement",
                        pattern: "Admin/RealEstateManagement/{controller=Rules}/{action=Index}/{id?}"
                    );
                endpoint.MapControllerRoute(name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoint.MapRazorPages();
                endpoint.MapControllers();
            });
        }
    }
}
