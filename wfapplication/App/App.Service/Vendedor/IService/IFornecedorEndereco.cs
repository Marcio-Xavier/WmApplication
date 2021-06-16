using App.Domain.Models.Vendedor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Vendedor.IService
{
    public interface IFornecedorEndereco
    {
        Task<IEnumerable<FornecedorEndereco>> Get();

        Task<FornecedorEndereco> Get(uint Id);

        Task<uint> Insert(FornecedorEndereco FornecedorEndereco);

        Task<bool> Update(FornecedorEndereco FornecedorEndereco);

        Task<bool> Delete(uint Id);
    }
}