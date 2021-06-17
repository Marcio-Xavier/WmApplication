using App.Repository.BaseContext.IRepository;
using App.Repository.BaseContext.Repository;
using App.Repository.Repositories.Comprador.IRepository;
using App.Repository.Repositories.Comprador.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace App.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IClienteRepository, ClienteRepository>();
            serviceCollection.AddScoped(typeof(ICRUDBaseRepository<>), typeof(CRUDBaseRepository<>));
        }
    }
}