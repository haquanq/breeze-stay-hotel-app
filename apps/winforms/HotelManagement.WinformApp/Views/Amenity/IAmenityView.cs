using HotelManagement.Domain.Enums;
using HotelManagement.Views.Abstracts;
using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Amenity
{
    public interface IAmenityView : IView
    {
        StaffRole CurrentUserRole { get; set; }
        int AmenityPageCount { get; set; }
        int AmenityPageNumber { get; set; }
        int AmenityPageSize { get; set; }
        string SelectedAmenityId { get; }
        AmenityStatus SelectedAmenityStatus { get; }
        bool UsingFilterAmenityStatus { get; }
        string SelectedAmenitySearchField { get; }
        bool UsingFilterAmenitySearchField { get; }
        string AmenitySearchText { get; }

        event EventHandler OnAmenityPaginationChange;
        event EventHandler OnAmenityFilterChange;
        event EventHandler OnAmenitySearchFieldChange;
        event EventHandler OnAmenityCreateViewOpen;
        event EventHandler OnAmenityUpdateViewOpen;

        void SetupAmenityGridView(BindingSource bindingSource);
        void SetupAmenityPageSizeComboBox(BindingSource bindingSource, string displayMember, string valueMember);
        void SetupAmenitySearchFieldComboBox(BindingSource bindingSource, string displayMember, string valueMember);
        void SetupAmenityStatusComboBox(BindingSource bindingSource, string displayMember, string valueMember);
        void SetupAmenitySearchTextBox(Binding binding);
    }
}
