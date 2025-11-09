using HotelManagement.Domain.Enums;
using HotelManagement.Views.Abstracts;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Customer
{
    public interface ICustomerDetailView : IView
    {
        string CustomerId { get; set; }
        string CustomerPid { get; set; }
        string CustomerFirstName { get; set; }
        string CustomerLastName { get; set; }
        string CustomerPhone { get; set; }
        string CustomerEmail { get; set; }
        string CustomerAddress { get; set; }
        DateTime CustomerCreatedAt { get; set; }
        DateTime CustomerUpdatedAt { get; set; }
        CustomerStatus CustomerStatus { get; set; }

        event EventHandler OnReservationMoreDetail;
        event EventHandler OnReservationSearch;
        event EventHandler OnExit;

        void SetupReservationStatusComboBox(DataTable dtbReservationStatus, string displayMember, string valueMember);
        void SetupReservationSearchTypeComboBox(DataTable dtbReservationStatus, string displayMember, string valueMember);
        void SetupReservationGridView(BindingSource bindingSource);
    }
}
