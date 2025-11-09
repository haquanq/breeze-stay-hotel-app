using HotelManagement.Views.Abstracts;
using System;

namespace HotelManagement.WinformApp.Views.RoomType
{
    public interface IRoomTypeAddView : IView
    {
        string RoomTypeTitle { get; set; }
        string RoomTypeDetail { get; set; }
        decimal RoomTypePricePerNight { get; set; }

        event EventHandler OnRoomTypeAdd;
        event EventHandler OnCancel;
    }
}
