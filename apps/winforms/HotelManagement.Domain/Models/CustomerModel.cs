using HotelManagement.Domain.Enums;
using System;

namespace HotelManagement.Domain.Models
{
    public class CustomerModel
    {
        public string CustomerId { get; set; }
        public string CitizenIdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public CustomerStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
