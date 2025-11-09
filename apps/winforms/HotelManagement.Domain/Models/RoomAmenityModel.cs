using System;

namespace HotelManagement.Domain.Models
{
    public class RoomAmenityModel
    {
        public string RoomAmenityId { get; set; }
        public RoomModel Room { get; set; }
        public AmenityModel Amenity { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
