using HotelManagement.Domain.Enums;
using HotelManagement.Views.Abstracts;
using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Room
{
    public interface IRoomView : IView
    {
        StaffRole CurrentUserRole { get; set; }
        string SelectedRoomId { get; }

        int RoomPageCount { get; set; }
        int RoomPageSize { get; set; }
        int RoomPageNumber { get; set; }
        string SelectedRoomTypeId { get; }
        bool UsingFilterRoomType { get; }
        RoomStatus SelectedRoomStatus { get; }
        bool UsingFilterRoomStatus { get; }
        string SelectedRoomSearchField { get; }
        bool UsingFilterRoomSearchField { get; }
        string RoomSearchText { get; }

        event EventHandler OnRoomUpdateViewOpen;
        event EventHandler OnRoomAddViewOpen;
        event EventHandler OnRoomPaginationChange;
        event EventHandler OnRoomFilterChange;

        void SetupRoomGridView(BindingSource bindingSource);
        void SetupRoomTypeFilterComboBox(BindingSource bindingSource, string displayMember, string valueMember);
        void SetupRoomStatusFilterComboBox(BindingSource bindingSource, string displayMember, string valueMember);
        void SetupRoomSearchFieldComboBox(BindingSource bindingSource, string displayMember, string valueMember);
        void SetupRoomPageSizeComboBox(BindingSource bindingSource, string displayMember, string valueMember);
    }
}
