using HotelManagement.Domain.Enums;
using HotelManagement.Views.Abstracts;
using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Amenity
{
    public interface IAmenityAddView : IView
    {
        string AmenityTitle { get; set; }
        string AmenityDetail { get; set; }
        decimal AmenityPrice { get; set; }
        AmenityStatus AmenityStatus { get; set; }

        event EventHandler OnAmenityAdd;
        event EventHandler OnCancel;

        void SetupAmenityStatusComboBox(BindingSource bindingSource, string displayMember, string valueMember);
    }
}
