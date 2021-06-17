using App.Domain.Models.Clientes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Clientes.IService
{
    public interface IClienteEnderecoService
    {
        Task<IEnumerable<ClienteEndereco>> Get();

        Task<Cliente> Get(uint Id);
        
        Task<uint> Insert(ClienteEndereco ClienteEndereco);
        
        Task<bool> Update(ClienteEndereco ClienteEndereco);
        
        Task<bool> Delete(uint Id);
    }
}