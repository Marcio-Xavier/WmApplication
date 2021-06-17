using App.Domain.Models.Itens;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Itens.IService
{
    public interface IIItemModeloService
    {
        Task<IEnumerable<ItemModelo>> Get();

        Task<ItemModelo> Get(uint Id);

        Task<uint> Insert(ItemModelo ItemModelo);

        Task<bool> Update(ItemModelo ItemModelo);

        Task<bool> Delete(uint Id);
    }
}