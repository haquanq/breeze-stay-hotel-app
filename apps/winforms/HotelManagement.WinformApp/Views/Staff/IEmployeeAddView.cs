using HotelManagement.Domain.Enums;
using HotelManagement.Views.Abstracts;
using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Staff
{
    public interface IEmployeeAddView : IView
    {
        string StaffFirstName { get; set; }
        string StaffLastName { get; set; }
        string StaffPhone { get; set; }
        string StaffEmail { get; set; }
        DateTime StaffDob { get; set; }
        StaffRole StaffRole { get; set; }

        event EventHandler OnStaffAddClick;
        event EventHandler OnCancel;

        void SetupStaffRoleComboBox(BindingSource bindingSource, string displayMember, string valueMember);
    }
}
