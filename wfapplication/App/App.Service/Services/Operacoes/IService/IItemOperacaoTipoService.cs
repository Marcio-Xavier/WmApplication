using App.Domain.Models.Operacoes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Operacoes.IService
{
    public interface IItemOperacaoTipoService
    {
        Task<IEnumerable<ItemOperacaoTipo>> Get();

        Task<ItemOperacaoTipo> Get(uint Id);

        Task<uint> Insert(ItemOperacaoTipo ItemOperacaoTipo);

        Task<bool> Update(ItemOperacaoTipo ItemOperacaoTipo);

        Task<bool> Delete(uint Id);
    }
}