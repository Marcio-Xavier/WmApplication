using App.Domain.Models.Comunicacao;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Vendedor
{
    [Table("FornecedorContato")]
    public class FornecedorContato
    {
        public uint ForneceodrId { get; set; }

        public uint ContatoId { get; set; }

        public Fornecedor Fornecedor { get; set; }

        public Contato Contato { get; set; }
    }
}