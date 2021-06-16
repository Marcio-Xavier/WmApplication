using App.Domain.Models.Comunicacao;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Comprador
{
    [Table("ClienteContato")]
    public class ClienteContato
    {
        public uint ClienteId { get; set; }

        public uint ContatoId { get; set; }

        public Cliente Cliente { get; set; }

        public Contato Contato { get; set; }
    }
}