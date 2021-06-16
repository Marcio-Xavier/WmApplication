using App.Domain.Base;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace App.Domain.Models.Localizacao
{
    [Table("Estado")]
    public class Estado : BaseModel
    {
        public string Nome { get; set; }

        public string Uf { get; set; }

        public IEnumerable<Cidade> Cidades { get; set; }
    }
}