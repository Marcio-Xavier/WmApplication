using App.Domain.Models.Fornecedores;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Fornecedores.IService
{
    public interface IFornecedorContatoService
    {
        Task<IEnumerable<FornecedorContato>> Get();

        Task<FornecedorContato> Get(uint Id);

        Task<uint> Insert(FornecedorContato FornecedorContato);

        Task<bool> Update(FornecedorContato FornecedorContato);

        Task<bool> Delete(uint Id);
    }
}