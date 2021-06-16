using App.Domain.Models.Localizacao;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Localizacao.IService
{
    public interface IEstadoService
    {
        Task<IEnumerable<Estado>> Get();

        Task<Estado> Get(uint Id);

        Task<uint> Insert(Estado Estado);

        Task<bool> Update(Estado Estado);

        Task<bool> Delete(uint Id);
    }
}