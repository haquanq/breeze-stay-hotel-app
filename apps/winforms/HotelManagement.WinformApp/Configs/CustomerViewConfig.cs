using HotelManagement.Domain.Enums;
using HotelManagement.WinformApp.Common;
using System.Collections.Generic;

namespace HotelManagement.WinformApp.Constants
{
    public static class CustomerViewConfig
    {
        public static readonly Dictionary<int, string> PageOffset = new Dictionary<int, string>
        {
            { 20, "20 / page" },
            { 40, "40 / page" },
            { 60, "60 / page" },
        };

        public static readonly Dictionary<CustomerStatus, string> StatusDescription = new Dictionary<CustomerStatus, string>()
        {
            { CustomerStatus.NEW, "New" },
            { CustomerStatus.COMMON, "Common" },
            { CustomerStatus.VIP, "Vip" }
        };

        public static readonly Dictionary<CustomerStatus, dynamic> StatusColor = new Dictionary<CustomerStatus, dynamic>()
        {

            { CustomerStatus.NEW, new ResourceStatusColor { LightHex = MaterialColor.Green._200, DarkHex = MaterialColor.Green._600 } },
            {CustomerStatus.COMMON, new ResourceStatusColor { LightHex = MaterialColor.Orange._200, DarkHex = MaterialColor.Orange._600 } },
            {CustomerStatus.VIP, new ResourceStatusColor { LightHex = MaterialColor.Purple._200, DarkHex = MaterialColor.Purple._600 } }
        };
    }
}
