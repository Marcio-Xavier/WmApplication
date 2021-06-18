using App.Domain.Models.Contatos;
using App.Repository.BaseContext.IRepository;

namespace App.Repository.Repositories.Contatos.IRepository
{
    public interface IContatoRepository : ICRUDBaseRepository<Contato> { }
}
