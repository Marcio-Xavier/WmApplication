using App.Domain.Models.Clientes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Repository.Repositories.Clientes.IRepository
{
    public interface IClienteContatoRepository
    {
        Task<IEnumerable<ClienteContato>> GetByCliente(uint Id);
    }
}
