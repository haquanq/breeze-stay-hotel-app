using HotelManagement.Infrastructure.Attributes;
using System.ComponentModel;

namespace HotelManagement.Domain.Dtos.HotelService
{
    public class HotelServiceSearchDto
    {
        [DbMapping("hotel_service_id")]
        [DisplayName("Hotel service ID")]
        public string HotelServiceId { get; set; }

        [DbMapping("hotel_service_title")]
        [DisplayName("Hotel service title")]
        public string HotelServiceTitle { get; set; }
    }
}
