using App.Domain.Models.Operacoes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Operacoes.IService
{
    public interface IOperacaoItemService
    {
        Task<IEnumerable<OperacaoItem>> Get();

        Task<OperacaoItem> Get(uint Id);

        Task<uint> Insert(OperacaoItem OperacaoItem);

        Task<bool> Update(OperacaoItem OperacaoItem);

        Task<bool> Delete(uint Id);
    }
}