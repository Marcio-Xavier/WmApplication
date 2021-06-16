using App.Domain.Models.Localizacao;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Localizacao.IService
{
    public interface ILogradouroTipo
    {
        Task<IEnumerable<LogradouroTipo>> Get();

        Task<LogradouroTipo> Get(uint Id);

        Task<uint> Insert(LogradouroTipo LogradouroTipo);

        Task<bool> Update(LogradouroTipo LogradouroTipo);

        Task<bool> Delete(uint Id);
    }
}