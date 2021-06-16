using App.Domain.Models.Localizacao;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Comprador
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
