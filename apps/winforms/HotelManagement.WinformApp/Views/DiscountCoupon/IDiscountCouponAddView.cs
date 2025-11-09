using HotelManagement.Views.Abstracts;
using System;

namespace HotelManagement.WinformApp.Views.DiscountCoupon
{
    public interface IDiscountCouponAddView : IView
    {
        string DiscountCouponTitle { get; set; }
        string DiscountCouponDetail { get; set; }
        string DiscountCouponCode { get; set; }
        DateTime DiscountCouponExpiredAt { get; set; }
        int DiscountCouponRate { get; set; }
        int DiscountCouponUsageLimit { get; set; }
        int DiscountCouponMinBalance { get; set; }

        event EventHandler OnDiscountCouponAdd;
        event EventHandler OnCancel;
    }
}
