using App.Domain.Base;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Comunicacao
{
    [Table("Contato")]
    public class Contato : BaseModel
    {
        public string Descricao { get; set; }

        public uint ContatoTipoId { get; set; }

        public ContatoTipo ContatoTipo { get; set; }
    }
}