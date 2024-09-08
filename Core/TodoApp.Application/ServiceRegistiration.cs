using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace TodoApp.Application
{
    static public class ServiceRegistiration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
