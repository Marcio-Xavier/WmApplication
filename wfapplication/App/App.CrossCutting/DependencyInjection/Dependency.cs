using App.Repository.BaseContext.IRepository;
using App.Repository.BaseContext.Repository;
using App.Repository.Repositories.Comprador.IRepository;
using App.Repository.Repositories.Comprador.Repository;
using App.Service.Services.Comprador.IService;
using App.Service.Services.Comprador.Service;
using Microsoft.Extensions.DependencyInjection;

namespace App.CrossCutting.DependencyInjection
{
    public static class Dependency
    {
        public static void ConfigureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IClienteService, ClienteService>();
        }

        public static void ConfigureRepositories(this IServiceCollection serviceCollection)
        { 
            serviceCollection.AddScoped<IClienteRepository, ClienteRepository>();
            serviceCollection.AddScoped(typeof(ICRUDBaseRepository<>), typeof(CRUDBaseRepository<>));
        }
    }
}