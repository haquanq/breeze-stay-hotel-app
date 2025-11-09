using HotelManagement.Domain.Enums;
using HotelManagement.WinformApp.Common;
using HotelManagement.WinformApp.Constants;
using System.Collections.Generic;

namespace HotelManagement.WinformApp.Configs
{
    public static class AmenityViewConfig
    {
        public static readonly Dictionary<int, string> PageOffset = new Dictionary<int, string>
        {
            { 20, "20 / page" },
            { 40, "40 / page" },
            { 60, "60 / page" },
        };

        public static readonly Dictionary<AmenityStatus, string> StatusDescription = new Dictionary<AmenityStatus, string>()
        {
            { AmenityStatus.PAY, "Pay" },
            { AmenityStatus.FREE, "Free" },
        };

        public static readonly Dictionary<AmenityStatus, dynamic> StatusColor = new Dictionary<AmenityStatus, dynamic>()
        {
            { AmenityStatus.PAY, new  ResourceStatusColor { LightHex = MaterialColor.Purple._200, DarkHex = MaterialColor.Purple._600 } },
            { AmenityStatus.FREE, new  ResourceStatusColor { LightHex = MaterialColor.Orange._200, DarkHex = MaterialColor.Orange._600 } }
        };

    }
}
