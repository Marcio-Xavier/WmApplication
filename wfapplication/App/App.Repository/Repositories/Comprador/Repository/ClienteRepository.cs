using App.Domain.Models.Comprador;
using App.Repository.BaseContext.Repository;
using App.Repository.Repositories.Comprador.IRepository;

namespace App.Repository.Repositories.Comprador.Repository
{
    public class ClienteRepository : CRUDBaseRepository<Cliente>, IClienteRepository { }
}