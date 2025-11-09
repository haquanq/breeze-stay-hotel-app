using HotelManagement.Domain.Enums;
using HotelManagement.WinformApp.Common;
using System.Collections.Generic;

namespace HotelManagement.WinformApp.Constants
{
    public static class HotelServiceUsageViewConfig
    {
        public static readonly Dictionary<int, string> PageOffset = new Dictionary<int, string>
        {
            { 20, "20 / page" },
            { 40, "40 / page" },
            { 60, "60 / page" },
        };

        public static readonly Dictionary<HotelServiceUsageStatus, string> StatusDescription = new Dictionary<HotelServiceUsageStatus, string>()
        {
            { HotelServiceUsageStatus.PENDING, "Pending" },
            {HotelServiceUsageStatus.COMPLETED, "Completed" },
            {HotelServiceUsageStatus.CANCELLED, "Cancelled" }
        };

        public static readonly Dictionary<HotelServiceUsageStatus, dynamic> StatusColor = new Dictionary<HotelServiceUsageStatus, dynamic>()
        {
            { HotelServiceUsageStatus.PENDING, new ResourceStatusColor { LightHex = MaterialColor.Blue._200, DarkHex = MaterialColor.Blue._600 } },
            {HotelServiceUsageStatus.COMPLETED, new ResourceStatusColor { LightHex = MaterialColor.Green._200, DarkHex = MaterialColor.Green._600 } },
            {HotelServiceUsageStatus.CANCELLED, new ResourceStatusColor { LightHex = MaterialColor.Red._200, DarkHex = MaterialColor.Red._600 } }
        };
    }
}
