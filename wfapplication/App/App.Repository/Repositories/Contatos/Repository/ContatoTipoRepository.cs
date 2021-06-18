using App.Domain.Models.Contatos;
using App.Repository.BaseContext.Repository;
using App.Repository.Repositories.Contatos.IRepository;

namespace App.Repository.Repositories.Contatos.Repository
{
    public class ContatoTipoRepository : CRUDBaseRepository<ContatoTipo>, IContatoTipoRepository { }
}