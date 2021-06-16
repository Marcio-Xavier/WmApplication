using App.Domain.Base;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Usuario
{
    [Table("Usuario")]
    public class Usuario : BaseModel
    {
        public string Nome { get; set; }
        
        public string Login { get; set; }
        
        public string Senha { get; set; }
    }
}