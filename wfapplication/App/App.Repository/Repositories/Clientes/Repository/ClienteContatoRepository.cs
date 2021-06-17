using App.Domain.Models.Clientes;
using App.Repository.BaseContext.Repository;
using App.Repository.Repositories.Clientes.IRepository;
using Dapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Repository.Repositories.Clientes.Repository
{
    public class ClienteContatoRepository : BaseRepository, IClienteContatoRepository
    {
        public async Task<IEnumerable<ClienteContato>> GetByCliente(uint Id)
        {
            var sql = @"SELECT * FROM ClienteContato WHERE ClienteId = @Id;";
            return await _conn.QueryAsync<ClienteContato>(sql, new { Id });
        }
    }
}