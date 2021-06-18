using Dapper.Contrib.Extensions;
using System;

namespace App.Domain.Base
{
    public abstract class BaseModel
    {
        [Key]
        public uint Id { get; }

        [Write(false)]
        [Computed]
        public DateTime DataRegistro { get; }

        [Write(false)]
        public uint StatusRegistroId { get; set; }
    }
}