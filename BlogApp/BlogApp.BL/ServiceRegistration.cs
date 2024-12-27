using BlogApp.BL.Services.Implements;
using BlogApp.BL.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BlogApp.BL
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryService>();
            return services;
        }
    }
}
