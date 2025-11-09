using HotelManagement.Infrastructure.Attributes;
using System.ComponentModel;

namespace HotelManagement.Domain.Dtos.Room
{
    public class RoomSearchDto
    {

        [DbMapping("room_status")]
        public string RoomStatus { get; set; }

        [DbMapping("room_type_id")]
        public string RoomTypeId { get; set; }

        [DbMapping("room_id")]
        [DisplayName("Room ID")]
        public string RoomId { get; set; }

        [DbMapping("room_title")]
        [DisplayName("Room title")]
        public string RoomTitle { get; set; }
    }
}
