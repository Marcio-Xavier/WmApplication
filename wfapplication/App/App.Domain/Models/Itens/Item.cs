using App.Domain.Base;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Itens
{
    [Table("Item")]
    public class Item : BaseModel
    {
        public string CodigoInterno { get; set; }

        public string Descricao { get; set; }

        public uint Estoque { get; set; }

        public double ValorUnitario { get; set; }

        public uint ItemCategoriaId { get; set; }

        public uint ItemModeloId { get; set; }

        public uint ItemCorId { get; set; }
        
        public string Imagem { get; set; }

        public ItemCategoria ItemCategoria { get; set; }

        public ItemModelo ItemModelo { get; set; }
    }
}