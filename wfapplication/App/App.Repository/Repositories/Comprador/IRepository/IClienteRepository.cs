using App.Domain.Models.Comprador;
using App.Repository.BaseContext.IRepository;

namespace App.Repository.Repositories.Comprador.IRepository
{
    public interface IClienteRepository : ICRUDBaseRepository<Cliente> { }
}