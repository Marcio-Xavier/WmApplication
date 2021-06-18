using App.Domain.Models.Itens;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Itens.IService
{
    public interface IModeloCorService
    {
        Task<IEnumerable<ItemCor>> Get();

        Task<ItemCor> Get(uint Id);

        Task<uint> Insert(ItemCor ModeloCor);

        Task<bool> Update(ItemCor ModeloCor);

        Task<bool> Delete(uint Id);
    }
}