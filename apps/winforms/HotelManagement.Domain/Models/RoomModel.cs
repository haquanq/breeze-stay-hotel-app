using HotelManagement.Domain.Enums;
using System;
using System.Collections.Generic;

namespace HotelManagement.Domain.Models
{
    public class RoomModel
    {
        public string RoomId { get; set; }
        public string RoomCode { get; set; }
        public int FloorNumber { get; set; }
        public RoomTypeModel RoomType { get; set; }
        public RoomStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<RoomAmenityModel> Amenities { get; set; }
        public List<ReservationModel> Reservations { get; set; }
    }
}
