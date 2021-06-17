using App.Domain.Models.Operacoes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Operacoes.IService
{
    public interface IVendaService
    {
        Task<IEnumerable<Venda>> Get();

        Task<Venda> Get(uint Id);

        Task<uint> Insert(Venda Venda);

        Task<bool> Update(Venda Venda);

        Task<bool> Delete(uint Id);
    }
}