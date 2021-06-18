using App.Domain.Models.Fornecedores;
using App.Repository.BaseContext.Repository;
using App.Repository.Repositories.Fornecedores.IRepository;

namespace App.Repository.Repositories.Fornecedores.Repository
{
    public class FornecedorRepository : CRUDBaseRepository<Fornecedor>, IFornecedorRepository { }
}