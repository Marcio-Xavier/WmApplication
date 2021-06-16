using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace App.Domain.Models.Produto
{
    [Table("ModeloCor")]
    public class ModeloCor
    {
        public string Descricao { get; set; }

        public IEnumerable<ItemModelo> ItemModelos { get; set; }
    }
}