
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TodoApp.Application.Auth;
using TodoApp.Application.Interfaces.Context;
using TodoApp.Application.Interfaces.Repositories;
using TodoApp.Persistence.Context;
using TodoApp.Persistence.Repositories;

namespace TodoApp.Persistence
{
    static public class ServiceRegistiration
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("TodoAppConnection");  
            var identityConnectionString = configuration.GetConnectionString("IdentityConnection");

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
            services.AddDbContext<IdentityContext>(options => options.UseSqlServer(identityConnectionString));
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<IdentityContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
