using App.Domain.Models.Fornecedores;
using App.Repository.BaseContext.Repository;
using App.Repository.Repositories.Fornecedores.IRepository;
using Dapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Repository.Repositories.Fornecedores.Repository
{
    public class FornecedorEnderecoRepository : BaseRepository, IFornecedorEnderecoRepository
    {
        public async Task<IEnumerable<FornecedorEndereco>> GetByFornecedor(uint Id)
        {
            var sql = @"SELECT * FROM FornecedorEndereco WHERE FornecedorId = @Id;";
            return await _conn.QueryAsync<FornecedorEndereco>(sql, new { Id });
        }
    }
}