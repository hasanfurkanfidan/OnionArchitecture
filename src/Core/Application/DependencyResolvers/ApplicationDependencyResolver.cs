using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application.DependencyResolvers
{
    public static class ApplicationDependencyResolver
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
