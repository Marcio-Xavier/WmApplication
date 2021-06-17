using App.Domain.Models.Enderecos;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Fornecedores
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