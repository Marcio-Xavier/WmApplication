using App.Domain.Base;
using App.Repository.BaseContext.Repository;

namespace App.Repository.BaseContext
{
    public class WmModasBaseRepository<T> : CRUDBaseRepository<T> where T : BaseModel { }
}