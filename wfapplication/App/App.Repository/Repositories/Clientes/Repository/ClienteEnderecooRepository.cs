using App.Domain.Models.Clientes;
using App.Repository.BaseContext.Repository;
using App.Repository.Repositories.Clientes.IRepository;
using Dapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Repository.Repositories.Clientes.Repository
{
    public class ClienteEnderecoRepository : BaseRepository, IClienteEnderecoRepository
    {
        public async Task<IEnumerable<ClienteEndereco>> GetByCliente(uint Id)
        {
            var sql = @"SELECT * FROM ClienteEndereco WHERE ClienteId = @Id;";
            return await _conn.QueryAsync<ClienteEndereco>(sql, new { Id });
        }
    }
}