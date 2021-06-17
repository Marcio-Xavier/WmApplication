using App.Domain.Models.Clientes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Clientes.IService
{
    public interface IClienteContatoService
    {
        Task<IEnumerable<ClienteContato>> Get();

        Task<Cliente> Get(uint Id);
        
        Task<uint> Insert(ClienteContato ClienteContato);
        
        Task<bool> Update(ClienteContato ClienteContato);
        
        Task<bool> Delete(uint Id);
    }
}