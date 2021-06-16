using System.Configuration;
using System.Data.SqlClient;

namespace App.Repository._baseContext.Repository
{
    public class BaseRepository
    {
        protected readonly string connection = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;
        protected SqlConnection _conn;

        public BaseRepository()
        {
            _conn = new SqlConnection(connection);
        }
    }
}