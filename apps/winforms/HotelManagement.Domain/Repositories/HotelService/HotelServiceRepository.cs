using Dapper;
using HotelManagement.Infrastructure.Common;
using HotelManagement.Infrastructure.Abstracts;
using HotelManagement.Domain.Dtos.HotelService;
using HotelManagement.Domain.Models;
using HotelManagement.Infrastructure.Database;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using HotelManagement.Domain.Repositories.HotelService;

namespace HotelManagement.Infrastructure.Repositories.HotelService
{
    public class HotelServiceRepository : BaseRepository, IHotelServiceRepository
    {
        public HotelServiceRepository(IDbConnectionFactory connectionFactory, IDbParameterFactory parameterFactory)
            : base(connectionFactory, parameterFactory) { }

        public async Task<PageResponse<HotelServiceModel>> FindAsync(HotelServiceSearchDto hotelServiceSearchDto, PageRequest pageRequest)
        {
            var result = new PageResponse<HotelServiceModel>();

            using (var conn = _connectionFactory.CreateConnection())
            {
                var p = new DynamicParameters(_parameterFactory.Create(hotelServiceSearchDto));
                p.Add("@page_number", pageRequest.PageNumber, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);
                p.Add("@offset_elements", pageRequest.OffsetElements, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);
                p.Add("@total_pages", null, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@total_elements", null, dbType: DbType.Int32, direction: ParameterDirection.Output);

                var hotelServices = await conn.QueryAsync<HotelServiceModel>(".usp_HotelService_Search", p, commandType: CommandType.StoredProcedure);

                result.Content = hotelServices;
                result.TotalElements = p.Get<int>("@total_elements");
                result.TotalPages = p.Get<int>("@total_pages");
                result.CurrentPage = p.Get<int>("@page_number");
            }

            return result;
        }

        public async Task<HotelServiceModel> FindByIdAsync(string hotelServiceId)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "SELECT id hotel_service_id, * FROM dbo.hotel_service WHERE id = @id";
                return await conn.QuerySingleAsync<HotelServiceModel>(sql, new { id = hotelServiceId });
            }
        }

        public async Task CreateAsync(HotelServiceCreateDto HotelServiceCreateDto)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "INSERT INTO dbo.hotel_service (title, detail ) VALUES (@title, @detail )";
                await conn.ExecuteAsync(sql, _parameterFactory.Create(HotelServiceCreateDto));
            }
        }

        public async Task UpdateAsync(HotelServiceUpdateDto HotelServiceUpdateDto)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "UPDATE dbo.hotel_service SET title=@title, detail=@detail  WHERE id=@hotel_service_id";
                await conn.ExecuteAsync(sql, _parameterFactory.Create(HotelServiceUpdateDto));
            }
        }

        public async Task DeleteByIdAsync(string hotelServiceId)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "DELETE FORM dbo.hotel_service WHERE id=@id";
                await conn.ExecuteAsync(sql, new { id = hotelServiceId });
            }
        }

        public async Task InsertMany(List<HotelServiceCreateDto> data)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "INSERT INTO dbo.hotel_service (title, detail) VALUES (@title, @detail)";
                await conn.ExecuteAsync(sql, data);
            }
        }
    }
}
