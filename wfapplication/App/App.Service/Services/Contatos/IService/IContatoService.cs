using App.Domain.Models.Contatos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Contatos.IService
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