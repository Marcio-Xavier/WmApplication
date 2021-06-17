using App.Domain.Base;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace App.Domain.Models.Itens
{
    [Table("Item")]
    public class ItemCategoria : BaseModel
    {   
        public string Descricao { get; set; }

        public IEnumerable<Item> Itens { get; set; }
    }
}