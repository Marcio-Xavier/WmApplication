using App.Domain.Base;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace App.Domain.Models.Operacoes
{
    [Table("TipoPagamento")]
    public class TipoPagamento : BaseModel
    {
        public string Descricao { get; set; }

        public IEnumerable<Compra> Compras { get; set; }
        
        public IEnumerable<Venda> Vendas { get; set; }
    }
}