using HotelManagement.Domain.Enums;
using System;

namespace HotelManagement.Domain.Models
{
    public class StaffModel
    {
        public string StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public StaffRole Role { get; set; }
        public string AccountPassword { get; set; }
        public StaffAccountStatus AccountStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
