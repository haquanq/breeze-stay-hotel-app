using HotelManagement.Domain.Dtos.DiscountCoupon;
using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories.DiscountCoupon;
using System.Threading.Tasks;
using HotelManagement.Infrastructure.Common;

namespace HotelManagement.Domain.Services.DiscountCoupon
{
    public class DiscountCouponService : IDiscountCouponService
    {
        private readonly IDiscountCouponRepository _discountCouponRepository;

        public DiscountCouponService(IDiscountCouponRepository discountCouponRepository)
        {
            _discountCouponRepository = discountCouponRepository;
        }

        public async Task<PageResponse<DiscountCouponModel>> FindAsync(DiscountCouponSearchDto discountCouponSearchDto, PageRequest pageRequest)
        {
            return await _discountCouponRepository.FindAsync(discountCouponSearchDto, pageRequest);
        }

        public async Task<DiscountCouponModel> FindByIdAsync(string discountCouponId)
        {
            return await _discountCouponRepository.FindByIdAsync(discountCouponId);
        }

        public async Task CreateAsync(DiscountCouponCreateDto discountCoupon)
        {
            await _discountCouponRepository.CreateAsync(discountCoupon);
        }

        public async Task UpdateAsync(DiscountCouponUpdateDto discountCoupon)
        {
            await _discountCouponRepository.UpdateAsync(discountCoupon);
        }

        public async Task DeleteByIdAsync(string discountCouponId)
        {
            await _discountCouponRepository.DeleteById(discountCouponId);
        }
    }
}
