using App.Domain.Models.Contatos;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Fornecedores
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