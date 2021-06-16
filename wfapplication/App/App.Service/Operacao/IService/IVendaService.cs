using App.Domain.Models.Operacao;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Operacao.IService
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