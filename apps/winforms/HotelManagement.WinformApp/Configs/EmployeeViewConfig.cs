using HotelManagement.Domain.Enums;
using HotelManagement.WinformApp.Common;
using System.Collections.Generic;

namespace HotelManagement.WinformApp.Constants
{
    public static class EmployeeViewConfig
    {
        public static readonly Dictionary<int, string> PageOffset = new Dictionary<int, string>
        {
            { 20, "20 / page" },
            { 40, "40 / page" },
            { 60, "60 / page" },
        };

        public static readonly Dictionary<StaffAccountStatus, string> AccountStatusDescription = new Dictionary<StaffAccountStatus, string>()
        {
            { StaffAccountStatus.ACTIVATED, "Activated" },
            { StaffAccountStatus.DEACTIVATED, "Deactivated" }
        };

        public static readonly Dictionary<StaffAccountStatus, dynamic> AccountStatusColor = new Dictionary<StaffAccountStatus, dynamic>()
        {
            { StaffAccountStatus.ACTIVATED, new ResourceStatusColor { LightHex = MaterialColor.Green._200, DarkHex  = MaterialColor.Green._600 } },
            { StaffAccountStatus.DEACTIVATED, new ResourceStatusColor { LightHex = MaterialColor.Red._200, DarkHex = MaterialColor.Red._600 } }
        };

        public static readonly Dictionary<StaffRole, string> RoleDescription = new Dictionary<StaffRole, string>()
        {
            { StaffRole.ADMIN, "Admin" },
            {StaffRole.RECEPTIONIST, "Receptionist" },
            { StaffRole.MANAGER, "Manager" },
            {  StaffRole.HOUSEKEEPER, "Houskeeper" },
        };
    }
}
