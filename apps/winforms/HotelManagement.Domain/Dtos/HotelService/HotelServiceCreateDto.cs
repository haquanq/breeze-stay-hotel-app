using HotelManagement.Infrastructure.Attributes;

namespace HotelManagement.Domain.Dtos.HotelService
{
    public class HotelServiceCreateDto
    {
        [DbMapping("title")]
        public string Title { get; set; }

        [DbMapping("detail")]
        public string Detail { get; set; }
    }
}
