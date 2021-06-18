using App.Domain.Models.Usuarios;
using App.Repository.BaseContext.IRepository;

namespace App.Repository.Repositories.Usuarios.IRepository
{
    public interface IUsuarioRepository : ICRUDBaseRepository<Usuario> { }
}