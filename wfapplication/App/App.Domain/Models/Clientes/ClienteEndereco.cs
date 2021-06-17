using App.Domain.Base;
using App.Domain.Models.Enderecos;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Clientes
{
    [Table("ClienteEndereco")]
    public class ClienteEndereco
    {
        public uint ClienteId { get; set; }
        
        public uint EnderecoId { get; set; }

        public Cliente Cliente { get; set; }
        
        public Endereco Endereco { get; set; }
    }
}
