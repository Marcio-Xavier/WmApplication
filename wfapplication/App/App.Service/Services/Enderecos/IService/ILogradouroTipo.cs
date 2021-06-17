using App.Domain.Models.Enderecos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Services.Enderecos.IService
{
    public interface ILogradouroTipo
    {
        Task<IEnumerable<LogradouroTipo>> Get();

        Task<LogradouroTipo> Get(uint Id);

        Task<uint> Insert(LogradouroTipo LogradouroTipo);

        Task<bool> Update(LogradouroTipo LogradouroTipo);

        Task<bool> Delete(uint Id);
    }
}