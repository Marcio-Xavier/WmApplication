using App.Domain.Base;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace App.Domain.Models.Itens
{
    [Table("ItemCor")]
    public class ItemCor : BaseModel
    {
        public string Descricao { get; set; }
    }
}