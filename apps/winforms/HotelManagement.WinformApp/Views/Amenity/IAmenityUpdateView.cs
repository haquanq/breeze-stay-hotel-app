using HotelManagement.Domain.Enums;
using HotelManagement.Views.Abstracts;
using System;
using System.Windows.Forms;

namespace HotelManagement.WinformApp.Views.Amenity
{
    public interface IAmenityUpdateView : IView
    {
        string AmenityId { get; set; }
        string AmenityTitle { get; set; }
        string AmenityDetail { get; set; }
        decimal AmenityPrice { get; set; }
        AmenityStatus AmenityStatus { get; set; }

        event EventHandler OnAmenitySave;
        event EventHandler OnAmenityDelete;
        event EventHandler OnCancel;

        void SetupAmenityStatusComboBox(BindingSource bindingSource, string displayMember, string valueMember);
    }
}
