using System;

namespace HotelManagement.Domain.Dtos.Reservation
{
    public class ReservationUpdateDto
    {
        public string ReservationId { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
    }
}
