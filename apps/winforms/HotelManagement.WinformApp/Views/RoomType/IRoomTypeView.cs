using HotelManagement.Domain.Enums;
using HotelManagement.Views.Abstracts;
using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.RoomType
{
    public interface IRoomTypeView : IView
    {
        StaffRole CurrentUserRole { get; set; }
        string SelectedRoomTypeId { get; }

        int RoomTypePageCount { get; set; }
        int RoomTypePageSize { get; set; }
        int RoomTypePageNumber { get; set; }
        string SelectedRoomTypeSearchField { get; }
        bool UsingFilterRoomTypeSearchField { get; }
        string RoomTypeSearchText { get; }

        event EventHandler OnRoomTypePaginationChange;
        event EventHandler OnRoomTypeFilterChange;
        event EventHandler OnRoomTypeAddViewOpen;
        event EventHandler OnRoomTypeUpdateViewOpen;

        void SetupRoomTypeGridView(BindingSource bindingSource);
        void SetupRoomTypeSearchFieldComboBox(BindingSource bindingSource, string displayMember, string valueMember);
        void SetupRoomTypePageSizeComboBox(BindingSource bindingSource, string displayMember, string valueMember);
    }
}
