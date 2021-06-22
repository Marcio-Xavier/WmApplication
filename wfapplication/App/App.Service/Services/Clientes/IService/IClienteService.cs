using App.Domain.Models.Clientes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Clientes.IService
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> Get();
        
        Task<Cliente> Get(uint Id);

        Task<int> Insert(Cliente Cliente);

        Task<int> Insert(IEnumerable<Cliente> Clientes);

        Task<bool> Update(Cliente Cliente);
        
        Task<bool> Update(IEnumerable<Cliente> Cliente);

        Task<bool> LogicDelete(Cliente Cliente);

        Task<bool> LogicDelete(IEnumerable<Cliente> Clientes);
    }
}