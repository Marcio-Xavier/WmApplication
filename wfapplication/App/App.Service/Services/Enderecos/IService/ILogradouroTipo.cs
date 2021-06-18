using App.Domain.Models.Enderecos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Enderecos.IService
{
    public interface ILogradouroTipo
    {
        Task<IEnumerable<Logradouro>> Get();

        Task<Logradouro> Get(uint Id);

        Task<uint> Insert(Logradouro LogradouroTipo);

        Task<bool> Update(Logradouro LogradouroTipo);

        Task<bool> Delete(uint Id);
    }
}