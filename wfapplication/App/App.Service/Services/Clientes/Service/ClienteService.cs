using App.Domain.Models.Clientes;
using App.Repository.Repositories.Clientes.IRepository;
using App.Service.Services.Clientes.IService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Clientes.Service
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<bool> Delete(uint Id)
        {
            return false;
        }

        public async Task<IEnumerable<Cliente>> Get()
        {
            try
            {
                return await _clienteRepository.Get();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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
