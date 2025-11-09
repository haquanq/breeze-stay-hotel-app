using HotelManagement.Infrastructure.Attributes;
using System.ComponentModel;

namespace HotelManagement.Domain.Dtos.DiscountCoupon
{
    public class DiscountCouponSearchDto
    {
        [DbMapping("discount_coupon_status")]
        public string DiscountCouponStatus { get; set; }

        [DbMapping("discount_coupon_id")]
        [DisplayName("Discount coupon ID")]
        public string DiscountCouponId { get; set; }

        [DbMapping("discount_coupon_title")]
        [DisplayName("Discount coupon title")]
        public string DiscountCouponTitle { get; set; }
        [DbMapping("discount_coupon_code")]
        [DisplayName("Discount coupon code")]
        public string DiscountCouponCode { get; set; }
    }
}
