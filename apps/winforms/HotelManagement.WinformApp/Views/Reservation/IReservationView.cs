using HotelManagement.Domain.Enums;
using HotelManagement.Views.Abstracts;
using System;

namespace HotelManagement.Views.Reservation
{
    public interface IReservationView : IView
    {
        StaffRole CurrentUserRole { get; set; }
        string SelectedReservationId { get; set; }

        event EventHandler OnReservationCreateViewOpen;
        event EventHandler OnReservationUpdateViewOpen;
        event EventHandler OnReservationDetailViewOpen;

        void SetupReservationGridView();
        void SetupReservationStatusComboBox();

    }
}
