using HotelManagement.Domain.Enums;
using System;

namespace HotelManagement.Domain.Models
{
    public class HotelServiceUsageModel
    {
        public string HotelServiceUsageId { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime EndedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public decimal Price { get; set; }
        public HotelServiceUsageStatus Status { get; set; }
        public ReservationModel Reservation { get; set; }
    }
}
