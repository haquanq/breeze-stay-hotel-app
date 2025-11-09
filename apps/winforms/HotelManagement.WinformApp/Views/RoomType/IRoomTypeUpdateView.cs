using HotelManagement.Views.Abstracts;
using System;

namespace HotelManagement.WinformApp.Views.RoomType
{
    public interface IRoomTypeUpdateView : IView
    {
        string RoomTypeId { get; set; }
        string RoomTypeTitle { get; set; }
        string RoomTypeDetail { get; set; }
        decimal RoomTypePricePerNight { get; set; }
        DateTime RoomTypeCreatedAt { get; set; }
        DateTime RoomTypeUpdatedAt { get; set; }

        event EventHandler OnCancel;
        event EventHandler OnRoomTypeSave;
        event EventHandler OnRoomTypeDelete;
    }
}
