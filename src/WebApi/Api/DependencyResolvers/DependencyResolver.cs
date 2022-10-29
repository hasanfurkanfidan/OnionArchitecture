using Application.DependencyResolvers;
using Application.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using Persistence.Repositories;

namespace Api.DependencyResolvers
{
    public static class DependencyResolver
    {
        public static void AddDependencies(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetSection("SqlCon").Value);
            });

            services.AddScoped<IBookRepository, BookRepoistory>();

            ApplicationDependencyResolver.AddDependencies(services);
        }
    }
}
