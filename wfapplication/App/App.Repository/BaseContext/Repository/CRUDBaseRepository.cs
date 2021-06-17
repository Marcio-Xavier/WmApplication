using App.Domain.Base;
using App.Repository.BaseContext.IRepository;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Repository.BaseContext.Repository
{
    public abstract class CRUDBaseRepository<T> : BaseRepository, ICRUDBaseRepository<T> where T : BaseModel
    {
        public async Task<T> Get(uint Id)
        {
            return await _conn.GetAsync<T>(Id);
        }

        public async Task<IEnumerable<T>> Get()
        {
            return await _conn.GetAllAsync<T>();
        }

        public async Task<int> Insert(T Objeto)
        {
            return await _conn.InsertAsync(Objeto);
        }

        public async Task<int> Insert(IEnumerable<T> Objetos)
        {
            return await _conn.InsertAsync(Objetos);
        }

        public async Task<bool> Update(T Objeto)
        {
            return await _conn.UpdateAsync(Objeto);
        }

        public async Task<bool> Update(IEnumerable<T> Objetos)
        {
            return await _conn.UpdateAsync(Objetos);
        }

        public async Task<bool> Delete(T Objeto)
        {
            return await _conn.DeleteAsync(Objeto);
        }

        public async Task<bool> Delete(IEnumerable<T> Objetos)
        {
            return await _conn.DeleteAsync(Objetos);
        }
    }
}