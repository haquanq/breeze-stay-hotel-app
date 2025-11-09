using Dapper;
using HotelManagement.Infrastructure.Common;
using HotelManagement.Infrastructure.Abstracts;
using HotelManagement.Domain.Dtos.Staff;
using HotelManagement.Domain.Models;
using HotelManagement.Infrastructure.Database;
using System.Data;
using System.Threading.Tasks;

namespace HotelManagement.Domain.Repositories.Staff
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public EmployeeRepository(IDbConnectionFactory connectionFactory, IDbParameterFactory parameterFactory)
            : base(connectionFactory, parameterFactory) { }

        public async Task<PageResponse<StaffModel>> FindAsync(EmployeeSearchDto searchParams, PageRequest pageRequest)
        {
            var res = new PageResponse<StaffModel>();
            using (var conn = _connectionFactory.CreateConnection())
            {
                var p = new DynamicParameters(_parameterFactory.Create(searchParams));
                p.Add("@page_number", pageRequest.PageNumber, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);
                p.Add("@offset_elements", pageRequest.OffsetElements, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);
                p.Add("@total_pages", null, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@total_elements", null, dbType: DbType.Int32, direction: ParameterDirection.Output);

                var staves = await conn.QueryAsync<StaffModel>(".usp_Staff_Search", p, commandType: CommandType.StoredProcedure);
                res.Content = staves;
                res.TotalElements = p.Get<int>("@total_elements");
                res.TotalPages = p.Get<int>("@total_pages");
                res.CurrentPage = p.Get<int>("@page_number");
            }
            return res;
        }

        public async Task<StaffModel> FindByIdAsync(string staffId)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "SELECT id staff_id, first_name,last_name, dob, " +
                    " phone, email, role, account_status, created_at, updated_at " +
                    " FROM dbo.staff WHERE id=@id";
                var res = await conn.QuerySingleAsync<StaffModel>(sql, new { id = staffId });
                return res;
            }
        }

        public async Task CreateAsync(StaffCreateDto staff)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "INSERT INTO dbo.staff ( first_name, last_name, dob, phone, email, role, account_status, account_password) values " +
                " (@first_name, @last_name, @dob, @phone, @email, @role, @account_status, @account_password)";
                await conn.ExecuteAsync(sql, _parameterFactory.Create(staff));
            }
        }

        public async Task UpdateAsync(StaffUpdateDto staff)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = $"UPDATE dbo.staff SET first_name = @first_name, last_name = @last_name, dob = @dob, role = @role, " +
                $" phone = @phone, email = @email, account_status = @account_status, acccount_password = @account_password " +
                $" WHERE id=@staff_id";
                await conn.ExecuteAsync(sql, _parameterFactory.Create(staff));
            }
        }

        public async Task DeleteByIdAsync(string staffId)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "DELETE FROM dbo.staff WHERE id = @id";
                await conn.ExecuteAsync(sql, new { id = staffId });
            }
        }
    }
}
