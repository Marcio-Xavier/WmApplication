﻿using App.Domain.Base;
using App.Domain.Models.Cliente;
using App.Domain.Models.Fornecedor;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace App.Domain.Models.Localizacao
{
    [Table("Cidade")]
    public class Cidade : BaseModel
    {
        public string Nome { get; set; }

        public bool Capital { get; set; }

        public int EstadoId { get; set; }

        public Estado Estado { get; set; }

        public IEnumerable<Endereco> Cidades { get; set; }
        
        public IEnumerable<ClienteEndereco> ClienteEnderecos { get; set; }
        
        public IEnumerable<FornecedorEndereco> FornecedorEnderecos { get; set; }
    }
}