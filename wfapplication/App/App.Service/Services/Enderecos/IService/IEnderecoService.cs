using App.Domain.Models.Enderecos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Enderecos.IService
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