using HotelManagement.Domain.Enums;
using HotelManagement.WinformApp.Common;
using System.Collections.Generic;

namespace HotelManagement.WinformApp.Constants
{
    public static class RoomViewConfig
    {
        public static readonly Dictionary<int, string> PageOffset = new Dictionary<int, string>
        {
            { 20, "20 / page" },
            { 40, "40 / page" },
            { 60, "60 / page" },
        };

        public static readonly Dictionary<RoomStatus, string> StatusDescription = new Dictionary<RoomStatus, string>()
        {

            { RoomStatus.READY, "Ready" },
            {RoomStatus.BOOKED, "Booked" },
            {RoomStatus.OCCUPIED, "Occupied" },
            {RoomStatus.VACANT_CLEAN, "Vacant clean" },
            {RoomStatus.VACANT_DIRTY, "Vacant dirty" },
        };

        public static readonly Dictionary<RoomStatus, dynamic> StatusColor = new Dictionary<RoomStatus, dynamic>()
        {

            {RoomStatus.VACANT_DIRTY, new ResourceStatusColor { LightHex = MaterialColor.Red._200, DarkHex = MaterialColor.Red._600 } },
            {RoomStatus.VACANT_CLEAN, new ResourceStatusColor { LightHex= MaterialColor.Orange._200, DarkHex = MaterialColor.Orange._600 } },
            {RoomStatus.READY, new ResourceStatusColor { LightHex = MaterialColor.Green._200, DarkHex = MaterialColor.Green._600 } },
            {RoomStatus.BOOKED, new ResourceStatusColor { LightHex = MaterialColor.Blue._200, DarkHex = MaterialColor.Blue._600 } },
            {RoomStatus.OCCUPIED, new ResourceStatusColor { LightHex = MaterialColor.Purple._200, DarkHex = MaterialColor.Purple._600 } },
        };
    }
}
