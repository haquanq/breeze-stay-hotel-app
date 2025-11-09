using HotelManagement.Infrastructure.Attributes;

namespace HotelManagement.Domain.Dtos.RoomType
{
    public class RoomTypeCreateDto
    {
        [DbMapping("title")]
        public string Title { get; set; }

        [DbMapping("detail")]
        public string Detail { get; set; }

        [DbMapping("price_per_night")]
        public decimal PricePerNight { get; set; }
    }
}
