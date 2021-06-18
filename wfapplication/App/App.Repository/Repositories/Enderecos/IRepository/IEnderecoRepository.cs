﻿using App.Domain.Models.Enderecos;
using App.Repository.BaseContext.IRepository;

namespace App.Repository.Repositories.Enderecos.IRepository
{
    public interface IEnderecoRepository : ICRUDBaseRepository<Endereco> { }
}