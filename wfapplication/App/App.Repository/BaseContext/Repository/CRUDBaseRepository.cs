using App.Domain.Base;
using App.Domain.Enums;
using App.Repository.BaseContext.IRepository;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Repository.BaseContext.Repository
{
    public class CRUDBaseRepository<T> : BaseRepository, ICRUDBaseRepository<T> where T : BaseModel
    {
        public async Task<T> Get(uint Id)
        {
            return await _conn.GetAsync<T>(Id);
        }

        public async Task<IEnumerable<T>> Get()
        {
            try
            {
                return await _conn.GetAllAsync<T>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<int> Insert(T Objeto)
        {
            try
            {
                return await _conn.InsertAsync(Objeto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<int> Insert(IEnumerable<T> Objetos)
        {
            try
            {
                return await _conn.InsertAsync(Objetos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Update(T Objeto)
        {
            try
            {
                return await _conn.UpdateAsync(Objeto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Update(IEnumerable<T> Objetos)
        {
            try
            {
                return await _conn.UpdateAsync(Objetos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> LogicDelete(T Objeto)
        {
            try
            {
                Objeto.StatusRegistroId = (int)StatusRegistro.Excluido;
                return await _conn.UpdateAsync(Objeto);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> LogicDelete(IEnumerable<T> Objetos)
        {
            try
            {
                Objetos.ToList().ForEach(x => x.StatusRegistroId = (int)StatusRegistro.Excluido);
                return await _conn.UpdateAsync(Objetos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}