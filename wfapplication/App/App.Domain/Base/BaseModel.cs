using Dapper.Contrib.Extensions;
using System;

namespace App.Domain.Base
{
    public abstract class BaseModel
    {
        [ExplicitKey]
        public int Id { get; }
        
        public DateTime DataRegistro { get; }

        public int StatusRegistroId { get; set; }
    }
}