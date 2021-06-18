using App.Domain.Models.Usuarios;
using App.Repository.BaseContext.Repository;
using App.Repository.Repositories.Usuarios.IRepository;

namespace App.Repository.Repositories.Usuarios.Repository
{
    public class UsuarioRepository : CRUDBaseRepository<Usuario>, IUsuarioRepository { }
}