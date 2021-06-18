using App.Domain.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Models.Itens
{
    [Table("ItemModelo")]
    public class ItemModelo : BaseModel
    {
        public string Descricao { get; set; }

        public IEnumerable<Item> Itens { get; set; }
    }
}