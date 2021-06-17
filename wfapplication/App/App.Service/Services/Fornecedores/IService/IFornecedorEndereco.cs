using App.Domain.Models.Fornecedores;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Fornecedores.IService
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