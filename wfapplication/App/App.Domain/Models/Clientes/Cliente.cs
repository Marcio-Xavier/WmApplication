using App.Domain.Base;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Clientes
{
    [Table("Cliente")]
    public class Cliente : BaseModel
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }
    }
}