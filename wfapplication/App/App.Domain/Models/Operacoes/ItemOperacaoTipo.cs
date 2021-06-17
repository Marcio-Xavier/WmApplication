using App.Domain.Base;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Operacoes
{
    [Table("ItemOperacaoTipo")]
    public class ItemOperacaoTipo : BaseModel
    {
        public string Descricao { get; set; }
    }
}