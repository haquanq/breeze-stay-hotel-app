using HotelManagement.Domain.Enums;
using HotelManagement.Views.Abstracts;
using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.DiscountCoupon
{
    public interface IDiscountCouponUpdateView : IView
    {
        string DiscountCouponId { get; set; }
        string DiscountCouponTitle { get; set; }
        string DiscountCouponDetail { get; set; }
        string DiscountCouponCode { get; set; }
        DateTime DiscountCouponExpiredAt { get; set; }
        int DiscountCouponRatePercent { get; set; }
        int DiscountCouponUsageLimit { get; set; }
        int DiscountCouponMinBalance { get; set; }
        DiscountCouponStatus DiscountCouponStatus { get; set; }
        DateTime DiscountCouponUpdatedAt { get; set; }
        DateTime DiscountCouponCreatedAt { get; set; }

        event EventHandler OnDiscountCouponSave;
        event EventHandler OnDiscountCouponDelete;
        event EventHandler OnCancel;

        void SetupDiscountCouponStatusComboBox(BindingSource bindingSource, string displayMember, string valueMember);
    }
}
