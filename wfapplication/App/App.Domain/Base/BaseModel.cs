using Dapper.Contrib.Extensions;
using System;

namespace App.Domain.Base
{
    public abstract class BaseModel
    {
        [Key]
        public int Id { get; set; }

        [Write(false)]
        public DateTime DataRegistro { get; set; }

        public int StatusRegistroId { get; set; }
    }
}