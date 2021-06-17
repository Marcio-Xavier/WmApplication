using App.Domain.Models.Clientes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Clientes.IService
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> Get();

        Task<Cliente> Get(uint Id);
        
        Task<uint> Insert(Cliente Cliente);
        
        Task<bool> Update(Cliente Cliente);
        
        Task<bool> Delete(uint Id);
    }
}