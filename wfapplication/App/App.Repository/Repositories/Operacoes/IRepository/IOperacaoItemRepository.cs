﻿using App.Domain.Models.Operacoes;
using App.Repository.BaseContext.IRepository;

namespace App.Repository.Repositories.Operacoes.IRepository
{
    public interface IOperacaoItemRepository : ICRUDBaseRepository<OperacaoItem> { }
}