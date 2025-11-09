using HotelManagement.Domain.Enums;

namespace HotelManagement.Domain.Dtos.Auth
{
    public class CurrentUserDto
    {
        public string StaffId { get; set; }
        public string FullName { get; set; }
        public StaffRole Role { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
