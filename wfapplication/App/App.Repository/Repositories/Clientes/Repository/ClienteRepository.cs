using App.Domain.Models.Clientes;
using App.Repository.BaseContext.Repository;
using App.Repository.Repositories.Clientes.IRepository;

namespace App.Repository.Repositories.Clientes.Repository
{
    public class ClienteRepository : CRUDBaseRepository<Cliente>, IClienteRepository { }
}