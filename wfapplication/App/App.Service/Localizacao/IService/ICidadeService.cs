using App.Domain.Models.Localizacao;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Localizacao.IService
{
    public interface ICidadeService
    {
        Task<IEnumerable<Cidade>> Get();

        Task<Cidade> Get(uint Id);

        Task<uint> Insert(Cidade Cidade);

        Task<bool> Update(Cidade Cidade);

        Task<bool> Delete(uint Id);
    }
}
