using HotelManagement.Infrastructure.Attributes;

namespace HotelManagement.Domain.Dtos.Room
{
    public class RoomUpdateDto
    {
        [DbMapping("amenity_id")]
        public string RoomId { get; set; }

        [DbMapping("room_type_id")]
        public string RoomTypeId { get; set; }

        [DbMapping("room_code")]
        public string RoomCode { get; set; }

        [DbMapping("floor_number")]
        public decimal FloorNumber { get; set; }
    }
}
