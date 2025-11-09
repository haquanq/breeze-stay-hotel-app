using HotelManagement.Infrastructure.Attributes;
using System.ComponentModel;

namespace HotelManagement.Domain.Dtos.Customer
{
    public class CustomerSearchDto
    {
        [DbMapping("customer_status")]
        public string CustomerStatus { get; set; }

        [DbMapping("customer_id")]
        [DisplayName("Customer ID")]
        public string CustomerId { get; set; }

        [DbMapping("customer_citizen_id_number")]
        [DisplayName("Customer citizen ID")]
        public string CustomerCitizenIdNumber { get; set; }

        [DbMapping("customer_name")]
        [DisplayName("Customer name")]
        public string CustomerName { get; set; }

        [DbMapping("customer_email")]
        [DisplayName("Customer email")]
        public string CustomerEmail { get; set; }

        [DbMapping("customer_phone")]
        [DisplayName("Customer phone")]
        public string CustomerPhone { get; set; }
    }
}
