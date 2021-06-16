using App.Domain.Base;
using App.Domain.Models.Comprador;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Operacao
{
    [Table("Venda")]
    public class Venda : BaseModel
    {
        public uint ClienteId { get; set; }

        public Cliente Cliente { get; set; }
    }
}