using HotelManagement.Domain.Enums;
using HotelManagement.Infrastructure.Attributes;
using System;

namespace HotelManagement.Domain.Dtos.Staff
{
    public class StaffUpdateDto
    {
        [DbMapping("staff_id")]
        public string StaffId { get; set; }
        [DbMapping("first_name")]
        public string FirstName { get; set; }

        [DbMapping("last_name")]
        public string LastName { get; set; }

        [DbMapping("dob")]
        public DateTime Dob { get; set; }

        [DbMapping("phone")]
        public string Phone { get; set; }

        [DbMapping("email")]
        public string Email { get; set; }

        [DbMapping("role")]
        public StaffRole Role { get; set; }

        [DbMapping("account_status")]
        public StaffAccountStatus AccountStatus { get; set; }

        [DbMapping("account_password")]
        public string AccountPassword { get; set; }
    }
}
