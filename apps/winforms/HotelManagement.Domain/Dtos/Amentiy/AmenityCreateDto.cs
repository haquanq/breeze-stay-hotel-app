using HotelManagement.Domain.Enums;
using HotelManagement.Infrastructure.Attributes;

namespace HotelManagement.Domain.Dtos.Amenity
{
    public class AmenityCreateDto
    {
        [DbMapping("title")]
        public string Title { get; set; }

        [DbMapping("detail")]
        public string Detail { get; set; }

        [DbMapping("price")]
        public decimal Price { get; set; }

        [DbMapping("status")]
        public AmenityStatus Status { get; set; }
    }
}
