using App.Domain.Models.Itens;
using App.Repository.BaseContext.Repository;
using App.Repository.Repositories.Itens.IRepository;

namespace App.Repository.Repositories.Itens.Repository
{
    public class ModeloCorRepository : CRUDBaseRepository<ItemCor>, IModeloCorRepository { }
}