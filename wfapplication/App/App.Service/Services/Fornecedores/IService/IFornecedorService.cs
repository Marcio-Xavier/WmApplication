using App.Domain.Models.Fornecedores;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Fornecedores.IService
{
    public interface IFornecedorService
    {
        Task<IEnumerable<Fornecedor>> Get();

        Task<Fornecedor> Get(uint Id);

        Task<uint> Insert(Fornecedor Fornecedor);

        Task<bool> Update(Fornecedor Fornecedor);

        Task<bool> Delete(uint Id);
    }
}