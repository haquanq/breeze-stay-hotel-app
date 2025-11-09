using HotelManagement.Views.Abstracts;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Room
{
    public interface IRoomAddView : IView
    {
        string RoomCode { get; set; }
        string RoomTypeId { get; set; }
        int FloorNumber { get; set; }

        string SelectedAmenityId { get; set; }

        event EventHandler OnAmenitySearchChange;
        event EventHandler OnRoomAmenityAdd;
        event EventHandler OnRoomAmenityRemove;
        event EventHandler OnRoomAdd;
        event EventHandler OnCancel;

        void SetupRoomAmenityGridView(BindingSource bindingSource);
        void SetupRoomTypeComboBox(BindingSource bindingSource, string displayMember, string valueMember);
    }
}
