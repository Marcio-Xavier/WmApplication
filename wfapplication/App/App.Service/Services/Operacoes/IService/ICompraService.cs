using App.Domain.Models.Operacoes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Operacoes.IService
{
    public interface ICompraService
    {
        Task<IEnumerable<Compra>> Get();

        Task<Compra> Get(uint Id);

        Task<uint> Insert(Compra Compra);

        Task<bool> Update(Compra Compra);

        Task<bool> Delete(uint Id);
    }
}