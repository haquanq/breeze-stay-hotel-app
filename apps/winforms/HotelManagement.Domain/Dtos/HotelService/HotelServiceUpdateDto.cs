using HotelManagement.Infrastructure.Attributes;

namespace HotelManagement.Domain.Dtos.HotelService
{
    public class HotelServiceUpdateDto
    {
        [DbMapping("hotel_service_id")]
        public string HotelServiceId { get; set; }

        [DbMapping("title")]
        public string Title { get; set; }

        [DbMapping("detail")]
        public string Detail { get; set; }
    }
}
