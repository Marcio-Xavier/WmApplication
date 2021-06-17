using App.Domain.Base;
using App.Domain.Models.Fornecedores;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Operacoes
{
    [Table("Compra")]
    public class Compra : BaseModel
    {
        public uint FornecedorId { get; set; }
        
        public Fornecedor  Fornecedor { get; set; }
    }
}