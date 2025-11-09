using System.Configuration;
using System.Data.SqlClient;

namespace HotelManagement.Infrastructure.Database
{
    public class DbConnectionFactory : IDbConnectionFactory
    {
        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(GetConnectionString());
        }
    }
}
