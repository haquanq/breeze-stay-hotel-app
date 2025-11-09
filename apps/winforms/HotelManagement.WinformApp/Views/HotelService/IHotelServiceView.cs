using HotelManagement.Domain.Enums;
using HotelManagement.Views.Abstracts;
using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.HotelService
{
    public interface IHotelServiceView : IView
    {
        StaffRole CurrentUserRole { get; set; }
        int HotelServicePageCount { get; set; }
        int HotelServicePageSize { get; set; }
        int HotelServicePageNumber { get; set; }
        string SelectedHotelServiceId { get; }
        string SelectedHotelServiceSearchField { get; }
        bool UsingFilterHotelServiceSearchField { get; }
        string HotelServiceSearchText { get; }

        event EventHandler OnHotelServicePaginationChange;
        event EventHandler OnHotelServiceFilterChange;
        event EventHandler OnHotelServiceCreateViewOpen;
        event EventHandler OnHotelServiceUpdateViewOpen;

        void SetupHotelServiceGridView(BindingSource bindingSource);
        void SetupHotelServiceSearchFieldComboBox(BindingSource bindingSource, string displayMember, string valueMember);
        void SetupHotelServicePageSizeComboBox(BindingSource bindingSource, string displayMember, string valueMember);
    }
}
