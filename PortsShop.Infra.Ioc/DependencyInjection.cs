using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PortsShop.Application.Interfaces;
using PortsShop.Application.Mappings;
using PortsShop.Application.Services;
using PortsShop.Domain.Interfaces;
using PortsShop.Infra.Data.Context;
using PortsShop.Infra.Data.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Options;
using PortsShop.Domain.Account;
using PortsShop.Infra.Data.Identity;

namespace PortsShop.Infra.Ioc;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("iSAGAConnectionQAS"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
        });

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["jwt:secretKey"])),
                ClockSkew = TimeSpan.Zero
            };
        });

        //Cors
    

        // Configurar o AutoMapper
        services.AddAutoMapper(typeof(UserMappingProfile));
        services.AddAutoMapper(typeof(CategoryMappingProfile));

        // Repositories
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IBranchRepository, BranchRepository>();

        // Services
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IAuthenticate, AuthenticateService>();
        services.AddScoped<IBranchService, BranchService>();

        return services;
    }
}