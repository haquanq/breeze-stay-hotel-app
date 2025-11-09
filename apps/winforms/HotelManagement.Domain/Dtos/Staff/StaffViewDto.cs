using HotelManagement.Domain.Enums;
using System;

namespace HotelManagement.Domain.Dtos
{
    public class StaffViewDto
    {
        public string StaffId { get; set; }
        public string FullName { get; set; }
        public DateTime Dob { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public StaffRole Role { get; set; }
        public StaffAccountStatus AccountStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
