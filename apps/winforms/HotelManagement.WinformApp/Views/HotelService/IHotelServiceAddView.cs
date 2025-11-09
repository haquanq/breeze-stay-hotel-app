using HotelManagement.Views.Abstracts;
using System;

namespace HotelManagement.WinformApp.Views.HotelService
{
    public interface IHotelServiceAddView : IView
    {
        string HotelServiceTitle { get; set; }
        string HotelServiceDetail { get; set; }

        event EventHandler OnHotelServiceAdd;
        event EventHandler OnCancel;
    }
}
