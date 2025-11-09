using Dapper;
using HotelManagement.Infrastructure.Common;
using HotelManagement.Infrastructure.Abstracts;
using HotelManagement.Domain.Dtos.Customer;
using HotelManagement.Domain.Models;
using HotelManagement.Infrastructure.Database;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data;

namespace HotelManagement.Domain.Repositories.Customer
{
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(IDbConnectionFactory connectionFactory, IDbParameterFactory parameterFactory) : base(connectionFactory, parameterFactory) { }

        public async Task<PageResponse<CustomerModel>> FindAsync(CustomerSearchDto customerSearchDto, PageRequest pageRequest)
        {
            var res = new PageResponse<CustomerModel>();

            using (var conn = _connectionFactory.CreateConnection())
            {
                var p = new DynamicParameters(_parameterFactory.Create(customerSearchDto));
                p.Add("@page_number", pageRequest.PageNumber, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);
                p.Add("@offset_elements", pageRequest.OffsetElements, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);
                p.Add("@total_pages", null, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@total_elements", null, dbType: DbType.Int32, direction: ParameterDirection.Output);

                var customers = await conn.QueryAsync<CustomerModel>("dbo.usp_Customer_Find", p, commandType: CommandType.StoredProcedure);

                res.Content = customers;
                res.TotalElements = p.Get<int>("@total_elements");
                res.TotalPages = p.Get<int>("@total_pages");
                res.CurrentPage = p.Get<int>("@page_number");
            }

            return res;
        }

        public async Task<CustomerModel> FindByIdAsync(string customerId)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "select id customer_id, first_name, last_name, citizen_id_number, address1, address2, " +
                             " email, phone, status, created_at, updated_at FROM dbo.customer WHERE id = @id";
                var res = await conn.QuerySingleAsync<CustomerModel>(sql, new { id = customerId });
                return res;
            }
        }

        public async Task CreateAsync(CustomerCreateDto customer)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "insert into customer (first_name, last_name, citizen_id_number, address1, address2, phone, email, status) values " +
                            " (@first_name, @last_name, @citizen_id_number, @address1, @address2, @phone, @email, @status)";
                await conn.ExecuteAsync(sql, _parameterFactory.Create(customer));
            }
        }

        public async Task UpdateAsync(CustomerUpdateDto customer)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "UPDATE dbo.customer SET first_name=@first_name, last_name=@last_name, citizen_id_number=@citizen_id_number, " +
                    " address1=@address1, address2=@address2, phone=@phone, email=@email, status=@status WHERE id=@customer_id";
                await conn.ExecuteAsync(sql, _parameterFactory.Create(customer));
            }
        }

        public async Task DeleteByIdAsync(string customerId)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "DELETE FROM dbo.customer WHERE id=@id";
                await conn.ExecuteAsync(sql, new { id = customerId });
            }
        }


        ///  clean
        public async Task InsertMany(List<CustomerCreateDto> data)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "insert into customer (first_name, last_name, citizen_id_number, address1, address2, phone, email, status) values " +
                            " (@first_name, @last_name, @citizen_id_number, @address1, @address2, @phone, @email, @status)";
                var x = data.ConvertAll(_parameterFactory.Create);
                await conn.ExecuteAsync(sql, x);
            }
        }
    }
}
