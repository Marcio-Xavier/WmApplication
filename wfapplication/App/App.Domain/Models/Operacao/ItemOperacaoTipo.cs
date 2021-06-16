using App.Domain.Base;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Operacao
{
    [Table("ItemOperacaoTipo")]
    public class ItemOperacaoTipo : BaseModel
    {
        public string Descricao { get; set; }
    }
}