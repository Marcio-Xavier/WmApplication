using App.Domain.Models.Contatos;
using App.Repository.Repositories.Contatos.IRepository;
using App.Service.Services.Contatos.IService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Contatos.Service
{
    public class ContatoTipoService : IContatoTipoService
    {
        private IContatoTipoRepository _contatoTipoRepository;

        public ContatoTipoService(IContatoTipoRepository contatoTipoRepository)
        {
            _contatoTipoRepository = contatoTipoRepository;
        }

        #region Métodos CRUD
        public async Task<IEnumerable<ContatoTipo>> Get()
        {
            try
            {
                return await _contatoTipoRepository.Get();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<ContatoTipo> Get(uint Id)
        {
            try
            {
                return await _contatoTipoRepository.Get(Id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<int> Insert(ContatoTipo ContatoTipo)
        {
            try
            {
                return await _contatoTipoRepository.Insert(ContatoTipo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Update(ContatoTipo ContatoTipo)
        {
            try
            {
                return await _contatoTipoRepository.Update(ContatoTipo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
