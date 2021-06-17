using App.Domain.Models.Clientes;
using App.Repository.BaseContext.IRepository;

namespace App.Repository.Repositories.Clientes.IRepository
{
    public interface IClienteRepository : ICRUDBaseRepository<Cliente> { }
}