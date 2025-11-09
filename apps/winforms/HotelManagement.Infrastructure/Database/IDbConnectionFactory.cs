using System.Data.SqlClient;

namespace HotelManagement.Infrastructure.Database
{
    public interface IDbConnectionFactory
    {
        SqlConnection CreateConnection();
        string GetConnectionString();
    }
}