using MeuTodoCoreWebApi.Infrastructure.Data;
using MeuTodoCoreWebApi.Infrastructure.Repository;
using MeuTodoCoreWebApi.Infrastructure.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MeuTodoCoreWebApi.Infrastructure
{
    public class IoCRegistrator
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>();
            services.AddTransient<ITodoRepository, TodoRepository>();
        }
    }
}
