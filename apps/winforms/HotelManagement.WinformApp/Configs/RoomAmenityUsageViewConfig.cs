using HotelManagement.Domain.Enums;
using HotelManagement.WinformApp.Common;
using System.Collections.Generic;

namespace HotelManagement.WinformApp.Constants
{
    public static class RoomAmenityUsageViewConfig
    {
        public static readonly Dictionary<int, string> PageSize = new Dictionary<int, string>
        {
            { 20, "20 / page" },
            { 40, "40 / page" },
            { 60, "60 / page" },
        };

        public static readonly Dictionary<RoomAmenityUsageStatus, string> StatusDescription = new Dictionary<RoomAmenityUsageStatus, string>()
        {
            { RoomAmenityUsageStatus.PENDING, "Pending" },
            { RoomAmenityUsageStatus.USED, "Used" },
            { RoomAmenityUsageStatus.UNUSED, "Unused" },

        };

        public static readonly Dictionary<RoomAmenityUsageStatus, dynamic> StatusColor = new Dictionary<RoomAmenityUsageStatus, dynamic>()
        {
            { RoomAmenityUsageStatus.USED, new ResourceStatusColor { LightHex = MaterialColor.Green._200, DarkHex = MaterialColor.Green._600 } },
            {RoomAmenityUsageStatus.UNUSED, new ResourceStatusColor { LightHex = MaterialColor.Orange._200, DarkHex = MaterialColor.Orange._600 } },
            {RoomAmenityUsageStatus.PENDING, new ResourceStatusColor { LightHex = MaterialColor.Blue._200, DarkHex = MaterialColor.Blue._600 } },
        };
    }
}
