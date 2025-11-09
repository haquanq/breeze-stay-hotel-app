using HotelManagement.Domain.Enums;
using HotelManagement.Views.Abstracts;
using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.DiscountCoupon
{
    public interface IDiscountCouponView : IView
    {
        StaffRole CurrentUserRole { get; set; }
        string SelectedDiscountCouponId { get; }
        int DiscountCouponPageCount { get; set; }
        int DiscountCouponPageSize { get; set; }
        int DiscountCouponPageNumber { get; set; }
        DiscountCouponStatus SelectedDiscountCouponStatus { get; }
        bool UsingFilterDiscountCouponStatus { get; }
        string SelectedDiscountCouponSearchField { get; }
        bool UsingFilterDiscountCouponSearchField { get; }
        string DiscountCouponSearchText { get; }

        event EventHandler OnDiscountCouponCreateViewOpen;
        event EventHandler OnDiscountCouponUpdateViewOpen;
        event EventHandler OnDiscountCouponPaginationChange;
        event EventHandler OnDiscountCouponFilterChange;

        void SetupDiscountCouponGridView(BindingSource bindingSource);
        void SetupDiscountCouponSearchField(BindingSource bindingSource, string displayMember, string valueMember);
        void SetupDiscountCouponStatusFilter(BindingSource bindingSource, string displayMember, string valueMember);
    }
}
