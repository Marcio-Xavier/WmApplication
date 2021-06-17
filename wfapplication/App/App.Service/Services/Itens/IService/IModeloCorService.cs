using App.Domain.Models.Itens;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Itens.IService
{
    public interface IModeloCorService
    {
        Task<IEnumerable<ModeloCor>> Get();

        Task<ModeloCor> Get(uint Id);

        Task<uint> Insert(ModeloCor ModeloCor);

        Task<bool> Update(ModeloCor ModeloCor);

        Task<bool> Delete(uint Id);
    }
}