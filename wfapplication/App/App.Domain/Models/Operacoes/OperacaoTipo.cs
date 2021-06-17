using App.Domain.Base;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Operacoes
{
    [Table("OperacaoTipo")]

    public class OperacaoTipo : BaseModel
    {
        public string Descricao { get; set; }
    }
}