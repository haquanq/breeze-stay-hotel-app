using HotelManagement.Domain.Enums;
using HotelManagement.Views.Abstracts;
using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Customer
{
    public interface ICustomerView : IView
    {
        StaffRole CurrentUserRole { get; set; }
        string SelectedCustomerId { get; }
        int CustomerTotalPages { get; set; }
        int CustomerPageOffset { get; set; }
        int CustomerCurrentPage { get; set; }
        CustomerStatus SelectedCustomerStatus { get; }
        bool UsingFilterCustomerStatus { get; }
        string SelectedCustomerSearchField { get; }
        bool UsingFilterCustomerSearchField { get; }
        string CustomerSearchText { get; }

        event EventHandler OnCustomerPaginationChange;
        event EventHandler OnCustomerSearchChange;
        event EventHandler OnCustomerUpdateViewOpen;
        event EventHandler OnCustomerCreateViewOpen;
        event EventHandler OnCustomerDetailViewOpen;

        void SetupCustomerGridView(BindingSource bindingSource);
        void SetupCustomerSearchFieldComboBox(BindingSource bindingSource, string displayMember, string valueMember);
        void SetupCustomerStatusComboBox(BindingSource bindingSource, string displayMember, string valueMember);
        void SetupCustomerPageSizeComboBox(BindingSource bindingSource, string displayMember, string valueMember);
    }
}
