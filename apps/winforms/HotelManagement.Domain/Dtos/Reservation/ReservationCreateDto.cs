using System;

namespace HotelManagement.Domain.Dtos.Reservation
{
    public class ReservationCreateDto
    {
        public string CustomerId { get; set; }
        public string StaffId { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
    }
}
