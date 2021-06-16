using App.Domain.Base;
using Dapper.Contrib.Extensions;

namespace App.Domain.Models.Localizacao
{
    [Table("Endereco")]
    public class Endereco : BaseModel
    {
        public string Descricao { get; set; }

        public string Bairro { get; set; }

        public string Cep { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Referencia { get; set; }

        public uint LogradouroId { get; set; }
        
        public uint CidadeId { get; set; }

        public LogradouroTipo Logradouro { get; set; }

        public Cidade Cidade { get; set; }
    }
}