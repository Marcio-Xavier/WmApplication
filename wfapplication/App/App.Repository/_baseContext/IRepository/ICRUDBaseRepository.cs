using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Repository._baseContext.IRepository
{
    public interface ICRUDBaseRepository<T> where T : class
    {
        Task<T> Get(uint Id);

        Task<IEnumerable<T>> Get();

        Task<int> Insert(T Objeto);

        Task<int> Insert(IEnumerable<T> Objetos);

        Task<bool> Update(T Objeto);

        Task<bool> Update(IEnumerable<T> Objetos);

        Task<bool> Delete(T Objeto);

        Task<bool> Delete(IEnumerable<T> Objetos);
    }
}