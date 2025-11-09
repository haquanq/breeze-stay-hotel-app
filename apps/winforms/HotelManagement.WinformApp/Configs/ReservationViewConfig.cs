using HotelManagement.Domain.Enums;
using HotelManagement.WinformApp.Common;
using System.Collections.Generic;

namespace HotelManagement.WinformApp.Constants
{
    public static class ReservationViewConfig
    {
        public static readonly Dictionary<int, string> PageOffset = new Dictionary<int, string>
        {
            { 20, "20 / page" },
            { 40, "40 / page" },
            { 60, "60 / page" },
        };

        public static readonly Dictionary<ReservationStatus, string> StatusDescription = new Dictionary<ReservationStatus, string>()
        {
            { ReservationStatus.PENDING, "Pending" },
            {ReservationStatus.CHECKED_OUT, "Checked out" },
            {ReservationStatus.CHECKED_IN, "Checked in" },
            {ReservationStatus.CANCELLED, "Cancelled" },
        };

        public static readonly Dictionary<ReservationStatus, dynamic> StatusColor = new Dictionary<ReservationStatus, dynamic>()
        {
            { ReservationStatus.PENDING, new ResourceStatusColor { LightHex = MaterialColor.Blue._200, DarkHex = MaterialColor.Blue._600 } },
            { ReservationStatus.CHECKED_IN, new ResourceStatusColor { LightHex = MaterialColor.Orange._200, DarkHex = MaterialColor.Orange._600 }  },
            { ReservationStatus.CHECKED_OUT, new ResourceStatusColor { LightHex = MaterialColor.Green._200, DarkHex = MaterialColor.Green._600 } },
            { ReservationStatus.CANCELLED, new ResourceStatusColor { LightHex = MaterialColor.Red._200, DarkHex = MaterialColor.Red._600 } }
        };
    }
}
