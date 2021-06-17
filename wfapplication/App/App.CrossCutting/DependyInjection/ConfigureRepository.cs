using App.Repository.BaseContext.IRepository;
using App.Repository.BaseContext.Repository;
using App.Repository.Repositories.Comprador.IRepository;
using App.Repository.Repositories.Comprador.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace App.CrossCutting.DependyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(ICRUDBaseRepository<>), typeof(CRUDBaseRepository<>));

            serviceCollection.AddScoped<IClienteRepository, ClienteRepository>();
        }
    }
}