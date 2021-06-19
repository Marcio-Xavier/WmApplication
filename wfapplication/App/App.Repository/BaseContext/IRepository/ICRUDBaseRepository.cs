using App.Domain.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Repository.BaseContext.IRepository
{
    public interface ICRUDBaseRepository<T> where T : BaseModel
    {
        Task<T> Get(uint Id);

        Task<IEnumerable<T>> Get();

        Task<int> Insert(T Objeto);

        Task<int> Insert(IEnumerable<T> Objetos);

        Task<bool> Update(T Objeto);

        Task<bool> Update(IEnumerable<T> Objetos);

        Task<bool> LogicDelete(T Objeto);

        Task<bool> LogicDelete(IEnumerable<T> Objetos);
    }
}