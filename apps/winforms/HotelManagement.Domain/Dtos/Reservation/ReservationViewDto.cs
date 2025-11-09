using HotelManagement.Domain.Enums;
using System;

namespace HotelManagement.Domain.Dtos.Reservation
{
    public class ReservationViewDto
    {
        public string ReservationId { get; set; }
        public ReservationStatus ReservationStatus { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string StaffId { get; set; }
        public string StaffName { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Rooms { get; set; }
        public decimal TotalBalance { get; set; }
    }
}
