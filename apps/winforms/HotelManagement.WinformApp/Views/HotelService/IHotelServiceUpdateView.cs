using HotelManagement.Views.Abstracts;
using System;

namespace HotelManagement.WinformApp.Views.HotelService
{
    public interface IHotelServiceUpdateView : IView
    {
        string HotelServiceId { get; set; }
        string HotelServiceTitle { get; set; }
        string HotelServiceDetail { get; set; }

        event EventHandler OnHotelServiceSave;
        event EventHandler OnHotelServiceDelete;
        event EventHandler OnCancel;
    }
}
