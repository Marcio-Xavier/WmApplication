using App.Domain.Models.Enderecos;
using App.Repository.BaseContext.Repository;
using App.Repository.Repositories.Enderecos.IRepository;

namespace App.Repository.Repositories.Enderecos.Repository
{
    public class EstadoRepository : CRUDBaseRepository<Estado>, IEstadoRepository { }
}