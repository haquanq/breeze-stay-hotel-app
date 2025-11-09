using System.Collections.Generic;

namespace HotelManagement.Infrastructure.Database
{
    public interface IDbParameterFactory
    {
        Dictionary<string, dynamic> Create<T>(T ob) where T : class;
    }
}