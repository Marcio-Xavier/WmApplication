using App.Repository._baseContext.Repository;

namespace App.Repository._baseContext
{
    public class WmModasBaseRepository<T> : CRUDBaseRepository<T> where T : class { }
}