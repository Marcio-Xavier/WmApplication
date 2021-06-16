using App.Domain.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Models.Produto
{
    [Table("Item")]
    public class ItemModelo : BaseModel
    {
        public string Descricao { get; set; }

        public uint ModeloCorId { get; set; }

        public ModeloCor ModeloCor { get; set; }

        public IEnumerable<Item> Itens { get; set; }
    }
}