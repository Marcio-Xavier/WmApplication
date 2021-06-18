using App.Domain.Models.Fornecedores;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Repository.Repositories.Fornecedores.IRepository
{
    public interface IFornecedorContatoRepository
    {
        Task<IEnumerable<FornecedorContato>> GetByFornecedor(uint Id);
    }
}