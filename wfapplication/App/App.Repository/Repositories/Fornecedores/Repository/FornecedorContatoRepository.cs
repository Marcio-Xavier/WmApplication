using App.Domain.Models.Fornecedores;
using App.Repository.BaseContext.Repository;
using App.Repository.Repositories.Fornecedores.IRepository;
using Dapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Repository.Repositories.Fornecedores.Repository
{
    public class FornecedorContatoRepository : BaseRepository, IFornecedorContatoRepository
    {
        public async Task<IEnumerable<FornecedorContato>> GetByFornecedor(uint Id)
        {
            var sql = @"SELECT * FROM FornecedorContato WHERE FornecedorId = @Id;";
            return await _conn.QueryAsync<FornecedorContato>(sql, new { Id });
        }
    }
}