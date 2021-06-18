using App.Domain.Models.Operacoes;
using App.Repository.BaseContext.Repository;
using App.Repository.Repositories.Operacoes.IRepository;

namespace App.Repository.Repositories.Operacoes.Repository
{
    public class VendaRepository : CRUDBaseRepository<Venda>, IVendaRepository { }
}