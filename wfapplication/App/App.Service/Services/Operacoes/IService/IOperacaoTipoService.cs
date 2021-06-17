using App.Domain.Models.Operacoes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Operacoes.IService
{
    public interface IOperacaoTipoService
    {
        Task<IEnumerable<OperacaoTipo>> Get();

        Task<OperacaoTipo> Get(uint Id);

        Task<uint> Insert(OperacaoTipo OperacaoTipo);

        Task<bool> Update(OperacaoTipo OperacaoTipo);

        Task<bool> Delete(uint Id);
    }
}