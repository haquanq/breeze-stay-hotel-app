using HotelManagement.Domain.Enums;
using HotelManagement.Views.Abstracts;
using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Staff
{
    public interface IEmployeeUpdateView : IView
    {
        StaffRole CurrentUserRole { get; set; }
        string StaffId { get; set; }
        string StaffFirstName { get; set; }
        string StaffLastName { get; set; }
        string StaffPhone { get; set; }
        string StaffEmail { get; set; }
        string StaffPassword { get; set; }
        DateTime StaffCreatedAt { get; set; }
        DateTime StaffUpdatedAt { get; set; }
        DateTime StaffDob { get; set; }
        StaffRole StaffRole { get; set; }
        StaffAccountStatus StaffStatus { get; set; }

        event EventHandler OnCancel;
        event EventHandler OnStaffSave;
        event EventHandler OnStaffDelete;

        void SetupStaffRoleComboBox(BindingSource bindingSource, string displayMember, string valueMember);
        void SetupStaffStatusComboBox(BindingSource bindingSource, string displayMember, string valueMember);
    }
}
