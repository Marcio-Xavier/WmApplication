using App.Domain.Models.Comunicacao;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Comunicacao.IService
{
    public interface IContatoService
    {
        Task<IEnumerable<Contato>> Get();

        Task<Contato> Get(uint Id);

        Task<uint> Insert(Contato Contato);

        Task<bool> Update(Contato Contato);

        Task<bool> Delete(uint Id);
    }
}