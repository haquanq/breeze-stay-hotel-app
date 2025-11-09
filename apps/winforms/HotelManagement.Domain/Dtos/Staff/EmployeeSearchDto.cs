using HotelManagement.Infrastructure.Attributes;
using System.ComponentModel;

namespace HotelManagement.Domain.Dtos.Staff
{
    public class EmployeeSearchDto
    {

        [DbMapping("staff_id")]
        [DisplayName("Staff ID")]
        public string EmployeeId { get; set; }

        [DbMapping("staff_name")]
        [DisplayName("Staff name")]
        public string EmployeeName { get; set; }

        [DbMapping("staff_phone")]
        [DisplayName("Staff phone")]
        public string EmployeePhone { get; set; }

        [DbMapping("staff_email")]
        [DisplayName("Staff email")]
        public string EmployeeEmail { get; set; }

        [DbMapping("staff_status")]
        public string EmployeeStatus { get; set; }

        [DbMapping("staff_role")]
        public string EmployeeRole { get; set; }
    }
}
