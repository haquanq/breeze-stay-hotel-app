using HotelManagement.Infrastructure.Database;

namespace HotelManagement.Infrastructure.Abstracts
{
    public abstract class BaseRepository
    {
        protected readonly IDbConnectionFactory _connectionFactory;
        protected readonly IDbParameterFactory _parameterFactory;
        private IDbConnectionFactory factory;

        public BaseRepository(IDbConnectionFactory connectionFactory, IDbParameterFactory parameterFactoru)
        {
            _connectionFactory = connectionFactory;
            _parameterFactory = parameterFactoru;

        }

        protected BaseRepository(IDbConnectionFactory factory)
        {
            this.factory = factory;
        }
    }
}
