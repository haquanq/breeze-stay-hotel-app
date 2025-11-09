using HotelManagement.Infrastructure.Common;
using HotelManagement.Domain.Dtos.DiscountCoupon;
using HotelManagement.Domain.Models;
using System.Threading.Tasks;

namespace HotelManagement.Domain.Repositories.DiscountCoupon
{
    public interface IDiscountCouponRepository
    {
        Task<PageResponse<DiscountCouponModel>> FindAsync(DiscountCouponSearchDto discountCouponSearchDto, PageRequest pageRequest);
        Task<DiscountCouponModel> FindByIdAsync(string discountCouponId);
        Task CreateAsync(DiscountCouponCreateDto discountCouponCreateDto);
        Task UpdateAsync(DiscountCouponUpdateDto discountCouponUpdateDto);
        Task DeleteById(string discountCouponId);
    }
}