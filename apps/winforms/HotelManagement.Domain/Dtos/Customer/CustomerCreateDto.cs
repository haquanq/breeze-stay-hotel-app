using HotelManagement.Domain.Enums;
using HotelManagement.Infrastructure.Attributes;

namespace HotelManagement.Domain.Dtos.Customer
{
    public class CustomerCreateDto
    {
        [DbMapping("first_name")]
        public string FirstName { get; set; }

        [DbMapping("last_name")]
        public string LastName { get; set; }

        [DbMapping("phone")]
        public string Phone { get; set; }

        [DbMapping("email")]
        public string Email { get; set; }

        [DbMapping("citizen_id_number")]
        public string CitizenIdNumber { get; set; }

        [DbMapping("address1")]
        public string Address1 { get; set; }

        [DbMapping("address2")]
        public string Address2 { get; set; }

        [DbMapping("status")]
        public CustomerStatus Status { get; set; }
    }
}
