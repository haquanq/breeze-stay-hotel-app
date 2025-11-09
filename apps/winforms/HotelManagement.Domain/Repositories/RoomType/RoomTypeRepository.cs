using Dapper;
using HotelManagement.Infrastructure.Common;
using HotelManagement.Infrastructure.Abstracts;
using HotelManagement.Domain.Dtos.RoomType;
using HotelManagement.Domain.Models;
using HotelManagement.Infrastructure.Database;
using System.Data;
using System.Threading.Tasks;

namespace HotelManagement.Domain.Repositories.RoomType
{
    public class RoomTypeRepository : BaseRepository, IRoomTypeRepository
    {
        public RoomTypeRepository(IDbConnectionFactory connectionFactory, IDbParameterFactory parameterFactory) : base(connectionFactory, parameterFactory) { }

        public async Task<PageResponse<RoomTypeModel>> FindAsync(RoomTypeSearchDto roomTypeSearchDto, PageRequest pageRequest)
        {
            var res = new PageResponse<RoomTypeModel>();

            using (var conn = _connectionFactory.CreateConnection())
            {
                var p = new DynamicParameters(_parameterFactory.Create(roomTypeSearchDto));
                p.Add("@page_number", pageRequest.PageNumber, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);
                p.Add("@offset_elements", pageRequest.OffsetElements, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);
                p.Add("@total_pages", null, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@total_elements", null, dbType: DbType.Int32, direction: ParameterDirection.Output);

                var amenityList = await conn.QueryAsync<RoomTypeModel>(".usp_RoomType_Find", p, commandType: CommandType.StoredProcedure);

                res.Content = amenityList;
                res.TotalElements = p.Get<int>("@total_elements");
                res.TotalPages = p.Get<int>("@total_pages");
                res.CurrentPage = p.Get<int>("@page_number");
            }
            return res;
        }

        public async Task<RoomTypeModel> FindByIdAsync(string roomTypeId)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "SELECT id room_type_id, title, detail, price_per_night, " +
                    " created_at, updated_at FROM dbo.room_type WHERE id=@id";

                return await conn.QuerySingleAsync<RoomTypeModel>(sql, new { id = roomTypeId });
            }
        }

        public async Task CreateAsync(RoomTypeCreateDto roomType)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "INSERT INTO dbo.room_type (title, detail, price_per_night) " +
                    "VALUES (@title, @detail, @price_per_night)";
                await conn.ExecuteAsync(sql, _parameterFactory.Create(roomType));
            }
        }

        public async Task UpdateAsync(RoomTypeUpdateDto roomType)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "UPDATE dbo.room_type SET title=@title, detail=@detail, price_per_night=@price_per_night where id=@room_type_id";
                await conn.ExecuteAsync(sql, _parameterFactory.Create(roomType));
            }
        }

        public async Task DeleteByIdAsync(string roomTypeId)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "DELETE FROM dbo.room_type WHERE id=@id";
                await conn.ExecuteAsync(sql, new { id = roomTypeId });
            }
        }
    }
}
