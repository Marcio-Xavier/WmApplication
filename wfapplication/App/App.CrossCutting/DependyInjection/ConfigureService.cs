using App.Service.Services.Comprador.IService;
using App.Service.Services.Comprador.Service;
using Microsoft.Extensions.DependencyInjection;

namespace App.CrossCutting.DependyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IClienteService, ClienteService>();
        }
    }
}