using System;

namespace HotelManagement.Infrastructure.Extentions
{
    public static class IntExtenstion
    {
        public static void Repeat(this int count, Action action)
        {
            for (int i = 0; i < count; i++)
            {
                action();
            }
        }
    }
}
