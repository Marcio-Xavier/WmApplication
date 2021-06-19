using App.Domain.Base;
using App.Domain.Models.Clientes;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Operacoes
{
    [Table("Venda")]
    public class Venda : BaseModel
    {
        public uint ClienteId { get; set; }
        
        public int TipoPagamentoId { get; set; }

        public Cliente Cliente { get; set; }

        public TipoPagamento TipoPagamento { get; set; }
    }
}