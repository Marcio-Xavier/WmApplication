using App.Domain.Models.Clientes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Repository.Repositories.Clientes.IRepository
{
    public interface IClienteEnderecoRepository
    {
        Task<IEnumerable<ClienteEndereco>> GetByCliente(uint Id);
    }
}
