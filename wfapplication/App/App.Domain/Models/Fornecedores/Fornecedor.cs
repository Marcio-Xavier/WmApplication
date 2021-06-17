using App.Domain.Base;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Fornecedores
{
    [Table("Fornecedor")]
    public class Fornecedor : BaseModel
    {
        public string Nome { get; set; }
        
        public string Cnpj { get; set; }
    }
}