using HotelManagement.Infrastructure.Attributes;
using System.ComponentModel;

namespace HotelManagement.Domain.Dtos.RoomType
{
    public class RoomTypeSearchDto
    {
        [DbMapping("room_type_id")]
        [DisplayName("Room type ID")]
        public string RoomTypeId { get; set; }

        [DbMapping("room_type_title")]
        [DisplayName("Room type title")]
        public string RoomTypeTitle { get; set; }
    }
}
