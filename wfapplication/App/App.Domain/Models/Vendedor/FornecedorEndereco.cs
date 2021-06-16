using App.Domain.Models.Localizacao;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Vendedor
{
    [Table("FornecedorEndereco")]
    public class FornecedorEndereco
    {
        public uint FornecedorId { get; set; }
        
        public uint EnderecoId { get; set; }

        public Fornecedor Fornecedor { get; set; }
        
        public Endereco Endereco { get; set; }
    }
}