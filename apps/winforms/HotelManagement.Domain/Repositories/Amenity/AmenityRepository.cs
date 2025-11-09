using Dapper;
using HotelManagement.Infrastructure.Common;
using HotelManagement.Infrastructure.Database;
using HotelManagement.Infrastructure.Abstracts;
using HotelManagement.Domain.Dtos.Amenity;
using HotelManagement.Domain.Models;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace HotelManagement.Domain.Repositories.Amenity
{
    public class AmenityRepository : BaseRepository, IAmenityRepository
    {
        public AmenityRepository(IDbConnectionFactory connectionFactory, IDbParameterFactory parameterFactory) : base(connectionFactory, parameterFactory) { }

        public async Task<PageResponse<AmenityModel>> FindAsync(AmenitySearchDto amenitySearchDto, PageRequest pageRequest)
        {
            var res = new PageResponse<AmenityModel>();

            using (var conn = _connectionFactory.CreateConnection())
            {
                var p = new DynamicParameters(_parameterFactory.Create(amenitySearchDto));
                p.Add("@page_number", pageRequest.PageNumber, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);
                p.Add("@offset_elements", pageRequest.OffsetElements, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);
                p.Add("@total_pages", null, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@total_elements", null, dbType: DbType.Int32, direction: ParameterDirection.Output);

                var amenities = await conn.QueryAsync<AmenityModel>("dbo.usp_Amenity_Search", p, commandType: CommandType.StoredProcedure);

                res.Content = amenities;
                res.TotalElements = p.Get<int>("@total_elements");
                res.TotalPages = p.Get<int>("@total_pages");
                res.CurrentPage = p.Get<int>("@page_number");
            }

            return res;
        }

        public async Task<AmenityModel> FindByIdAsync(string amenityId)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "SELECT id amenity_id, * FROM dbo.amenity WHERE id = @id";
                return await conn.QuerySingleAsync<AmenityModel>(sql, new { id = amenityId });
            }
        }

        public async Task CreateAsync(AmenityCreateDto amenity)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "INSERT INTO dbo.amenity (title, detail, price, status) VALUES (@title, @detail, @price, @status)";
                await conn.ExecuteAsync(sql, _parameterFactory.Create(amenity));
            }
        }

        public async Task UpdateAsync(AmenityUpdateDto amenity)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "UPDATE dbo.amenity SET title=@title, detail=@detail, price=@price, status=@status WHERE id=@amenity_id";
                await conn.ExecuteAsync(sql, _parameterFactory.Create(amenity));
            }
        }

        public async Task DeleteByIdAsync(string amenityId)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "DELETE FORM dbo.amenity WHERE id=@id";
                await conn.ExecuteAsync(sql, new { id = amenityId });
            }
        }

        public async Task InsertMany(List<AmenityCreateDto> data)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "INSERT INTO dbo.amenity (title, detail, price, status) VALUES (@title, @detail, @price, @status)";
                await conn.ExecuteAsync(sql, data);
            }
        }
    }
}
