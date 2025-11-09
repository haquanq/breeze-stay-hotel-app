using Dapper;
using HotelManagement.Infrastructure.Common;
using HotelManagement.Infrastructure.Abstracts;
using HotelManagement.Domain.Dtos.DiscountCoupon;
using HotelManagement.Domain.Models;
using HotelManagement.Infrastructure.Database;
using System.Data;
using System.Threading.Tasks;

namespace HotelManagement.Domain.Repositories.DiscountCoupon
{
    public class DiscountCouponRepository : BaseRepository, IDiscountCouponRepository
    {
        public DiscountCouponRepository(IDbConnectionFactory connectionFactory, IDbParameterFactory parameterFactory) : base(connectionFactory, parameterFactory) { }

        public async Task<PageResponse<DiscountCouponModel>> FindAsync(DiscountCouponSearchDto discountCouponSearchDto, PageRequest pageRequest)
        {
            var res = new PageResponse<DiscountCouponModel>();

            using (var conn = _connectionFactory.CreateConnection())
            {

                var p = new DynamicParameters(_parameterFactory.Create(discountCouponSearchDto));
                p.Add("@page_number", pageRequest.PageNumber, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);
                p.Add("@offset_elements", pageRequest.OffsetElements, dbType: DbType.Int32, direction: ParameterDirection.InputOutput);
                p.Add("@total_pages", null, dbType: DbType.Int32, direction: ParameterDirection.Output);
                p.Add("@total_elements", null, dbType: DbType.Int32, direction: ParameterDirection.Output);

                var discountCoupons = await conn.QueryAsync<DiscountCouponModel>("dbo.usp_DiscountCoupon_Find", p, commandType: System.Data.CommandType.StoredProcedure);

                res.Content = discountCoupons;
                res.TotalElements = p.Get<int>("@total_elements");
                res.TotalPages = p.Get<int>("@total_pages");
                res.CurrentPage = p.Get<int>("@page_number");
            }
            return res;
        }

        public async Task<DiscountCouponModel> FindByIdAsync(string discountCouponId)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "SELECT id discount_coupon_id, title, detail, coupon_code, " +
                    " min_balance, usage_limit, rate_percent, expired_at, created_at, updated_at " +
                    " FROM dbo.discount_coupon WHERE id=@id";

                return await conn.QuerySingleAsync<DiscountCouponModel>(sql, new { id = discountCouponId });
            }
        }

        public async Task CreateAsync(DiscountCouponCreateDto discountCoupon)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "INSERT INTO dbo.discount_coupon " +
                    " (title, detail, coupon_code, min_balance, usage_limit, rate_percent, expired_at, status) VALUES " +
                    " (@title, @detail, @coupon_code, @min_balance, @usage_limit, @rate_percent, @expired_at, @status )";

                await conn.ExecuteAsync(sql, _parameterFactory.Create(discountCoupon));
            }
        }

        public async Task UpdateAsync(DiscountCouponUpdateDto discountCoupon)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "UPDATE dbo.discount_coupon SET " +
                    " title=@title, detail=@detail, coupon_code=@coupon_code, min_balance=@min_balance, usage_limit=@usage_limit, " +
                    " rate_percent=@RatePercent, expired_at=@expired_at, status=@status " +
                    " WHERE id=@discount_coupon_id";

                await conn.ExecuteAsync(sql, _parameterFactory.Create(discountCoupon));
            }
        }

        public async Task DeleteById(string discountCouponId)
        {
            using (var conn = _connectionFactory.CreateConnection())
            {
                string sql = "DELETE FROM dbo.discount_coupon WHERE id=@id";
                await conn.ExecuteAsync(sql, new { id = discountCouponId });
            }
        }
    }
}

