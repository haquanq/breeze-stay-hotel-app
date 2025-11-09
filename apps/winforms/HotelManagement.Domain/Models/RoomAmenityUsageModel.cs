using HotelManagement.Domain.Enums;
using System;

namespace HotelManagement.Domain.Models
{
    public class RoomAmenityUsageModel
    {
        public string RoomAmenityUsageId { get; set; }
        public ReservationModel Reservation { get; set; }
        public RoomModel Room { get; set; }
        public AmenityModel Amenity { get; set; }
        public decimal Price { get; set; }
        public RoomAmenityUsageStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
