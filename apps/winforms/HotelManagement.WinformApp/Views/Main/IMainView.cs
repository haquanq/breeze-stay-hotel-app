using HotelManagement.Views.Abstracts;
using HotelManagement.WinformApp.Enums;
using System;

namespace HotelManagement.WinformApp.Views.Main
{
    public interface IMainView : IView
    {
        IView CurrentView { get; set; }

        event EventHandler OnAmenityViewOpen;
        event EventHandler OnCustomerViewOpen;
        event EventHandler OnStaffViewOpen;
        event EventHandler OnDiscountCouponViewOpen;

        bool ShowMessage(MessageType contentType, string content, string title = "");
    }
}
