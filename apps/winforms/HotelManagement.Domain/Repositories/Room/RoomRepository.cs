using Dapper;
using HotelManagement.Infrastructure.Common;
using HotelManagement.Infrastructure.Abstracts;
using HotelManagement.Domain.Dtos.Room;
using HotelManagement.Domain.Models;
using HotelManagement.Infrastructure.Database;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Linq;

namespace HotelManagement.Domain.Repositories.Room
{
    public class RoomRepository : BaseRepository, IRoomRepository
    {
        public RoomRepository(IDbConnectionFactory connectionFactory, IDbParameterFactory parameterFactory) : base(connectionFactory, parameterFactory) { }

        public async Task<PageResponse<RoomModel>> FindAsync(RoomSearchDto roomSearchDto, PageRequest pageRequest)
        {
            var res = new PageResponse<RoomModel>();

            using (var conn = _connectionFactory.CreateConnection())
            {
                Func<RoomModel, RoomTypeModel, RoomModel> queryMapper = (room, roomType) =>
                {
                    room.RoomType = roomType;
                    return room;
                };

                res.Content = await conn.QueryAsync(
                    "dbo.usp_Room_Search",
                    queryMapper,
                    _parameterFactory.Create(roomSearchDto),
                    splitOn: "row_count, room_type_id",
                    commandType: CommandType.StoredProcedure);
            }
            return res;
        }

        public async Task<RoomModel> FindByIdAsync(string roomId)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {

                Func<RoomModel, RoomTypeModel, RoomAmenityModel, AmenityModel, RoomModel> queryMapper =
                    (room, roomType, roomAmenity, Amenity) =>
                {
                    room.RoomType = roomType;
                    roomAmenity.Amenity = Amenity;
                    room.Amenities.Add(roomAmenity);
                    return room;
                };

                var result = await conn.QueryAsync(
                    "dbo.usp_Room_FindOne",
                    queryMapper,
                    new { room_id = roomId },
                    splitOn: "room_type_id, room_amenity_id, amenity_id",
                    commandType: CommandType.StoredProcedure);

                return result.GroupBy(v => v.RoomId).Select(v => v.Single()).Single();
            }
        }

        public async Task CreateAsync(RoomCreateDto room)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "INSERT INTO dbo.room (title, detail, price, status) VALUES (@title, @detail, @price, @status)";
                await conn.ExecuteAsync(sql, _parameterFactory.Create(room));
            }
        }

        public async Task UpdateAsync(RoomUpdateDto room)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "UPDATE dbo.room SET title=@title, detail=@detail, price=@price, status=@status WHERE id=@room_id";
                await conn.ExecuteAsync(sql, _parameterFactory.Create(room));
            }
        }

        public async Task DeleteByIdAsync(string roomId)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "DELETE FORM dbo.room WHERE id=@id";
                await conn.ExecuteAsync(sql, new { id = roomId });
            }
        }
    }
}
