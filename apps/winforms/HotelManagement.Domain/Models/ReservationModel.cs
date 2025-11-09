using HotelManagement.Domain.Enums;
using System;
using System.Collections.Generic;

namespace HotelManagement.Domain.Models
{
    public class ReservationModel
    {
        public string ReservationId { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime CheckedInAt { get; set; }
        public DateTime CheckedOutAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ReservationStatus Status { get; set; }
        public decimal TotalPrice { get; set; }
        public DiscountCouponModel DiscountCoupon { get; set; }
        public StaffModel Staff { get; set; }
        public CustomerModel Customer { get; set; }
        public List<RoomModel> Rooms { get; set; }
    }
}
