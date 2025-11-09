using System.Globalization;

namespace HotelManagement.Infrastructure.Utilities
{
    public static class DoubleExtension
    {
        public static string ToCurrency(this double num)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            if (num == 0) return "0 vnd";
            return string.Format(cul, "{0:0,0} vnd", num);
        }
        public static string YieldThousandDelimiter(this double num)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            if (num == 0) return "0 vnd";
            return string.Format(cul, "{0:0,0}", num);
        }
    }
}
