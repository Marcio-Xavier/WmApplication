using App.Domain.Base;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace App.Domain.Models.Localizacao
{
    [Table("LogradouroTipo")]
    public class LogradouroTipo : BaseModel
    {
        public string Descricao { get; set; }

        public IEnumerable<Endereco> Enderecos { get; set; }
    }
}