using HotelManagement.Domain.Enums;
using System;

namespace HotelManagement.Domain.Models
{
    public class DiscountCouponModel
    {
        public string DiscountCouponId { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string CouponCode { get; set; }
        public int MinBalance { get; set; }
        public int UsageLimit { get; set; }
        public int RatePercent { get; set; }
        public DateTime ExpiredAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DiscountCouponStatus Status { get; set; }
    }
}
