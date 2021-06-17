using App.Domain.Models.Usuarios;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Usuarios.IService
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> Get();

        Task<Usuario> Get(uint Id);

        Task<uint> Insert(Usuario Usuario);

        Task<bool> Update(Usuario Usuario);

        Task<bool> Delete(uint Id);
    }
}