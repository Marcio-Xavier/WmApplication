using App.Domain.Models.Comprador;
using App.Service.Services.Comprador.IService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Comprador.Service
{
    public class ClienteService : IClienteService
    {
        public async Task<bool> Delete(uint Id)
        {
            return false;
        }

        public async Task<IEnumerable<Cliente>> Get()
        {
            return null;
        }

        public async Task<Cliente> Get(uint Id)
        {
            return null;
        }

        public async Task<uint> Insert(Cliente Cliente)
        {
            return 0;
        }

        public async Task<bool> Update(Cliente Cliente)
        {
            return false;
        }
    }
}
