using App.Domain.Base;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Comunicacao
{
    [Table("ContatoTipo")]
    public class ContatoTipo : BaseModel
    {
        public string Descricao { get; set; }
    }
}