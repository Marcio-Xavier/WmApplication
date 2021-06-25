using App.Repository.BaseContext.IRepository;
using App.Repository.BaseContext.Repository;
using App.Repository.Repositories.Clientes.IRepository;
using App.Repository.Repositories.Clientes.Repository;
using App.Repository.Repositories.Contatos.IRepository;
using App.Repository.Repositories.Contatos.Repository;
using App.Service.Services.Clientes.IService;
using App.Service.Services.Clientes.Service;
using App.Service.Services.Contatos.IService;
using App.Service.Services.Contatos.Service;
using Microsoft.Extensions.DependencyInjection;

namespace App.CrossCutting.DependencyInjection
{
    public static class Dependency
    {
        public static void ConfigureServices(this IServiceCollection Services)
        {
            Services.AddTransient<IClienteService, ClienteService>();
            Services.AddTransient<IContatoTipoService, ContatoTipoService>();
        }

        public static void ConfigureRepositories(this IServiceCollection Services)
        { 
            Services.AddScoped(typeof(ICRUDBaseRepository<>), typeof(CRUDBaseRepository<>));
            Services.AddScoped<IClienteRepository, ClienteRepository>();
            Services.AddScoped<IContatoTipoRepository, ContatoTipoRepository>();
        }
    }
}