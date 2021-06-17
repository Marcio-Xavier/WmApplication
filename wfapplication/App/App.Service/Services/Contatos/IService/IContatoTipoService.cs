using App.Domain.Models.Contatos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Contatos.IService
{
    public interface IContatoTipoService
    {
        Task<IEnumerable<ContatoTipo>> Get();

        Task<ContatoTipo> Get(uint Id);

        Task<uint> Insert(ContatoTipo ContatoTipo);

        Task<bool> Update(ContatoTipo ContatoTipo);

        Task<bool> Delete(uint Id);
    }
}