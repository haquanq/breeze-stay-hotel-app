using HotelManagement.Infrastructure.Attributes;
using System.ComponentModel;

namespace HotelManagement.Domain.Dtos.Amenity
{
    public class AmenitySearchDto
    {
        [DbMapping("amenity_id")]
        [DisplayName("Amenity ID")]
        public string AmenityId { get; set; }

        [DbMapping("amenity_title")]
        [DisplayName("Amenity title")]
        public string AmenityTitle { get; set; }

        [DbMapping("amenity_status")]
        public string AmenityStatus { get; set; }
    }
}
