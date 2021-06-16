using App.Domain.Base;
using App.Domain.Models.Vendedor;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Operacao
{
    [Table("Compra")]
    public class Compra : BaseModel
    {
        public uint FornecedorId { get; set; }
        
        public Fornecedor  Fornecedor { get; set; }
    }
}