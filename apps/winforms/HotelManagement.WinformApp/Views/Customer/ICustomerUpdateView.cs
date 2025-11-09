using HotelManagement.Views.Abstracts;
using HotelManagement.Domain.Enums;
using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Customer
{
    public interface ICustomerUpdateView : IView
    {
        string CustomerId { get; set; }
        string CustomerCitizenIdNumber { get; set; }
        string CustomerFirstName { get; set; }
        string CustomerLastName { get; set; }
        string CustomerPhone { get; set; }
        string CustomerEmail { get; set; }
        string CustomerAddress { get; set; }
        DateTime CustomerCreatedAt { get; set; }
        DateTime CustomerUpdatedAt { get; set; }
        CustomerStatus CustomerStatus { get; set; }

        event EventHandler OnCancel;
        event EventHandler OnCustomerSave;
        event EventHandler OnCustomerDelete;

        void SetupCustomerStatusComboBox(BindingSource bindingSource, string displayMember, string valueMember);
    }
}
