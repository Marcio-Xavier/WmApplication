using App.Domain.Models.Fornecedores;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Repository.Repositories.Fornecedores.IRepository
{
    public interface IFornecedorEnderecoRepository
    {
        Task<IEnumerable<FornecedorEndereco>> GetByFornecedor(uint Id);
    }
}