using App.Domain.Base;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace App.Domain.Models.Enderecos
{
    [Table("Logradouro")]
    public class Logradouro : BaseModel
    {
        public string Descricao { get; set; }

        public IEnumerable<Endereco> Enderecos { get; set; }
    }
}