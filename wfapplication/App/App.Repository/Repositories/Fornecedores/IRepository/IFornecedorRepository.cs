using App.Domain.Models.Fornecedores;
using App.Repository.BaseContext.IRepository;

namespace App.Repository.Repositories.Fornecedores.IRepository
{
    public interface IFornecedorRepository : ICRUDBaseRepository<Fornecedor> { }
}