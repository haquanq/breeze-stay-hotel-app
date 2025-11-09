using HotelManagement.Domain.Enums;
using HotelManagement.Infrastructure.Attributes;
using System;

namespace HotelManagement.Domain.Dtos.DiscountCoupon
{
    public class DiscountCouponUpdateDto
    {
        [DbMapping("discount_coupon_id")]
        public string DiscountCouponId { get; set; }

        [DbMapping("title")]
        public string Title { get; set; }

        [DbMapping("detail")]
        public string Detail { get; set; }

        [DbMapping("coupon_code")]
        public string CouponCode { get; set; }

        [DbMapping("min_balance")]
        public int MinBalance { get; set; }

        [DbMapping("usage_limit")]
        public int UsageLimit { get; set; }

        [DbMapping("rate_percent")]
        public int RatePercent { get; set; }

        [DbMapping("expired_at")]
        public DateTime ExpiredAt { get; set; }

        [DbMapping("status")]
        public DiscountCouponStatus Status { get; set; }
    }
}
