using App.Domain.Base;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace App.Domain.Models.Itens
{
    [Table("ModeloCor")]
    public class ModeloCor : BaseModel
    {
        public string Descricao { get; set; }

        public IEnumerable<ItemModelo> ItemModelos { get; set; }
    }
}