using App.Domain.Models.Localizacao;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Localizacao.IService
{
    public interface IEnderecoService
    {
        Task<IEnumerable<Endereco>> Get();

        Task<Endereco> Get(uint Id);

        Task<uint> Insert(Endereco Endereco);

        Task<bool> Update(Endereco Endereco);

        Task<bool> Delete(uint Id);
    }
}