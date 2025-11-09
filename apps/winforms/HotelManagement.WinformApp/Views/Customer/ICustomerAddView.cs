using HotelManagement.Views.Abstracts;
using System;

namespace HotelManagement.WinformApp.Views.Customer
{
    public interface ICustomerAddView : IView
    {
        string CustomerCitizenIdNumber { get; set; }
        string CustomerFirstName { get; set; }
        string CustomerLastName { get; set; }
        string CustomerAddress1 { get; set; }
        string CustomerAddress2 { get; set; }
        string CustomerPhone { get; set; }
        string CustomerEmail { get; set; }

        event EventHandler OnCustomerAdd;
        event EventHandler OnCancel;
    }
}
