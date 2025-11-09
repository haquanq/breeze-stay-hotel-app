using System;

namespace HotelManagement.Domain.Models
{
    public class RoomTypeModel
    {
        public string RoomTypeId { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public decimal PricePerNight { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
