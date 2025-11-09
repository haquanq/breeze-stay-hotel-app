using HotelManagement.Domain.Dtos.DiscountCoupon;
using HotelManagement.Domain.Models;
using System.Threading.Tasks;
using HotelManagement.Infrastructure.Common;

namespace HotelManagement.Domain.Services.DiscountCoupon
{
    public interface IDiscountCouponService
    {
        Task<PageResponse<DiscountCouponModel>> FindAsync(DiscountCouponSearchDto discountCouponSearchDto, PageRequest pageRequest);
        Task<DiscountCouponModel> FindByIdAsync(string discountCouponId);
        Task CreateAsync(DiscountCouponCreateDto discountCouponCreateDto);
        Task UpdateAsync(DiscountCouponUpdateDto discountCouponUpdateDto);
        Task DeleteByIdAsync(string discountCouponId);
    }
}