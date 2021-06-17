using App.Domain.Base;
using App.Domain.Models.Itens;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Operacoes
{
    [Table("OperacaoItem")]

    public class OperacaoItem : BaseModel
    {
        public uint Quantidade { get; set; }

        public double ValorUnitario { get; set; }

        public double Desconto { get; set; }

        public bool Brinde { get; set; }

        public string Observacao { get; set; }

        public uint CompraId { get; set; }
        
        public uint VendaId { get; set; }
        
        public uint ItemId { get; set; }

        public uint OperacaoTipoId { get; set; } /// Compra; Venda

        public uint ItemOperacaoTipoId { get; set; } /// Compra/Venda; Frete

        public Compra Compra { get; set; }

        public Venda Venda { get; set; }

        public Item Item { get; set; }

        public OperacaoTipo OperacaoTipo { get; set; } /// Compra; Venda

        public ItemOperacaoTipo ItemOperacaoTipo { get; set; } /// Compra/Venda; Frete
    }
}