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

        #region Métodos CRUD
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

        public async Task<IEnumerable<Cliente>> GetTeste()
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
            try
            {
                return await _clienteRepository.Get(Id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<int> Insert(Cliente Cliente)
        {
            try
            {
                return await _clienteRepository.Insert(Cliente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<int> Insert(IEnumerable<Cliente> Clientes)
        {
            try
            {
                return await _clienteRepository.Insert(Clientes);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Update(Cliente Cliente)
        {
            try
            {
                return await _clienteRepository.Update(Cliente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Update(IEnumerable<Cliente> Clientes)
        {
            try
            {
                return await _clienteRepository.Update(Clientes);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> LogicDelete(Cliente Cliente)
        {
            try
            {
                return await _clienteRepository.LogicDelete(Cliente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> LogicDelete(IEnumerable<Cliente> Clientes)
        {
            try
            {
                return await _clienteRepository.LogicDelete(Clientes);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}