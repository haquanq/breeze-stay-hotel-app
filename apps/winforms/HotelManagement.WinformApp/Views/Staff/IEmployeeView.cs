using HotelManagement.Domain.Enums;
using HotelManagement.Views.Abstracts;
using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Staff
{
    public interface IEmployeeView : IView
    {

        StaffRole CurrentUserRole { get; set; }
        string SelectedStaffId { get; }
        int StaffPageCount { get; set; }
        int StaffPageSize { get; set; }
        int StaffPageNumber { get; set; }
        StaffRole SelectedStaffRole { get; }
        bool UsingFilterStaffRole { get; }
        StaffAccountStatus SelectedStaffStatus { get; }
        bool UsingFilterStaffStatus { get; }
        string SelectedStaffSearchField { get; }
        bool UsingFilterStaffSearchField { get; }
        string StaffSearchText { get; }

        event EventHandler OnStaffUpdateViewOpen;
        event EventHandler OnStaffCreateViewOpen;
        event EventHandler OnStaffPaginationChange;
        event EventHandler OnStaffFilterChange;

        void SetupStaffGridView(BindingSource bindingSource);
        void SetupStaffRoleFilter(BindingSource bindingSource, string displayMember, string valueMember);
        void SetupStaffStatusFilter(BindingSource bindingSource, string displayMember, string valueMember);
        void SetupStaffSearchField(BindingSource bindingSource, string displayMember, string valueMember);
        void SetupStaffPageSize(BindingSource bindingSource, string displayMember, string valueMember);
    }
}
