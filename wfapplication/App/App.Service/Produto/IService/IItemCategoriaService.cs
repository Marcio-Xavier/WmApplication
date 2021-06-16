﻿using App.Domain.Models.Produto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Service.Produto.IService
{
    public interface IItemCategoriaService
    {
        Task<IEnumerable<ItemCategoria>> Get();

        Task<ItemCategoria> Get(uint Id);

        Task<uint> Insert(ItemCategoria ItemCategoria);

        Task<bool> Update(ItemCategoria ItemCategoria);

        Task<bool> Delete(uint Id);
    }
}