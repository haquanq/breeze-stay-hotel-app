using HotelManagement.Infrastructure.Attributes;

namespace HotelManagement.Domain.Dtos.RoomType
{
    public class RoomTypeUpdateDto
    {
        [DbMapping("room_type_id")]
        public string RoomTypeId { get; set; }

        [DbMapping("title")]
        public string Title { get; set; }

        [DbMapping("detail")]
        public string Detail { get; set; }

        [DbMapping("price_per_night")]
        public decimal PricePerNight { get; set; }
    }
}
