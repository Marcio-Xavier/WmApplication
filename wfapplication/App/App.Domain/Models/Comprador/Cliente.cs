using App.Domain.Base;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Comprador
{
    [Table("Cliente")]
    public class Cliente : BaseModel
    {
        public string Nome { get; }

        public string Cpf { get; }
    }
}