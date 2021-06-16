using App.Domain.Base;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Operacao
{
    [Table("OperacaoTipo")]

    public class OperacaoTipo : BaseModel
    {
        public string Descricao { get; set; }
    }
}