using HotelManagement.Domain.Enums;
using System;
using System.Collections.Generic;

namespace HotelManagement.Domain.Models

{
    public class AmenityModel
    {
        public string AmenityId { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public decimal Price { get; set; }
        public AmenityStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<RoomModel> Rooms { get; set; }
    }
}
